// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    public VkExtent2D minFragmentShadingRateAttachmentTexelSize;

    public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;

    [NativeTypeName("uint32_t")]
    public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;

    [NativeTypeName("VkBool32")]
    public uint primitiveFragmentShadingRateWithMultipleViewports;

    [NativeTypeName("VkBool32")]
    public uint layeredShadingRateAttachments;

    [NativeTypeName("VkBool32")]
    public uint fragmentShadingRateNonTrivialCombinerOps;

    public VkExtent2D maxFragmentSize;

    [NativeTypeName("uint32_t")]
    public uint maxFragmentSizeAspectRatio;

    [NativeTypeName("uint32_t")]
    public uint maxFragmentShadingRateCoverageSamples;

    [NativeTypeName("VkSampleCountFlagBits")]
    public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;

    [NativeTypeName("VkBool32")]
    public uint fragmentShadingRateWithShaderDepthStencilWrites;

    [NativeTypeName("VkBool32")]
    public uint fragmentShadingRateWithSampleMask;

    [NativeTypeName("VkBool32")]
    public uint fragmentShadingRateWithShaderSampleMask;

    [NativeTypeName("VkBool32")]
    public uint fragmentShadingRateWithConservativeRasterization;

    [NativeTypeName("VkBool32")]
    public uint fragmentShadingRateWithFragmentShaderInterlock;

    [NativeTypeName("VkBool32")]
    public uint fragmentShadingRateWithCustomSampleLocations;

    [NativeTypeName("VkBool32")]
    public uint fragmentShadingRateStrictMultiplyCombiner;
}
