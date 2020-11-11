// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkCopyBufferInfo2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkBuffer")]
        public ulong srcBuffer;

        [NativeTypeName("VkBuffer")]
        public ulong dstBuffer;

        [NativeTypeName("uint32_t")]
        public uint regionCount;

        [NativeTypeName("const VkBufferCopy2KHR *")]
        public VkBufferCopy2KHR* pRegions;
    }
}