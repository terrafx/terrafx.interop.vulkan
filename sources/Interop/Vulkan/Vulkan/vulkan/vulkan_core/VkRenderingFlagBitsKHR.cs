// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkRenderingFlagBitsKHR
    {
        VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR = 0x00000001,
        VK_RENDERING_SUSPENDING_BIT_KHR = 0x00000002,
        VK_RENDERING_RESUMING_BIT_KHR = 0x00000004,
        VK_RENDERING_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
