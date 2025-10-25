// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeH264WeightTable
{
    public StdVideoEncodeH264WeightTableFlags flags;

    [NativeTypeName("uint8_t")]
    public byte luma_log2_weight_denom;

    [NativeTypeName("uint8_t")]
    public byte chroma_log2_weight_denom;

    [NativeTypeName("int8_t[32]")]
    public _luma_weight_l0_e__FixedBuffer luma_weight_l0;

    [NativeTypeName("int8_t[32]")]
    public _luma_offset_l0_e__FixedBuffer luma_offset_l0;

    [NativeTypeName("int8_t[32][2]")]
    public _chroma_weight_l0_e__FixedBuffer chroma_weight_l0;

    [NativeTypeName("int8_t[32][2]")]
    public _chroma_offset_l0_e__FixedBuffer chroma_offset_l0;

    [NativeTypeName("int8_t[32]")]
    public _luma_weight_l1_e__FixedBuffer luma_weight_l1;

    [NativeTypeName("int8_t[32]")]
    public _luma_offset_l1_e__FixedBuffer luma_offset_l1;

    [NativeTypeName("int8_t[32][2]")]
    public _chroma_weight_l1_e__FixedBuffer chroma_weight_l1;

    [NativeTypeName("int8_t[32][2]")]
    public _chroma_offset_l1_e__FixedBuffer chroma_offset_l1;

    [InlineArray(32)]
    public partial struct _luma_weight_l0_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(32)]
    public partial struct _luma_offset_l0_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(32 * 2)]
    public partial struct _chroma_weight_l0_e__FixedBuffer
    {
        public sbyte e0_0;
    }

    [InlineArray(32 * 2)]
    public partial struct _chroma_offset_l0_e__FixedBuffer
    {
        public sbyte e0_0;
    }

    [InlineArray(32)]
    public partial struct _luma_weight_l1_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(32)]
    public partial struct _luma_offset_l1_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(32 * 2)]
    public partial struct _chroma_weight_l1_e__FixedBuffer
    {
        public sbyte e0_0;
    }

    [InlineArray(32 * 2)]
    public partial struct _chroma_offset_l1_e__FixedBuffer
    {
        public sbyte e0_0;
    }
}
