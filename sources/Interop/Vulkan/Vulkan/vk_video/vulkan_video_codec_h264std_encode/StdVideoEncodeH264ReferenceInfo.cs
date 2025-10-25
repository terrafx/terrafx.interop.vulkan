// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeH264ReferenceInfo
{
    public StdVideoEncodeH264ReferenceInfoFlags flags;

    public StdVideoH264PictureType primary_pic_type;

    [NativeTypeName("uint32_t")]
    public uint FrameNum;

    [NativeTypeName("int32_t")]
    public int PicOrderCnt;

    [NativeTypeName("uint16_t")]
    public ushort long_term_pic_num;

    [NativeTypeName("uint16_t")]
    public ushort long_term_frame_idx;

    [NativeTypeName("uint8_t")]
    public byte temporal_id;
}
