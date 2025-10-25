// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH264PictureInfo
{
    public StdVideoEncodeH264PictureInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pic_parameter_set_id;

    [NativeTypeName("uint16_t")]
    public ushort idr_pic_id;

    public StdVideoH264PictureType primary_pic_type;

    [NativeTypeName("uint32_t")]
    public uint frame_num;

    [NativeTypeName("int32_t")]
    public int PicOrderCnt;

    [NativeTypeName("uint8_t")]
    public byte temporal_id;

    [NativeTypeName("uint8_t[3]")]
    public _reserved1_e__FixedBuffer reserved1;

    [NativeTypeName("const StdVideoEncodeH264ReferenceListsInfo *")]
    public StdVideoEncodeH264ReferenceListsInfo* pRefLists;

    [InlineArray(3)]
    public partial struct _reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
