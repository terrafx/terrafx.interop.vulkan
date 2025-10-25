// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_vp9std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum StdVideoVP9FrameType
{
    STD_VIDEO_VP9_FRAME_TYPE_KEY = 0,
    STD_VIDEO_VP9_FRAME_TYPE_NON_KEY = 1,
    STD_VIDEO_VP9_FRAME_TYPE_INVALID = 0x7FFFFFFF,
    STD_VIDEO_VP9_FRAME_TYPE_MAX_ENUM = 0x7FFFFFFF,
}
