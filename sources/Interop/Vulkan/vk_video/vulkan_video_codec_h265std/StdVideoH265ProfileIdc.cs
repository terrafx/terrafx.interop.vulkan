// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum StdVideoH265ProfileIdc
    {
        std_video_h265_profile_idc_main = 1,
        std_video_h265_profile_idc_main_10 = 2,
        std_video_h265_profile_idc_main_still_picture = 3,
        std_video_h265_profile_idc_format_range_extensions = 4,
        std_video_h265_profile_idc_scc_extensions = 9,
        std_video_h265_profile_idc_invalid = 0x7FFFFFFF,
    }
}
