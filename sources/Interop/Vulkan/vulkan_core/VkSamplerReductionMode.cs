// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkSamplerReductionMode
    {
        VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE = 0,
        VK_SAMPLER_REDUCTION_MODE_MIN = 1,
        VK_SAMPLER_REDUCTION_MODE_MAX = 2,
        VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT = VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE,
        VK_SAMPLER_REDUCTION_MODE_MIN_EXT = VK_SAMPLER_REDUCTION_MODE_MIN,
        VK_SAMPLER_REDUCTION_MODE_MAX_EXT = VK_SAMPLER_REDUCTION_MODE_MAX,
        VK_SAMPLER_REDUCTION_MODE_BEGIN_RANGE = VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE,
        VK_SAMPLER_REDUCTION_MODE_END_RANGE = VK_SAMPLER_REDUCTION_MODE_MAX,
        VK_SAMPLER_REDUCTION_MODE_RANGE_SIZE = (VK_SAMPLER_REDUCTION_MODE_MAX - VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE + 1),
        VK_SAMPLER_REDUCTION_MODE_MAX_ENUM = 0x7FFFFFFF,
    }
}
