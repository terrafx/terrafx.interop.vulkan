// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkMemoryPropertyFlags : uint
    {
        VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT = 0x00000001,
        VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = 0x00000002,
        VK_MEMORY_PROPERTY_HOST_COHERENT_BIT = 0x00000004,
        VK_MEMORY_PROPERTY_HOST_CACHED_BIT = 0x00000008,
        VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = 0x00000010,
        VK_MEMORY_PROPERTY_PROTECTED_BIT = 0x00000020,
        VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD = 0x00000040,
        VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD = 0x00000080,
        VK_MEMORY_PROPERTY_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
