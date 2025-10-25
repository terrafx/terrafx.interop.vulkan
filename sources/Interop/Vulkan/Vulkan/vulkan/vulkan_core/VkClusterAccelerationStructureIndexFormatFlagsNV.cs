// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkClusterAccelerationStructureIndexFormatFlagsNV : uint
{
    VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_8BIT_NV = 0x00000001,
    VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_16BIT_NV = 0x00000002,
    VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_32BIT_NV = 0x00000004,
    VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
}
