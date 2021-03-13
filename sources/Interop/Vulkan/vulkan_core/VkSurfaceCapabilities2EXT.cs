// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSurfaceCapabilities2EXT
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint minImageCount;

        [NativeTypeName("uint32_t")]
        public uint maxImageCount;

        public VkExtent2D currentExtent;

        public VkExtent2D minImageExtent;

        public VkExtent2D maxImageExtent;

        [NativeTypeName("uint32_t")]
        public uint maxImageArrayLayers;

        [NativeTypeName("VkSurfaceTransformFlagsKHR")]
        public uint supportedTransforms;

        public VkSurfaceTransformFlagBitsKHR currentTransform;

        [NativeTypeName("VkCompositeAlphaFlagsKHR")]
        public uint supportedCompositeAlpha;

        [NativeTypeName("VkImageUsageFlags")]
        public uint supportedUsageFlags;

        [NativeTypeName("VkSurfaceCounterFlagsEXT")]
        public uint supportedSurfaceCounters;
    }
}
