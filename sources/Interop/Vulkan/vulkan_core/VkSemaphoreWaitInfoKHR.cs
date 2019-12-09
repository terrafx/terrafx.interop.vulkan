// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSemaphoreWaitInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkSemaphoreWaitFlagsKHR")]
        public uint flags;

        [NativeTypeName("uint32_t")]
        public uint semaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public ulong* pSemaphores;

        [NativeTypeName("const uint64_t *")]
        public ulong* pValues;
    }
}
