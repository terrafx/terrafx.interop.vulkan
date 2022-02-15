// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceLimits
    {
        [NativeTypeName("uint32_t")]
        public uint maxImageDimension1D;

        [NativeTypeName("uint32_t")]
        public uint maxImageDimension2D;

        [NativeTypeName("uint32_t")]
        public uint maxImageDimension3D;

        [NativeTypeName("uint32_t")]
        public uint maxImageDimensionCube;

        [NativeTypeName("uint32_t")]
        public uint maxImageArrayLayers;

        [NativeTypeName("uint32_t")]
        public uint maxTexelBufferElements;

        [NativeTypeName("uint32_t")]
        public uint maxUniformBufferRange;

        [NativeTypeName("uint32_t")]
        public uint maxStorageBufferRange;

        [NativeTypeName("uint32_t")]
        public uint maxPushConstantsSize;

        [NativeTypeName("uint32_t")]
        public uint maxMemoryAllocationCount;

        [NativeTypeName("uint32_t")]
        public uint maxSamplerAllocationCount;

        [NativeTypeName("VkDeviceSize")]
        public ulong bufferImageGranularity;

        [NativeTypeName("VkDeviceSize")]
        public ulong sparseAddressSpaceSize;

        [NativeTypeName("uint32_t")]
        public uint maxBoundDescriptorSets;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageDescriptorSamplers;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageDescriptorUniformBuffers;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageDescriptorStorageBuffers;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageDescriptorSampledImages;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageDescriptorStorageImages;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageDescriptorInputAttachments;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageResources;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetSamplers;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetUniformBuffers;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetUniformBuffersDynamic;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetStorageBuffers;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetStorageBuffersDynamic;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetSampledImages;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetStorageImages;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetInputAttachments;

        [NativeTypeName("uint32_t")]
        public uint maxVertexInputAttributes;

        [NativeTypeName("uint32_t")]
        public uint maxVertexInputBindings;

        [NativeTypeName("uint32_t")]
        public uint maxVertexInputAttributeOffset;

        [NativeTypeName("uint32_t")]
        public uint maxVertexInputBindingStride;

        [NativeTypeName("uint32_t")]
        public uint maxVertexOutputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxTessellationGenerationLevel;

        [NativeTypeName("uint32_t")]
        public uint maxTessellationPatchSize;

        [NativeTypeName("uint32_t")]
        public uint maxTessellationControlPerVertexInputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxTessellationControlPerVertexOutputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxTessellationControlPerPatchOutputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxTessellationControlTotalOutputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxTessellationEvaluationInputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxTessellationEvaluationOutputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxGeometryShaderInvocations;

        [NativeTypeName("uint32_t")]
        public uint maxGeometryInputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxGeometryOutputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxGeometryOutputVertices;

        [NativeTypeName("uint32_t")]
        public uint maxGeometryTotalOutputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxFragmentInputComponents;

        [NativeTypeName("uint32_t")]
        public uint maxFragmentOutputAttachments;

        [NativeTypeName("uint32_t")]
        public uint maxFragmentDualSrcAttachments;

        [NativeTypeName("uint32_t")]
        public uint maxFragmentCombinedOutputResources;

        [NativeTypeName("uint32_t")]
        public uint maxComputeSharedMemorySize;

        [NativeTypeName("uint32_t [3]")]
        public fixed uint maxComputeWorkGroupCount[3];

        [NativeTypeName("uint32_t")]
        public uint maxComputeWorkGroupInvocations;

        [NativeTypeName("uint32_t [3]")]
        public fixed uint maxComputeWorkGroupSize[3];

        [NativeTypeName("uint32_t")]
        public uint subPixelPrecisionBits;

        [NativeTypeName("uint32_t")]
        public uint subTexelPrecisionBits;

        [NativeTypeName("uint32_t")]
        public uint mipmapPrecisionBits;

        [NativeTypeName("uint32_t")]
        public uint maxDrawIndexedIndexValue;

        [NativeTypeName("uint32_t")]
        public uint maxDrawIndirectCount;

        public float maxSamplerLodBias;

        public float maxSamplerAnisotropy;

        [NativeTypeName("uint32_t")]
        public uint maxViewports;

        [NativeTypeName("uint32_t [2]")]
        public fixed uint maxViewportDimensions[2];

        [NativeTypeName("float [2]")]
        public fixed float viewportBoundsRange[2];

        [NativeTypeName("uint32_t")]
        public uint viewportSubPixelBits;

        [NativeTypeName("size_t")]
        public nuint minMemoryMapAlignment;

        [NativeTypeName("VkDeviceSize")]
        public ulong minTexelBufferOffsetAlignment;

        [NativeTypeName("VkDeviceSize")]
        public ulong minUniformBufferOffsetAlignment;

        [NativeTypeName("VkDeviceSize")]
        public ulong minStorageBufferOffsetAlignment;

        [NativeTypeName("int32_t")]
        public int minTexelOffset;

        [NativeTypeName("uint32_t")]
        public uint maxTexelOffset;

        [NativeTypeName("int32_t")]
        public int minTexelGatherOffset;

        [NativeTypeName("uint32_t")]
        public uint maxTexelGatherOffset;

        public float minInterpolationOffset;

        public float maxInterpolationOffset;

        [NativeTypeName("uint32_t")]
        public uint subPixelInterpolationOffsetBits;

        [NativeTypeName("uint32_t")]
        public uint maxFramebufferWidth;

        [NativeTypeName("uint32_t")]
        public uint maxFramebufferHeight;

        [NativeTypeName("uint32_t")]
        public uint maxFramebufferLayers;

        public VkSampleCountFlags framebufferColorSampleCounts;

        public VkSampleCountFlags framebufferDepthSampleCounts;

        public VkSampleCountFlags framebufferStencilSampleCounts;

        public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;

        [NativeTypeName("uint32_t")]
        public uint maxColorAttachments;

        public VkSampleCountFlags sampledImageColorSampleCounts;

        public VkSampleCountFlags sampledImageIntegerSampleCounts;

        public VkSampleCountFlags sampledImageDepthSampleCounts;

        public VkSampleCountFlags sampledImageStencilSampleCounts;

        public VkSampleCountFlags storageImageSampleCounts;

        [NativeTypeName("uint32_t")]
        public uint maxSampleMaskWords;

        public VkBool32 timestampComputeAndGraphics;

        public float timestampPeriod;

        [NativeTypeName("uint32_t")]
        public uint maxClipDistances;

        [NativeTypeName("uint32_t")]
        public uint maxCullDistances;

        [NativeTypeName("uint32_t")]
        public uint maxCombinedClipAndCullDistances;

        [NativeTypeName("uint32_t")]
        public uint discreteQueuePriorities;

        [NativeTypeName("float [2]")]
        public fixed float pointSizeRange[2];

        [NativeTypeName("float [2]")]
        public fixed float lineWidthRange[2];

        public float pointSizeGranularity;

        public float lineWidthGranularity;

        public VkBool32 strictLines;

        public VkBool32 standardSampleLocations;

        [NativeTypeName("VkDeviceSize")]
        public ulong optimalBufferCopyOffsetAlignment;

        [NativeTypeName("VkDeviceSize")]
        public ulong optimalBufferCopyRowPitchAlignment;

        [NativeTypeName("VkDeviceSize")]
        public ulong nonCoherentAtomSize;
    }
}
