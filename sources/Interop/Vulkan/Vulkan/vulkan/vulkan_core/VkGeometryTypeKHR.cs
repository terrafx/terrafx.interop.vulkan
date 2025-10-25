// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkGeometryTypeKHR
{
    VK_GEOMETRY_TYPE_TRIANGLES_KHR = 0,
    VK_GEOMETRY_TYPE_AABBS_KHR = 1,
    VK_GEOMETRY_TYPE_INSTANCES_KHR = 2,
    VK_GEOMETRY_TYPE_SPHERES_NV = 1000429004,
    VK_GEOMETRY_TYPE_LINEAR_SWEPT_SPHERES_NV = 1000429005,
    VK_GEOMETRY_TYPE_DENSE_GEOMETRY_FORMAT_TRIANGLES_AMDX = 1000478000,
    VK_GEOMETRY_TYPE_TRIANGLES_NV = VK_GEOMETRY_TYPE_TRIANGLES_KHR,
    VK_GEOMETRY_TYPE_AABBS_NV = VK_GEOMETRY_TYPE_AABBS_KHR,
    VK_GEOMETRY_TYPE_MAX_ENUM_KHR = 0x7FFFFFFF,
}
