// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkImageType
    {
        VK_IMAGE_TYPE_1D = 0,
        VK_IMAGE_TYPE_2D = 1,
        VK_IMAGE_TYPE_3D = 2,
        VK_IMAGE_TYPE_BEGIN_RANGE = VK_IMAGE_TYPE_1D,
        VK_IMAGE_TYPE_END_RANGE = VK_IMAGE_TYPE_3D,
        VK_IMAGE_TYPE_RANGE_SIZE = (VK_IMAGE_TYPE_3D - VK_IMAGE_TYPE_1D + 1),
        VK_IMAGE_TYPE_MAX_ENUM = 0x7FFFFFFF,
    }
}
