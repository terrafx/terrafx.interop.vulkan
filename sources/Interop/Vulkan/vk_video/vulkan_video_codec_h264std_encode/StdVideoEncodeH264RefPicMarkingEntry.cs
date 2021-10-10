// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct StdVideoEncodeH264RefPicMarkingEntry
    {
        public StdVideoH264MemMgmtControlOp operation;

        [NativeTypeName("uint16_t")]
        public ushort difference_of_pic_nums_minus1;

        [NativeTypeName("uint16_t")]
        public ushort long_term_pic_num;

        [NativeTypeName("uint16_t")]
        public ushort long_term_frame_idx;

        [NativeTypeName("uint16_t")]
        public ushort max_long_term_frame_idx_plus1;
    }
}
