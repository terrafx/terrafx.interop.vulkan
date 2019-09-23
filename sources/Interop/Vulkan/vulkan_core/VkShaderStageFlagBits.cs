// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkShaderStageFlagBits
    {
        VK_SHADER_STAGE_VERTEX_BIT = 0x00000001,
        VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT = 0x00000002,
        VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT = 0x00000004,
        VK_SHADER_STAGE_GEOMETRY_BIT = 0x00000008,
        VK_SHADER_STAGE_FRAGMENT_BIT = 0x00000010,
        VK_SHADER_STAGE_COMPUTE_BIT = 0x00000020,
        VK_SHADER_STAGE_ALL_GRAPHICS = 0x0000001F,
        VK_SHADER_STAGE_ALL = 0x7FFFFFFF,
        VK_SHADER_STAGE_RAYGEN_BIT_NV = 0x00000100,
        VK_SHADER_STAGE_ANY_HIT_BIT_NV = 0x00000200,
        VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV = 0x00000400,
        VK_SHADER_STAGE_MISS_BIT_NV = 0x00000800,
        VK_SHADER_STAGE_INTERSECTION_BIT_NV = 0x00001000,
        VK_SHADER_STAGE_CALLABLE_BIT_NV = 0x00002000,
        VK_SHADER_STAGE_TASK_BIT_NV = 0x00000040,
        VK_SHADER_STAGE_MESH_BIT_NV = 0x00000080,
        VK_SHADER_STAGE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
