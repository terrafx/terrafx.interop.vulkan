// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkSparseMemoryBindFlags : uint
    {
        VK_SPARSE_MEMORY_BIND_METADATA_BIT = 0x00000001,
        VK_SPARSE_MEMORY_BIND_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
