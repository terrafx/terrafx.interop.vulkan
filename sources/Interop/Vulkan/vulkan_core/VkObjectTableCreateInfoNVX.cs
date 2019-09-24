// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkObjectTableCreateInfoNVX
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint objectCount;

        [NativeTypeName("const VkObjectEntryTypeNVX *")]
        public VkObjectEntryTypeNVX* pObjectEntryTypes;

        [NativeTypeName("const uint32_t *")]
        public uint* pObjectEntryCounts;

        [NativeTypeName("const VkObjectEntryUsageFlagsNVX *")]
        public uint* pObjectEntryUsageFlags;

        [NativeTypeName("uint32_t")]
        public uint maxUniformBuffersPerDescriptor;

        [NativeTypeName("uint32_t")]
        public uint maxStorageBuffersPerDescriptor;

        [NativeTypeName("uint32_t")]
        public uint maxStorageImagesPerDescriptor;

        [NativeTypeName("uint32_t")]
        public uint maxSampledImagesPerDescriptor;

        [NativeTypeName("uint32_t")]
        public uint maxPipelineLayouts;
    }
}
