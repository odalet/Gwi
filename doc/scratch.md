# Scratch

## Articles

* From the authors of [Gio](https://gioui.org/): [Immediate Mode GUI Programming](https://eliasnaur.com/blog/immediate-mode-gui-programming)

## Libraries

* Golang
  * [Gio](https://gioui.org/)
* Rust
  * [egui](https://github.com/emilk/egui); Web demo: <https://emilk.github.io/egui/index.html>

## Links

* OpenGL Language Bindings: <https://www.khronos.org/opengl/wiki/Language_bindings>
  * Silk.NET: <https://github.com/dotnet/Silk.NET>
  * OpenTK (5.0 branch): <https://github.com/opentk/opentk/tree/opentk5.0>
  * OpenGL.Net: <https://github.com/luca-piccioni/OpenGL.Net>
  * OpenGLDotNet: <https://github.com/taylaninan/opengldotnet>
  * opengl4csharp: <https://github.com/giawa/opengl4csharp>
* `gl.xml` @ OpenGL-Registry: <https://github.com/KhronosGroup/OpenGL-Registry/blob/963994171fb35ed29e8c2605c94b20fcca8e47e7/xml/gl.xml>
  * `gl.xml` specification: <https://github.com/KhronosGroup/OpenGL-Registry/blob/master/xml/readme.pdf>
* GLFW: <https://github.com/glfw/glfw>

## C# 9 function pointers

<https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/function-pointers>

## Misc code

* [scratch.cs](./scratch.cs)
* SDL-based text editor: <https://github.com/rxi/lite>

## GlfwTestApp

### WSL

```shell
$ glxinfo | grep OpenGL
OpenGL vendor string: VMware, Inc.
OpenGL renderer string: llvmpipe (LLVM 7.0, 256 bits)
OpenGL core profile version string: 3.3 (Core Profile) Mesa 18.3.6
OpenGL core profile shading language version string: 3.30
OpenGL core profile context flags: (none)
OpenGL core profile profile mask: core profile
OpenGL core profile extensions:
OpenGL version string: 3.1 Mesa 18.3.6
OpenGL shading language version string: 1.40
OpenGL context flags: (none)
OpenGL extensions:
OpenGL ES profile version string: OpenGL ES 3.0 Mesa 18.3.6
OpenGL ES profile shading language version string: OpenGL ES GLSL ES 3.00
OpenGL ES profile extensions:

$ ./GlfwTestApp
Version   : 3.3 (Core Profile) Mesa 18.3.6
Vendor    : VMware, Inc.
GLSL      : 3.30
Renderer  : llvmpipe (LLVM 7.0, 256 bits)
```

### Windows (Home PC)

> uses <https://github.com/gkv311/wglinfo>


```ps1
> C:\temp\wglinfo64.exe | findstr OpenGL

[WGL] OpenGL vendor string: ATI Technologies Inc.
[WGL] OpenGL renderer string: Radeon RX550/550 Series
[WGL] OpenGL version string: 4.6.13547 Compatibility Profile Context 25.20.15027.5007
[WGL] OpenGL shading language version string: 4.60
[WGL] OpenGL GPU memory: 2048 MiB
[WGL] OpenGL extensions:
[WGL] OpenGL (core profile) vendor string: ATI Technologies Inc.
[WGL] OpenGL (core profile) renderer string: Radeon RX550/550 Series
[WGL] OpenGL (core profile) version string: 4.6.13547 Core Profile Context 25.20.15027.5007
[WGL] OpenGL (core profile) shading language version string: 4.60
[WGL] OpenGL (core profile) extensions:
[WGL] OpenGL (software) vendor string: Microsoft Corporation
[WGL] OpenGL (software) renderer string: GDI Generic
[WGL] OpenGL (software) version string: 1.1.0
[WGL] OpenGL (software) extensions:

Version   : 3.3.13547 Core Profile Context 25.20.15027.5007
Vendor    : ATI Technologies Inc.
GLSL      : 4.60
Renderer  : Radeon RX550/550 Series
```
