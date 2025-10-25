// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265ShortTermRefPicSet
{
    public StdVideoH265ShortTermRefPicSetFlags flags;

    [NativeTypeName("uint32_t")]
    public uint delta_idx_minus1;

    [NativeTypeName("uint16_t")]
    public ushort use_delta_flag;

    [NativeTypeName("uint16_t")]
    public ushort abs_delta_rps_minus1;

    [NativeTypeName("uint16_t")]
    public ushort used_by_curr_pic_flag;

    [NativeTypeName("uint16_t")]
    public ushort used_by_curr_pic_s0_flag;

    [NativeTypeName("uint16_t")]
    public ushort used_by_curr_pic_s1_flag;

    [NativeTypeName("uint16_t")]
    public ushort reserved1;

    [NativeTypeName("uint8_t")]
    public byte reserved2;

    [NativeTypeName("uint8_t")]
    public byte reserved3;

    [NativeTypeName("uint8_t")]
    public byte num_negative_pics;

    [NativeTypeName("uint8_t")]
    public byte num_positive_pics;

    [NativeTypeName("uint16_t[16]")]
    public _delta_poc_s0_minus1_e__FixedBuffer delta_poc_s0_minus1;

    [NativeTypeName("uint16_t[16]")]
    public _delta_poc_s1_minus1_e__FixedBuffer delta_poc_s1_minus1;

    [InlineArray(16)]
    public partial struct _delta_poc_s0_minus1_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(16)]
    public partial struct _delta_poc_s1_minus1_e__FixedBuffer
    {
        public ushort e0;
    }
}
