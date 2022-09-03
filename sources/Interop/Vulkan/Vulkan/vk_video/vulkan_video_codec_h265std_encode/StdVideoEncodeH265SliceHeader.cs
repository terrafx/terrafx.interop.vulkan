// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH265SliceHeader
{
    public StdVideoH265SliceType slice_type;

    [NativeTypeName("uint8_t")]
    public byte slice_pic_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte num_short_term_ref_pic_sets;

    [NativeTypeName("uint32_t")]
    public uint slice_segment_address;

    [NativeTypeName("uint8_t")]
    public byte short_term_ref_pic_set_idx;

    [NativeTypeName("uint8_t")]
    public byte num_long_term_sps;

    [NativeTypeName("uint8_t")]
    public byte num_long_term_pics;

    [NativeTypeName("uint8_t")]
    public byte collocated_ref_idx;

    [NativeTypeName("uint8_t")]
    public byte num_ref_idx_l0_active_minus1;

    [NativeTypeName("uint8_t")]
    public byte num_ref_idx_l1_active_minus1;

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

    [NativeTypeName("uint8_t")]
    public byte MaxNumMergeCand;

    [NativeTypeName("int8_t")]
    public sbyte slice_qp_delta;

    [NativeTypeName("int8_t")]
    public sbyte slice_cb_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_cr_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_beta_offset_div2;

    [NativeTypeName("int8_t")]
    public sbyte slice_tc_offset_div2;

    [NativeTypeName("int8_t")]
    public sbyte slice_act_y_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_act_cb_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_act_cr_qp_offset;

    public StdVideoEncodeH265SliceHeaderFlags flags;
}
