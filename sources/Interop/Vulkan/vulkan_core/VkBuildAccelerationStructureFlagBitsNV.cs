// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkBuildAccelerationStructureFlagBitsNV
    {
        VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_NV = 0x00000001,
        VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_NV = 0x00000002,
        VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_NV = 0x00000004,
        VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_NV = 0x00000008,
        VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_NV = 0x00000010,
        VK_BUILD_ACCELERATION_STRUCTURE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
