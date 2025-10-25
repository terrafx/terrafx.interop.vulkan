// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

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

    public delegate* unmanaged<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void> vkCmdSetRenderingAttachmentLocationsKHR;

    public delegate* unmanaged<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void> vkCmdSetRenderingInputAttachmentIndicesKHR;

    public delegate* unmanaged<VkCommandBuffer, VkVideoEncodeInfoKHR*, void> vkCmdEncodeVideoKHR;

    public delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> vkCmdSetEvent2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> vkCmdResetEvent2KHR;

    public delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> vkCmdWaitEvents2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkDependencyInfo*, void> vkCmdPipelineBarrier2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void> vkCmdWriteTimestamp2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2*, void> vkCmdCopyBuffer2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2*, void> vkCmdCopyImage2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> vkCmdCopyBufferToImage2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> vkCmdCopyImageToBuffer2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2*, void> vkCmdBlitImage2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2*, void> vkCmdResolveImage2KHR;

    public delegate* unmanaged<VkCommandBuffer, ulong, void> vkCmdTraceRaysIndirect2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, VkIndexType, void> vkCmdBindIndexBuffer2KHR;

    public delegate* unmanaged<VkCommandBuffer, uint, ushort, void> vkCmdSetLineStippleKHR;

    public delegate* unmanaged<VkCommandBuffer, VkBindDescriptorSetsInfo*, void> vkCmdBindDescriptorSets2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkPushConstantsInfo*, void> vkCmdPushConstants2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetInfo*, void> vkCmdPushDescriptorSet2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void> vkCmdPushDescriptorSetWithTemplate2KHR;

    public delegate* unmanaged<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void> vkCmdSetDescriptorBufferOffsets2EXT;

    public delegate* unmanaged<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void> vkCmdBindDescriptorBufferEmbeddedSamplers2EXT;

    public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryIndirectInfoKHR*, void> vkCmdCopyMemoryIndirectKHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToImageIndirectInfoKHR*, void> vkCmdCopyMemoryToImageIndirectKHR;

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

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDiscardRectangleEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkDiscardRectangleModeEXT, void> vkCmdSetDiscardRectangleModeEXT;

    public delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdBeginDebugUtilsLabelEXT;

    public delegate* unmanaged<VkCommandBuffer, void> vkCmdEndDebugUtilsLabelEXT;

    public delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdInsertDebugUtilsLabelEXT;

    public delegate* unmanaged<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> vkCmdSetSampleLocationsEXT;

    public delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindShadingRateImageNV;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void> vkCmdSetViewportShadingRatePaletteNV;

    public delegate* unmanaged<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> vkCmdSetCoarseSampleOrderNV;

    public delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, ulong, uint, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void> vkCmdBuildAccelerationStructureNV;

    public delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void> vkCmdCopyAccelerationStructureNV;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void> vkCmdTraceRaysNV;

    public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesNV;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, ulong, uint, void> vkCmdWriteBufferMarkerAMD;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlags2, VkBuffer, ulong, uint, void> vkCmdWriteBufferMarker2AMD;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, void> vkCmdDrawMeshTasksNV;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectNV;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectCountNV;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, uint*, void> vkCmdSetExclusiveScissorEnableNV;

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

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDepthTestEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDepthWriteEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkCompareOp, void> vkCmdSetDepthCompareOpEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDepthBoundsTestEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetStencilTestEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> vkCmdSetStencilOpEXT;

    public delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> vkCmdPreprocessGeneratedCommandsNV;

    public delegate* unmanaged<VkCommandBuffer, uint, VkGeneratedCommandsInfoNV*, void> vkCmdExecuteGeneratedCommandsNV;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void> vkCmdBindPipelineShaderGroupNV;

    public delegate* unmanaged<VkCommandBuffer, VkDepthBiasInfoEXT*, void> vkCmdSetDepthBias2EXT;

    public delegate* unmanaged<VkCommandBuffer, VkDispatchTileInfoQCOM*, void> vkCmdDispatchTileQCOM;

    public delegate* unmanaged<VkCommandBuffer, VkPerTileBeginInfoQCOM*, void> vkCmdBeginPerTileExecutionQCOM;

    public delegate* unmanaged<VkCommandBuffer, VkPerTileEndInfoQCOM*, void> vkCmdEndPerTileExecutionQCOM;

    public delegate* unmanaged<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void> vkCmdBindDescriptorBuffersEXT;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, ulong*, void> vkCmdSetDescriptorBufferOffsetsEXT;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void> vkCmdBindDescriptorBufferEmbeddedSamplersEXT;

    public delegate* unmanaged<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void> vkCmdSetFragmentShadingRateEnumNV;

    public delegate* unmanaged<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void> vkCmdSetVertexInputEXT;

    public delegate* unmanaged<VkCommandBuffer, void> vkCmdSubpassShadingHUAWEI;

    public delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindInvocationMaskHUAWEI;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetPatchControlPointsEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetRasterizerDiscardEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDepthBiasEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkLogicOp, void> vkCmdSetLogicOpEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetPrimitiveRestartEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint*, void> vkCmdSetColorWriteEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void> vkCmdDrawMultiEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void> vkCmdDrawMultiIndexedEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void> vkCmdBuildMicromapsEXT;

    public delegate* unmanaged<VkCommandBuffer, VkCopyMicromapInfoEXT*, void> vkCmdCopyMicromapEXT;

    public delegate* unmanaged<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void> vkCmdCopyMicromapToMemoryEXT;

    public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void> vkCmdCopyMemoryToMicromapEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteMicromapsPropertiesEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> vkCmdDrawClusterHUAWEI;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void> vkCmdDrawClusterIndirectHUAWEI;

    public delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, void> vkCmdCopyMemoryIndirectNV;

    public delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void> vkCmdCopyMemoryToImageIndirectNV;

    public delegate* unmanaged<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void> vkCmdDecompressMemoryNV;

    public delegate* unmanaged<VkCommandBuffer, ulong, ulong, uint, void> vkCmdDecompressMemoryIndirectCountNV;

    public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> vkCmdUpdatePipelineIndirectBufferNV;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDepthClampEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkPolygonMode, void> vkCmdSetPolygonModeEXT;

    public delegate* unmanaged<VkCommandBuffer, VkSampleCountFlags, void> vkCmdSetRasterizationSamplesEXT;

    public delegate* unmanaged<VkCommandBuffer, VkSampleCountFlags, uint*, void> vkCmdSetSampleMaskEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetAlphaToCoverageEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetAlphaToOneEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetLogicOpEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, uint*, void> vkCmdSetColorBlendEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void> vkCmdSetColorBlendEquationEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorComponentFlags*, void> vkCmdSetColorWriteMaskEXT;

    public delegate* unmanaged<VkCommandBuffer, VkTessellationDomainOrigin, void> vkCmdSetTessellationDomainOriginEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetRasterizationStreamEXT;

    public delegate* unmanaged<VkCommandBuffer, VkConservativeRasterizationModeEXT, void> vkCmdSetConservativeRasterizationModeEXT;

    public delegate* unmanaged<VkCommandBuffer, float, void> vkCmdSetExtraPrimitiveOverestimationSizeEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDepthClipEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetSampleLocationsEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void> vkCmdSetColorBlendAdvancedEXT;

    public delegate* unmanaged<VkCommandBuffer, VkProvokingVertexModeEXT, void> vkCmdSetProvokingVertexModeEXT;

    public delegate* unmanaged<VkCommandBuffer, VkLineRasterizationMode, void> vkCmdSetLineRasterizationModeEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetLineStippleEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetDepthClipNegativeOneToOneEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetViewportWScalingEnableNV;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void> vkCmdSetViewportSwizzleNV;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetCoverageToColorEnableNV;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetCoverageToColorLocationNV;

    public delegate* unmanaged<VkCommandBuffer, VkCoverageModulationModeNV, void> vkCmdSetCoverageModulationModeNV;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetCoverageModulationTableEnableNV;

    public delegate* unmanaged<VkCommandBuffer, uint, float*, void> vkCmdSetCoverageModulationTableNV;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetShadingRateImageEnableNV;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetRepresentativeFragmentTestEnableNV;

    public delegate* unmanaged<VkCommandBuffer, VkCoverageReductionModeNV, void> vkCmdSetCoverageReductionModeNV;

    public delegate* unmanaged<VkCommandBuffer, VkCopyTensorInfoARM*, void> vkCmdCopyTensorARM;

    public delegate* unmanaged<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void> vkCmdOpticalFlowExecuteNV;

    public delegate* unmanaged<VkCommandBuffer, uint, VkShaderStageFlags*, VkShaderEXT*, void> vkCmdBindShadersEXT;

    public delegate* unmanaged<VkCommandBuffer, VkDepthClampModeEXT, VkDepthClampRangeEXT*, void> vkCmdSetDepthClampRangeEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkConvertCooperativeVectorMatrixInfoNV*, void> vkCmdConvertCooperativeVectorMatrixNV;

    public delegate* unmanaged<VkCommandBuffer, VkDataGraphPipelineSessionARM, VkDataGraphPipelineDispatchInfoARM*, void> vkCmdDispatchDataGraphARM;

    public delegate* unmanaged<VkCommandBuffer, VkImageAspectFlags, void> vkCmdSetAttachmentFeedbackLoopEnableEXT;

    public delegate* unmanaged<VkCommandBuffer, VkTileMemoryBindInfoQCOM*, void> vkCmdBindTileMemoryQCOM;

    public delegate* unmanaged<VkCommandBuffer, VkClusterAccelerationStructureCommandsInfoNV*, void> vkCmdBuildClusterAccelerationStructureIndirectNV;

    public delegate* unmanaged<VkCommandBuffer, VkBuildPartitionedAccelerationStructureInfoNV*, void> vkCmdBuildPartitionedAccelerationStructuresNV;

    public delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoEXT*, VkCommandBuffer, void> vkCmdPreprocessGeneratedCommandsEXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkGeneratedCommandsInfoEXT*, void> vkCmdExecuteGeneratedCommandsEXT;

    public delegate* unmanaged<VkCommandBuffer, VkRenderingEndInfoEXT*, void> vkCmdEndRendering2EXT;

    public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void> vkCmdBuildAccelerationStructuresKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, ulong*, uint*, uint**, void> vkCmdBuildAccelerationStructuresIndirectKHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> vkCmdCopyAccelerationStructureKHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> vkCmdCopyAccelerationStructureToMemoryKHR;

    public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> vkCmdCopyMemoryToAccelerationStructureKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesKHR;

    public delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void> vkCmdTraceRaysKHR;

    public delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, ulong, void> vkCmdTraceRaysIndirectKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, void> vkCmdSetRayTracingPipelineStackSizeKHR;

    public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> vkCmdDrawMeshTasksEXT;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectEXT;

    public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectCountEXT;
}
