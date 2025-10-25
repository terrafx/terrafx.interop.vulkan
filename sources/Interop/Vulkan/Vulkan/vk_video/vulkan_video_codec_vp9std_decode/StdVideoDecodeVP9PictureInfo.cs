// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_vp9std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoDecodeVP9PictureInfo
{
    public StdVideoDecodeVP9PictureInfoFlags flags;

    public StdVideoVP9Profile profile;

    public StdVideoVP9FrameType frame_type;

    [NativeTypeName("uint8_t")]
    public byte frame_context_idx;

    [NativeTypeName("uint8_t")]
    public byte reset_frame_context;

    [NativeTypeName("uint8_t")]
    public byte refresh_frame_flags;

    [NativeTypeName("uint8_t")]
    public byte ref_frame_sign_bias_mask;

    public StdVideoVP9InterpolationFilter interpolation_filter;

    [NativeTypeName("uint8_t")]
    public byte base_q_idx;

    [NativeTypeName("int8_t")]
    public sbyte delta_q_y_dc;

    [NativeTypeName("int8_t")]
    public sbyte delta_q_uv_dc;

    [NativeTypeName("int8_t")]
    public sbyte delta_q_uv_ac;

    [NativeTypeName("uint8_t")]
    public byte tile_cols_log2;

    [NativeTypeName("uint8_t")]
    public byte tile_rows_log2;

    [NativeTypeName("uint16_t[3]")]
    public _reserved1_e__FixedBuffer reserved1;

    [NativeTypeName("const StdVideoVP9ColorConfig *")]
    public StdVideoVP9ColorConfig* pColorConfig;

    [NativeTypeName("const StdVideoVP9LoopFilter *")]
    public StdVideoVP9LoopFilter* pLoopFilter;

    [NativeTypeName("const StdVideoVP9Segmentation *")]
    public StdVideoVP9Segmentation* pSegmentation;

    [InlineArray(3)]
    public partial struct _reserved1_e__FixedBuffer
    {
        public ushort e0;
    }
}
