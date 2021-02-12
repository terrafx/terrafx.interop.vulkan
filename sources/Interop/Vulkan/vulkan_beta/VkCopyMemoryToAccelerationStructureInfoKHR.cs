// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkCopyMemoryToAccelerationStructureInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkDeviceOrHostAddressConstKHR src;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public ulong dst;

        public VkCopyAccelerationStructureModeKHR mode;
    }
}
