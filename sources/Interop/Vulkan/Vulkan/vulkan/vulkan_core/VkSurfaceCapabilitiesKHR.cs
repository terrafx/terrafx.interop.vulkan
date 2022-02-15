// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkSurfaceCapabilitiesKHR
    {
        [NativeTypeName("uint32_t")]
        public uint minImageCount;

        [NativeTypeName("uint32_t")]
        public uint maxImageCount;

        public VkExtent2D currentExtent;

        public VkExtent2D minImageExtent;

        public VkExtent2D maxImageExtent;

        [NativeTypeName("uint32_t")]
        public uint maxImageArrayLayers;

        public VkSurfaceTransformFlagsKHR supportedTransforms;

        [NativeTypeName("VkSurfaceTransformFlagBitsKHR")]
        public VkSurfaceTransformFlagsKHR currentTransform;

        public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;

        public VkImageUsageFlags supportedUsageFlags;
    }
}
