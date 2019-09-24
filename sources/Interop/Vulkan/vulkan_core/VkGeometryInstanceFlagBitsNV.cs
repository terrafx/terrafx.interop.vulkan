// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkGeometryInstanceFlagBitsNV
    {
        VK_GEOMETRY_INSTANCE_TRIANGLE_CULL_DISABLE_BIT_NV = 0x00000001,
        VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV = 0x00000002,
        VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_NV = 0x00000004,
        VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_NV = 0x00000008,
        VK_GEOMETRY_INSTANCE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
