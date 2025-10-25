// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265SequenceParameterSetVui
{
    public StdVideoH265SpsVuiFlags flags;

    public StdVideoH265AspectRatioIdc aspect_ratio_idc;

    [NativeTypeName("uint16_t")]
    public ushort sar_width;

    [NativeTypeName("uint16_t")]
    public ushort sar_height;

    [NativeTypeName("uint8_t")]
    public byte video_format;

    [NativeTypeName("uint8_t")]
    public byte colour_primaries;

    [NativeTypeName("uint8_t")]
    public byte transfer_characteristics;

    [NativeTypeName("uint8_t")]
    public byte matrix_coeffs;

    [NativeTypeName("uint8_t")]
    public byte chroma_sample_loc_type_top_field;

    [NativeTypeName("uint8_t")]
    public byte chroma_sample_loc_type_bottom_field;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    [NativeTypeName("uint8_t")]
    public byte reserved2;

    [NativeTypeName("uint16_t")]
    public ushort def_disp_win_left_offset;

    [NativeTypeName("uint16_t")]
    public ushort def_disp_win_right_offset;

    [NativeTypeName("uint16_t")]
    public ushort def_disp_win_top_offset;

    [NativeTypeName("uint16_t")]
    public ushort def_disp_win_bottom_offset;

    [NativeTypeName("uint32_t")]
    public uint vui_num_units_in_tick;

    [NativeTypeName("uint32_t")]
    public uint vui_time_scale;

    [NativeTypeName("uint32_t")]
    public uint vui_num_ticks_poc_diff_one_minus1;

    [NativeTypeName("uint16_t")]
    public ushort min_spatial_segmentation_idc;

    [NativeTypeName("uint16_t")]
    public ushort reserved3;

    [NativeTypeName("uint8_t")]
    public byte max_bytes_per_pic_denom;

    [NativeTypeName("uint8_t")]
    public byte max_bits_per_min_cu_denom;

    [NativeTypeName("uint8_t")]
    public byte log2_max_mv_length_horizontal;

    [NativeTypeName("uint8_t")]
    public byte log2_max_mv_length_vertical;

    [NativeTypeName("const StdVideoH265HrdParameters *")]
    public StdVideoH265HrdParameters* pHrdParameters;
}
