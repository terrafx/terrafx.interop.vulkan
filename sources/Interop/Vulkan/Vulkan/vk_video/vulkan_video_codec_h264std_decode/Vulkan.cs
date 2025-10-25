// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_h264std_decode 1")]
    public const int vulkan_video_codec_h264std_decode = 1;

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_1_0_0 VK_MAKE_VIDEO_STD_VERSION(1, 0, 0)")]
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_1_0_0 = ((((uint)(1)) << 22) | (((uint)(0)) << 12) | ((uint)(0)));

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_SPEC_VERSION VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_1_0_0")]
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_SPEC_VERSION = ((((uint)(1)) << 22) | (((uint)(0)) << 12) | ((uint)(0)));

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_EXTENSION_NAME \"VK_STD_vulkan_video_codec_h264_decode\"")]
    public static ReadOnlySpan<byte> VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_EXTENSION_NAME => "VK_STD_vulkan_video_codec_h264_decode"u8;

    [NativeTypeName("#define STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE 2U")]
    public const uint STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE = 2U;
}
