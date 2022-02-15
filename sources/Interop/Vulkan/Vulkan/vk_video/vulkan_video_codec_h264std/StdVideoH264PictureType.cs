// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH264PictureType
    {
        STD_VIDEO_H264_PICTURE_TYPE_P = 0,
        STD_VIDEO_H264_PICTURE_TYPE_B = 1,
        STD_VIDEO_H264_PICTURE_TYPE_I = 2,
        STD_VIDEO_H264_PICTURE_TYPE_IDR = 5,
        STD_VIDEO_H264_PICTURE_TYPE_INVALID = 0x7FFFFFFF,
        STD_VIDEO_H264_PICTURE_TYPE_MAX_ENUM = 0x7FFFFFFF,
    }
}
