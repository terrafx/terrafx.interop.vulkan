// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_h265std 1")]
    public const int vulkan_video_codec_h265std = 1;

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H265_API_VERSION_0_9_5 VK_MAKE_VIDEO_STD_VERSION(0, 9, 5)")]
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H265_API_VERSION_0_9_5 = ((((uint)(0)) << 22) | (((uint)(9)) << 12) | ((uint)(5)));

    [NativeTypeName("#define STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE 7")]
    public const int STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE = 7;

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

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE 19")]
    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE = 19;

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE 21")]
    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE = 21;

    [NativeTypeName("#define STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE 6")]
    public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE = 6;

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H265_SPEC_VERSION VK_STD_VULKAN_VIDEO_CODEC_H265_API_VERSION_0_9_5")]
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H265_SPEC_VERSION = ((((uint)(0)) << 22) | (((uint)(9)) << 12) | ((uint)(5)));

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H265_EXTENSION_NAME \"VK_STD_vulkan_video_codec_h265\"")]
    public static ReadOnlySpan<byte> VK_STD_VULKAN_VIDEO_CODEC_H265_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x53, 0x54, 0x44, 0x5F, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x5F, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x5F, 0x63, 0x6F, 0x64, 0x65, 0x63, 0x5F, 0x68, 0x32, 0x36, 0x35, 0x00 };
}
