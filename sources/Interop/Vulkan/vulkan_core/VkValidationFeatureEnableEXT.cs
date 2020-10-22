// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkValidationFeatureEnableEXT
    {
        VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = 0,
        VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = 1,
        VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT = 2,
        VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT = 3,
        VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT = 4,
        VK_VALIDATION_FEATURE_ENABLE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
