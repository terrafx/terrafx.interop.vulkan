// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkIndexType
{
    VK_INDEX_TYPE_UINT16 = 0,
    VK_INDEX_TYPE_UINT32 = 1,
    VK_INDEX_TYPE_UINT8 = 1000265000,
    VK_INDEX_TYPE_NONE_KHR = 1000165000,
    VK_INDEX_TYPE_NONE_NV = VK_INDEX_TYPE_NONE_KHR,
    VK_INDEX_TYPE_UINT8_EXT = VK_INDEX_TYPE_UINT8,
    VK_INDEX_TYPE_UINT8_KHR = VK_INDEX_TYPE_UINT8,
    VK_INDEX_TYPE_MAX_ENUM = 0x7FFFFFFF,
}
