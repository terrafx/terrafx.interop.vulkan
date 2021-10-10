// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum StdVideoH264ModificationOfPicNumsIdc
    {
        std_video_h264_modification_of_pic_nums_idc_short_term_subtract = 0,
        std_video_h264_modification_of_pic_nums_idc_short_term_add = 1,
        std_video_h264_modification_of_pic_nums_idc_long_term = 2,
        std_video_h264_modification_of_pic_nums_idc_end = 3,
        std_video_h264_modification_of_pic_nums_idc_invalid = 0x7FFFFFFF,
    }
}
