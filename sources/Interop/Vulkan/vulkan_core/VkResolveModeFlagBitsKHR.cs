// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkResolveModeFlagBitsKHR
    {
        VK_RESOLVE_MODE_NONE_KHR = 0,
        VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR = 0x00000001,
        VK_RESOLVE_MODE_AVERAGE_BIT_KHR = 0x00000002,
        VK_RESOLVE_MODE_MIN_BIT_KHR = 0x00000004,
        VK_RESOLVE_MODE_MAX_BIT_KHR = 0x00000008,
        VK_RESOLVE_MODE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
