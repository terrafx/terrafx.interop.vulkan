// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkResolveModeFlags
    {
        VK_RESOLVE_MODE_NONE = 0,
        VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = 0x00000001,
        VK_RESOLVE_MODE_AVERAGE_BIT = 0x00000002,
        VK_RESOLVE_MODE_MIN_BIT = 0x00000004,
        VK_RESOLVE_MODE_MAX_BIT = 0x00000008,
        VK_RESOLVE_MODE_NONE_KHR = VK_RESOLVE_MODE_NONE,
        VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR = VK_RESOLVE_MODE_SAMPLE_ZERO_BIT,
        VK_RESOLVE_MODE_AVERAGE_BIT_KHR = VK_RESOLVE_MODE_AVERAGE_BIT,
        VK_RESOLVE_MODE_MIN_BIT_KHR = VK_RESOLVE_MODE_MIN_BIT,
        VK_RESOLVE_MODE_MAX_BIT_KHR = VK_RESOLVE_MODE_MAX_BIT,
        VK_RESOLVE_MODE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
