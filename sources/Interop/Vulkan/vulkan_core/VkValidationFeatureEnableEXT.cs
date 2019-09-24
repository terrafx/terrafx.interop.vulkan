// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkValidationFeatureEnableEXT
    {
        VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = 0,
        VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = 1,
        VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT = 2,
        VK_VALIDATION_FEATURE_ENABLE_BEGIN_RANGE_EXT = VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT,
        VK_VALIDATION_FEATURE_ENABLE_END_RANGE_EXT = VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT,
        VK_VALIDATION_FEATURE_ENABLE_RANGE_SIZE_EXT = (VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT - VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT + 1),
        VK_VALIDATION_FEATURE_ENABLE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
