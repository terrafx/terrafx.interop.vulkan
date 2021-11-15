// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct StdVideoH265DecPicBufMgr
    {
        [NativeTypeName("uint32_t [7]")]
        public fixed uint max_latency_increase_plus1[7];

        [NativeTypeName("uint8_t [7]")]
        public fixed byte max_dec_pic_buffering_minus1[7];

        [NativeTypeName("uint8_t [7]")]
        public fixed byte max_num_reorder_pics[7];
    }
}
