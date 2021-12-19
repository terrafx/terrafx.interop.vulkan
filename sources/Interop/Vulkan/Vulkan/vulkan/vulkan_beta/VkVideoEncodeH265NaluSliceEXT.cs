// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoEncodeH265NaluSliceEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint ctbCount;

        [NativeTypeName("const VkVideoEncodeH265ReferenceListsEXT *")]
        public VkVideoEncodeH265ReferenceListsEXT* pReferenceFinalLists;

        [NativeTypeName("const StdVideoEncodeH265SliceHeader *")]
        public StdVideoEncodeH265SliceHeader* pSliceHeaderStd;
    }
}
