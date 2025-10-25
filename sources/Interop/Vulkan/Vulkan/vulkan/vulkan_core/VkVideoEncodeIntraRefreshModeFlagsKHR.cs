// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkVideoEncodeIntraRefreshModeFlagsKHR : uint
{
    VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_NONE_KHR = 0,
    VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_PER_PICTURE_PARTITION_BIT_KHR = 0x00000001,
    VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_BASED_BIT_KHR = 0x00000002,
    VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_ROW_BASED_BIT_KHR = 0x00000004,
    VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_COLUMN_BASED_BIT_KHR = 0x00000008,
    VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
