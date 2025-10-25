// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH265PictureInfo
{
    public StdVideoEncodeH265PictureInfoFlags flags;

    public StdVideoH265PictureType pic_type;

    [NativeTypeName("uint8_t")]
    public byte sps_video_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pps_seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pps_pic_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte short_term_ref_pic_set_idx;

    [NativeTypeName("int32_t")]
    public int PicOrderCntVal;

    [NativeTypeName("uint8_t")]
    public byte TemporalId;

    [NativeTypeName("uint8_t[7]")]
    public _reserved1_e__FixedBuffer reserved1;

    [NativeTypeName("const StdVideoEncodeH265ReferenceListsInfo *")]
    public StdVideoEncodeH265ReferenceListsInfo* pRefLists;

    [NativeTypeName("const StdVideoH265ShortTermRefPicSet *")]
    public StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;

    [NativeTypeName("const StdVideoEncodeH265LongTermRefPics *")]
    public StdVideoEncodeH265LongTermRefPics* pLongTermRefPics;

    [InlineArray(7)]
    public partial struct _reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
