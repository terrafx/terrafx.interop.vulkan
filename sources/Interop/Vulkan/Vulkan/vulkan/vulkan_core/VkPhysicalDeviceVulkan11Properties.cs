// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceVulkan11Properties
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("uint8_t [16]")]
        public fixed byte deviceUUID[16];

        [NativeTypeName("uint8_t [16]")]
        public fixed byte driverUUID[16];

        [NativeTypeName("uint8_t [8]")]
        public fixed byte deviceLUID[8];

        [NativeTypeName("uint32_t")]
        public uint deviceNodeMask;

        public VkBool32 deviceLUIDValid;

        [NativeTypeName("uint32_t")]
        public uint subgroupSize;

        public VkShaderStageFlags subgroupSupportedStages;

        public VkSubgroupFeatureFlags subgroupSupportedOperations;

        public VkBool32 subgroupQuadOperationsInAllStages;

        public VkPointClippingBehavior pointClippingBehavior;

        [NativeTypeName("uint32_t")]
        public uint maxMultiviewViewCount;

        [NativeTypeName("uint32_t")]
        public uint maxMultiviewInstanceIndex;

        public VkBool32 protectedNoFault;

        [NativeTypeName("uint32_t")]
        public uint maxPerSetDescriptors;

        [NativeTypeName("VkDeviceSize")]
        public ulong maxMemoryAllocationSize;
    }
}
