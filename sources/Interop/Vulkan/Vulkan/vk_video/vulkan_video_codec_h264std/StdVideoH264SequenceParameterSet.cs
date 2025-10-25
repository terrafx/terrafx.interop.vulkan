// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH264SequenceParameterSet
{
    public StdVideoH264SpsFlags flags;

    public StdVideoH264ProfileIdc profile_idc;

    public StdVideoH264LevelIdc level_idc;

    public StdVideoH264ChromaFormatIdc chroma_format_idc;

    [NativeTypeName("uint8_t")]
    public byte seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte bit_depth_luma_minus8;

    [NativeTypeName("uint8_t")]
    public byte bit_depth_chroma_minus8;

    [NativeTypeName("uint8_t")]
    public byte log2_max_frame_num_minus4;

    public StdVideoH264PocType pic_order_cnt_type;

    [NativeTypeName("int32_t")]
    public int offset_for_non_ref_pic;

    [NativeTypeName("int32_t")]
    public int offset_for_top_to_bottom_field;

    [NativeTypeName("uint8_t")]
    public byte log2_max_pic_order_cnt_lsb_minus4;

    [NativeTypeName("uint8_t")]
    public byte num_ref_frames_in_pic_order_cnt_cycle;

    [NativeTypeName("uint8_t")]
    public byte max_num_ref_frames;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    [NativeTypeName("uint32_t")]
    public uint pic_width_in_mbs_minus1;

    [NativeTypeName("uint32_t")]
    public uint pic_height_in_map_units_minus1;

    [NativeTypeName("uint32_t")]
    public uint frame_crop_left_offset;

    [NativeTypeName("uint32_t")]
    public uint frame_crop_right_offset;

    [NativeTypeName("uint32_t")]
    public uint frame_crop_top_offset;

    [NativeTypeName("uint32_t")]
    public uint frame_crop_bottom_offset;

    [NativeTypeName("uint32_t")]
    public uint reserved2;

    [NativeTypeName("const int32_t *")]
    public int* pOffsetForRefFrame;

    [NativeTypeName("const StdVideoH264ScalingLists *")]
    public StdVideoH264ScalingLists* pScalingLists;

    [NativeTypeName("const StdVideoH264SequenceParameterSetVui *")]
    public StdVideoH264SequenceParameterSetVui* pSequenceParameterSetVui;
}
