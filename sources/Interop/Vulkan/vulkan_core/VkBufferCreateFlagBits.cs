// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkBufferCreateFlagBits
    {
        VK_BUFFER_CREATE_SPARSE_BINDING_BIT = 0x00000001,
        VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = 0x00000002,
        VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = 0x00000004,
        VK_BUFFER_CREATE_PROTECTED_BIT = 0x00000008,
        VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = 0x00000010,
        VK_BUFFER_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
