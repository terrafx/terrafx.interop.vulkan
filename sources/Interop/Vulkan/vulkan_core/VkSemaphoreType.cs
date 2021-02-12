// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkSemaphoreType
    {
        VK_SEMAPHORE_TYPE_BINARY = 0,
        VK_SEMAPHORE_TYPE_TIMELINE = 1,
        VK_SEMAPHORE_TYPE_BINARY_KHR = VK_SEMAPHORE_TYPE_BINARY,
        VK_SEMAPHORE_TYPE_TIMELINE_KHR = VK_SEMAPHORE_TYPE_TIMELINE,
        VK_SEMAPHORE_TYPE_MAX_ENUM = 0x7FFFFFFF,
    }
}
