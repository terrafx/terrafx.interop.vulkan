// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeAV1DecoderModelInfo
{
    [NativeTypeName("uint8_t")]
    public byte buffer_delay_length_minus_1;

    [NativeTypeName("uint8_t")]
    public byte buffer_removal_time_length_minus_1;

    [NativeTypeName("uint8_t")]
    public byte frame_presentation_time_length_minus_1;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    [NativeTypeName("uint32_t")]
    public uint num_units_in_decoding_tick;
}
