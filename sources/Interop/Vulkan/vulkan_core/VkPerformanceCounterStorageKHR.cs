// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkPerformanceCounterStorageKHR
    {
        VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR = 0,
        VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR = 1,
        VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR = 2,
        VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR = 3,
        VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR = 4,
        VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR = 5,
        VK_PERFORMANCE_COUNTER_STORAGE_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
