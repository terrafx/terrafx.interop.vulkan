// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265LongTermRefPicsSps
{
    [NativeTypeName("uint32_t")]
    public uint used_by_curr_pic_lt_sps_flag;

    [NativeTypeName("uint32_t[32]")]
    public _lt_ref_pic_poc_lsb_sps_e__FixedBuffer lt_ref_pic_poc_lsb_sps;

    [InlineArray(32)]
    public partial struct _lt_ref_pic_poc_lsb_sps_e__FixedBuffer
    {
        public uint e0;
    }
}
