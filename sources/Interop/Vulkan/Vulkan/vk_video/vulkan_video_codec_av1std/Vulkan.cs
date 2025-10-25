// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_av1std 1")]
    public const int vulkan_video_codec_av1std = 1;

    [NativeTypeName("#define STD_VIDEO_AV1_NUM_REF_FRAMES 8U")]
    public const uint STD_VIDEO_AV1_NUM_REF_FRAMES = 8U;

    [NativeTypeName("#define STD_VIDEO_AV1_REFS_PER_FRAME 7U")]
    public const uint STD_VIDEO_AV1_REFS_PER_FRAME = 7U;

    [NativeTypeName("#define STD_VIDEO_AV1_TOTAL_REFS_PER_FRAME 8U")]
    public const uint STD_VIDEO_AV1_TOTAL_REFS_PER_FRAME = 8U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_TILE_COLS 64U")]
    public const uint STD_VIDEO_AV1_MAX_TILE_COLS = 64U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_TILE_ROWS 64U")]
    public const uint STD_VIDEO_AV1_MAX_TILE_ROWS = 64U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_SEGMENTS 8U")]
    public const uint STD_VIDEO_AV1_MAX_SEGMENTS = 8U;

    [NativeTypeName("#define STD_VIDEO_AV1_SEG_LVL_MAX 8U")]
    public const uint STD_VIDEO_AV1_SEG_LVL_MAX = 8U;

    [NativeTypeName("#define STD_VIDEO_AV1_PRIMARY_REF_NONE 7U")]
    public const uint STD_VIDEO_AV1_PRIMARY_REF_NONE = 7U;

    [NativeTypeName("#define STD_VIDEO_AV1_SELECT_INTEGER_MV 2U")]
    public const uint STD_VIDEO_AV1_SELECT_INTEGER_MV = 2U;

    [NativeTypeName("#define STD_VIDEO_AV1_SELECT_SCREEN_CONTENT_TOOLS 2U")]
    public const uint STD_VIDEO_AV1_SELECT_SCREEN_CONTENT_TOOLS = 2U;

    [NativeTypeName("#define STD_VIDEO_AV1_SKIP_MODE_FRAMES 2U")]
    public const uint STD_VIDEO_AV1_SKIP_MODE_FRAMES = 2U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_LOOP_FILTER_STRENGTHS 4U")]
    public const uint STD_VIDEO_AV1_MAX_LOOP_FILTER_STRENGTHS = 4U;

    [NativeTypeName("#define STD_VIDEO_AV1_LOOP_FILTER_ADJUSTMENTS 2U")]
    public const uint STD_VIDEO_AV1_LOOP_FILTER_ADJUSTMENTS = 2U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS 8U")]
    public const uint STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS = 8U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_NUM_PLANES 3U")]
    public const uint STD_VIDEO_AV1_MAX_NUM_PLANES = 3U;

    [NativeTypeName("#define STD_VIDEO_AV1_GLOBAL_MOTION_PARAMS 6U")]
    public const uint STD_VIDEO_AV1_GLOBAL_MOTION_PARAMS = 6U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_NUM_Y_POINTS 14U")]
    public const uint STD_VIDEO_AV1_MAX_NUM_Y_POINTS = 14U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_NUM_CB_POINTS 10U")]
    public const uint STD_VIDEO_AV1_MAX_NUM_CB_POINTS = 10U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_NUM_CR_POINTS 10U")]
    public const uint STD_VIDEO_AV1_MAX_NUM_CR_POINTS = 10U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_NUM_POS_LUMA 24U")]
    public const uint STD_VIDEO_AV1_MAX_NUM_POS_LUMA = 24U;

    [NativeTypeName("#define STD_VIDEO_AV1_MAX_NUM_POS_CHROMA 25U")]
    public const uint STD_VIDEO_AV1_MAX_NUM_POS_CHROMA = 25U;
}
