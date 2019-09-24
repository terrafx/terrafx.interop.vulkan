// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkCommandBufferResetFlagBits
    {
        VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT = 0x00000001,
        VK_COMMAND_BUFFER_RESET_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
