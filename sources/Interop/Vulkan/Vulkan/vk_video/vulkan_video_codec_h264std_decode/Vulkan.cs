// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_h264std_decode 1")]
    public const int vulkan_video_codec_h264std_decode = 1;

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_0_9_6 VK_MAKE_VIDEO_STD_VERSION(0, 9, 6)")]
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_0_9_6 = ((((uint)(0)) << 22) | (((uint)(9)) << 12) | ((uint)(6)));

    [NativeTypeName("#define STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE 2")]
    public const int STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE = 2;

    [NativeTypeName("#define STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE 15")]
    public const int STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE = 15;

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_SPEC_VERSION VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_0_9_6")]
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_SPEC_VERSION = ((((uint)(0)) << 22) | (((uint)(9)) << 12) | ((uint)(6)));

    [NativeTypeName("#define VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_EXTENSION_NAME \"VK_STD_vulkan_video_codec_h264_decode\"")]
    public static ReadOnlySpan<byte> VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_EXTENSION_NAME => "VK_STD_vulkan_video_codec_h264_decode"u8;
}
