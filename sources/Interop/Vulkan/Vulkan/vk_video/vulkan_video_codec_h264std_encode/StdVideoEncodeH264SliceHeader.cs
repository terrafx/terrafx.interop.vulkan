// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct StdVideoEncodeH264SliceHeader
    {
        public StdVideoEncodeH264SliceHeaderFlags flags;

        public StdVideoH264SliceType slice_type;

        [NativeTypeName("uint8_t")]
        public byte seq_parameter_set_id;

        [NativeTypeName("uint8_t")]
        public byte pic_parameter_set_id;

        [NativeTypeName("uint16_t")]
        public ushort idr_pic_id;

        [NativeTypeName("uint8_t")]
        public byte num_ref_idx_l0_active_minus1;

        [NativeTypeName("uint8_t")]
        public byte num_ref_idx_l1_active_minus1;

        public StdVideoH264CabacInitIdc cabac_init_idc;

        public StdVideoH264DisableDeblockingFilterIdc disable_deblocking_filter_idc;

        [NativeTypeName("int8_t")]
        public sbyte slice_alpha_c0_offset_div2;

        [NativeTypeName("int8_t")]
        public sbyte slice_beta_offset_div2;

        public StdVideoEncodeH264RefMemMgmtCtrlOperations* pMemMgmtCtrlOperations;
    }
}
