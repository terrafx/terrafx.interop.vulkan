// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_KHR_portability_subset 1")]
    public const int VK_KHR_portability_subset = 1;

    [NativeTypeName("#define VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION 1")]
    public const int VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME \"VK_KHR_portability_subset\"")]
    public static ReadOnlySpan<byte> VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME => "VK_KHR_portability_subset"u8;

    [NativeTypeName("#define VK_KHR_video_encode_queue 1")]
    public const int VK_KHR_video_encode_queue = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION 7")]
    public const int VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION = 7;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME \"VK_KHR_video_encode_queue\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME => "VK_KHR_video_encode_queue"u8;

    [NativeTypeName("#define VK_EXT_video_encode_h264 1")]
    public const int VK_EXT_video_encode_h264 = 1;

    [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H264_SPEC_VERSION 9")]
    public const int VK_EXT_VIDEO_ENCODE_H264_SPEC_VERSION = 9;

    [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H264_EXTENSION_NAME \"VK_EXT_video_encode_h264\"")]
    public static ReadOnlySpan<byte> VK_EXT_VIDEO_ENCODE_H264_EXTENSION_NAME => "VK_EXT_video_encode_h264"u8;

    [NativeTypeName("#define VK_EXT_video_encode_h265 1")]
    public const int VK_EXT_video_encode_h265 = 1;

    [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H265_SPEC_VERSION 9")]
    public const int VK_EXT_VIDEO_ENCODE_H265_SPEC_VERSION = 9;

    [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H265_EXTENSION_NAME \"VK_EXT_video_encode_h265\"")]
    public static ReadOnlySpan<byte> VK_EXT_VIDEO_ENCODE_H265_EXTENSION_NAME => "VK_EXT_video_encode_h265"u8;
}
