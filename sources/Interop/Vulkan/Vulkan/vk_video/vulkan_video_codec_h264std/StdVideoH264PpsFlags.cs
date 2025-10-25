// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH264PpsFlags
{
    public uint _bitfield;

    [NativeTypeName("uint32_t : 1")]
    public uint transform_8x8_mode_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint redundant_pic_cnt_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 1) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint constrained_intra_pred_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 2) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint deblocking_filter_control_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 3) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint weighted_pred_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 4) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint bottom_field_pic_order_in_frame_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 5) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint entropy_coding_mode_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 6) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint pic_scaling_matrix_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 7) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
        }
    }
}
