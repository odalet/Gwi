using System;
using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    // The parse tree that is the result of parsing gl.xml

    // Root of the tree
    public record Specification(
        IEnumerable<Command> Commands,
        IEnumerable<Enum> Enums,
        IEnumerable<Feature> Features,
        IEnumerable<Extension> Extensions);

    public record Command(
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

    public record Enum(
        string Namespace,
        string[] Groups,
        EnumType Type,
        string Vendor,
        Range? Range,
        string Comment,
        IEnumerable<EnumEntry> Entries);

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

    public record EnumEntry(
        string Name,
        GLApi Api,
        ulong Value,
        string Alias,
        string Comment,
        string[] Groups,
        TypeSuffix Type);

    public record Feature(
        GLApi Api,
        Version Version,
        string Name,
        IEnumerable<RequireEntry> Requires,
        IEnumerable<RemoveEntry> Removes);

    public record Extension(
        string Name,
        string Vendor,
        GLApi[] SupportedApis,
        string? Comment,
        IEnumerable<RequireEntry> Requires);

    public record RequireEntry(
        GLApi Api,
        GLProfile Profile,
        string Comment,
        IEnumerable<string> Commands,
        IEnumerable<string> Enums);

    public record RemoveEntry(
        GLProfile Profile,
        string Comment,
        IEnumerable<string> Commands,
        IEnumerable<string> Enums);
}
