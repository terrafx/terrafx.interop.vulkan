// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoAV1SequenceHeader
{
    public StdVideoAV1SequenceHeaderFlags flags;

    public StdVideoAV1Profile seq_profile;

    [NativeTypeName("uint8_t")]
    public byte frame_width_bits_minus_1;

    [NativeTypeName("uint8_t")]
    public byte frame_height_bits_minus_1;

    [NativeTypeName("uint16_t")]
    public ushort max_frame_width_minus_1;

    [NativeTypeName("uint16_t")]
    public ushort max_frame_height_minus_1;

    [NativeTypeName("uint8_t")]
    public byte delta_frame_id_length_minus_2;

    [NativeTypeName("uint8_t")]
    public byte additional_frame_id_length_minus_1;

    [NativeTypeName("uint8_t")]
    public byte order_hint_bits_minus_1;

    [NativeTypeName("uint8_t")]
    public byte seq_force_integer_mv;

    [NativeTypeName("uint8_t")]
    public byte seq_force_screen_content_tools;

    [NativeTypeName("uint8_t[5]")]
    public _reserved1_e__FixedBuffer reserved1;

    [NativeTypeName("const StdVideoAV1ColorConfig *")]
    public StdVideoAV1ColorConfig* pColorConfig;

    [NativeTypeName("const StdVideoAV1TimingInfo *")]
    public StdVideoAV1TimingInfo* pTimingInfo;

    [InlineArray(5)]
    public partial struct _reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
