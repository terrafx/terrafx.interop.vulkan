// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkRayTracingShaderGroupTypeNV
    {
        VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV = 0,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV = 1,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV = 2,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_BEGIN_RANGE_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_END_RANGE_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_RANGE_SIZE_NV = (VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV - VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV + 1),
        VK_RAY_TRACING_SHADER_GROUP_TYPE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
