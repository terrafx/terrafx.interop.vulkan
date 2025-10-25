// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkCopyMicromapModeEXT
{
    VK_COPY_MICROMAP_MODE_CLONE_EXT = 0,
    VK_COPY_MICROMAP_MODE_SERIALIZE_EXT = 1,
    VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT = 2,
    VK_COPY_MICROMAP_MODE_COMPACT_EXT = 3,
    VK_COPY_MICROMAP_MODE_MAX_ENUM_EXT = 0x7FFFFFFF,
}
