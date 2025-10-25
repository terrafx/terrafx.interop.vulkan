// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoAV1FilmGrain
{
    public StdVideoAV1FilmGrainFlags flags;

    [NativeTypeName("uint8_t")]
    public byte grain_scaling_minus_8;

    [NativeTypeName("uint8_t")]
    public byte ar_coeff_lag;

    [NativeTypeName("uint8_t")]
    public byte ar_coeff_shift_minus_6;

    [NativeTypeName("uint8_t")]
    public byte grain_scale_shift;

    [NativeTypeName("uint16_t")]
    public ushort grain_seed;

    [NativeTypeName("uint8_t")]
    public byte film_grain_params_ref_idx;

    [NativeTypeName("uint8_t")]
    public byte num_y_points;

    [NativeTypeName("uint8_t[14]")]
    public _point_y_value_e__FixedBuffer point_y_value;

    [NativeTypeName("uint8_t[14]")]
    public _point_y_scaling_e__FixedBuffer point_y_scaling;

    [NativeTypeName("uint8_t")]
    public byte num_cb_points;

    [NativeTypeName("uint8_t[10]")]
    public _point_cb_value_e__FixedBuffer point_cb_value;

    [NativeTypeName("uint8_t[10]")]
    public _point_cb_scaling_e__FixedBuffer point_cb_scaling;

    [NativeTypeName("uint8_t")]
    public byte num_cr_points;

    [NativeTypeName("uint8_t[10]")]
    public _point_cr_value_e__FixedBuffer point_cr_value;

    [NativeTypeName("uint8_t[10]")]
    public _point_cr_scaling_e__FixedBuffer point_cr_scaling;

    [NativeTypeName("int8_t[24]")]
    public _ar_coeffs_y_plus_128_e__FixedBuffer ar_coeffs_y_plus_128;

    [NativeTypeName("int8_t[25]")]
    public _ar_coeffs_cb_plus_128_e__FixedBuffer ar_coeffs_cb_plus_128;

    [NativeTypeName("int8_t[25]")]
    public _ar_coeffs_cr_plus_128_e__FixedBuffer ar_coeffs_cr_plus_128;

    [NativeTypeName("uint8_t")]
    public byte cb_mult;

    [NativeTypeName("uint8_t")]
    public byte cb_luma_mult;

    [NativeTypeName("uint16_t")]
    public ushort cb_offset;

    [NativeTypeName("uint8_t")]
    public byte cr_mult;

    [NativeTypeName("uint8_t")]
    public byte cr_luma_mult;

    [NativeTypeName("uint16_t")]
    public ushort cr_offset;

    [InlineArray(14)]
    public partial struct _point_y_value_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(14)]
    public partial struct _point_y_scaling_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(10)]
    public partial struct _point_cb_value_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(10)]
    public partial struct _point_cb_scaling_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(10)]
    public partial struct _point_cr_value_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(10)]
    public partial struct _point_cr_scaling_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(24)]
    public partial struct _ar_coeffs_y_plus_128_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(25)]
    public partial struct _ar_coeffs_cb_plus_128_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(25)]
    public partial struct _ar_coeffs_cr_plus_128_e__FixedBuffer
    {
        public sbyte e0;
    }
}
