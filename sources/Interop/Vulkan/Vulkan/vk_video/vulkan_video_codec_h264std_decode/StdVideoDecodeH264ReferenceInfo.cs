// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2019-2020 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct StdVideoDecodeH264ReferenceInfo
    {
        [NativeTypeName("uint16_t")]
        public ushort FrameNum;

        [NativeTypeName("uint16_t")]
        public ushort reserved;

        [NativeTypeName("int32_t [2]")]
        public fixed int PicOrderCnt[2];

        public StdVideoDecodeH264ReferenceInfoFlags flags;
    }
}
