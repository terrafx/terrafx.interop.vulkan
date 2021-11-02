// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType sType;

        public void* pNext;

        public VkExtent2D minFragmentShadingRateAttachmentTexelSize;

        public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;

        [NativeTypeName("uint32_t")]
        public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;

        public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;

        public VkBool32 layeredShadingRateAttachments;

        public VkBool32 fragmentShadingRateNonTrivialCombinerOps;

        public VkExtent2D maxFragmentSize;

        [NativeTypeName("uint32_t")]
        public uint maxFragmentSizeAspectRatio;

        [NativeTypeName("uint32_t")]
        public uint maxFragmentShadingRateCoverageSamples;

        [NativeTypeName("VkSampleCountFlagBits")]
        public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;

        public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;

        public VkBool32 fragmentShadingRateWithSampleMask;

        public VkBool32 fragmentShadingRateWithShaderSampleMask;

        public VkBool32 fragmentShadingRateWithConservativeRasterization;

        public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;

        public VkBool32 fragmentShadingRateWithCustomSampleLocations;

        public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
    }
}
