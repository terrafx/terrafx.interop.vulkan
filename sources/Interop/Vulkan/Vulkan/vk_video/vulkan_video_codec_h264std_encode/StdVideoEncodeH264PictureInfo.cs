// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeH264PictureInfo
{
    public StdVideoEncodeH264PictureInfoFlags flags;

    public StdVideoH264PictureType pictureType;

    [NativeTypeName("uint32_t")]
    public uint frameNum;

    [NativeTypeName("uint32_t")]
    public uint pictureOrderCount;

    [NativeTypeName("uint16_t")]
    public ushort long_term_pic_num;

    [NativeTypeName("uint16_t")]
    public ushort long_term_frame_idx;
}
