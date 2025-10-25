// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkTimeDomainKHR
{
    VK_TIME_DOMAIN_DEVICE_KHR = 0,
    VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR = 1,
    VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR = 2,
    VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR = 3,
    VK_TIME_DOMAIN_DEVICE_EXT = VK_TIME_DOMAIN_DEVICE_KHR,
    VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR,
    VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR,
    VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR,
    VK_TIME_DOMAIN_MAX_ENUM_KHR = 0x7FFFFFFF,
}
