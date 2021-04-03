// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
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

        [NativeTypeName("VkBool32")]
        public uint deviceLUIDValid;

        [NativeTypeName("uint32_t")]
        public uint subgroupSize;

        [NativeTypeName("VkShaderStageFlags")]
        public uint subgroupSupportedStages;

        [NativeTypeName("VkSubgroupFeatureFlags")]
        public uint subgroupSupportedOperations;

        [NativeTypeName("VkBool32")]
        public uint subgroupQuadOperationsInAllStages;

        public VkPointClippingBehavior pointClippingBehavior;

        [NativeTypeName("uint32_t")]
        public uint maxMultiviewViewCount;

        [NativeTypeName("uint32_t")]
        public uint maxMultiviewInstanceIndex;

        [NativeTypeName("VkBool32")]
        public uint protectedNoFault;

        [NativeTypeName("uint32_t")]
        public uint maxPerSetDescriptors;

        [NativeTypeName("VkDeviceSize")]
        public ulong maxMemoryAllocationSize;
    }
}
