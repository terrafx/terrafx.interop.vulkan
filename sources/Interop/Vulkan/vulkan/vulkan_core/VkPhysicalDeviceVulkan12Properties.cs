// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceVulkan12Properties
    {
        public VkStructureType sType;

        public void* pNext;

        public VkDriverId driverID;

        [NativeTypeName("char [256]")]
        public fixed sbyte driverName[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte driverInfo[256];

        public VkConformanceVersion conformanceVersion;

        public VkShaderFloatControlsIndependence denormBehaviorIndependence;

        public VkShaderFloatControlsIndependence roundingModeIndependence;

        [NativeTypeName("VkBool32")]
        public uint shaderSignedZeroInfNanPreserveFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderSignedZeroInfNanPreserveFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderSignedZeroInfNanPreserveFloat64;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormPreserveFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormPreserveFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormPreserveFloat64;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormFlushToZeroFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormFlushToZeroFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormFlushToZeroFloat64;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTEFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTEFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTEFloat64;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTZFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTZFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTZFloat64;

        [NativeTypeName("uint32_t")]
        public uint maxUpdateAfterBindDescriptorsInAllPools;

        [NativeTypeName("VkBool32")]
        public uint shaderUniformBufferArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")]
        public uint shaderSampledImageArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")]
        public uint shaderStorageBufferArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")]
        public uint shaderStorageImageArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")]
        public uint shaderInputAttachmentArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")]
        public uint robustBufferAccessUpdateAfterBind;

        [NativeTypeName("VkBool32")]
        public uint quadDivergentImplicitLod;

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

        [NativeTypeName("VkBool32")]
        public uint independentResolveNone;

        [NativeTypeName("VkBool32")]
        public uint independentResolve;

        [NativeTypeName("VkBool32")]
        public uint filterMinmaxSingleComponentFormats;

        [NativeTypeName("VkBool32")]
        public uint filterMinmaxImageComponentMapping;

        [NativeTypeName("uint64_t")]
        public ulong maxTimelineSemaphoreValueDifference;

        public VkSampleCountFlags framebufferIntegerColorSampleCounts;
    }
}
