// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_vp9std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_vp9std 1")]
    public const int vulkan_video_codec_vp9std = 1;

    [NativeTypeName("#define STD_VIDEO_VP9_NUM_REF_FRAMES 8U")]
    public const uint STD_VIDEO_VP9_NUM_REF_FRAMES = 8U;

    [NativeTypeName("#define STD_VIDEO_VP9_REFS_PER_FRAME 3U")]
    public const uint STD_VIDEO_VP9_REFS_PER_FRAME = 3U;

    [NativeTypeName("#define STD_VIDEO_VP9_MAX_REF_FRAMES 4U")]
    public const uint STD_VIDEO_VP9_MAX_REF_FRAMES = 4U;

    [NativeTypeName("#define STD_VIDEO_VP9_LOOP_FILTER_ADJUSTMENTS 2U")]
    public const uint STD_VIDEO_VP9_LOOP_FILTER_ADJUSTMENTS = 2U;

    [NativeTypeName("#define STD_VIDEO_VP9_MAX_SEGMENTS 8U")]
    public const uint STD_VIDEO_VP9_MAX_SEGMENTS = 8U;

    [NativeTypeName("#define STD_VIDEO_VP9_SEG_LVL_MAX 4U")]
    public const uint STD_VIDEO_VP9_SEG_LVL_MAX = 4U;

    [NativeTypeName("#define STD_VIDEO_VP9_MAX_SEGMENTATION_TREE_PROBS 7U")]
    public const uint STD_VIDEO_VP9_MAX_SEGMENTATION_TREE_PROBS = 7U;

    [NativeTypeName("#define STD_VIDEO_VP9_MAX_SEGMENTATION_PRED_PROB 3U")]
    public const uint STD_VIDEO_VP9_MAX_SEGMENTATION_PRED_PROB = 3U;
}
