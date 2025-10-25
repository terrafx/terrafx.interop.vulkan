// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeH265LongTermRefPics
{
    [NativeTypeName("uint8_t")]
    public byte num_long_term_sps;

    [NativeTypeName("uint8_t")]
    public byte num_long_term_pics;

    [NativeTypeName("uint8_t[32]")]
    public _lt_idx_sps_e__FixedBuffer lt_idx_sps;

    [NativeTypeName("uint8_t[16]")]
    public _poc_lsb_lt_e__FixedBuffer poc_lsb_lt;

    [NativeTypeName("uint16_t")]
    public ushort used_by_curr_pic_lt_flag;

    [NativeTypeName("uint8_t[48]")]
    public _delta_poc_msb_present_flag_e__FixedBuffer delta_poc_msb_present_flag;

    [NativeTypeName("uint8_t[48]")]
    public _delta_poc_msb_cycle_lt_e__FixedBuffer delta_poc_msb_cycle_lt;

    [InlineArray(32)]
    public partial struct _lt_idx_sps_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _poc_lsb_lt_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(48)]
    public partial struct _delta_poc_msb_present_flag_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(48)]
    public partial struct _delta_poc_msb_cycle_lt_e__FixedBuffer
    {
        public byte e0;
    }
}
