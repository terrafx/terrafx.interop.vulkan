// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct StdVideoH264PictureParameterSet
    {
        [NativeTypeName("uint8_t")]
        public byte seq_parameter_set_id;

        [NativeTypeName("uint8_t")]
        public byte pic_parameter_set_id;

        [NativeTypeName("uint8_t")]
        public byte num_ref_idx_l0_default_active_minus1;

        [NativeTypeName("uint8_t")]
        public byte num_ref_idx_l1_default_active_minus1;

        public StdVideoH264WeightedBiPredIdc weighted_bipred_idc;

        [NativeTypeName("int8_t")]
        public sbyte pic_init_qp_minus26;

        [NativeTypeName("int8_t")]
        public sbyte pic_init_qs_minus26;

        [NativeTypeName("int8_t")]
        public sbyte chroma_qp_index_offset;

        [NativeTypeName("int8_t")]
        public sbyte second_chroma_qp_index_offset;

        public StdVideoH264PpsFlags flags;

        public StdVideoH264ScalingLists* pScalingLists;
    }
}
