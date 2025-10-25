// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoAV1ColorConfig
{
    public StdVideoAV1ColorConfigFlags flags;

    [NativeTypeName("uint8_t")]
    public byte BitDepth;

    [NativeTypeName("uint8_t")]
    public byte subsampling_x;

    [NativeTypeName("uint8_t")]
    public byte subsampling_y;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    public StdVideoAV1ColorPrimaries color_primaries;

    public StdVideoAV1TransferCharacteristics transfer_characteristics;

    public StdVideoAV1MatrixCoefficients matrix_coefficients;

    public StdVideoAV1ChromaSamplePosition chroma_sample_position;
}
