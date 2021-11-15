// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkCompositeAlphaFlagsKHR : uint
    {
        VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR = 0x00000001,
        VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR = 0x00000002,
        VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR = 0x00000004,
        VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR = 0x00000008,
        VK_COMPOSITE_ALPHA_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
