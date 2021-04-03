// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkSwapchainCreateFlagsKHR flags;

        [NativeTypeName("VkSurfaceKHR")]
        public ulong surface;

        [NativeTypeName("uint32_t")]
        public uint minImageCount;

        public VkFormat imageFormat;

        public VkColorSpaceKHR imageColorSpace;

        public VkExtent2D imageExtent;

        [NativeTypeName("uint32_t")]
        public uint imageArrayLayers;

        public VkImageUsageFlags imageUsage;

        public VkSharingMode imageSharingMode;

        [NativeTypeName("uint32_t")]
        public uint queueFamilyIndexCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pQueueFamilyIndices;

        [NativeTypeName("VkSurfaceTransformFlagBitsKHR")]
        public VkSurfaceTransformFlagsKHR preTransform;

        [NativeTypeName("VkCompositeAlphaFlagBitsKHR")]
        public VkCompositeAlphaFlagsKHR compositeAlpha;

        public VkPresentModeKHR presentMode;

        [NativeTypeName("VkBool32")]
        public uint clipped;

        [NativeTypeName("VkSwapchainKHR")]
        public ulong oldSwapchain;
    }
}
