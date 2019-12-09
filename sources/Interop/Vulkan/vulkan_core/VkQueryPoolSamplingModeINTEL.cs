// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkQueryPoolSamplingModeINTEL
    {
        VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL = 0,
        VK_QUERY_POOL_SAMPLING_MODE_BEGIN_RANGE_INTEL = VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL,
        VK_QUERY_POOL_SAMPLING_MODE_END_RANGE_INTEL = VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL,
        VK_QUERY_POOL_SAMPLING_MODE_RANGE_SIZE_INTEL = (VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL - VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL + 1),
        VK_QUERY_POOL_SAMPLING_MODE_MAX_ENUM_INTEL = 0x7FFFFFFF,
    }
}
