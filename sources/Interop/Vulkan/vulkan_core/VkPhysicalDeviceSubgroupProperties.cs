// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceSubgroupProperties
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint subgroupSize;

        [NativeTypeName("VkShaderStageFlags")]
        public uint supportedStages;

        [NativeTypeName("VkSubgroupFeatureFlags")]
        public uint supportedOperations;

        [NativeTypeName("VkBool32")]
        public uint quadOperationsInAllStages;
    }
}
