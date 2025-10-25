// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_h265std 1")]
    public const int vulkan_video_codec_h265std = 1;

    [NativeTypeName("#define STD_VIDEO_H265_CPB_CNT_LIST_SIZE 32U")]
    public const uint STD_VIDEO_H265_CPB_CNT_LIST_SIZE = 32U;

    [NativeTypeName("#define STD_VIDEO_H265_SUBLAYERS_LIST_SIZE 7U")]
    public const uint STD_VIDEO_H265_SUBLAYERS_LIST_SIZE = 7U;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS 6U")]
    public const uint STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS = 6U;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS 16U")]
    public const uint STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS = 16U;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS 6U")]
    public const uint STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS = 6U;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS 64U")]
    public const uint STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS = 64U;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS 6U")]
    public const uint STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS = 6U;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS 64U")]
    public const uint STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS = 64U;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS 2U")]
    public const uint STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS = 2U;

    [NativeTypeName("#define STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS 64U")]
    public const uint STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS = 64U;

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE 6U")]
    public const uint STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE = 6U;

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE 19U")]
    public const uint STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE = 19U;

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE 21U")]
    public const uint STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE = 21U;

    [NativeTypeName("#define STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE 3U")]
    public const uint STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE = 3U;

    [NativeTypeName("#define STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE 128U")]
    public const uint STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE = 128U;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_NUM_LIST_REF 15U")]
    public const uint STD_VIDEO_H265_MAX_NUM_LIST_REF = 15U;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_CHROMA_PLANES 2U")]
    public const uint STD_VIDEO_H265_MAX_CHROMA_PLANES = 2U;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_SHORT_TERM_REF_PIC_SETS 64U")]
    public const uint STD_VIDEO_H265_MAX_SHORT_TERM_REF_PIC_SETS = 64U;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_DPB_SIZE 16U")]
    public const uint STD_VIDEO_H265_MAX_DPB_SIZE = 16U;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS 32U")]
    public const uint STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS = 32U;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_LONG_TERM_PICS 16U")]
    public const uint STD_VIDEO_H265_MAX_LONG_TERM_PICS = 16U;

    [NativeTypeName("#define STD_VIDEO_H265_MAX_DELTA_POC 48U")]
    public const uint STD_VIDEO_H265_MAX_DELTA_POC = 48U;

    [NativeTypeName("#define STD_VIDEO_H265_NO_REFERENCE_PICTURE 0xFFU")]
    public const uint STD_VIDEO_H265_NO_REFERENCE_PICTURE = 0xFFU;
}
