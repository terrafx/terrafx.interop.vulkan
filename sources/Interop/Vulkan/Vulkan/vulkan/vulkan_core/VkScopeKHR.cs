// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkScopeKHR
{
    VK_SCOPE_DEVICE_KHR = 1,
    VK_SCOPE_WORKGROUP_KHR = 2,
    VK_SCOPE_SUBGROUP_KHR = 3,
    VK_SCOPE_QUEUE_FAMILY_KHR = 5,
    VK_SCOPE_DEVICE_NV = VK_SCOPE_DEVICE_KHR,
    VK_SCOPE_WORKGROUP_NV = VK_SCOPE_WORKGROUP_KHR,
    VK_SCOPE_SUBGROUP_NV = VK_SCOPE_SUBGROUP_KHR,
    VK_SCOPE_QUEUE_FAMILY_NV = VK_SCOPE_QUEUE_FAMILY_KHR,
    VK_SCOPE_MAX_ENUM_KHR = 0x7FFFFFFF,
}
