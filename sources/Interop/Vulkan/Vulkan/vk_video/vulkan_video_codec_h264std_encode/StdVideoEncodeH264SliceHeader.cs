// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH264SliceHeader
{
    public StdVideoEncodeH264SliceHeaderFlags flags;

    [NativeTypeName("uint32_t")]
    public uint first_mb_in_slice;

    public StdVideoH264SliceType slice_type;

    [NativeTypeName("int8_t")]
    public sbyte slice_alpha_c0_offset_div2;

    [NativeTypeName("int8_t")]
    public sbyte slice_beta_offset_div2;

    [NativeTypeName("int8_t")]
    public sbyte slice_qp_delta;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    public StdVideoH264CabacInitIdc cabac_init_idc;

    public StdVideoH264DisableDeblockingFilterIdc disable_deblocking_filter_idc;

    [NativeTypeName("const StdVideoEncodeH264WeightTable *")]
    public StdVideoEncodeH264WeightTable* pWeightTable;
}
