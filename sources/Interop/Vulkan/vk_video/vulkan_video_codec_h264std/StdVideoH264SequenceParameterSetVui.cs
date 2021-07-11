// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct StdVideoH264SequenceParameterSetVui
    {
        public StdVideoH264AspectRatioIdc aspect_ratio_idc;

        [NativeTypeName("uint16_t")]
        public ushort sar_width;

        [NativeTypeName("uint16_t")]
        public ushort sar_height;

        [NativeTypeName("uint8_t")]
        public byte video_format;

        [NativeTypeName("uint8_t")]
        public byte color_primaries;

        [NativeTypeName("uint8_t")]
        public byte transfer_characteristics;

        [NativeTypeName("uint8_t")]
        public byte matrix_coefficients;

        [NativeTypeName("uint32_t")]
        public uint num_units_in_tick;

        [NativeTypeName("uint32_t")]
        public uint time_scale;

        public StdVideoH264HrdParameters hrd_parameters;

        [NativeTypeName("uint8_t")]
        public byte num_reorder_frames;

        [NativeTypeName("uint8_t")]
        public byte max_dec_frame_buffering;

        public StdVideoH264SpsVuiFlags flags;
    }
}
