// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH264WeightTable
{
    public StdVideoEncodeH264WeightTableFlags flags;

    [NativeTypeName("uint8_t")]
    public byte luma_log2_weight_denom;

    [NativeTypeName("uint8_t")]
    public byte chroma_log2_weight_denom;

    [NativeTypeName("int8_t[32]")]
    public fixed sbyte luma_weight_l0[32];

    [NativeTypeName("int8_t[32]")]
    public fixed sbyte luma_offset_l0[32];

    [NativeTypeName("int8_t[32][2]")]
    public fixed sbyte chroma_weight_l0[32 * 2];

    [NativeTypeName("int8_t[32][2]")]
    public fixed sbyte chroma_offset_l0[32 * 2];

    [NativeTypeName("int8_t[32]")]
    public fixed sbyte luma_weight_l1[32];

    [NativeTypeName("int8_t[32]")]
    public fixed sbyte luma_offset_l1[32];

    [NativeTypeName("int8_t[32][2]")]
    public fixed sbyte chroma_weight_l1[32 * 2];

    [NativeTypeName("int8_t[32][2]")]
    public fixed sbyte chroma_offset_l1[32 * 2];
}
