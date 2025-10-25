// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265PictureParameterSet
{
    public StdVideoH265PpsFlags flags;

    [NativeTypeName("uint8_t")]
    public byte pps_pic_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pps_seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte sps_video_parameter_set_id;

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

    [NativeTypeName("int8_t")]
    public sbyte pps_beta_offset_div2;

    [NativeTypeName("int8_t")]
    public sbyte pps_tc_offset_div2;

    [NativeTypeName("uint8_t")]
    public byte log2_parallel_merge_level_minus2;

    [NativeTypeName("uint8_t")]
    public byte log2_max_transform_skip_block_size_minus2;

    [NativeTypeName("uint8_t")]
    public byte diff_cu_chroma_qp_offset_depth;

    [NativeTypeName("uint8_t")]
    public byte chroma_qp_offset_list_len_minus1;

    [NativeTypeName("int8_t[6]")]
    public _cb_qp_offset_list_e__FixedBuffer cb_qp_offset_list;

    [NativeTypeName("int8_t[6]")]
    public _cr_qp_offset_list_e__FixedBuffer cr_qp_offset_list;

    [NativeTypeName("uint8_t")]
    public byte log2_sao_offset_scale_luma;

    [NativeTypeName("uint8_t")]
    public byte log2_sao_offset_scale_chroma;

    [NativeTypeName("int8_t")]
    public sbyte pps_act_y_qp_offset_plus5;

    [NativeTypeName("int8_t")]
    public sbyte pps_act_cb_qp_offset_plus5;

    [NativeTypeName("int8_t")]
    public sbyte pps_act_cr_qp_offset_plus3;

    [NativeTypeName("uint8_t")]
    public byte pps_num_palette_predictor_initializers;

    [NativeTypeName("uint8_t")]
    public byte luma_bit_depth_entry_minus8;

    [NativeTypeName("uint8_t")]
    public byte chroma_bit_depth_entry_minus8;

    [NativeTypeName("uint8_t")]
    public byte num_tile_columns_minus1;

    [NativeTypeName("uint8_t")]
    public byte num_tile_rows_minus1;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    [NativeTypeName("uint8_t")]
    public byte reserved2;

    [NativeTypeName("uint16_t[19]")]
    public _column_width_minus1_e__FixedBuffer column_width_minus1;

    [NativeTypeName("uint16_t[21]")]
    public _row_height_minus1_e__FixedBuffer row_height_minus1;

    [NativeTypeName("uint32_t")]
    public uint reserved3;

    [NativeTypeName("const StdVideoH265ScalingLists *")]
    public StdVideoH265ScalingLists* pScalingLists;

    [NativeTypeName("const StdVideoH265PredictorPaletteEntries *")]
    public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;

    [InlineArray(6)]
    public partial struct _cb_qp_offset_list_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(6)]
    public partial struct _cr_qp_offset_list_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(19)]
    public partial struct _column_width_minus1_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(21)]
    public partial struct _row_height_minus1_e__FixedBuffer
    {
        public ushort e0;
    }
}
