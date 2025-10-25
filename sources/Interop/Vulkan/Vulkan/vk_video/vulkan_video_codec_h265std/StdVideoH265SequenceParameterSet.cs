// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265SequenceParameterSet
{
    public StdVideoH265SpsFlags flags;

    public StdVideoH265ChromaFormatIdc chroma_format_idc;

    [NativeTypeName("uint32_t")]
    public uint pic_width_in_luma_samples;

    [NativeTypeName("uint32_t")]
    public uint pic_height_in_luma_samples;

    [NativeTypeName("uint8_t")]
    public byte sps_video_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte sps_max_sub_layers_minus1;

    [NativeTypeName("uint8_t")]
    public byte sps_seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte bit_depth_luma_minus8;

    [NativeTypeName("uint8_t")]
    public byte bit_depth_chroma_minus8;

    [NativeTypeName("uint8_t")]
    public byte log2_max_pic_order_cnt_lsb_minus4;

    [NativeTypeName("uint8_t")]
    public byte log2_min_luma_coding_block_size_minus3;

    [NativeTypeName("uint8_t")]
    public byte log2_diff_max_min_luma_coding_block_size;

    [NativeTypeName("uint8_t")]
    public byte log2_min_luma_transform_block_size_minus2;

    [NativeTypeName("uint8_t")]
    public byte log2_diff_max_min_luma_transform_block_size;

    [NativeTypeName("uint8_t")]
    public byte max_transform_hierarchy_depth_inter;

    [NativeTypeName("uint8_t")]
    public byte max_transform_hierarchy_depth_intra;

    [NativeTypeName("uint8_t")]
    public byte num_short_term_ref_pic_sets;

    [NativeTypeName("uint8_t")]
    public byte num_long_term_ref_pics_sps;

    [NativeTypeName("uint8_t")]
    public byte pcm_sample_bit_depth_luma_minus1;

    [NativeTypeName("uint8_t")]
    public byte pcm_sample_bit_depth_chroma_minus1;

    [NativeTypeName("uint8_t")]
    public byte log2_min_pcm_luma_coding_block_size_minus3;

    [NativeTypeName("uint8_t")]
    public byte log2_diff_max_min_pcm_luma_coding_block_size;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    [NativeTypeName("uint8_t")]
    public byte reserved2;

    [NativeTypeName("uint8_t")]
    public byte palette_max_size;

    [NativeTypeName("uint8_t")]
    public byte delta_palette_max_predictor_size;

    [NativeTypeName("uint8_t")]
    public byte motion_vector_resolution_control_idc;

    [NativeTypeName("uint8_t")]
    public byte sps_num_palette_predictor_initializers_minus1;

    [NativeTypeName("uint32_t")]
    public uint conf_win_left_offset;

    [NativeTypeName("uint32_t")]
    public uint conf_win_right_offset;

    [NativeTypeName("uint32_t")]
    public uint conf_win_top_offset;

    [NativeTypeName("uint32_t")]
    public uint conf_win_bottom_offset;

    [NativeTypeName("const StdVideoH265ProfileTierLevel *")]
    public StdVideoH265ProfileTierLevel* pProfileTierLevel;

    [NativeTypeName("const StdVideoH265DecPicBufMgr *")]
    public StdVideoH265DecPicBufMgr* pDecPicBufMgr;

    [NativeTypeName("const StdVideoH265ScalingLists *")]
    public StdVideoH265ScalingLists* pScalingLists;

    [NativeTypeName("const StdVideoH265ShortTermRefPicSet *")]
    public StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;

    [NativeTypeName("const StdVideoH265LongTermRefPicsSps *")]
    public StdVideoH265LongTermRefPicsSps* pLongTermRefPicsSps;

    [NativeTypeName("const StdVideoH265SequenceParameterSetVui *")]
    public StdVideoH265SequenceParameterSetVui* pSequenceParameterSetVui;

    [NativeTypeName("const StdVideoH265PredictorPaletteEntries *")]
    public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
}
