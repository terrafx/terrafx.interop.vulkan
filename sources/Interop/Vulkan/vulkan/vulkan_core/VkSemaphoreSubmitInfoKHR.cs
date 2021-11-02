// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSemaphoreSubmitInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkSemaphore semaphore;

        [NativeTypeName("uint64_t")]
        public ulong value;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong stageMask;

        [NativeTypeName("uint32_t")]
        public uint deviceIndex;
    }
}
