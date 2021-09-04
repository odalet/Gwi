// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable S1144 // Unused private types or members should be removed
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class GREMEDY
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glFrameTerminatorGREMEDY => _glFrameTerminatorGREMEDY != 0 ? _glFrameTerminatorGREMEDY : _glFrameTerminatorGREMEDY = Lib.GetProcAddress("glFrameTerminatorGREMEDY");
                private nint _glFrameTerminatorGREMEDY;

                public nint glStringMarkerGREMEDY => _glStringMarkerGREMEDY != 0 ? _glStringMarkerGREMEDY : _glStringMarkerGREMEDY = Lib.GetProcAddress("glStringMarkerGREMEDY");
                private nint _glStringMarkerGREMEDY;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
#pragma warning restore S1144 // Unused private types or members should be removed
}
