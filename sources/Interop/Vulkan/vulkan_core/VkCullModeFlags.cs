// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkCullModeFlags
    {
        VK_CULL_MODE_NONE = 0,
        VK_CULL_MODE_FRONT_BIT = 0x00000001,
        VK_CULL_MODE_BACK_BIT = 0x00000002,
        VK_CULL_MODE_FRONT_AND_BACK = 0x00000003,
        VK_CULL_MODE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
