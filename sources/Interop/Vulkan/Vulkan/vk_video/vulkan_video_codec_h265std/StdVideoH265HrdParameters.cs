// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct StdVideoH265HrdParameters
    {
        [NativeTypeName("uint8_t")]
        public byte tick_divisor_minus2;

        [NativeTypeName("uint8_t")]
        public byte du_cpb_removal_delay_increment_length_minus1;

        [NativeTypeName("uint8_t")]
        public byte dpb_output_delay_du_length_minus1;

        [NativeTypeName("uint8_t")]
        public byte bit_rate_scale;

        [NativeTypeName("uint8_t")]
        public byte cpb_size_scale;

        [NativeTypeName("uint8_t")]
        public byte cpb_size_du_scale;

        [NativeTypeName("uint8_t")]
        public byte initial_cpb_removal_delay_length_minus1;

        [NativeTypeName("uint8_t")]
        public byte au_cpb_removal_delay_length_minus1;

        [NativeTypeName("uint8_t")]
        public byte dpb_output_delay_length_minus1;

        [NativeTypeName("uint8_t [7]")]
        public fixed byte cpb_cnt_minus1[7];

        [NativeTypeName("uint16_t [7]")]
        public fixed ushort elemental_duration_in_tc_minus1[7];

        [NativeTypeName("StdVideoH265SubLayerHrdParameters *[7]")]
        public _pSubLayerHrdParametersNal_e__FixedBuffer pSubLayerHrdParametersNal;

        [NativeTypeName("StdVideoH265SubLayerHrdParameters *[7]")]
        public _pSubLayerHrdParametersVcl_e__FixedBuffer pSubLayerHrdParametersVcl;

        public StdVideoH265HrdFlags flags;

        public unsafe partial struct _pSubLayerHrdParametersNal_e__FixedBuffer
        {
            public StdVideoH265SubLayerHrdParameters* e0;
            public StdVideoH265SubLayerHrdParameters* e1;
            public StdVideoH265SubLayerHrdParameters* e2;
            public StdVideoH265SubLayerHrdParameters* e3;
            public StdVideoH265SubLayerHrdParameters* e4;
            public StdVideoH265SubLayerHrdParameters* e5;
            public StdVideoH265SubLayerHrdParameters* e6;

            public ref StdVideoH265SubLayerHrdParameters* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (StdVideoH265SubLayerHrdParameters** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public unsafe partial struct _pSubLayerHrdParametersVcl_e__FixedBuffer
        {
            public StdVideoH265SubLayerHrdParameters* e0;
            public StdVideoH265SubLayerHrdParameters* e1;
            public StdVideoH265SubLayerHrdParameters* e2;
            public StdVideoH265SubLayerHrdParameters* e3;
            public StdVideoH265SubLayerHrdParameters* e4;
            public StdVideoH265SubLayerHrdParameters* e5;
            public StdVideoH265SubLayerHrdParameters* e6;

            public ref StdVideoH265SubLayerHrdParameters* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (StdVideoH265SubLayerHrdParameters** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
