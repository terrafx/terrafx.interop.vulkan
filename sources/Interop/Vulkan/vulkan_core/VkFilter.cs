// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkFilter
    {
        VK_FILTER_NEAREST = 0,
        VK_FILTER_LINEAR = 1,
        VK_FILTER_CUBIC_IMG = 1000015000,
        VK_FILTER_CUBIC_EXT = VK_FILTER_CUBIC_IMG,
        VK_FILTER_MAX_ENUM = 0x7FFFFFFF,
    }
}
