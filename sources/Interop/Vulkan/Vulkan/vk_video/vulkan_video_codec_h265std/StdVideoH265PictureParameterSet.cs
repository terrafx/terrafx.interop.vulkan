// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265PictureParameterSet
{
    [NativeTypeName("uint8_t")]
    public byte pps_pic_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pps_seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte num_extra_slice_header_bits;

    [NativeTypeName("uint8_t")]
    public byte num_ref_idx_l0_default_active_minus1;

    [NativeTypeName("uint8_t")]
    public byte num_ref_idx_l1_default_active_minus1;

    [NativeTypeName("int8_t")]
    public sbyte init_qp_minus26;

    [NativeTypeName("uint8_t")]
    public byte diff_cu_qp_delta_depth;

    [NativeTypeName("int8_t")]
    public sbyte pps_cb_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte pps_cr_qp_offset;

    [NativeTypeName("uint8_t")]
    public byte num_tile_columns_minus1;

    [NativeTypeName("uint8_t")]
    public byte num_tile_rows_minus1;

    [NativeTypeName("uint16_t[19]")]
    public fixed ushort column_width_minus1[19];

    [NativeTypeName("uint16_t[21]")]
    public fixed ushort row_height_minus1[21];

    [NativeTypeName("int8_t")]
    public sbyte pps_beta_offset_div2;

    [NativeTypeName("int8_t")]
    public sbyte pps_tc_offset_div2;

    [NativeTypeName("uint8_t")]
    public byte log2_parallel_merge_level_minus2;

    public StdVideoH265PpsFlags flags;

    public StdVideoH265ScalingLists* pScalingLists;

    [NativeTypeName("uint8_t")]
    public byte log2_max_transform_skip_block_size_minus2;

    [NativeTypeName("uint8_t")]
    public byte diff_cu_chroma_qp_offset_depth;

    [NativeTypeName("uint8_t")]
    public byte chroma_qp_offset_list_len_minus1;

    [NativeTypeName("int8_t[6]")]
    public fixed sbyte cb_qp_offset_list[6];

    [NativeTypeName("int8_t[6]")]
    public fixed sbyte cr_qp_offset_list[6];

    [NativeTypeName("uint8_t")]
    public byte log2_sao_offset_scale_luma;

    [NativeTypeName("uint8_t")]
    public byte log2_sao_offset_scale_chroma;

    [NativeTypeName("int8_t")]
    public sbyte pps_act_y_qp_offset_plus5;

    [NativeTypeName("int8_t")]
    public sbyte pps_act_cb_qp_offset_plus5;

    [NativeTypeName("int8_t")]
    public sbyte pps_act_cr_qp_offset_plus5;

    [NativeTypeName("uint8_t")]
    public byte pps_num_palette_predictor_initializer;

    [NativeTypeName("uint8_t")]
    public byte luma_bit_depth_entry_minus8;

    [NativeTypeName("uint8_t")]
    public byte chroma_bit_depth_entry_minus8;

    public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
}
