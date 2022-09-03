// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265SubLayerHrdParameters
{
    [NativeTypeName("uint32_t[32]")]
    public fixed uint bit_rate_value_minus1[32];

    [NativeTypeName("uint32_t[32]")]
    public fixed uint cpb_size_value_minus1[32];

    [NativeTypeName("uint32_t[32]")]
    public fixed uint cpb_size_du_value_minus1[32];

    [NativeTypeName("uint32_t[32]")]
    public fixed uint bit_rate_du_value_minus1[32];

    [NativeTypeName("uint32_t")]
    public uint cbr_flag;
}
