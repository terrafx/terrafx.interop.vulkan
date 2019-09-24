// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkTimeDomainEXT
    {
        VK_TIME_DOMAIN_DEVICE_EXT = 0,
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = 1,
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = 2,
        VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = 3,
        VK_TIME_DOMAIN_BEGIN_RANGE_EXT = VK_TIME_DOMAIN_DEVICE_EXT,
        VK_TIME_DOMAIN_END_RANGE_EXT = VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT,
        VK_TIME_DOMAIN_RANGE_SIZE_EXT = (VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT - VK_TIME_DOMAIN_DEVICE_EXT + 1),
        VK_TIME_DOMAIN_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}