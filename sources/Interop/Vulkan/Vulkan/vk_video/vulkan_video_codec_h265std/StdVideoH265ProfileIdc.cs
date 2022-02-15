// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH265ProfileIdc
    {
        STD_VIDEO_H265_PROFILE_IDC_MAIN = 1,
        STD_VIDEO_H265_PROFILE_IDC_MAIN_10 = 2,
        STD_VIDEO_H265_PROFILE_IDC_MAIN_STILL_PICTURE = 3,
        STD_VIDEO_H265_PROFILE_IDC_FORMAT_RANGE_EXTENSIONS = 4,
        STD_VIDEO_H265_PROFILE_IDC_SCC_EXTENSIONS = 9,
        STD_VIDEO_H265_PROFILE_IDC_INVALID = 0x7FFFFFFF,
    }
}
