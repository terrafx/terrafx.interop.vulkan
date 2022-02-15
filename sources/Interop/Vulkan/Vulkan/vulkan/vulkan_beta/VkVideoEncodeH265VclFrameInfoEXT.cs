// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoEncodeH265VclFrameInfoEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("const VkVideoEncodeH265ReferenceListsEXT *")]
        public VkVideoEncodeH265ReferenceListsEXT* pReferenceFinalLists;

        [NativeTypeName("uint32_t")]
        public uint naluSliceEntryCount;

        [NativeTypeName("const VkVideoEncodeH265NaluSliceEXT *")]
        public VkVideoEncodeH265NaluSliceEXT* pNaluSliceEntries;

        [NativeTypeName("const StdVideoEncodeH265PictureInfo *")]
        public StdVideoEncodeH265PictureInfo* pCurrentPictureInfo;
    }
}
