// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoAV1GlobalMotion
{
    [NativeTypeName("uint8_t[8]")]
    public _GmType_e__FixedBuffer GmType;

    [NativeTypeName("int32_t[8][6]")]
    public _gm_params_e__FixedBuffer gm_params;

    [InlineArray(8)]
    public partial struct _GmType_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8 * 6)]
    public partial struct _gm_params_e__FixedBuffer
    {
        public int e0_0;
    }
}
