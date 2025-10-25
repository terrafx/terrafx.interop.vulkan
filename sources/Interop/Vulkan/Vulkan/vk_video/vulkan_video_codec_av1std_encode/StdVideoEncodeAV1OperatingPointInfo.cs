// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeAV1OperatingPointInfo
{
    public StdVideoEncodeAV1OperatingPointInfoFlags flags;

    [NativeTypeName("uint16_t")]
    public ushort operating_point_idc;

    [NativeTypeName("uint8_t")]
    public byte seq_level_idx;

    [NativeTypeName("uint8_t")]
    public byte seq_tier;

    [NativeTypeName("uint32_t")]
    public uint decoder_buffer_delay;

    [NativeTypeName("uint32_t")]
    public uint encoder_buffer_delay;

    [NativeTypeName("uint8_t")]
    public byte initial_display_delay_minus_1;
}
