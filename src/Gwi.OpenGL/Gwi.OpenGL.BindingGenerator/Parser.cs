using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;
using NLog;

namespace Gwi.OpenGL.BindingGenerator
{
    internal sealed class Parser : BaseProcessor
    {
        private static readonly ILogger log = LogManager.GetCurrentClassLogger();

        public Parser(string filename) : base(log)
        {
            FileName = filename;
            if (!File.Exists(FileName)) throw new FileNotFoundException("Missing input OpenGL Api definition", FileName);
            var xdoc = XDocument.Load(FileName);
            if (xdoc.Root == null) throw new ParsingException("The input XML data doesn't contain a Root node.");
            Root = xdoc.Root;
        }

        private string FileName { get; }
        private XElement Root { get; }

        public void DumpStatistics()
        {
            var descendants = Root.XPathSelectElements("descendant::*").ToArray();
            var distinctNamespaces = descendants.SelectMany(xe => xe.Attributes("namespace")).Select(xa => xa.Value).Distinct().OrderBy(x => x).ToArray();
            log.Info($"Distinct namespaces: {string.Join(", ", distinctNamespaces)}");

            var distinctApis = descendants.SelectMany(xe => xe.Attributes("api")).Select(xa => xa.Value).Distinct().OrderBy(x => x).ToArray();
            log.Info($"Distinct APIs: {string.Join(", ", distinctApis)}");

            var distinctProfiles = descendants.SelectMany(xe => xe.Attributes("profile")).Select(xa => xa.Value).Distinct().OrderBy(x => x).ToArray();
            log.Info($"Distinct profiles: {string.Join(", ", distinctProfiles)}");

            var distinctSupportedValues = descendants.SelectMany(xe => xe.Attributes("supported")).Select(xa => xa.Value).Distinct().ToArray();
            var distinctSupportedApis = distinctSupportedValues.SelectMany(s => s.Split('|')).Distinct().OrderBy(x => x).ToArray();
            log.Info($"Distinct supported APIs: {string.Join(", ", distinctSupportedApis)}");

            //var coreProfileRemoveElements = descendants.Where(xe => xe.Name == "remove" && xe.Attribute("profile")?.Value == "core");
            //var removedCommands = coreProfileRemoveElements.SelectMany(xe => xe.Elements("command")).Select(xe => xe.Attribute("name")?.Value ?? "");
            //var removedEnums = coreProfileRemoveElements.SelectMany(xe => xe.Elements("enum")).Select(xe => xe.Attribute("name")?.Value ?? "");
            //var allRemoved = removedCommands.Concat(removedEnums).Where(s => !string.IsNullOrEmpty(s)).Distinct().OrderBy(x => x).ToArray();
            ////log.Info($"Core Profile - Removed commands and enums:\r\n\t{string.Join("\r\n\t", allRemoved)}");

            //var compatibilityProfileRequiredElements = descendants.Where(xe => xe.Name == "require" && xe.Attribute("profile")?.Value == "compatibility");
            //var requiredCommands = compatibilityProfileRequiredElements.SelectMany(xe => xe.Elements("command")).Select(xe => xe.Attribute("name")?.Value ?? "");
            //var requiredEnums = compatibilityProfileRequiredElements.SelectMany(xe => xe.Elements("enum")).Select(xe => xe.Attribute("name")?.Value ?? "");
            //var allRequired = requiredCommands.Concat(requiredEnums).Where(s => !string.IsNullOrEmpty(s)).Distinct().OrderBy(x => x).ToArray();
            ////log.Info($"Compatibility Profile - Required commands and enums:\r\n\t{string.Join("\r\n\t", allRequired)}");

            //var removedThenRequired = allRequired.Where(x => allRemoved.Contains(x)).ToArray();
            //log.Info($"Commands and enums removed in core profile and required in compatibility profile:\r\n\t{string.Join("\r\n\t", removedThenRequired)}");

            //var distinctLens = descendants.Where(xe => xe.Name == "param" && xe.Attribute("len") != null).Select(xe => xe.Attribute("len")?.Value ?? "").Distinct().ToArray();
            //log.Info($"Distinct Len Expressions:\r\n\t{string.Join("\r\n\t", distinctLens)}");

            var distinctPTypes = descendants.Where(xe => xe.Name == "param").Select(ParsePType).Select(p => p.Declaration).Distinct().ToArray();
            log.Info($"Distinct PTypes:\r\n\t{string.Join("\r\n\t", distinctPTypes)}");

            //var distinctReturnTypes = descendants.Where(xe => xe.Name == "proto").Select(xe => GetXmlText(xe, e => e.Name == "name" ? string.Empty : e.Value).Trim()).Distinct().ToArray();
            //log.Info($"Distinct Return Types:\r\n\t{string.Join("\r\n\t", distinctReturnTypes)}");
        }

        public ParseTree Parse() => Parse(Root);

        private ParseTree Parse(XElement root)
        {
            LogInfo("Parsing gl.xml");

            //var commands = LogScoped(() => ParseCommands(root), "Parse Commands");
            //var enumerations = LogScoped(() => ParseEnumerants(root), "Parse Enumerations");
            //var features = LogScoped(() => ParseFeatures(root), "Parse Features");
            //var extensions = LogScoped(() => ParseExtensions(root), "Parse Extensions");

            //return new ParseTree(commands, enumerations, features, extensions);

            IndentLog();
            var vendors = ParseVendors(root);
            var commands = ParseCommands(root);
            var enums = ParseEnums(root);
            DedentLog();
            return new ParseTree(vendors, commands, enums);
        }

        private static List<string> ParseVendors(XElement root)
        {
            var descendants = root.XPathSelectElements("descendant::*").ToArray();
            var vendors = new HashSet<string>();
            foreach (var vendor in descendants.SelectMany(xe => xe.Attributes("vendor")).Select(xa => xa.Value).Distinct().OrderBy(x => x))
            {
                if (vendor.Contains("/")) // There is 1 such case: "AMD/NV"
                    foreach (var v in vendor.Split('/').Select(x => x.Trim()))
                        _ = vendors.Add(v);
                else _ = vendors.Add(vendor);
            }

            // The strings below do not appear in any vendor attribute, but they appear as suffix in enums and commands
            _ = vendors.Add("ATI"); 
            _ = vendors.Add("SGIX");
            _ = vendors.Add("EXT");

            return vendors.ToList();
        }

        private List<Command> ParseCommands(XElement xe)
        {
            LogInfo($"Parsing commands");
            var commands = new List<Command>();

            foreach (var xeCommands in xe.Elements("commands"))
                foreach (var element in xeCommands.Elements("command"))
                {
                    var command = ParseCommand(element);
                    commands.Add(command);
                }

            LogInfo($"{commands.Count} commands were parsed");
            return commands;
        }

        private static Command ParseCommand(XElement xe)
        {
            var xeProto = xe.Element("proto");
            if (xeProto == null) throw new ParsingException("Missing proto in command");
            var returnType = ParsePType(xeProto);

            var entryPoint = xeProto.Element("name")?.Value;
            if (string.IsNullOrEmpty(entryPoint)) throw new ParsingException("Missing name in command/proto");

            var parameters = new List<CommandParameter>(xe.Elements("param").Select(ParseCommandParameter));
            return new Command(entryPoint, returnType, parameters);
        }

        private static CommandParameter ParseCommandParameter(XElement xe)
        {
            var name = xe.Element("name")?.Value;
            if (string.IsNullOrEmpty(name)) throw new ParsingException("Missing parameter name in command/param");

            var ptype = ParsePType(xe);
            var len = xe.Attribute("len")?.Value ?? "";
            return new CommandParameter(name, ptype, len);
        }

        private static PType ParsePType(XElement xe)
        {
            var group = xe.Attribute("group")?.Value ?? "";
            var className = xe.Attribute("class")?.Value ?? "";
            var declaration = GetXmlText(xe, e => e.Name == "name" ? string.Empty : e.Value).Trim();
            var glType = PTypeParser.Parse(declaration);
            return new PType(glType, declaration, group, className);
        }

        private static int ParseInt(string str)
        {
            var isHex = str.StartsWith("0x");
            if (isHex) str = str[2..];
            return int.Parse(str, isHex ? NumberStyles.HexNumber : NumberStyles.Integer);
        }

        private Enums ParseEnums(XElement xe)
        {
            static ulong convertToUInt64(string value, string type) => (type ?? "") switch
            {
                "" => (uint)(int)new Int32Converter().ConvertFromString(value),
                "ull" => (ulong)(long)new Int64Converter().ConvertFromString(value),
                "u" => (uint)new UInt32Converter().ConvertFromString(value),
                _ => throw new ParsingException($"Invalid type suffix '{type}'!"),
            };

            var entries = new Dictionary<string, EnumEntry>();
            var groupsByName = new Dictionary<string, EnumGroup>();
            var entriesByGroupName = new Dictionary<string, Dictionary<string, EnumEntry>>();

            void addOrUpdateGroup(string name, string vendor = "", bool bitmask = false)
            {
                if (!groupsByName.ContainsKey(name))
                    groupsByName.Add(name, new EnumGroup(name, vendor, bitmask));

                var targetGroup = groupsByName[name];
                if (!string.IsNullOrEmpty(vendor) && string.IsNullOrEmpty(targetGroup.Vendor))
                    targetGroup.Vendor = vendor;
                if (bitmask && !targetGroup.IsBitMask)
                    targetGroup.IsBitMask = true;
            }

            foreach (var xeEnums in xe.Elements("enums"))
            {
                var groupNames = SplitOnComma(xeEnums.Attribute("group")?.Value);
                var vendor = xeEnums.Attribute("vendor")?.Value ?? "";
                var isBitmask = xeEnums.Attribute("type")?.Value == "bitmask";
                foreach (var groupName in groupNames)
                    addOrUpdateGroup(groupName, vendor, isBitmask);

                foreach (var xeEnum in xeEnums.Elements("enum"))
                {
                    var name = xeEnum.Attribute("name")?.Value;
                    if (string.IsNullOrEmpty(name)) throw new ParsingException($"Enum entry has no name");

                    var entryValue = xeEnum.Attribute("value")?.Value;
                    if (string.IsNullOrEmpty(entryValue)) throw new ParsingException($"Enum entry '{name}' has no value");

                    var entryType = xeEnum.Attribute("type")?.Value ?? "";
                    var isULong = entryType.Trim() == "ull"; // nothing or "u" -> uint

                    var value = convertToUInt64(entryValue, entryType);

                    var alias = xeEnum.Attribute("alias")?.Value ?? "";
                    var entryGroupNames = SplitOnComma(xeEnum.Attribute("group")?.Value);
                    foreach (var entryGroupName in entryGroupNames)
                        addOrUpdateGroup(entryGroupName);

                    var api = ParseGLApi(xeEnum.Attribute("api")?.Value ?? "");

                    if (api is GLApi.GL or GLApi.GLCore or GLApi.None)
                    {
                        var entry = new EnumEntry(name, alias, value, entryValue, api, isULong);

                        // Add to the global list
                        if (!entries.ContainsKey(name))
                            entries.Add(name, entry);
                        else
                            LogWarn($"Enum Entry {name} was already encountered");

                        // Dispatch in groups
                        var allGroups = groupNames.Concat(entryGroupNames).Distinct().ToArray();
                        foreach (var key in allGroups)
                        {
                            if (!entriesByGroupName.ContainsKey(key))
                                entriesByGroupName.Add(key, new Dictionary<string, EnumEntry>());
                            var groupEntries = entriesByGroupName[key];
                            if (!groupEntries.ContainsKey(name))
                                groupEntries.Add(name, entry);
                            else
                                LogWarn($"Enum Entry {name} was already encountered in Enum Group {key}");
                        }
                    }
                    else LogInfo($"Ignoring Enum Entry {name} belonging to API {api}");
                }
            }

            return new Enums(
                entries.Select(kvp => kvp.Value).ToList(),
                entriesByGroupName.ToDictionary(kvp => groupsByName[kvp.Key], kvp => kvp.Value.Select(kvp2 => kvp2.Value).ToList())
                );
        }

        private static GLApi ParseGLApi(string api) => api switch
        {
            "" or "disabled" => GLApi.None,
            "gl" => GLApi.GL,
            "gles1" => GLApi.GLES1,
            "gles2" => GLApi.GLES2,
            "glsc2" => GLApi.GLSC2,
            "glcore" => GLApi.GLCore,
            _ => GLApi.Invalid,
        };

        private static string[] SplitOnComma(string? input) =>
            string.IsNullOrEmpty(input) ?
            Array.Empty<string>() :
            input.Split(',').Where(e => !string.IsNullOrWhiteSpace(e)).Select(e => e.Trim()).ToArray();

        private static string GetXmlText(XElement element, Func<XElement, string> elementTransformer)
        {
            var sb = new StringBuilder();

            foreach (var node in element.Nodes()) _ = node switch
            {
                XText xtext => sb.Append(xtext.Value),
                XElement xelement => sb.Append(elementTransformer(xelement)),
                _ => sb.Append(node),
            };

            return sb.ToString();
        }
    }
}
