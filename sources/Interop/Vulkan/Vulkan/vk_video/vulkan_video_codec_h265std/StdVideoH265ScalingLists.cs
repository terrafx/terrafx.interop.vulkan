// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265ScalingLists
{
    [NativeTypeName("uint8_t[6][16]")]
    public fixed byte ScalingList4x4[6 * 16];

    [NativeTypeName("uint8_t[6][64]")]
    public fixed byte ScalingList8x8[6 * 64];

    [NativeTypeName("uint8_t[6][64]")]
    public fixed byte ScalingList16x16[6 * 64];

    [NativeTypeName("uint8_t[2][64]")]
    public fixed byte ScalingList32x32[2 * 64];

    [NativeTypeName("uint8_t[6]")]
    public fixed byte ScalingListDCCoef16x16[6];

    [NativeTypeName("uint8_t[2]")]
    public fixed byte ScalingListDCCoef32x32[2];
}
