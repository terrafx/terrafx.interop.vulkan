// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH265ReferenceModifications
{
    public StdVideoEncodeH265ReferenceModificationFlags flags;

    [NativeTypeName("uint8_t")]
    public byte referenceList0ModificationsCount;

    [NativeTypeName("const uint8_t *")]
    public byte* pReferenceList0Modifications;

    [NativeTypeName("uint8_t")]
    public byte referenceList1ModificationsCount;

    [NativeTypeName("const uint8_t *")]
    public byte* pReferenceList1Modifications;
}
