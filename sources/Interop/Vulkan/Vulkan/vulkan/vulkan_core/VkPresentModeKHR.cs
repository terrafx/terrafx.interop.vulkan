// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkPresentModeKHR
    {
        VK_PRESENT_MODE_IMMEDIATE_KHR = 0,
        VK_PRESENT_MODE_MAILBOX_KHR = 1,
        VK_PRESENT_MODE_FIFO_KHR = 2,
        VK_PRESENT_MODE_FIFO_RELAXED_KHR = 3,
        VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR = 1000111000,
        VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR = 1000111001,
        VK_PRESENT_MODE_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
