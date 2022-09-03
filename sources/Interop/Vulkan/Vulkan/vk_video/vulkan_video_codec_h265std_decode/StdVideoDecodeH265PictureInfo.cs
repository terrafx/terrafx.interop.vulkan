// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoDecodeH265PictureInfo
{
    public StdVideoDecodeH265PictureInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte sps_video_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pps_seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pps_pic_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte num_short_term_ref_pic_sets;

    [NativeTypeName("int32_t")]
    public int PicOrderCntVal;

    [NativeTypeName("uint16_t")]
    public ushort NumBitsForSTRefPicSetInSlice;

    [NativeTypeName("uint8_t")]
    public byte NumDeltaPocsOfRefRpsIdx;

    [NativeTypeName("uint8_t[8]")]
    public fixed byte RefPicSetStCurrBefore[8];

    [NativeTypeName("uint8_t[8]")]
    public fixed byte RefPicSetStCurrAfter[8];

    [NativeTypeName("uint8_t[8]")]
    public fixed byte RefPicSetLtCurr[8];
}
