// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPresentInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint waitSemaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public ulong* pWaitSemaphores;

        [NativeTypeName("uint32_t")]
        public uint swapchainCount;

        [NativeTypeName("const VkSwapchainKHR *")]
        public ulong* pSwapchains;

        [NativeTypeName("const uint32_t *")]
        public uint* pImageIndices;

        [NativeTypeName("VkResult *")]
        public VkResult* pResults;
    }
}
