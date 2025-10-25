// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_h264std 1")]
    public const int vulkan_video_codec_h264std = 1;

    [NativeTypeName("#define STD_VIDEO_H264_CPB_CNT_LIST_SIZE 32U")]
    public const uint STD_VIDEO_H264_CPB_CNT_LIST_SIZE = 32U;

    [NativeTypeName("#define STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS 6U")]
    public const uint STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS = 6U;

    [NativeTypeName("#define STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS 16U")]
    public const uint STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS = 16U;

    [NativeTypeName("#define STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS 6U")]
    public const uint STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS = 6U;

    [NativeTypeName("#define STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS 64U")]
    public const uint STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS = 64U;

    [NativeTypeName("#define STD_VIDEO_H264_MAX_NUM_LIST_REF 32U")]
    public const uint STD_VIDEO_H264_MAX_NUM_LIST_REF = 32U;

    [NativeTypeName("#define STD_VIDEO_H264_MAX_CHROMA_PLANES 2U")]
    public const uint STD_VIDEO_H264_MAX_CHROMA_PLANES = 2U;

    [NativeTypeName("#define STD_VIDEO_H264_NO_REFERENCE_PICTURE 0xFFU")]
    public const uint STD_VIDEO_H264_NO_REFERENCE_PICTURE = 0xFFU;
}
