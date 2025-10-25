// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum StdVideoH264ModificationOfPicNumsIdc
{
    STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_SUBTRACT = 0,
    STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_ADD = 1,
    STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_LONG_TERM = 2,
    STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_END = 3,
    STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_INVALID = 0x7FFFFFFF,
    STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_MAX_ENUM = 0x7FFFFFFF,
}
