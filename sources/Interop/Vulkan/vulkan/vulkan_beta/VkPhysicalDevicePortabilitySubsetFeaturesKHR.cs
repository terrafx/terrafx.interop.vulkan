// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDevicePortabilitySubsetFeaturesKHR
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkBool32")]
        public uint constantAlphaColorBlendFactors;

        [NativeTypeName("VkBool32")]
        public uint events;

        [NativeTypeName("VkBool32")]
        public uint imageViewFormatReinterpretation;

        [NativeTypeName("VkBool32")]
        public uint imageViewFormatSwizzle;

        [NativeTypeName("VkBool32")]
        public uint imageView2DOn3DImage;

        [NativeTypeName("VkBool32")]
        public uint multisampleArrayImage;

        [NativeTypeName("VkBool32")]
        public uint mutableComparisonSamplers;

        [NativeTypeName("VkBool32")]
        public uint pointPolygons;

        [NativeTypeName("VkBool32")]
        public uint samplerMipLodBias;

        [NativeTypeName("VkBool32")]
        public uint separateStencilMaskRef;

        [NativeTypeName("VkBool32")]
        public uint shaderSampleRateInterpolationFunctions;

        [NativeTypeName("VkBool32")]
        public uint tessellationIsolines;

        [NativeTypeName("VkBool32")]
        public uint tessellationPointMode;

        [NativeTypeName("VkBool32")]
        public uint triangleFans;

        [NativeTypeName("VkBool32")]
        public uint vertexAttributeAccessBeyondStride;
    }
}
