// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoAV1Quantization
{
    public StdVideoAV1QuantizationFlags flags;

    [NativeTypeName("uint8_t")]
    public byte base_q_idx;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQYDc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQUDc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQUAc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQVDc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQVAc;

    [NativeTypeName("uint8_t")]
    public byte qm_y;

    [NativeTypeName("uint8_t")]
    public byte qm_u;

    [NativeTypeName("uint8_t")]
    public byte qm_v;
}
