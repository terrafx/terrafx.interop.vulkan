// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH264NonVclNaluType
    {
        std_video_h264_non_vcl_nalu_type_sps = 0,
        std_video_h264_non_vcl_nalu_type_pps = 1,
        std_video_h264_non_vcl_nalu_type_aud = 2,
        std_video_h264_non_vcl_nalu_type_prefix = 3,
        std_video_h264_non_vcl_nalu_type_end_of_sequence = 4,
        std_video_h264_non_vcl_nalu_type_end_of_stream = 5,
        std_video_h264_non_vcl_nalu_type_precoded = 6,
        std_video_h264_non_vcl_nalu_type_invalid = 0x7FFFFFFF,
    }
}
