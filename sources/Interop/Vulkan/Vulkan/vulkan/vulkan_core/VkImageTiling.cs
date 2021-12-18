// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkImageTiling
    {
        VK_IMAGE_TILING_OPTIMAL = 0,
        VK_IMAGE_TILING_LINEAR = 1,
        VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = 1000158000,
        VK_IMAGE_TILING_MAX_ENUM = 0x7FFFFFFF,
    }
}
