// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkGeometryTypeNV
    {
        VK_GEOMETRY_TYPE_TRIANGLES_NV = 0,
        VK_GEOMETRY_TYPE_AABBS_NV = 1,
        VK_GEOMETRY_TYPE_BEGIN_RANGE_NV = VK_GEOMETRY_TYPE_TRIANGLES_NV,
        VK_GEOMETRY_TYPE_END_RANGE_NV = VK_GEOMETRY_TYPE_AABBS_NV,
        VK_GEOMETRY_TYPE_RANGE_SIZE_NV = (VK_GEOMETRY_TYPE_AABBS_NV - VK_GEOMETRY_TYPE_TRIANGLES_NV + 1),
        VK_GEOMETRY_TYPE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
