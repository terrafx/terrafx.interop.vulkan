// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum StdVideoH265ProfileIdc
{
    STD_VIDEO_H265_PROFILE_IDC_MAIN = 1,
    STD_VIDEO_H265_PROFILE_IDC_MAIN_10 = 2,
    STD_VIDEO_H265_PROFILE_IDC_MAIN_STILL_PICTURE = 3,
    STD_VIDEO_H265_PROFILE_IDC_FORMAT_RANGE_EXTENSIONS = 4,
    STD_VIDEO_H265_PROFILE_IDC_SCC_EXTENSIONS = 9,
    STD_VIDEO_H265_PROFILE_IDC_INVALID = 0x7FFFFFFF,
    STD_VIDEO_H265_PROFILE_IDC_MAX_ENUM = 0x7FFFFFFF,
}
