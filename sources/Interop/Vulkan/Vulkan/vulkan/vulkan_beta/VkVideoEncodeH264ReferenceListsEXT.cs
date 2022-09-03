// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH264ReferenceListsEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint8_t")]
    public byte referenceList0EntryCount;

    [NativeTypeName("const VkVideoEncodeH264DpbSlotInfoEXT *")]
    public VkVideoEncodeH264DpbSlotInfoEXT* pReferenceList0Entries;

    [NativeTypeName("uint8_t")]
    public byte referenceList1EntryCount;

    [NativeTypeName("const VkVideoEncodeH264DpbSlotInfoEXT *")]
    public VkVideoEncodeH264DpbSlotInfoEXT* pReferenceList1Entries;

    [NativeTypeName("const StdVideoEncodeH264RefMemMgmtCtrlOperations *")]
    public StdVideoEncodeH264RefMemMgmtCtrlOperations* pMemMgmtCtrlOperations;
}
