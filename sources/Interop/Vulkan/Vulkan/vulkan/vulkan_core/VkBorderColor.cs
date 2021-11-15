// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkBorderColor
    {
        VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = 0,
        VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = 1,
        VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = 2,
        VK_BORDER_COLOR_INT_OPAQUE_BLACK = 3,
        VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = 4,
        VK_BORDER_COLOR_INT_OPAQUE_WHITE = 5,
        VK_BORDER_COLOR_FLOAT_CUSTOM_EXT = 1000287003,
        VK_BORDER_COLOR_INT_CUSTOM_EXT = 1000287004,
        VK_BORDER_COLOR_MAX_ENUM = 0x7FFFFFFF,
    }
}
