// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkSubmitInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint waitSemaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public ulong* pWaitSemaphores;

        [NativeTypeName("const VkPipelineStageFlags *")]
        public uint* pWaitDstStageMask;

        [NativeTypeName("uint32_t")]
        public uint commandBufferCount;

        [NativeTypeName("const VkCommandBuffer *")]
        public IntPtr* pCommandBuffers;

        [NativeTypeName("uint32_t")]
        public uint signalSemaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public ulong* pSignalSemaphores;
    }
}
