// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkSubgroupFeatureFlags : uint
{
    VK_SUBGROUP_FEATURE_BASIC_BIT = 0x00000001,
    VK_SUBGROUP_FEATURE_VOTE_BIT = 0x00000002,
    VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = 0x00000004,
    VK_SUBGROUP_FEATURE_BALLOT_BIT = 0x00000008,
    VK_SUBGROUP_FEATURE_SHUFFLE_BIT = 0x00000010,
    VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = 0x00000020,
    VK_SUBGROUP_FEATURE_CLUSTERED_BIT = 0x00000040,
    VK_SUBGROUP_FEATURE_QUAD_BIT = 0x00000080,
    VK_SUBGROUP_FEATURE_ROTATE_BIT = 0x00000200,
    VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT = 0x00000400,
    VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 0x00000100,
    VK_SUBGROUP_FEATURE_ROTATE_BIT_KHR = VK_SUBGROUP_FEATURE_ROTATE_BIT,
    VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT_KHR = VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT,
    VK_SUBGROUP_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
