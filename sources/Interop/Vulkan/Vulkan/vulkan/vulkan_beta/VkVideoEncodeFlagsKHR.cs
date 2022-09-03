// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkVideoEncodeFlagsKHR : uint
{
    VK_VIDEO_ENCODE_DEFAULT_KHR = 0,
    VK_VIDEO_ENCODE_RESERVED_0_BIT_KHR = 0x00000001,
    VK_VIDEO_ENCODE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
