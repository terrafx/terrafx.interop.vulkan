// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public enum VkTimeDomainEXT
    {
        VK_TIME_DOMAIN_DEVICE_EXT = 0,
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = 1,
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = 2,
        VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = 3,
        VK_TIME_DOMAIN_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
