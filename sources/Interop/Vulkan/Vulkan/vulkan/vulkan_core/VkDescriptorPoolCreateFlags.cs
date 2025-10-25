// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkDescriptorPoolCreateFlags : uint
{
    VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = 0x00000001,
    VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT = 0x00000002,
    VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT = 0x00000004,
    VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NV = 0x00000008,
    VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NV = 0x00000010,
    VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT = VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT,
    VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE = VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT,
    VK_DESCRIPTOR_POOL_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
