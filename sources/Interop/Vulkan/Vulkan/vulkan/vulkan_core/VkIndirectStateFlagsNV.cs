// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    [NativeTypeName("int")]
    [Flags]
    public enum VkIndirectStateFlagsNV : uint
    {
        VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV = 0x00000001,
        VK_INDIRECT_STATE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
