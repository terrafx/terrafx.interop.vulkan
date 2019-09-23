// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkValidationCheckEXT
    {
        VK_VALIDATION_CHECK_ALL_EXT = 0,
        VK_VALIDATION_CHECK_SHADERS_EXT = 1,
        VK_VALIDATION_CHECK_BEGIN_RANGE_EXT = VK_VALIDATION_CHECK_ALL_EXT,
        VK_VALIDATION_CHECK_END_RANGE_EXT = VK_VALIDATION_CHECK_SHADERS_EXT,
        VK_VALIDATION_CHECK_RANGE_SIZE_EXT = (VK_VALIDATION_CHECK_SHADERS_EXT - VK_VALIDATION_CHECK_ALL_EXT + 1),
        VK_VALIDATION_CHECK_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
