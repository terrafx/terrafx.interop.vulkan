// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkSwapchainCreateFlagsKHR : uint
    {
        VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = 0x00000001,
        VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR = 0x00000002,
        VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR = 0x00000004,
        VK_SWAPCHAIN_CREATE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
