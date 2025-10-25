// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265DecPicBufMgr
{
    [NativeTypeName("uint32_t[7]")]
    public _max_latency_increase_plus1_e__FixedBuffer max_latency_increase_plus1;

    [NativeTypeName("uint8_t[7]")]
    public _max_dec_pic_buffering_minus1_e__FixedBuffer max_dec_pic_buffering_minus1;

    [NativeTypeName("uint8_t[7]")]
    public _max_num_reorder_pics_e__FixedBuffer max_num_reorder_pics;

    [InlineArray(7)]
    public partial struct _max_latency_increase_plus1_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(7)]
    public partial struct _max_dec_pic_buffering_minus1_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(7)]
    public partial struct _max_num_reorder_pics_e__FixedBuffer
    {
        public byte e0;
    }
}
