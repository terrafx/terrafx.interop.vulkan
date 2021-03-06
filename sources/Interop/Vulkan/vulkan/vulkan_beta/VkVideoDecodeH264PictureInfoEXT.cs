// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkVideoDecodeH264PictureInfoEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("const StdVideoDecodeH264PictureInfo *")]
        public StdVideoDecodeH264PictureInfo* pStdPictureInfo;

        [NativeTypeName("uint32_t")]
        public uint slicesCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pSlicesDataOffsets;
    }
}
