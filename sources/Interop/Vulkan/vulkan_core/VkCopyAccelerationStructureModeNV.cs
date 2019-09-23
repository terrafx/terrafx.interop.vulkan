// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkCopyAccelerationStructureModeNV
    {
        VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV = 0,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV = 1,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_BEGIN_RANGE_NV = VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_END_RANGE_NV = VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV,
        VK_COPY_ACCELERATION_STRUCTURE_MODE_RANGE_SIZE_NV = (VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV - VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV + 1),
        VK_COPY_ACCELERATION_STRUCTURE_MODE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
