// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkLineRasterizationModeEXT
    {
        VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT = 0,
        VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT = 1,
        VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT = 2,
        VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT = 3,
        VK_LINE_RASTERIZATION_MODE_BEGIN_RANGE_EXT = VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT,
        VK_LINE_RASTERIZATION_MODE_END_RANGE_EXT = VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT,
        VK_LINE_RASTERIZATION_MODE_RANGE_SIZE_EXT = (VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT - VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT + 1),
        VK_LINE_RASTERIZATION_MODE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
