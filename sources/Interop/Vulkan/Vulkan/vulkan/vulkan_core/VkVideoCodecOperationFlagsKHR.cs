// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkVideoCodecOperationFlagsKHR
{
    VK_VIDEO_CODEC_OPERATION_NONE_KHR = 0,
    VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR = 0x00010000,
    VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR = 0x00020000,
    VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR = 0x00000001,
    VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR = 0x00000002,
    VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR = 0x00000004,
    VK_VIDEO_CODEC_OPERATION_ENCODE_AV1_BIT_KHR = 0x00040000,
    VK_VIDEO_CODEC_OPERATION_DECODE_VP9_BIT_KHR = 0x00000008,
    VK_VIDEO_CODEC_OPERATION_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
