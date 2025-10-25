// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoDecodeH264PictureInfo
{
    public StdVideoDecodeH264PictureInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pic_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    [NativeTypeName("uint8_t")]
    public byte reserved2;

    [NativeTypeName("uint16_t")]
    public ushort frame_num;

    [NativeTypeName("uint16_t")]
    public ushort idr_pic_id;

    [NativeTypeName("int32_t[2]")]
    public _PicOrderCnt_e__FixedBuffer PicOrderCnt;

    [InlineArray(2)]
    public partial struct _PicOrderCnt_e__FixedBuffer
    {
        public int e0;
    }
}
