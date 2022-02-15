// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan
{
    [NativeTypeName("int")]
    [Flags]
    public enum VkDependencyFlags : uint
    {
        VK_DEPENDENCY_BY_REGION_BIT = 0x00000001,
        VK_DEPENDENCY_DEVICE_GROUP_BIT = 0x00000004,
        VK_DEPENDENCY_VIEW_LOCAL_BIT = 0x00000002,
        VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = VK_DEPENDENCY_VIEW_LOCAL_BIT,
        VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = VK_DEPENDENCY_DEVICE_GROUP_BIT,
        VK_DEPENDENCY_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
