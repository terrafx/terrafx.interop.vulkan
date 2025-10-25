// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoDecodeAV1ReferenceInfo
{
    public StdVideoDecodeAV1ReferenceInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte frame_type;

    [NativeTypeName("uint8_t")]
    public byte RefFrameSignBias;

    [NativeTypeName("uint8_t")]
    public byte OrderHint;

    [NativeTypeName("uint8_t[8]")]
    public _SavedOrderHints_e__FixedBuffer SavedOrderHints;

    [InlineArray(8)]
    public partial struct _SavedOrderHints_e__FixedBuffer
    {
        public byte e0;
    }
}
