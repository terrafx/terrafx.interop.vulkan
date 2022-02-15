// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH264ChromaFormatIdc
    {
        STD_VIDEO_H264_CHROMA_FORMAT_IDC_MONOCHROME = 0,
        STD_VIDEO_H264_CHROMA_FORMAT_IDC_420 = 1,
        STD_VIDEO_H264_CHROMA_FORMAT_IDC_422 = 2,
        STD_VIDEO_H264_CHROMA_FORMAT_IDC_444 = 3,
        STD_VIDEO_H264_CHROMA_FORMAT_IDC_INVALID = 0x7FFFFFFF,
        STD_VIDEO_H264_CHROMA_FORMAT_IDC_MAX_ENUM = 0x7FFFFFFF,
    }
}
