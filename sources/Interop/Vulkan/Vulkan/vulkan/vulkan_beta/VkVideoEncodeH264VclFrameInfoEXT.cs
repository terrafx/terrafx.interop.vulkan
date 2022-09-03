// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH264VclFrameInfoEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint8_t")]
    public byte refDefaultFinalList0EntryCount;

    [NativeTypeName("const VkVideoEncodeH264DpbSlotInfoEXT *")]
    public VkVideoEncodeH264DpbSlotInfoEXT* pRefDefaultFinalList0Entries;

    [NativeTypeName("uint8_t")]
    public byte refDefaultFinalList1EntryCount;

    [NativeTypeName("const VkVideoEncodeH264DpbSlotInfoEXT *")]
    public VkVideoEncodeH264DpbSlotInfoEXT* pRefDefaultFinalList1Entries;

    [NativeTypeName("uint32_t")]
    public uint naluSliceEntryCount;

    [NativeTypeName("const VkVideoEncodeH264NaluSliceEXT *")]
    public VkVideoEncodeH264NaluSliceEXT* pNaluSliceEntries;

    [NativeTypeName("const VkVideoEncodeH264DpbSlotInfoEXT *")]
    public VkVideoEncodeH264DpbSlotInfoEXT* pCurrentPictureInfo;
}
