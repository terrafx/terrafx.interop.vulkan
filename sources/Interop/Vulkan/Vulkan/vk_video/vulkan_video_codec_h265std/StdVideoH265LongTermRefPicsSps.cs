// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoH265LongTermRefPicsSps
{
    [NativeTypeName("uint32_t")]
    public uint used_by_curr_pic_lt_sps_flag;

    [NativeTypeName("uint32_t[32]")]
    public fixed uint lt_ref_pic_poc_lsb_sps[32];
}
