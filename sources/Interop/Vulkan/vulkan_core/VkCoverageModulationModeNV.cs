// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkCoverageModulationModeNV
    {
        VK_COVERAGE_MODULATION_MODE_NONE_NV = 0,
        VK_COVERAGE_MODULATION_MODE_RGB_NV = 1,
        VK_COVERAGE_MODULATION_MODE_ALPHA_NV = 2,
        VK_COVERAGE_MODULATION_MODE_RGBA_NV = 3,
        VK_COVERAGE_MODULATION_MODE_BEGIN_RANGE_NV = VK_COVERAGE_MODULATION_MODE_NONE_NV,
        VK_COVERAGE_MODULATION_MODE_END_RANGE_NV = VK_COVERAGE_MODULATION_MODE_RGBA_NV,
        VK_COVERAGE_MODULATION_MODE_RANGE_SIZE_NV = (VK_COVERAGE_MODULATION_MODE_RGBA_NV - VK_COVERAGE_MODULATION_MODE_NONE_NV + 1),
        VK_COVERAGE_MODULATION_MODE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
