// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkRayTracingShaderGroupTypeKHR
    {
        VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR = 0,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR = 1,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR = 2,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR,
        VK_RAY_TRACING_SHADER_GROUP_TYPE_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
