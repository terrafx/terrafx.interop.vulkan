// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkDependencyFlags : uint
{
    VK_DEPENDENCY_BY_REGION_BIT = 0x00000001,
    VK_DEPENDENCY_DEVICE_GROUP_BIT = 0x00000004,
    VK_DEPENDENCY_VIEW_LOCAL_BIT = 0x00000002,
    VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT = 0x00000008,
    VK_DEPENDENCY_QUEUE_FAMILY_OWNERSHIP_TRANSFER_USE_ALL_STAGES_BIT_KHR = 0x00000020,
    VK_DEPENDENCY_ASYMMETRIC_EVENT_BIT_KHR = 0x00000040,
    VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = VK_DEPENDENCY_VIEW_LOCAL_BIT,
    VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = VK_DEPENDENCY_DEVICE_GROUP_BIT,
    VK_DEPENDENCY_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
