// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265SpsFlags
{
    public uint _bitfield;

    [NativeTypeName("uint32_t : 1")]
    public uint sps_temporal_id_nesting_flag
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
    public uint separate_colour_plane_flag
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
    public uint conformance_window_flag
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
    public uint sps_sub_layer_ordering_info_present_flag
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
    public uint scaling_list_enabled_flag
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
    public uint sps_scaling_list_data_present_flag
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
    public uint amp_enabled_flag
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
    public uint sample_adaptive_offset_enabled_flag
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
    public uint pcm_enabled_flag
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
    public uint pcm_loop_filter_disabled_flag
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
    public uint long_term_ref_pics_present_flag
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
    public uint sps_temporal_mvp_enabled_flag
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
    public uint strong_intra_smoothing_enabled_flag
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
    public uint vui_parameters_present_flag
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
    public uint sps_extension_present_flag
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
    public uint sps_range_extension_flag
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
    public uint transform_skip_rotation_enabled_flag
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
    public uint transform_skip_context_enabled_flag
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
    public uint implicit_rdpcm_enabled_flag
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
    public uint explicit_rdpcm_enabled_flag
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
    public uint extended_precision_processing_flag
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
    public uint intra_smoothing_disabled_flag
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
    public uint high_precision_offsets_enabled_flag
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
    public uint persistent_rice_adaptation_enabled_flag
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
    public uint cabac_bypass_alignment_enabled_flag
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
    public uint sps_scc_extension_flag
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
    public uint sps_curr_pic_ref_enabled_flag
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
    public uint palette_mode_enabled_flag
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
    public uint sps_palette_predictor_initializers_present_flag
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

    [NativeTypeName("uint32_t : 1")]
    public uint intra_boundary_filtering_disabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 29) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 29)) | ((value & 0x1u) << 29);
        }
    }
}
