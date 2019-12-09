// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkBindSparseInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint waitSemaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public ulong* pWaitSemaphores;

        [NativeTypeName("uint32_t")]
        public uint bufferBindCount;

        [NativeTypeName("const VkSparseBufferMemoryBindInfo *")]
        public VkSparseBufferMemoryBindInfo* pBufferBinds;

        [NativeTypeName("uint32_t")]
        public uint imageOpaqueBindCount;

        [NativeTypeName("const VkSparseImageOpaqueMemoryBindInfo *")]
        public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;

        [NativeTypeName("uint32_t")]
        public uint imageBindCount;

        [NativeTypeName("const VkSparseImageMemoryBindInfo *")]
        public VkSparseImageMemoryBindInfo* pImageBinds;

        [NativeTypeName("uint32_t")]
        public uint signalSemaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public ulong* pSignalSemaphores;
    }
}
