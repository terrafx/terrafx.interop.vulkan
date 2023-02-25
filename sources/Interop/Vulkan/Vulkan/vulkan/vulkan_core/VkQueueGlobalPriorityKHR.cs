// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkQueueGlobalPriorityKHR
{
    VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR = 128,
    VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR = 256,
    VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR = 512,
    VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR = 1024,
    VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT = VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR,
    VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT = VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR,
    VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT = VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR,
    VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT = VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR,
    VK_QUEUE_GLOBAL_PRIORITY_MAX_ENUM_KHR = 0x7FFFFFFF,
}
