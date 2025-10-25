// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoDecodeAV1PictureInfo
{
    public StdVideoDecodeAV1PictureInfoFlags flags;

    public StdVideoAV1FrameType frame_type;

    [NativeTypeName("uint32_t")]
    public uint current_frame_id;

    [NativeTypeName("uint8_t")]
    public byte OrderHint;

    [NativeTypeName("uint8_t")]
    public byte primary_ref_frame;

    [NativeTypeName("uint8_t")]
    public byte refresh_frame_flags;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    public StdVideoAV1InterpolationFilter interpolation_filter;

    public StdVideoAV1TxMode TxMode;

    [NativeTypeName("uint8_t")]
    public byte delta_q_res;

    [NativeTypeName("uint8_t")]
    public byte delta_lf_res;

    [NativeTypeName("uint8_t[2]")]
    public _SkipModeFrame_e__FixedBuffer SkipModeFrame;

    [NativeTypeName("uint8_t")]
    public byte coded_denom;

    [NativeTypeName("uint8_t[3]")]
    public _reserved2_e__FixedBuffer reserved2;

    [NativeTypeName("uint8_t[8]")]
    public _OrderHints_e__FixedBuffer OrderHints;

    [NativeTypeName("uint32_t[8]")]
    public _expectedFrameId_e__FixedBuffer expectedFrameId;

    [NativeTypeName("const StdVideoAV1TileInfo *")]
    public StdVideoAV1TileInfo* pTileInfo;

    [NativeTypeName("const StdVideoAV1Quantization *")]
    public StdVideoAV1Quantization* pQuantization;

    [NativeTypeName("const StdVideoAV1Segmentation *")]
    public StdVideoAV1Segmentation* pSegmentation;

    [NativeTypeName("const StdVideoAV1LoopFilter *")]
    public StdVideoAV1LoopFilter* pLoopFilter;

    [NativeTypeName("const StdVideoAV1CDEF *")]
    public StdVideoAV1CDEF* pCDEF;

    [NativeTypeName("const StdVideoAV1LoopRestoration *")]
    public StdVideoAV1LoopRestoration* pLoopRestoration;

    [NativeTypeName("const StdVideoAV1GlobalMotion *")]
    public StdVideoAV1GlobalMotion* pGlobalMotion;

    [NativeTypeName("const StdVideoAV1FilmGrain *")]
    public StdVideoAV1FilmGrain* pFilmGrain;

    [InlineArray(2)]
    public partial struct _SkipModeFrame_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(3)]
    public partial struct _reserved2_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _OrderHints_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _expectedFrameId_e__FixedBuffer
    {
        public uint e0;
    }
}
