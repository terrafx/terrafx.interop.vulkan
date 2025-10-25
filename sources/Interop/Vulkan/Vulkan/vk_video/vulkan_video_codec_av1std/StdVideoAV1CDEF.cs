// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoAV1CDEF
{
    [NativeTypeName("uint8_t")]
    public byte cdef_damping_minus_3;

    [NativeTypeName("uint8_t")]
    public byte cdef_bits;

    [NativeTypeName("uint8_t[8]")]
    public _cdef_y_pri_strength_e__FixedBuffer cdef_y_pri_strength;

    [NativeTypeName("uint8_t[8]")]
    public _cdef_y_sec_strength_e__FixedBuffer cdef_y_sec_strength;

    [NativeTypeName("uint8_t[8]")]
    public _cdef_uv_pri_strength_e__FixedBuffer cdef_uv_pri_strength;

    [NativeTypeName("uint8_t[8]")]
    public _cdef_uv_sec_strength_e__FixedBuffer cdef_uv_sec_strength;

    [InlineArray(8)]
    public partial struct _cdef_y_pri_strength_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _cdef_y_sec_strength_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _cdef_uv_pri_strength_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _cdef_uv_sec_strength_e__FixedBuffer
    {
        public byte e0;
    }
}
