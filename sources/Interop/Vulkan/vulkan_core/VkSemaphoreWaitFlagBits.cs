// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkSemaphoreWaitFlagBits
    {
        VK_SEMAPHORE_WAIT_ANY_BIT = 0x00000001,
        VK_SEMAPHORE_WAIT_ANY_BIT_KHR = VK_SEMAPHORE_WAIT_ANY_BIT,
        VK_SEMAPHORE_WAIT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}