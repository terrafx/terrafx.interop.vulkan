// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkImageTiling
    {
        VK_IMAGE_TILING_OPTIMAL = 0,
        VK_IMAGE_TILING_LINEAR = 1,
        VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = 1000158000,
        VK_IMAGE_TILING_BEGIN_RANGE = VK_IMAGE_TILING_OPTIMAL,
        VK_IMAGE_TILING_END_RANGE = VK_IMAGE_TILING_LINEAR,
        VK_IMAGE_TILING_RANGE_SIZE = (VK_IMAGE_TILING_LINEAR - VK_IMAGE_TILING_OPTIMAL + 1),
        VK_IMAGE_TILING_MAX_ENUM = 0x7FFFFFFF,
    }
}
