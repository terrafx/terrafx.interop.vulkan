// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkFullScreenExclusiveEXT
    {
        VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT = 0,
        VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT = 1,
        VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT = 2,
        VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT = 3,
        VK_FULL_SCREEN_EXCLUSIVE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
