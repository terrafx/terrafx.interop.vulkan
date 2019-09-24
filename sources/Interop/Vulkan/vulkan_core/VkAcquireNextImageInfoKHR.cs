// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAcquireNextImageInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkSwapchainKHR")]
        public ulong swapchain;

        [NativeTypeName("uint64_t")]
        public ulong timeout;

        [NativeTypeName("VkSemaphore")]
        public ulong semaphore;

        [NativeTypeName("VkFence")]
        public ulong fence;

        [NativeTypeName("uint32_t")]
        public uint deviceMask;
    }
}
