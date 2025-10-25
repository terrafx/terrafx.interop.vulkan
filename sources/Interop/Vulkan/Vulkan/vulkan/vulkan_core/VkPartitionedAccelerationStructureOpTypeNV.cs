// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkPartitionedAccelerationStructureOpTypeNV
{
    VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_WRITE_INSTANCE_NV = 0,
    VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_UPDATE_INSTANCE_NV = 1,
    VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_WRITE_PARTITION_TRANSLATION_NV = 2,
    VK_PARTITIONED_ACCELERATION_STRUCTURE_OP_TYPE_MAX_ENUM_NV = 0x7FFFFFFF,
}
