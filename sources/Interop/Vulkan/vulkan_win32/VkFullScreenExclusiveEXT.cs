// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_win32.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkFullScreenExclusiveEXT
    {
        VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT = 0,
        VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT = 1,
        VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT = 2,
        VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT = 3,
        VK_FULL_SCREEN_EXCLUSIVE_BEGIN_RANGE_EXT = VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT,
        VK_FULL_SCREEN_EXCLUSIVE_END_RANGE_EXT = VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT,
        VK_FULL_SCREEN_EXCLUSIVE_RANGE_SIZE_EXT = (VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT - VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT + 1),
        VK_FULL_SCREEN_EXCLUSIVE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
