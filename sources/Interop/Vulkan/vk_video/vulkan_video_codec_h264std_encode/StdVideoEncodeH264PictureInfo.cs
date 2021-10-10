// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
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
}
