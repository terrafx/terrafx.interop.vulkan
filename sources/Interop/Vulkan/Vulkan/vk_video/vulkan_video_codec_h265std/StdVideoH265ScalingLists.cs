// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265ScalingLists
{
    [NativeTypeName("uint8_t[6][16]")]
    public _ScalingList4x4_e__FixedBuffer ScalingList4x4;

    [NativeTypeName("uint8_t[6][64]")]
    public _ScalingList8x8_e__FixedBuffer ScalingList8x8;

    [NativeTypeName("uint8_t[6][64]")]
    public _ScalingList16x16_e__FixedBuffer ScalingList16x16;

    [NativeTypeName("uint8_t[2][64]")]
    public _ScalingList32x32_e__FixedBuffer ScalingList32x32;

    [NativeTypeName("uint8_t[6]")]
    public _ScalingListDCCoef16x16_e__FixedBuffer ScalingListDCCoef16x16;

    [NativeTypeName("uint8_t[2]")]
    public _ScalingListDCCoef32x32_e__FixedBuffer ScalingListDCCoef32x32;

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

    [InlineArray(6 * 64)]
    public partial struct _ScalingList16x16_e__FixedBuffer
    {
        public byte e0_0;
    }

    [InlineArray(2 * 64)]
    public partial struct _ScalingList32x32_e__FixedBuffer
    {
        public byte e0_0;
    }

    [InlineArray(6)]
    public partial struct _ScalingListDCCoef16x16_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _ScalingListDCCoef32x32_e__FixedBuffer
    {
        public byte e0;
    }
}
