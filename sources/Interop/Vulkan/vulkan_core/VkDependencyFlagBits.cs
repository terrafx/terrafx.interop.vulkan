// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkDependencyFlagBits
    {
        VK_DEPENDENCY_BY_REGION_BIT = 0x00000001,
        VK_DEPENDENCY_DEVICE_GROUP_BIT = 0x00000004,
        VK_DEPENDENCY_VIEW_LOCAL_BIT = 0x00000002,
        VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = VK_DEPENDENCY_VIEW_LOCAL_BIT,
        VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = VK_DEPENDENCY_DEVICE_GROUP_BIT,
        VK_DEPENDENCY_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
