// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkVideoDecodeUsageFlagsKHR : uint
{
    VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT = 0x00000001,
    VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT = 0x00000002,
    VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT = 0x00000004,
    VK_BUILD_MICROMAP_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
}
