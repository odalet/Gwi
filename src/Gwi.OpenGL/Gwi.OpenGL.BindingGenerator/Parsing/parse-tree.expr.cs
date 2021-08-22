using System;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    public enum BinaryOperator
    {
        Invalid,
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }

    public abstract record Expr();
    public sealed record Constant(int Value) : Expr;
    public sealed record CompSize(Expr[] Parameters) : Expr;
    public sealed record ParameterReference(string ParameterName) : Expr;
    public sealed record BinaryOperation(Expr Left, BinaryOperator Operator, Expr Right) : Expr;

    public static class ExprExtensions
    {
        // FIXME: Clean up this mess. We assume a lot of things we maybe dont wanna assume?
        // Can all lengths even be inverted and what should happen if they cant?
        // For now this works, but it might break later. 2021-06-23.
        public static string? InvertExpressionAndGetReferencedName(this Expr expr, out Func<string, string> inverseExpression)
        {
            switch (expr)
            {
                case Constant c:
                    inverseExpression = s => c.Value.ToString();
                    return null;
                case ParameterReference pr:
                    inverseExpression = s => $"{s}.Length";
                    return pr.ParameterName;
                case BinaryOperation bo:
                    // FIXME: We don't want to assume that the left expression contains the
                    // parameter name, but this is true for gl.xml 2020-12-30
                    var reference = bo.Left.InvertExpressionAndGetReferencedName(out var leftExpr);
                    _ = bo.Right.InvertExpressionAndGetReferencedName(out var rightExpr);
                    var invOp = bo.Operator.Invert();
                    inverseExpression = s => $"{leftExpr(s)} {invOp.GetOperationChar()} {rightExpr(s)}";
                    return reference;
                default:
                    inverseExpression = s => "";
                    return null;
            }
        }

        public static BinaryOperator Invert(this BinaryOperator op) => op switch
        {
            BinaryOperator.Addition => BinaryOperator.Subtraction,
            BinaryOperator.Subtraction => BinaryOperator.Addition,
            BinaryOperator.Multiplication => BinaryOperator.Division,
            BinaryOperator.Division => BinaryOperator.Multiplication,
            _ => throw new ParsingException("Invalid binary operator, we can't invert it."),
        };

        public static char GetOperationChar(this BinaryOperator op) => op switch
        {
            BinaryOperator.Addition => '+',
            BinaryOperator.Subtraction => '-',
            BinaryOperator.Multiplication => '*',
            BinaryOperator.Division => '/',
            _ => throw new ParsingException("Invalid binary operator, there is no char associated."),
        };
    }
}
