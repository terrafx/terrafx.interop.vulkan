// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct StdVideoEncodeH265PictureInfo
    {
        public StdVideoH265PictureType PictureType;

        [NativeTypeName("uint8_t")]
        public byte sps_video_parameter_set_id;

        [NativeTypeName("uint8_t")]
        public byte pps_seq_parameter_set_id;

        [NativeTypeName("int32_t")]
        public int PicOrderCntVal;

        [NativeTypeName("uint8_t")]
        public byte TemporalId;

        public StdVideoEncodeH265PictureInfoFlags flags;
    }
}