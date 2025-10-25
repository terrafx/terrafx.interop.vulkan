// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265VideoParameterSet
{
    public StdVideoH265VpsFlags flags;

    [NativeTypeName("uint8_t")]
    public byte vps_video_parameter_set_id;

    [NativeTypeName("uint8_t")]
    public byte vps_max_sub_layers_minus1;

    [NativeTypeName("uint8_t")]
    public byte reserved1;

    [NativeTypeName("uint8_t")]
    public byte reserved2;

    [NativeTypeName("uint32_t")]
    public uint vps_num_units_in_tick;

    [NativeTypeName("uint32_t")]
    public uint vps_time_scale;

    [NativeTypeName("uint32_t")]
    public uint vps_num_ticks_poc_diff_one_minus1;

    [NativeTypeName("uint32_t")]
    public uint reserved3;

    [NativeTypeName("const StdVideoH265DecPicBufMgr *")]
    public StdVideoH265DecPicBufMgr* pDecPicBufMgr;

    [NativeTypeName("const StdVideoH265HrdParameters *")]
    public StdVideoH265HrdParameters* pHrdParameters;

    [NativeTypeName("const StdVideoH265ProfileTierLevel *")]
    public StdVideoH265ProfileTierLevel* pProfileTierLevel;
}
