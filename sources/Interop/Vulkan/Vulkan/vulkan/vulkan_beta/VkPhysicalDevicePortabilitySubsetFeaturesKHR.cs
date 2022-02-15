// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDevicePortabilitySubsetFeaturesKHR
    {
        public VkStructureType sType;

        public void* pNext;

        public VkBool32 constantAlphaColorBlendFactors;

        public VkBool32 events;

        public VkBool32 imageViewFormatReinterpretation;

        public VkBool32 imageViewFormatSwizzle;

        public VkBool32 imageView2DOn3DImage;

        public VkBool32 multisampleArrayImage;

        public VkBool32 mutableComparisonSamplers;

        public VkBool32 pointPolygons;

        public VkBool32 samplerMipLodBias;

        public VkBool32 separateStencilMaskRef;

        public VkBool32 shaderSampleRateInterpolationFunctions;

        public VkBool32 tessellationIsolines;

        public VkBool32 tessellationPointMode;

        public VkBool32 triangleFans;

        public VkBool32 vertexAttributeAccessBeyondStride;
    }
}
