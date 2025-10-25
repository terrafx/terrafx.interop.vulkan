// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoDecodeH265PictureInfo
{
    public StdVideoDecodeH265PictureInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte sps_video_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pps_seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pps_pic_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte NumDeltaPocsOfRefRpsIdx;

    [NativeTypeName("int32_t")]
    public int PicOrderCntVal;

    [NativeTypeName("uint16_t")]
    public ushort NumBitsForSTRefPicSetInSlice;

    [NativeTypeName("uint16_t")]
    public ushort reserved;

    [NativeTypeName("uint8_t[8]")]
    public _RefPicSetStCurrBefore_e__FixedBuffer RefPicSetStCurrBefore;

    [NativeTypeName("uint8_t[8]")]
    public _RefPicSetStCurrAfter_e__FixedBuffer RefPicSetStCurrAfter;

    [NativeTypeName("uint8_t[8]")]
    public _RefPicSetLtCurr_e__FixedBuffer RefPicSetLtCurr;

    [InlineArray(8)]
    public partial struct _RefPicSetStCurrBefore_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _RefPicSetStCurrAfter_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _RefPicSetLtCurr_e__FixedBuffer
    {
        public byte e0;
    }
}
