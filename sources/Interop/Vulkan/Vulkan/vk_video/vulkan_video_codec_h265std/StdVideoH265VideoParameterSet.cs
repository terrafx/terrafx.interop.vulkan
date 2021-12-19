// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct StdVideoH265VideoParameterSet
    {
        [NativeTypeName("uint8_t")]
        public byte vps_video_parameter_set_id;

        [NativeTypeName("uint8_t")]
        public byte vps_max_sub_layers_minus1;

        [NativeTypeName("uint32_t")]
        public uint vps_num_units_in_tick;

        [NativeTypeName("uint32_t")]
        public uint vps_time_scale;

        [NativeTypeName("uint32_t")]
        public uint vps_num_ticks_poc_diff_one_minus1;

        public StdVideoH265DecPicBufMgr* pDecPicBufMgr;

        public StdVideoH265HrdParameters* pHrdParameters;

        public StdVideoH265VpsFlags flags;
    }
}
