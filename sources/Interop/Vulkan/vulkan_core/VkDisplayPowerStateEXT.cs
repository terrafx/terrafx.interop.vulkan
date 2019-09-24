// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkDisplayPowerStateEXT
    {
        VK_DISPLAY_POWER_STATE_OFF_EXT = 0,
        VK_DISPLAY_POWER_STATE_SUSPEND_EXT = 1,
        VK_DISPLAY_POWER_STATE_ON_EXT = 2,
        VK_DISPLAY_POWER_STATE_BEGIN_RANGE_EXT = VK_DISPLAY_POWER_STATE_OFF_EXT,
        VK_DISPLAY_POWER_STATE_END_RANGE_EXT = VK_DISPLAY_POWER_STATE_ON_EXT,
        VK_DISPLAY_POWER_STATE_RANGE_SIZE_EXT = (VK_DISPLAY_POWER_STATE_ON_EXT - VK_DISPLAY_POWER_STATE_OFF_EXT + 1),
        VK_DISPLAY_POWER_STATE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
