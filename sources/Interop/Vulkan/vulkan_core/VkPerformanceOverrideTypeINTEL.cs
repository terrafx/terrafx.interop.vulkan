// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkPerformanceOverrideTypeINTEL
    {
        VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL = 0,
        VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL = 1,
        VK_PERFORMANCE_OVERRIDE_TYPE_BEGIN_RANGE_INTEL = VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL,
        VK_PERFORMANCE_OVERRIDE_TYPE_END_RANGE_INTEL = VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL,
        VK_PERFORMANCE_OVERRIDE_TYPE_RANGE_SIZE_INTEL = (VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL - VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL + 1),
        VK_PERFORMANCE_OVERRIDE_TYPE_MAX_ENUM_INTEL = 0x7FFFFFFF,
    }
}
