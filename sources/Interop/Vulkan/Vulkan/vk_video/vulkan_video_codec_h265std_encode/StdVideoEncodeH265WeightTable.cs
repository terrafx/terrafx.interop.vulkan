// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeH265WeightTable
{
    public StdVideoEncodeH265WeightTableFlags flags;

    [NativeTypeName("uint8_t")]
    public byte luma_log2_weight_denom;

    [NativeTypeName("int8_t")]
    public sbyte delta_chroma_log2_weight_denom;

    [NativeTypeName("int8_t[15]")]
    public _delta_luma_weight_l0_e__FixedBuffer delta_luma_weight_l0;

    [NativeTypeName("int8_t[15]")]
    public _luma_offset_l0_e__FixedBuffer luma_offset_l0;

    [NativeTypeName("int8_t[15][2]")]
    public _delta_chroma_weight_l0_e__FixedBuffer delta_chroma_weight_l0;

    [NativeTypeName("int8_t[15][2]")]
    public _delta_chroma_offset_l0_e__FixedBuffer delta_chroma_offset_l0;

    [NativeTypeName("int8_t[15]")]
    public _delta_luma_weight_l1_e__FixedBuffer delta_luma_weight_l1;

    [NativeTypeName("int8_t[15]")]
    public _luma_offset_l1_e__FixedBuffer luma_offset_l1;

    [NativeTypeName("int8_t[15][2]")]
    public _delta_chroma_weight_l1_e__FixedBuffer delta_chroma_weight_l1;

    [NativeTypeName("int8_t[15][2]")]
    public _delta_chroma_offset_l1_e__FixedBuffer delta_chroma_offset_l1;

    [InlineArray(15)]
    public partial struct _delta_luma_weight_l0_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(15)]
    public partial struct _luma_offset_l0_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(15 * 2)]
    public partial struct _delta_chroma_weight_l0_e__FixedBuffer
    {
        public sbyte e0_0;
    }

    [InlineArray(15 * 2)]
    public partial struct _delta_chroma_offset_l0_e__FixedBuffer
    {
        public sbyte e0_0;
    }

    [InlineArray(15)]
    public partial struct _delta_luma_weight_l1_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(15)]
    public partial struct _luma_offset_l1_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(15 * 2)]
    public partial struct _delta_chroma_weight_l1_e__FixedBuffer
    {
        public sbyte e0_0;
    }

    [InlineArray(15 * 2)]
    public partial struct _delta_chroma_offset_l1_e__FixedBuffer
    {
        public sbyte e0_0;
    }
}
