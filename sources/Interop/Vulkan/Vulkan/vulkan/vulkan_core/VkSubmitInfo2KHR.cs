// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkSubmitInfo2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkSubmitFlags flags;

        [NativeTypeName("uint32_t")]
        public uint waitSemaphoreInfoCount;

        [NativeTypeName("const VkSemaphoreSubmitInfo *")]
        public VkSemaphoreSubmitInfoKHR* pWaitSemaphoreInfos;

        [NativeTypeName("uint32_t")]
        public uint commandBufferInfoCount;

        [NativeTypeName("const VkCommandBufferSubmitInfo *")]
        public VkCommandBufferSubmitInfoKHR* pCommandBufferInfos;

        [NativeTypeName("uint32_t")]
        public uint signalSemaphoreInfoCount;

        [NativeTypeName("const VkSemaphoreSubmitInfo *")]
        public VkSemaphoreSubmitInfoKHR* pSignalSemaphoreInfos;
    }
}
