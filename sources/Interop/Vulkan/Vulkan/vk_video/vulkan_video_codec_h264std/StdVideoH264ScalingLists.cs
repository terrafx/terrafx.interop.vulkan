// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH264ScalingLists
{
    [NativeTypeName("uint16_t")]
    public ushort scaling_list_present_mask;

    [NativeTypeName("uint16_t")]
    public ushort use_default_scaling_matrix_mask;

    [NativeTypeName("uint8_t[6][16]")]
    public _ScalingList4x4_e__FixedBuffer ScalingList4x4;

    [NativeTypeName("uint8_t[6][64]")]
    public _ScalingList8x8_e__FixedBuffer ScalingList8x8;

    [InlineArray(6 * 16)]
    public partial struct _ScalingList4x4_e__FixedBuffer
    {
        public byte e0_0;
    }

    [InlineArray(6 * 64)]
    public partial struct _ScalingList8x8_e__FixedBuffer
    {
        public byte e0_0;
    }
}
