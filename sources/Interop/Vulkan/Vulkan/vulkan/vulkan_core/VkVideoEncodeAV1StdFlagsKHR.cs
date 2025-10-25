// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkVideoEncodeAV1StdFlagsKHR : uint
{
    VK_VIDEO_ENCODE_AV1_STD_UNIFORM_TILE_SPACING_FLAG_SET_BIT_KHR = 0x00000001,
    VK_VIDEO_ENCODE_AV1_STD_SKIP_MODE_PRESENT_UNSET_BIT_KHR = 0x00000002,
    VK_VIDEO_ENCODE_AV1_STD_PRIMARY_REF_FRAME_BIT_KHR = 0x00000004,
    VK_VIDEO_ENCODE_AV1_STD_DELTA_Q_BIT_KHR = 0x00000008,
    VK_VIDEO_ENCODE_AV1_STD_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
