// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeH264WeightTableFlags
{
    [NativeTypeName("uint32_t")]
    public uint luma_weight_l0_flag;

    [NativeTypeName("uint32_t")]
    public uint chroma_weight_l0_flag;

    [NativeTypeName("uint32_t")]
    public uint luma_weight_l1_flag;

    [NativeTypeName("uint32_t")]
    public uint chroma_weight_l1_flag;
}
