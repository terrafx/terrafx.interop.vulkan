// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkDescriptorBindingFlagBitsEXT
    {
        VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT = 0x00000001,
        VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT_EXT = 0x00000002,
        VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT = 0x00000004,
        VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT_EXT = 0x00000008,
        VK_DESCRIPTOR_BINDING_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
