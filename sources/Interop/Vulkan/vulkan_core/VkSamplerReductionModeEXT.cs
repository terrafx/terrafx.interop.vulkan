// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkSamplerReductionModeEXT
    {
        VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT = 0,
        VK_SAMPLER_REDUCTION_MODE_MIN_EXT = 1,
        VK_SAMPLER_REDUCTION_MODE_MAX_EXT = 2,
        VK_SAMPLER_REDUCTION_MODE_BEGIN_RANGE_EXT = VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT,
        VK_SAMPLER_REDUCTION_MODE_END_RANGE_EXT = VK_SAMPLER_REDUCTION_MODE_MAX_EXT,
        VK_SAMPLER_REDUCTION_MODE_RANGE_SIZE_EXT = (VK_SAMPLER_REDUCTION_MODE_MAX_EXT - VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT + 1),
        VK_SAMPLER_REDUCTION_MODE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
