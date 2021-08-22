using System;
using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    // The parse tree that is the result of parsing gl.xml

    // Root of the tree
    public sealed record ParseTree(
        IReadOnlyCollection<Command> Commands,
        IReadOnlyCollection<Enum> Enums,
        IReadOnlyCollection<Feature> Features,
        IReadOnlyCollection<Extension> Extensions);

    public sealed record Command(
        string Namespace,
        string EntryPoint,
        PType ReturnType,
        GLParameter[] Parameters);

    public enum EnumType
    {
        Invalid,
        None,
        Bitmask
    }

    public sealed record Enum(
        string Namespace,
        string[] Groups,
        EnumType Type,
        string Vendor,
        Range? Range,
        string Comment,
        IReadOnlyCollection<EnumEntry> Entries);

    /// <summary>
    /// "
    /// Legal C suffix for the value to force it to a specific type.
    /// Currently only \code{u} and \code{ull} are used,
    /// for \code{unsigned} 32 - and 64 - bit integer values, respectively.
    /// Separated from the \attr{value} field since this eases parsing and
    /// sorting of values, and is rarely used.
    /// "
    /// <br/>
    /// Taken from <see href="https://github.com/KhronosGroup/OpenGL-Registry/blob/0dc24166d162723781f1bf9fe433f71fa03a7aa0/xml/readme.tex#L383">KhronosGroup/OpenGL-Registry/xml/readme.tex#L383</see> 2020-11-22
    /// </summary>
    public enum TypeSuffix
    {
        Invalid,
        None,
        U,
        Ull,
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

    public sealed record EnumEntry(
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
