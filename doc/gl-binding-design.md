# OpenGL C# Binding Generator

## Introduction

The Code generator that produces the C# bindings to OpenGL APIs is based on the `gl.xml` ([this version from 2021/08/12 as of this writing](https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/acc094d2dc2a78b1f774dc1899e2e6f6850ec5ea/xml/gl.xml)).

Given my poor knowledge of anything related to OpenGL, I was strongly inspired (not to say I shamelessly copy/pasted huge amounts of code) by:

* [The OpenTK project, and especially its v5 branch](https://github.com/opentk/opentk/tree/opentk5.0).
* [Silk.NET](https://github.com/dotnet/Silk.NET) (although their Roslyn generator-based code is beyond what I intend to do, I was inspired by the resulting types implementation and organization).

### Goals and non-goals

* Easy-to-use, type-safe and idiomatic API
  * Remove `gl` and `GL_` prefixes
  * Remove extensions suffixes?
  * Convert enums from Screaming- to Pascal-case
  * Remove suffixes in commands (such as `i`, `f`, `iv`, `fv`...) that indicate the type of some input parameter and replace those with overloads of the same method.
  * Provide safe overloads that can handle strings and arrays (instead of raw pointers).
* Allow fallbacks to low-level, unsafe, raw APIs when C#-friendly wrappers are not (yet) available.
  * In the low-level binding, original names of commands and enums are kept.
  * parameters of commands bound to enum values are replaced by `uint` or `GLEnum` so that any value can be passed.
* If possible allow easy navigation to types and method definitions from Visual Studio
  * Because the OpenGL API is huge, Visual Studio struggles when one _F12_ an OpenGL method...
  * In order to alleviate this, the method definitions will be organized in several classes (instead of a huge one).
  * And because this organization should be transparent to the user, we'll make a heavy use of enxtension classes.
* Non-static! Static is evil!
* Do not multiply versions of the wrapper depending on versions or profiles
* Have extensions easily usable but still separate from the core API.
* Support OpenGL ES?
* Provide XML Documentation?

## Handling of OpenGL versions and profiles

The handling of deprecated/removed/required commands and enums across versions of OpenGL is a complete mess... Simply by examining `gl.xml`, it appears that:

* OpengL 3.2 introduced a so-called *core* profile that removes elements.
* OpenGL 3.3 requires elements in a *compatibility* profile. Note that these required elements seem to be new in v3.3...
* OpenGL 4.3 adds new elemens to the *compatibility* profile, and so does v4.5.
* OpenGL 4.4 restores in its *core* profile elements that were previously removed in v3.2
* Some extensions declare support for *gl* and/or *glcore* whathever those represent (profile? API? what version?)

Based on this, I honestly don't know how to handle versions and profiles. It may have been nice to inform the user they're risking a runtime error because the command or enum they use is not available in their current OpenGL context. But:

* I don't want to generate a whole different wrapper for each combination of version and profile. On the contrary I'd rather I have only a unique wrapper class that could be used for any version/profile.
* I'm not even taking extensions or OpenGL ES into account here!

So, I suppose that:

* All enums regardless of their support in a version/profile will be exposed in the root namespace.
* The decision of whether a command belongs to a *core* or *compatibility* profile or to none of them will be made based on the highest version of OpenGL (4.6 for now).
* Commands that either are not part of a profile or part of the *core* profile will be exposed in the root class.
* Commands that are known to only exist in a *compatibility* profile will be exposed as extensions on the root class in a `Compatibility` namespace. This way, they won't be accessible by default, but still usable without having to resort to changing the real type of the OpenGL underlying class.

## Handling of extensions

TODO

## Handling of OpenGL ES

TODO

Beware of enum values defined differently in GL and GL ES...
