// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeAV1ReferenceInfo
{
    public StdVideoEncodeAV1ReferenceInfoFlags flags;

    [NativeTypeName("uint32_t")]
    public uint RefFrameId;

    public StdVideoAV1FrameType frame_type;

    [NativeTypeName("uint8_t")]
    public byte OrderHint;

    [NativeTypeName("uint8_t[3]")]
    public _reserved1_e__FixedBuffer reserved1;

    [NativeTypeName("const StdVideoEncodeAV1ExtensionHeader *")]
    public StdVideoEncodeAV1ExtensionHeader* pExtensionHeader;

    [InlineArray(3)]
    public partial struct _reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
