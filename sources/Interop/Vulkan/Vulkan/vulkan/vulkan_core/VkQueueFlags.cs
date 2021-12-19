// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    [NativeTypeName("int")]
    [Flags]
    public enum VkQueueFlags : uint
    {
        VK_QUEUE_GRAPHICS_BIT = 0x00000001,
        VK_QUEUE_COMPUTE_BIT = 0x00000002,
        VK_QUEUE_TRANSFER_BIT = 0x00000004,
        VK_QUEUE_SPARSE_BINDING_BIT = 0x00000008,
        VK_QUEUE_PROTECTED_BIT = 0x00000010,
        VK_QUEUE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
