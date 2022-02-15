// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct StdVideoH264HrdParameters
    {
        [NativeTypeName("uint8_t")]
        public byte cpb_cnt_minus1;

        [NativeTypeName("uint8_t")]
        public byte bit_rate_scale;

        [NativeTypeName("uint8_t")]
        public byte cpb_size_scale;

        [NativeTypeName("uint32_t [32]")]
        public fixed uint bit_rate_value_minus1[32];

        [NativeTypeName("uint32_t [32]")]
        public fixed uint cpb_size_value_minus1[32];

        [NativeTypeName("uint8_t [32]")]
        public fixed byte cbr_flag[32];

        [NativeTypeName("uint32_t")]
        public uint initial_cpb_removal_delay_length_minus1;

        [NativeTypeName("uint32_t")]
        public uint cpb_removal_delay_length_minus1;

        [NativeTypeName("uint32_t")]
        public uint dpb_output_delay_length_minus1;

        [NativeTypeName("uint32_t")]
        public uint time_offset_length;
    }
}
