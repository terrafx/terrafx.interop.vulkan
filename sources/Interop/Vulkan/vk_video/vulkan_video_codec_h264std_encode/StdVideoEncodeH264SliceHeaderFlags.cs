// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public partial struct StdVideoEncodeH264SliceHeaderFlags
    {
        public uint _bitfield;

        [NativeTypeName("uint32_t : 1")]
        public uint idr_flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
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
        public uint is_reference_flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
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
        public uint num_ref_idx_active_override_flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
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
        public uint no_output_of_prior_pics_flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
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
        public uint long_term_reference_flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
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
        public uint adaptive_ref_pic_marking_mode_flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
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
        public uint no_prior_references_available_flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 6) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
            }
        }
    }
}
