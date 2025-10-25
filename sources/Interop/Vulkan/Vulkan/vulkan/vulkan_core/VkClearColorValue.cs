// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public partial struct VkClearColorValue
{
    [FieldOffset(0)]
    [NativeTypeName("float[4]")]
    public _float32_e__FixedBuffer float32;

    [FieldOffset(0)]
    [NativeTypeName("int32_t[4]")]
    public _int32_e__FixedBuffer int32;

    [FieldOffset(0)]
    [NativeTypeName("uint32_t[4]")]
    public _uint32_e__FixedBuffer uint32;

    [InlineArray(4)]
    public partial struct _float32_e__FixedBuffer
    {
        public float e0;
    }

    [InlineArray(4)]
    public partial struct _int32_e__FixedBuffer
    {
        public int e0;
    }

    [InlineArray(4)]
    public partial struct _uint32_e__FixedBuffer
    {
        public uint e0;
    }
}
