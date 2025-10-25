// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkSwapchainCreateFlagsKHR : uint
{
    VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = 0x00000001,
    VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR = 0x00000002,
    VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR = 0x00000004,
    VK_SWAPCHAIN_CREATE_PRESENT_ID_2_BIT_KHR = 0x00000040,
    VK_SWAPCHAIN_CREATE_PRESENT_WAIT_2_BIT_KHR = 0x00000080,
    VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_KHR = 0x00000008,
    VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT = VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_KHR,
    VK_SWAPCHAIN_CREATE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
