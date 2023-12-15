// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH265NaluSliceSegmentInfoEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint ctbCount;

    [NativeTypeName("const VkVideoEncodeH265ReferenceListsInfoEXT *")]
    public VkVideoEncodeH265ReferenceListsInfoEXT* pReferenceFinalLists;

    [NativeTypeName("const StdVideoEncodeH265SliceSegmentHeader *")]
    public StdVideoEncodeH265SliceSegmentHeader* pSliceSegmentHeaderStd;
}
