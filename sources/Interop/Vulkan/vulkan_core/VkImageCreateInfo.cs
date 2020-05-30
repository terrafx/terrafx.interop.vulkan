// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkImageCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkImageCreateFlags")]
        public uint flags;

        public VkImageType imageType;

        public VkFormat format;

        public VkExtent3D extent;

        [NativeTypeName("uint32_t")]
        public uint mipLevels;

        [NativeTypeName("uint32_t")]
        public uint arrayLayers;

        public VkSampleCountFlagBits samples;

        public VkImageTiling tiling;

        [NativeTypeName("VkImageUsageFlags")]
        public uint usage;

        public VkSharingMode sharingMode;

        [NativeTypeName("uint32_t")]
        public uint queueFamilyIndexCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pQueueFamilyIndices;

        public VkImageLayout initialLayout;
    }
}
