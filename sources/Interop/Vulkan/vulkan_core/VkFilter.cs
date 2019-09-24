// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkFilter
    {
        VK_FILTER_NEAREST = 0,
        VK_FILTER_LINEAR = 1,
        VK_FILTER_CUBIC_IMG = 1000015000,
        VK_FILTER_CUBIC_EXT = VK_FILTER_CUBIC_IMG,
        VK_FILTER_BEGIN_RANGE = VK_FILTER_NEAREST,
        VK_FILTER_END_RANGE = VK_FILTER_LINEAR,
        VK_FILTER_RANGE_SIZE = (VK_FILTER_LINEAR - VK_FILTER_NEAREST + 1),
        VK_FILTER_MAX_ENUM = 0x7FFFFFFF,
    }
}