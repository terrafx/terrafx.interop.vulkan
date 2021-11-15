// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH264PictureType
    {
        std_video_h264_picture_type_i = 0,
        std_video_h264_picture_type_p = 1,
        std_video_h264_picture_type_b = 2,
        std_video_h264_picture_type_invalid = 0x7FFFFFFF,
    }
}
