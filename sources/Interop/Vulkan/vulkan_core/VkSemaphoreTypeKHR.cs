// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkSemaphoreTypeKHR
    {
        VK_SEMAPHORE_TYPE_BINARY_KHR = 0,
        VK_SEMAPHORE_TYPE_TIMELINE_KHR = 1,
        VK_SEMAPHORE_TYPE_BEGIN_RANGE_KHR = VK_SEMAPHORE_TYPE_BINARY_KHR,
        VK_SEMAPHORE_TYPE_END_RANGE_KHR = VK_SEMAPHORE_TYPE_TIMELINE_KHR,
        VK_SEMAPHORE_TYPE_RANGE_SIZE_KHR = (VK_SEMAPHORE_TYPE_TIMELINE_KHR - VK_SEMAPHORE_TYPE_BINARY_KHR + 1),
        VK_SEMAPHORE_TYPE_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
