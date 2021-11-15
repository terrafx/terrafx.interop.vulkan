// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH264WeightedBiPredIdc
    {
        std_video_h264_default_weighted_b_slices_prediction_idc = 0,
        std_video_h264_explicit_weighted_b_slices_prediction_idc = 1,
        std_video_h264_implicit_weighted_b_slices_prediction_idc = 2,
        std_video_h264_invalid_weighted_b_slices_prediction_idc = 0x7FFFFFFF,
    }
}
