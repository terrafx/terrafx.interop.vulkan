// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkSwapchainCreateFlagsKHR")]
        public uint flags;

        [NativeTypeName("VkSurfaceKHR")]
        public ulong surface;

        [NativeTypeName("uint32_t")]
        public uint minImageCount;

        public VkFormat imageFormat;

        public VkColorSpaceKHR imageColorSpace;

        public VkExtent2D imageExtent;

        [NativeTypeName("uint32_t")]
        public uint imageArrayLayers;

        [NativeTypeName("VkImageUsageFlags")]
        public uint imageUsage;

        public VkSharingMode imageSharingMode;

        [NativeTypeName("uint32_t")]
        public uint queueFamilyIndexCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pQueueFamilyIndices;

        public VkSurfaceTransformFlagBitsKHR preTransform;

        public VkCompositeAlphaFlagBitsKHR compositeAlpha;

        public VkPresentModeKHR presentMode;

        [NativeTypeName("VkBool32")]
        public uint clipped;

        [NativeTypeName("VkSwapchainKHR")]
        public ulong oldSwapchain;
    }
}
