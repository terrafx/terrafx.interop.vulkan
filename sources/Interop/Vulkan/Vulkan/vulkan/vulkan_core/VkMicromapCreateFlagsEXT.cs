// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkMicromapCreateFlagsEXT : uint
{
    VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT = 0x00000001,
    VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT = 0x00000002,
    VK_PRESENT_SCALING_STRETCH_BIT_EXT = 0x00000004,
    VK_PRESENT_SCALING_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
}
