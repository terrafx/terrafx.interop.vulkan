// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkVideoEncodeH264OutputModeFlagsEXT : uint
{
    VK_VIDEO_ENCODE_H264_OUTPUT_MODE_FRAME_BIT_EXT = 0x00000001,
    VK_VIDEO_ENCODE_H264_OUTPUT_MODE_SLICE_BIT_EXT = 0x00000002,
    VK_VIDEO_ENCODE_H264_OUTPUT_MODE_NON_VCL_BIT_EXT = 0x00000004,
    VK_VIDEO_ENCODE_H264_OUTPUT_MODE_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
}
