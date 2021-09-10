using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    // Sub-parser that parses the content of an 'Expr'
    // Example expressions:
    // - COMPSIZE(name)
    // - n
    // - waitSemaphoreCount
    // - 3
    // - COMPSIZE(type,stride)
    internal static class ExprParser
    {
        public static Expr Parse(string expression)
        {
            var result = ParsePrio2(expression, out var remainder);
            return string.IsNullOrEmpty(remainder) ?
                result :
                throw new ParsingException($"Failed to parse expression '{expression}': the remainder string '{remainder}' could not be matched");
        }

        private static Expr ParsePrio2(string expression, out string remainder)
        {
            static BinaryOperator getOperator(string expression) => expression.Length == 0 ? BinaryOperator.Invalid : expression[0] switch
            {
                '+' => BinaryOperator.Addition,
                '-' => BinaryOperator.Subtraction,
                _ => BinaryOperator.Invalid,
            };

            var result = ParsePrio1(expression, out var exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            while ((op = getOperator(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                var right = ParsePrio1(exp, out exp);
                exp = exp.TrimStart();

                result = new BinaryOperation(result, op, right);
            }

            remainder = exp;
            return result;
        }

        private static Expr ParsePrio1(string expression, out string remainder)
        {
            static BinaryOperator getOperator(string expression) => expression.Length == 0 ? BinaryOperator.Invalid : expression[0] switch
            {
                '*' => BinaryOperator.Multiplication,
                '/' => BinaryOperator.Division,
                _ => BinaryOperator.Invalid,
            };

            var result = ParsePrio0(expression, out var exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            while ((op = getOperator(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                var right = ParsePrio0(exp, out exp);
                exp = exp.TrimStart();

                result = new BinaryOperation(result, op, right);
            }

            remainder = exp;
            return result;
        }

        private static Expr ParsePrio0(string expression, out string remainder)
        {
            expression = expression.TrimStart();
            if (expression.StartsWith("COMPSIZE("))
            {
                var exp = expression["COMPSIZE(".Length..];
                var arguments = new List<Expr>();
                while (exp[0] != ')')
                {
                    // No need to bother with white spaces: the rest of the parser already eliminates them
                    arguments.Add(ParsePrio2(exp, out exp));
                    if (exp[0] == ',')
                        exp = exp[1..];
                }

                // Remove the last ')'
                remainder = exp[1..];
                return new CompSize(arguments.ToArray());
            }
            
            if (char.IsDigit(expression[0]))
            {
                var i = 1;
                while (i < expression.Length && char.IsDigit(expression[i]))
                    i++;

                remainder = expression[i..];
                return new Constant(int.Parse(expression[0..i]));
            }
            
            if (char.IsLetter(expression[0]))
            {
                var i = 1;
                while (i < expression.Length && char.IsLetterOrDigit(expression[i]))
                    i++;

                remainder = expression[i..];
                return new ParameterReference(expression[0..i]);
            }
            
            throw new ParsingException($"Could not parse expression '{expression}'");
        }
    }
}
