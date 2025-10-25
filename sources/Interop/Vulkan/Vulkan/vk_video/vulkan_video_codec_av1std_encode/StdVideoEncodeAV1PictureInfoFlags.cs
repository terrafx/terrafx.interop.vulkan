// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeAV1PictureInfoFlags
{
    public uint _bitfield;

    [NativeTypeName("uint32_t : 1")]
    public uint error_resilient_mode
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
    public uint disable_cdf_update
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
    public uint use_superres
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
    public uint render_and_frame_size_different
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
    public uint allow_screen_content_tools
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
    public uint is_filter_switchable
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
    public uint force_integer_mv
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
    public uint frame_size_override_flag
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

    [NativeTypeName("uint32_t : 1")]
    public uint buffer_removal_time_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 8) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint allow_intrabc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 9) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint frame_refs_short_signaling
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 10) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint allow_high_precision_mv
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 11) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint is_motion_mode_switchable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 12) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint use_ref_frame_mvs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 13) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint disable_frame_end_update_cdf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 14) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint allow_warped_motion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 15) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint reduced_tx_set
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 16) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint skip_mode_present
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 17) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint delta_q_present
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 18) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint delta_lf_present
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 19) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint delta_lf_multi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 20) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint segmentation_enabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 21) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint segmentation_update_map
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 22) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint segmentation_temporal_update
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 23) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint segmentation_update_data
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 24) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 24)) | ((value & 0x1u) << 24);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint UsesLr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 25) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 25)) | ((value & 0x1u) << 25);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint usesChromaLr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 26) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 26)) | ((value & 0x1u) << 26);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint show_frame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 27) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 27)) | ((value & 0x1u) << 27);
        }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint showable_frame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 28) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 28)) | ((value & 0x1u) << 28);
        }
    }

    [NativeTypeName("uint32_t : 3")]
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 29) & 0x7u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x7u << 29)) | ((value & 0x7u) << 29);
        }
    }
}
