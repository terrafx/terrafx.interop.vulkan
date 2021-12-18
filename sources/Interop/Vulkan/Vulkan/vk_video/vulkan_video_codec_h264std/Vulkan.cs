// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    public static partial class Vulkan
    {
        [NativeTypeName("#define VULKAN_VIDEO_CODEC_H264STD_H_ 1")]
        public const int VULKAN_VIDEO_CODEC_H264STD_H_ = 1;

        [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_API_VERSION_0_9_5 VK_MAKE_VIDEO_STD_VERSION(0, 9, 5)")]
        public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_API_VERSION_0_9_5 = ((((uint)(0)) << 22) | (((uint)(9)) << 12) | ((uint)(5)));

        [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_SPEC_VERSION VK_STD_VULKAN_VIDEO_CODEC_H264_API_VERSION_0_9_5")]
        public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_SPEC_VERSION = ((((uint)(0)) << 22) | (((uint)(9)) << 12) | ((uint)(5)));

        [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_EXTENSION_NAME \"VK_STD_vulkan_video_codec_h264\"")]
        public static ReadOnlySpan<byte> VK_STD_VULKAN_VIDEO_CODEC_H264_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x53, 0x54, 0x44, 0x5F, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x5F, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x5F, 0x63, 0x6F, 0x64, 0x65, 0x63, 0x5F, 0x68, 0x32, 0x36, 0x34, 0x00 };

        [NativeTypeName("#define STD_VIDEO_H264_CPB_CNT_LIST_SIZE 32")]
        public const int STD_VIDEO_H264_CPB_CNT_LIST_SIZE = 32;

        [NativeTypeName("#define STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS 6")]
        public const int STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS = 6;

        [NativeTypeName("#define STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS 16")]
        public const int STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS = 16;

        [NativeTypeName("#define STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS 2")]
        public const int STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS = 2;

        [NativeTypeName("#define STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS 64")]
        public const int STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS = 64;
    }
}
