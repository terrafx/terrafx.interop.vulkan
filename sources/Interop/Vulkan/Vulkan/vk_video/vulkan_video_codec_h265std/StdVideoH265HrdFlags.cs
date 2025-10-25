// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265HrdFlags
{
    public uint _bitfield;

    [NativeTypeName("uint32_t : 1")]
    public uint nal_hrd_parameters_present_flag
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
    public uint vcl_hrd_parameters_present_flag
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
    public uint sub_pic_hrd_params_present_flag
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
    public uint sub_pic_cpb_params_in_pic_timing_sei_flag
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

    [NativeTypeName("uint32_t : 8")]
    public uint fixed_pic_rate_general_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 4) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFu << 4)) | ((value & 0xFFu) << 4);
        }
    }

    [NativeTypeName("uint32_t : 8")]
    public uint fixed_pic_rate_within_cvs_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 12) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFu << 12)) | ((value & 0xFFu) << 12);
        }
    }

    [NativeTypeName("uint32_t : 8")]
    public uint low_delay_hrd_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 20) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFu << 20)) | ((value & 0xFFu) << 20);
        }
    }
}
