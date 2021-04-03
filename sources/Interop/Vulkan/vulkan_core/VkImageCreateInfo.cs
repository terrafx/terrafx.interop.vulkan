// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkImageCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkImageCreateFlags flags;

        public VkImageType imageType;

        public VkFormat format;

        public VkExtent3D extent;

        [NativeTypeName("uint32_t")]
        public uint mipLevels;

        [NativeTypeName("uint32_t")]
        public uint arrayLayers;

        [NativeTypeName("VkSampleCountFlagBits")]
        public VkSampleCountFlags samples;

        public VkImageTiling tiling;

        public VkImageUsageFlags usage;

        public VkSharingMode sharingMode;

        [NativeTypeName("uint32_t")]
        public uint queueFamilyIndexCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pQueueFamilyIndices;

        public VkImageLayout initialLayout;
    }
}
