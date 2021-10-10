// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkFenceCreateFlags : uint
    {
        VK_FENCE_CREATE_SIGNALED_BIT = 0x00000001,
        VK_FENCE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
