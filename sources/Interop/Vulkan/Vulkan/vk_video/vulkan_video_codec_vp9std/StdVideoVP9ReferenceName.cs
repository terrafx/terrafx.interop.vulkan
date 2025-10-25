// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_vp9std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum StdVideoVP9ReferenceName
{
    STD_VIDEO_VP9_REFERENCE_NAME_INTRA_FRAME = 0,
    STD_VIDEO_VP9_REFERENCE_NAME_LAST_FRAME = 1,
    STD_VIDEO_VP9_REFERENCE_NAME_GOLDEN_FRAME = 2,
    STD_VIDEO_VP9_REFERENCE_NAME_ALTREF_FRAME = 3,
    STD_VIDEO_VP9_REFERENCE_NAME_INVALID = 0x7FFFFFFF,
    STD_VIDEO_VP9_REFERENCE_NAME_MAX_ENUM = 0x7FFFFFFF,
}
