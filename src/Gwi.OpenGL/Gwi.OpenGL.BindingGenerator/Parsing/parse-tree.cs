using System;
using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    // The parse tree that is the result of parsing gl.xml

    // Root of the tree
    public sealed record ParseTree(
        IReadOnlyCollection<Command> Commands,
        IReadOnlyCollection<Enumerant> Enumerants,
        IReadOnlyCollection<Feature> Features,
        IReadOnlyCollection<Extension> Extensions);

    public sealed record Command(
        string Namespace,
        string EntryPoint,
        PType ReturnType,
        GLParameter[] Parameters);

    public enum EnumerantType
    {
        Invalid,
        None,
        Bitmask
    }

    // 'Enumerant' is a weird name, but this is how it's named
    // in https://github.com/KhronosGroup/OpenGL-Registry/blob/main/xml/readme.pdf
    public sealed record Enumerant(
        string Namespace,
        string[] Groups,
        EnumerantType Type,
        string Vendor,
        Range? Range,
        string Comment,
        IReadOnlyCollection<EnumerantEntry> Entries);

    // legal C suffix for the value to force it to a specific type.
    // Currently only u and ull are used, for unsigned 32- and 64-bit integer values, respectively.
    // Separated from the value field since this eases parsing and sorting of values, and is rarely used.
    // See https://github.com/KhronosGroup/OpenGL-Registry/blob/main/xml/readme.pdf § 9.1
    public enum TypeSuffix
    {
        Invalid,
        None,
        U, // uint
        Ull, // ulong
    }

    public enum GLApi
    {
        Invalid,
        None,
        GL,
        GLES1,
        GLES2,
        GLSC2,
        GLCore,
    }

    public enum GLProfile
    {
        Invalid,
        None,
        Core,
        Compatibility,
        Common,
    }

    public sealed record EnumerantEntry(
        string Name,
        GLApi Api,
        ulong Value,
        string Alias,
        string Comment,
        string[] Groups,
        TypeSuffix Type);

    public sealed record Feature(
        GLApi Api,
        Version Version,
        string Name,
        IReadOnlyCollection<RequireEntry> Requires,
        IReadOnlyCollection<RemoveEntry> Removes);

    public sealed record Extension(
        string Name,
        string Vendor,
        GLApi[] SupportedApis,
        string? Comment,
        IReadOnlyCollection<RequireEntry> Requires);

    public sealed record RequireEntry(
        GLApi Api,
        GLProfile Profile,
        string Comment,
        IReadOnlyCollection<string> Commands,
        IReadOnlyCollection<string> Enums);

    public sealed record RemoveEntry(
        GLProfile Profile,
        string Comment,
        IReadOnlyCollection<string> Commands,
        IReadOnlyCollection<string> Enums);
}
