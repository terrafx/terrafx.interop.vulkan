// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkPartitionedAccelerationStructureInstanceFlagsNV : uint
{
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FACING_CULL_DISABLE_BIT_NV = 0x00000001,
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FLIP_FACING_BIT_NV = 0x00000002,
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_OPAQUE_BIT_NV = 0x00000004,
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_NO_OPAQUE_BIT_NV = 0x00000008,
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_ENABLE_EXPLICIT_BOUNDING_BOX_NV = 0x00000010,
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
}
