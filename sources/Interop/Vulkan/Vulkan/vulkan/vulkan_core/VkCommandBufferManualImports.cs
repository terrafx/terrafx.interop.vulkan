// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkCommandBufferManualImports
{
    public delegate* unmanaged<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void> vkCmdBeginVideoCodingKHR;

    public delegate* unmanaged<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void> vkCmdEndVideoCodingKHR;

    public delegate* unmanaged<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void> vkCmdControlVideoCodingKHR;

    public delegate* unmanaged<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> vkCmdDecodeVideoKHR;

    public delegate* unmanaged<VkCommandBuffer, VkRenderingInfo*, void> vkCmdBeginRenderingKHR;

    public delegate* unmanaged<VkCommandBuffer, void> vkCmdEndRenderingKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDeviceMaskKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> vkCmdDispatchBaseKHR;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void> vkCmdPushDescriptorSetKHR;

    public delegate* unmanaged<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> vkCmdPushDescriptorSetWithTemplateKHR;

    public delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> vkCmdBeginRenderPass2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> vkCmdNextSubpass2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkSubpassEndInfo*, void> vkCmdEndRenderPass2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirectCountKHR;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndexedIndirectCountKHR;

    public delegate* unmanaged<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void> vkCmdSetFragmentShadingRateKHR;

    public delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> vkCmdSetEvent2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> vkCmdResetEvent2KHR;

    public delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> vkCmdWaitEvents2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkDependencyInfo*, void> vkCmdPipelineBarrier2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void> vkCmdWriteTimestamp2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags2, VkBuffer, ulong, uint, void> vkCmdWriteBufferMarker2AMD;

    public delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2*, void> vkCmdCopyBuffer2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2*, void> vkCmdCopyImage2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> vkCmdCopyBufferToImage2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> vkCmdCopyImageToBuffer2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2*, void> vkCmdBlitImage2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2*, void> vkCmdResolveImage2KHR;

    public delegate* unmanaged<VkCommandBuffer, ulong, void> vkCmdTraceRaysIndirect2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> vkCmdDebugMarkerBeginEXT;

    public delegate* unmanaged<VkCommandBuffer, void> vkCmdDebugMarkerEndEXT;

    public delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> vkCmdDebugMarkerInsertEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, void> vkCmdBindTransformFeedbackBuffersEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> vkCmdBeginTransformFeedbackEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> vkCmdEndTransformFeedbackEXT;

    public delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, uint, void> vkCmdBeginQueryIndexedEXT;

    public delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void> vkCmdEndQueryIndexedEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirectByteCountEXT;

    public delegate* unmanaged<VkCommandBuffer, VkCuLaunchInfoNVX*, void> vkCmdCuLaunchKernelNVX;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirectCountAMD;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndexedIndirectCountAMD;

    public delegate* unmanaged<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> vkCmdBeginConditionalRenderingEXT;

    public delegate* unmanaged<VkCommandBuffer, void> vkCmdEndConditionalRenderingEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void> vkCmdSetViewportWScalingNV;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetDiscardRectangleEXT;

    public delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdBeginDebugUtilsLabelEXT;

    public delegate* unmanaged<VkCommandBuffer, void> vkCmdEndDebugUtilsLabelEXT;

    public delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdInsertDebugUtilsLabelEXT;

    public delegate* unmanaged<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> vkCmdSetSampleLocationsEXT;

    public delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindShadingRateImageNV;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void> vkCmdSetViewportShadingRatePaletteNV;

    public delegate* unmanaged<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> vkCmdSetCoarseSampleOrderNV;

    public delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, ulong, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void> vkCmdBuildAccelerationStructureNV;

    public delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void> vkCmdCopyAccelerationStructureNV;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void> vkCmdTraceRaysNV;

    public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesNV;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, ulong, uint, void> vkCmdWriteBufferMarkerAMD;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, void> vkCmdDrawMeshTasksNV;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectNV;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectCountNV;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetExclusiveScissorNV;

    public delegate* unmanaged<VkCommandBuffer, void*, void> vkCmdSetCheckpointNV;

    public delegate* unmanaged<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> vkCmdSetPerformanceMarkerINTEL;

    public delegate* unmanaged<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult> vkCmdSetPerformanceStreamMarkerINTEL;

    public delegate* unmanaged<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> vkCmdSetPerformanceOverrideINTEL;

    public delegate* unmanaged<VkCommandBuffer, uint, ushort, void> vkCmdSetLineStippleEXT;

    public delegate* unmanaged<VkCommandBuffer, VkCullModeFlags, void> vkCmdSetCullModeEXT;

    public delegate* unmanaged<VkCommandBuffer, VkFrontFace, void> vkCmdSetFrontFaceEXT;

    public delegate* unmanaged<VkCommandBuffer, VkPrimitiveTopology, void> vkCmdSetPrimitiveTopologyEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkViewport*, void> vkCmdSetViewportWithCountEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkRect2D*, void> vkCmdSetScissorWithCountEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void> vkCmdBindVertexBuffers2EXT;

    public delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetDepthTestEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetDepthWriteEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkCompareOp, void> vkCmdSetDepthCompareOpEXT;

    public delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetDepthBoundsTestEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetStencilTestEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> vkCmdSetStencilOpEXT;

    public delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> vkCmdPreprocessGeneratedCommandsNV;

    public delegate* unmanaged<VkCommandBuffer, VkBool32, VkGeneratedCommandsInfoNV*, void> vkCmdExecuteGeneratedCommandsNV;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void> vkCmdBindPipelineShaderGroupNV;

    public delegate* unmanaged<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void> vkCmdSetFragmentShadingRateEnumNV;

    public delegate* unmanaged<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void> vkCmdSetVertexInputEXT;

    public delegate* unmanaged<VkCommandBuffer, void> vkCmdSubpassShadingHUAWEI;

    public delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindInvocationMaskHUAWEI;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetPatchControlPointsEXT;

    public delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetRasterizerDiscardEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetDepthBiasEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkLogicOp, void> vkCmdSetLogicOpEXT;

    public delegate* unmanaged<VkCommandBuffer, VkBool32, void> vkCmdSetPrimitiveRestartEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkBool32*, void> vkCmdSetColorWriteEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void> vkCmdDrawMultiEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void> vkCmdDrawMultiIndexedEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void> vkCmdBuildAccelerationStructuresKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, ulong*, uint*, uint**, void> vkCmdBuildAccelerationStructuresIndirectKHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> vkCmdCopyAccelerationStructureKHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> vkCmdCopyAccelerationStructureToMemoryKHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> vkCmdCopyMemoryToAccelerationStructureKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesKHR;

    public delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void> vkCmdTraceRaysKHR;

    public delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, ulong, void> vkCmdTraceRaysIndirectKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetRayTracingPipelineStackSizeKHR;
}
