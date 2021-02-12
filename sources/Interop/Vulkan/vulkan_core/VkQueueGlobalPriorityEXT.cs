// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkQueueGlobalPriorityEXT
    {
        VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT = 128,
        VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT = 256,
        VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT = 512,
        VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT = 1024,
        VK_QUEUE_GLOBAL_PRIORITY_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
