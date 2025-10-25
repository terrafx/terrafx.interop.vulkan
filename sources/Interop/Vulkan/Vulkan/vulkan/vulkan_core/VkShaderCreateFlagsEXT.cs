// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkShaderCreateFlagsEXT : uint
{
    VK_SHADER_CREATE_LINK_STAGE_BIT_EXT = 0x00000001,
    VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = 0x00000002,
    VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT = 0x00000004,
    VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT = 0x00000008,
    VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT = 0x00000010,
    VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT = 0x00000020,
    VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = 0x00000040,
    VK_SHADER_CREATE_INDIRECT_BINDABLE_BIT_EXT = 0x00000080,
    VK_SHADER_CREATE_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
}
