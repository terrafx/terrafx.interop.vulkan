// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkDeviceAddressBindingFlagsEXT : uint
{
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_KHR = 0,
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_KHR = 0x00000001,
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR = 0x00000002,
    VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
