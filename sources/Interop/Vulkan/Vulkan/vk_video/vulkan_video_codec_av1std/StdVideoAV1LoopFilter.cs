// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoAV1LoopFilter
{
    public StdVideoAV1LoopFilterFlags flags;

    [NativeTypeName("uint8_t[4]")]
    public _loop_filter_level_e__FixedBuffer loop_filter_level;

    [NativeTypeName("uint8_t")]
    public byte loop_filter_sharpness;

    [NativeTypeName("uint8_t")]
    public byte update_ref_delta;

    [NativeTypeName("int8_t[8]")]
    public _loop_filter_ref_deltas_e__FixedBuffer loop_filter_ref_deltas;

    [NativeTypeName("uint8_t")]
    public byte update_mode_delta;

    [NativeTypeName("int8_t[2]")]
    public _loop_filter_mode_deltas_e__FixedBuffer loop_filter_mode_deltas;

    [InlineArray(4)]
    public partial struct _loop_filter_level_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _loop_filter_ref_deltas_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(2)]
    public partial struct _loop_filter_mode_deltas_e__FixedBuffer
    {
        public sbyte e0;
    }
}
