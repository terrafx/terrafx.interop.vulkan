// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH265SliceSegmentLongTermRefPics
{
    [NativeTypeName("uint8_t")]
    public byte num_long_term_sps;

    [NativeTypeName("uint8_t")]
    public byte num_long_term_pics;

    [NativeTypeName("uint8_t[32]")]
    public fixed byte lt_idx_sps[32];

    [NativeTypeName("uint8_t[16]")]
    public fixed byte poc_lsb_lt[16];

    [NativeTypeName("uint16_t")]
    public ushort used_by_curr_pic_lt_flag;

    [NativeTypeName("uint8_t[48]")]
    public fixed byte delta_poc_msb_present_flag[48];

    [NativeTypeName("uint8_t[48]")]
    public fixed byte delta_poc_msb_cycle_lt[48];
}
