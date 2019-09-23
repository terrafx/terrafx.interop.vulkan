// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkBlendOverlapEXT
    {
        VK_BLEND_OVERLAP_UNCORRELATED_EXT = 0,
        VK_BLEND_OVERLAP_DISJOINT_EXT = 1,
        VK_BLEND_OVERLAP_CONJOINT_EXT = 2,
        VK_BLEND_OVERLAP_BEGIN_RANGE_EXT = VK_BLEND_OVERLAP_UNCORRELATED_EXT,
        VK_BLEND_OVERLAP_END_RANGE_EXT = VK_BLEND_OVERLAP_CONJOINT_EXT,
        VK_BLEND_OVERLAP_RANGE_SIZE_EXT = (VK_BLEND_OVERLAP_CONJOINT_EXT - VK_BLEND_OVERLAP_UNCORRELATED_EXT + 1),
        VK_BLEND_OVERLAP_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
