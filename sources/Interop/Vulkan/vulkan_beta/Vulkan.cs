// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDeferredOperationKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDeferredOperationKHR *")] ulong* pDeferredOperation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDeferredOperationKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeferredOperationKHR")] ulong operation, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint vkGetDeferredOperationMaxConcurrencyKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeferredOperationKHR")] ulong operation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDeferredOperationResultKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeferredOperationKHR")] ulong operation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDeferredOperationJoinKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeferredOperationKHR")] ulong operation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateAccelerationStructureKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureCreateInfoKHR *")] VkAccelerationStructureCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkAccelerationStructureKHR *")] ulong* pAccelerationStructure);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetAccelerationStructureMemoryRequirementsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureMemoryRequirementsInfoKHR *")] VkAccelerationStructureMemoryRequirementsInfoKHR* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBuildAccelerationStructureKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint infoCount, [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")] VkAccelerationStructureBuildGeometryInfoKHR* pInfos, [NativeTypeName("const VkAccelerationStructureBuildOffsetInfoKHR *const *")] VkAccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBuildAccelerationStructureIndirectKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")] VkAccelerationStructureBuildGeometryInfoKHR* pInfo, [NativeTypeName("VkBuffer")] ulong indirectBuffer, [NativeTypeName("VkDeviceSize")] ulong indirectOffset, [NativeTypeName("uint32_t")] uint indirectStride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBuildAccelerationStructureKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint infoCount, [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")] VkAccelerationStructureBuildGeometryInfoKHR* pInfos, [NativeTypeName("const VkAccelerationStructureBuildOffsetInfoKHR *const *")] VkAccelerationStructureBuildOffsetInfoKHR** ppOffsetInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCopyAccelerationStructureKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCopyAccelerationStructureInfoKHR *")] VkCopyAccelerationStructureInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCopyAccelerationStructureToMemoryKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCopyAccelerationStructureToMemoryInfoKHR *")] VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCopyMemoryToAccelerationStructureKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCopyMemoryToAccelerationStructureInfoKHR *")] VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkWriteAccelerationStructuresPropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureKHR *")] ulong* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData, [NativeTypeName("size_t")] nuint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyAccelerationStructureKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCopyAccelerationStructureInfoKHR *")] VkCopyAccelerationStructureInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyAccelerationStructureToMemoryKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCopyAccelerationStructureToMemoryInfoKHR *")] VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyMemoryToAccelerationStructureKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCopyMemoryToAccelerationStructureInfoKHR *")] VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdTraceRaysKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkStridedBufferRegionKHR *")] VkStridedBufferRegionKHR* pRaygenShaderBindingTable, [NativeTypeName("const VkStridedBufferRegionKHR *")] VkStridedBufferRegionKHR* pMissShaderBindingTable, [NativeTypeName("const VkStridedBufferRegionKHR *")] VkStridedBufferRegionKHR* pHitShaderBindingTable, [NativeTypeName("const VkStridedBufferRegionKHR *")] VkStridedBufferRegionKHR* pCallableShaderBindingTable, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateRayTracingPipelinesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkRayTracingPipelineCreateInfoKHR *")] VkRayTracingPipelineCreateInfoKHR* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetAccelerationStructureDeviceAddressKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureDeviceAddressInfoKHR *")] VkAccelerationStructureDeviceAddressInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdTraceRaysIndirectKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkStridedBufferRegionKHR *")] VkStridedBufferRegionKHR* pRaygenShaderBindingTable, [NativeTypeName("const VkStridedBufferRegionKHR *")] VkStridedBufferRegionKHR* pMissShaderBindingTable, [NativeTypeName("const VkStridedBufferRegionKHR *")] VkStridedBufferRegionKHR* pHitShaderBindingTable, [NativeTypeName("const VkStridedBufferRegionKHR *")] VkStridedBufferRegionKHR* pCallableShaderBindingTable, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceAccelerationStructureCompatibilityKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureVersionKHR *")] VkAccelerationStructureVersionKHR* version);
    }
}
