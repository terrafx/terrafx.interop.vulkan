// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoEncodeH264ReferenceListsInfo
{
    public StdVideoEncodeH264ReferenceListsInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte num_ref_idx_l0_active_minus1;

    [NativeTypeName("uint8_t")]
    public byte num_ref_idx_l1_active_minus1;

    [NativeTypeName("uint8_t[32]")]
    public _RefPicList0_e__FixedBuffer RefPicList0;

    [NativeTypeName("uint8_t[32]")]
    public _RefPicList1_e__FixedBuffer RefPicList1;

    [NativeTypeName("uint8_t")]
    public byte refList0ModOpCount;

    [NativeTypeName("uint8_t")]
    public byte refList1ModOpCount;

    [NativeTypeName("uint8_t")]
    public byte refPicMarkingOpCount;

    [NativeTypeName("uint8_t[7]")]
    public _reserved1_e__FixedBuffer reserved1;

    [NativeTypeName("const StdVideoEncodeH264RefListModEntry *")]
    public StdVideoEncodeH264RefListModEntry* pRefList0ModOperations;

    [NativeTypeName("const StdVideoEncodeH264RefListModEntry *")]
    public StdVideoEncodeH264RefListModEntry* pRefList1ModOperations;

    [NativeTypeName("const StdVideoEncodeH264RefPicMarkingEntry *")]
    public StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations;

    [InlineArray(32)]
    public partial struct _RefPicList0_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _RefPicList1_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(7)]
    public partial struct _reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
