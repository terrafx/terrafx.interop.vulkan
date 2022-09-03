// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceVulkan12Properties
{
    public VkStructureType sType;

    public void* pNext;

    public VkDriverId driverID;

    [NativeTypeName("char[256]")]
    public fixed sbyte driverName[256];

    [NativeTypeName("char[256]")]
    public fixed sbyte driverInfo[256];

    public VkConformanceVersion conformanceVersion;

    public VkShaderFloatControlsIndependence denormBehaviorIndependence;

    public VkShaderFloatControlsIndependence roundingModeIndependence;

    public VkBool32 shaderSignedZeroInfNanPreserveFloat16;

    public VkBool32 shaderSignedZeroInfNanPreserveFloat32;

    public VkBool32 shaderSignedZeroInfNanPreserveFloat64;

    public VkBool32 shaderDenormPreserveFloat16;

    public VkBool32 shaderDenormPreserveFloat32;

    public VkBool32 shaderDenormPreserveFloat64;

    public VkBool32 shaderDenormFlushToZeroFloat16;

    public VkBool32 shaderDenormFlushToZeroFloat32;

    public VkBool32 shaderDenormFlushToZeroFloat64;

    public VkBool32 shaderRoundingModeRTEFloat16;

    public VkBool32 shaderRoundingModeRTEFloat32;

    public VkBool32 shaderRoundingModeRTEFloat64;

    public VkBool32 shaderRoundingModeRTZFloat16;

    public VkBool32 shaderRoundingModeRTZFloat32;

    public VkBool32 shaderRoundingModeRTZFloat64;

    [NativeTypeName("uint32_t")]
    public uint maxUpdateAfterBindDescriptorsInAllPools;

    public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;

    public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;

    public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;

    public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;

    public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;

    public VkBool32 robustBufferAccessUpdateAfterBind;

    public VkBool32 quadDivergentImplicitLod;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageUpdateAfterBindResources;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindInputAttachments;

    public VkResolveModeFlags supportedDepthResolveModes;

    public VkResolveModeFlags supportedStencilResolveModes;

    public VkBool32 independentResolveNone;

    public VkBool32 independentResolve;

    public VkBool32 filterMinmaxSingleComponentFormats;

    public VkBool32 filterMinmaxImageComponentMapping;

    [NativeTypeName("uint64_t")]
    public ulong maxTimelineSemaphoreValueDifference;

    public VkSampleCountFlags framebufferIntegerColorSampleCounts;
}
