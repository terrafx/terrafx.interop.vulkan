// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkAccelerationStructureTypeNV
    {
        VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV = 0,
        VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV = 1,
        VK_ACCELERATION_STRUCTURE_TYPE_BEGIN_RANGE_NV = VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV,
        VK_ACCELERATION_STRUCTURE_TYPE_END_RANGE_NV = VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV,
        VK_ACCELERATION_STRUCTURE_TYPE_RANGE_SIZE_NV = (VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV - VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV + 1),
        VK_ACCELERATION_STRUCTURE_TYPE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
