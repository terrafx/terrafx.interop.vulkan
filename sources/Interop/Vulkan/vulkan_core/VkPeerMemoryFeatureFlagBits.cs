// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkPeerMemoryFeatureFlagBits
    {
        VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT = 0x00000001,
        VK_PEER_MEMORY_FEATURE_COPY_DST_BIT = 0x00000002,
        VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT = 0x00000004,
        VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT = 0x00000008,
        VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT_KHR = VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT,
        VK_PEER_MEMORY_FEATURE_COPY_DST_BIT_KHR = VK_PEER_MEMORY_FEATURE_COPY_DST_BIT,
        VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT_KHR = VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT,
        VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT_KHR = VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT,
        VK_PEER_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
