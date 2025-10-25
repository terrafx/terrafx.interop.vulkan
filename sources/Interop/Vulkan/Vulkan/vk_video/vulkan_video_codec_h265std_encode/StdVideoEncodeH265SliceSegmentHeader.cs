// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH265SliceSegmentHeader
{
    public StdVideoEncodeH265SliceSegmentHeaderFlags flags;

    public StdVideoH265SliceType slice_type;

    [NativeTypeName("uint32_t")]
    public uint slice_segment_address;

    [NativeTypeName("uint8_t")]
    public byte collocated_ref_idx;

    [NativeTypeName("uint8_t")]
    public byte MaxNumMergeCand;

    [NativeTypeName("int8_t")]
    public sbyte slice_cb_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_cr_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_beta_offset_div2;

    [NativeTypeName("int8_t")]
    public sbyte slice_tc_offset_div2;

    [NativeTypeName("int8_t")]
    public sbyte slice_act_y_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_act_cb_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_act_cr_qp_offset;

    [NativeTypeName("int8_t")]
    public sbyte slice_qp_delta;

    [NativeTypeName("uint16_t")]
    public ushort reserved1;

    [NativeTypeName("const StdVideoEncodeH265WeightTable *")]
    public StdVideoEncodeH265WeightTable* pWeightTable;
}
