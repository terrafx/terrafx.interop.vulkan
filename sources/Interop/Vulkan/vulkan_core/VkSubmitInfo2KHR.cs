// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSubmitInfo2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkSubmitFlagsKHR flags;

        [NativeTypeName("uint32_t")]
        public uint waitSemaphoreInfoCount;

        [NativeTypeName("const VkSemaphoreSubmitInfoKHR *")]
        public VkSemaphoreSubmitInfoKHR* pWaitSemaphoreInfos;

        [NativeTypeName("uint32_t")]
        public uint commandBufferInfoCount;

        [NativeTypeName("const VkCommandBufferSubmitInfoKHR *")]
        public VkCommandBufferSubmitInfoKHR* pCommandBufferInfos;

        [NativeTypeName("uint32_t")]
        public uint signalSemaphoreInfoCount;

        [NativeTypeName("const VkSemaphoreSubmitInfoKHR *")]
        public VkSemaphoreSubmitInfoKHR* pSignalSemaphoreInfos;
    }
}
