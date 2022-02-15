// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH265PictureType
    {
        STD_VIDEO_H265_PICTURE_TYPE_P = 0,
        STD_VIDEO_H265_PICTURE_TYPE_B = 1,
        STD_VIDEO_H265_PICTURE_TYPE_I = 2,
        STD_VIDEO_H265_PICTURE_TYPE_IDR = 3,
        STD_VIDEO_H265_PICTURE_TYPE_INVALID = 0x7FFFFFFF,
    }
}
