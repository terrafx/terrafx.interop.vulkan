// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoDecodeH264PictureInfo
{
    public StdVideoDecodeH264PictureInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte seq_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte pic_parameter_set_id;

    [NativeTypeName("uint16_t")]
    public ushort reserved;

    [NativeTypeName("uint16_t")]
    public ushort frame_num;

    [NativeTypeName("uint16_t")]
    public ushort idr_pic_id;

    [NativeTypeName("int32_t[2]")]
    public fixed int PicOrderCnt[2];
}
