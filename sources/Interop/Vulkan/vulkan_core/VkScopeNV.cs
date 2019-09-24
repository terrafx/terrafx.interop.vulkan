// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkScopeNV
    {
        VK_SCOPE_DEVICE_NV = 1,
        VK_SCOPE_WORKGROUP_NV = 2,
        VK_SCOPE_SUBGROUP_NV = 3,
        VK_SCOPE_QUEUE_FAMILY_NV = 5,
        VK_SCOPE_BEGIN_RANGE_NV = VK_SCOPE_DEVICE_NV,
        VK_SCOPE_END_RANGE_NV = VK_SCOPE_QUEUE_FAMILY_NV,
        VK_SCOPE_RANGE_SIZE_NV = (VK_SCOPE_QUEUE_FAMILY_NV - VK_SCOPE_DEVICE_NV + 1),
        VK_SCOPE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
