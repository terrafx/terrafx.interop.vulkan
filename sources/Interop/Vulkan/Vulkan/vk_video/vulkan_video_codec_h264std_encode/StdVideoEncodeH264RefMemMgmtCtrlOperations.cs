// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH264RefMemMgmtCtrlOperations
{
    public StdVideoEncodeH264RefMgmtFlags flags;

    [NativeTypeName("uint8_t")]
    public byte refList0ModOpCount;

    public StdVideoEncodeH264RefListModEntry* pRefList0ModOperations;

    [NativeTypeName("uint8_t")]
    public byte refList1ModOpCount;

    public StdVideoEncodeH264RefListModEntry* pRefList1ModOperations;

    [NativeTypeName("uint8_t")]
    public byte refPicMarkingOpCount;

    public StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations;
}
