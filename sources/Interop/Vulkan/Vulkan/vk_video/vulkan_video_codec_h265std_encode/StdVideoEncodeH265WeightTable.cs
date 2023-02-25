// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH265WeightTable
{
    public StdVideoEncodeH265WeightTableFlags flags;

    [NativeTypeName("uint8_t")]
    public byte luma_log2_weight_denom;

    [NativeTypeName("int8_t")]
    public sbyte delta_chroma_log2_weight_denom;

    [NativeTypeName("int8_t[15]")]
    public fixed sbyte delta_luma_weight_l0[15];

    [NativeTypeName("int8_t[15]")]
    public fixed sbyte luma_offset_l0[15];

    [NativeTypeName("int8_t[15][2]")]
    public fixed sbyte delta_chroma_weight_l0[15 * 2];

    [NativeTypeName("int8_t[15][2]")]
    public fixed sbyte delta_chroma_offset_l0[15 * 2];

    [NativeTypeName("int8_t[15]")]
    public fixed sbyte delta_luma_weight_l1[15];

    [NativeTypeName("int8_t[15]")]
    public fixed sbyte luma_offset_l1[15];

    [NativeTypeName("int8_t[15][2]")]
    public fixed sbyte delta_chroma_weight_l1[15 * 2];

    [NativeTypeName("int8_t[15][2]")]
    public fixed sbyte delta_chroma_offset_l1[15 * 2];
}
