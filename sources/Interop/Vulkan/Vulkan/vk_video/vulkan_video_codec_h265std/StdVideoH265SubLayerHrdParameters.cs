// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265SubLayerHrdParameters
{
    [NativeTypeName("uint32_t[32]")]
    public _bit_rate_value_minus1_e__FixedBuffer bit_rate_value_minus1;

    [NativeTypeName("uint32_t[32]")]
    public _cpb_size_value_minus1_e__FixedBuffer cpb_size_value_minus1;

    [NativeTypeName("uint32_t[32]")]
    public _cpb_size_du_value_minus1_e__FixedBuffer cpb_size_du_value_minus1;

    [NativeTypeName("uint32_t[32]")]
    public _bit_rate_du_value_minus1_e__FixedBuffer bit_rate_du_value_minus1;

    [NativeTypeName("uint32_t")]
    public uint cbr_flag;

    [InlineArray(32)]
    public partial struct _bit_rate_value_minus1_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(32)]
    public partial struct _cpb_size_value_minus1_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(32)]
    public partial struct _cpb_size_du_value_minus1_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(32)]
    public partial struct _bit_rate_du_value_minus1_e__FixedBuffer
    {
        public uint e0;
    }
}
