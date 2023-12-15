// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_h265std 1")]
    public const int vulkan_video_codec_h265std = 1;

    [NativeTypeName("#define STD_VIDEO_H265_SUBLAYERS_LIST_SIZE 7")]
    public const int STD_VIDEO_H265_SUBLAYERS_LIST_SIZE = 7;

    [NativeTypeName("#define STD_VIDEO_H265_CPB_CNT_LIST_SIZE 32")]
    public const int STD_VIDEO_H265_CPB_CNT_LIST_SIZE = 32;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS 6")]
    public const int STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS = 6;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS 16")]
    public const int STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS = 16;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS 6")]
    public const int STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS = 6;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS 64")]
    public const int STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS = 64;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS 6")]
    public const int STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS = 6;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS 64")]
    public const int STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS = 64;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS 2")]
    public const int STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS = 2;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS 64")]
    public const int STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS = 64;

    [NativeTypeName("#define STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE 3")]
    public const int STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE = 3;

    [NativeTypeName("#define STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE 128")]
    public const int STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE = 128;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_DPB_SIZE 16")]
    public const int STD_VIDEO_H265_MAX_DPB_SIZE = 16;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS 32")]
    public const int STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS = 32;

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE 6")]
    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE = 6;

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE 19")]
    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE = 19;

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE 21")]
    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE = 21;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_NUM_LIST_REF 15")]
    public const int STD_VIDEO_H265_MAX_NUM_LIST_REF = 15;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_CHROMA_PLANES 2")]
    public const int STD_VIDEO_H265_MAX_CHROMA_PLANES = 2;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_SHORT_TERM_REF_PIC_SETS 64")]
    public const int STD_VIDEO_H265_MAX_SHORT_TERM_REF_PIC_SETS = 64;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_LONG_TERM_PICS 16")]
    public const int STD_VIDEO_H265_MAX_LONG_TERM_PICS = 16;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_DELTA_POC 48")]
    public const int STD_VIDEO_H265_MAX_DELTA_POC = 48;
}
