// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkSamplerYcbcrRange
    {
        VK_SAMPLER_YCBCR_RANGE_ITU_FULL = 0,
        VK_SAMPLER_YCBCR_RANGE_ITU_NARROW = 1,
        VK_SAMPLER_YCBCR_RANGE_ITU_FULL_KHR = VK_SAMPLER_YCBCR_RANGE_ITU_FULL,
        VK_SAMPLER_YCBCR_RANGE_ITU_NARROW_KHR = VK_SAMPLER_YCBCR_RANGE_ITU_NARROW,
        VK_SAMPLER_YCBCR_RANGE_BEGIN_RANGE = VK_SAMPLER_YCBCR_RANGE_ITU_FULL,
        VK_SAMPLER_YCBCR_RANGE_END_RANGE = VK_SAMPLER_YCBCR_RANGE_ITU_NARROW,
        VK_SAMPLER_YCBCR_RANGE_RANGE_SIZE = (VK_SAMPLER_YCBCR_RANGE_ITU_NARROW - VK_SAMPLER_YCBCR_RANGE_ITU_FULL + 1),
        VK_SAMPLER_YCBCR_RANGE_MAX_ENUM = 0x7FFFFFFF,
    }
}
