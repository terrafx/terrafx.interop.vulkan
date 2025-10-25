// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceManualImports
{
    public delegate* unmanaged<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult> vkCreateVideoSessionKHR;

    public delegate* unmanaged<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> vkDestroyVideoSessionKHR;

    public delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult> vkGetVideoSessionMemoryRequirementsKHR;

    public delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult> vkBindVideoSessionMemoryKHR;

    public delegate* unmanaged<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult> vkCreateVideoSessionParametersKHR;

    public delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult> vkUpdateVideoSessionParametersKHR;

    public delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void> vkDestroyVideoSessionParametersKHR;

    public delegate* unmanaged<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void> vkGetDeviceGroupPeerMemoryFeaturesKHR;

    public delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> vkTrimCommandPoolKHR;

    public delegate* unmanaged<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult> vkGetMemoryFdKHR;

    public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlags, int, VkMemoryFdPropertiesKHR*, VkResult> vkGetMemoryFdPropertiesKHR;

    public delegate* unmanaged<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> vkImportSemaphoreFdKHR;

    public delegate* unmanaged<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult> vkGetSemaphoreFdKHR;

    public delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> vkCreateDescriptorUpdateTemplateKHR;

    public delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> vkDestroyDescriptorUpdateTemplateKHR;

    public delegate* unmanaged<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> vkUpdateDescriptorSetWithTemplateKHR;

    public delegate* unmanaged<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> vkCreateRenderPass2KHR;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> vkGetSwapchainStatusKHR;

    public delegate* unmanaged<VkDevice, VkImportFenceFdInfoKHR*, VkResult> vkImportFenceFdKHR;

    public delegate* unmanaged<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult> vkGetFenceFdKHR;

    public delegate* unmanaged<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> vkAcquireProfilingLockKHR;

    public delegate* unmanaged<VkDevice, void> vkReleaseProfilingLockKHR;

    public delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetImageMemoryRequirements2KHR;

    public delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetBufferMemoryRequirements2KHR;

    public delegate* unmanaged<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetImageSparseMemoryRequirements2KHR;

    public delegate* unmanaged<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> vkCreateSamplerYcbcrConversionKHR;

    public delegate* unmanaged<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> vkDestroySamplerYcbcrConversionKHR;

    public delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> vkBindBufferMemory2KHR;

    public delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> vkBindImageMemory2KHR;

    public delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> vkGetDescriptorSetLayoutSupportKHR;

    public delegate* unmanaged<VkDevice, VkSemaphore, ulong*, VkResult> vkGetSemaphoreCounterValueKHR;

    public delegate* unmanaged<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> vkWaitSemaphoresKHR;

    public delegate* unmanaged<VkDevice, VkSemaphoreSignalInfo*, VkResult> vkSignalSemaphoreKHR;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult> vkWaitForPresentKHR;

    public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferDeviceAddressKHR;

    public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferOpaqueCaptureAddressKHR;

    public delegate* unmanaged<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> vkGetDeviceMemoryOpaqueCaptureAddressKHR;

    public delegate* unmanaged<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult> vkCreateDeferredOperationKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void> vkDestroyDeferredOperationKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint> vkGetDeferredOperationMaxConcurrencyKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult> vkGetDeferredOperationResultKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult> vkDeferredOperationJoinKHR;

    public delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult> vkGetPipelineExecutablePropertiesKHR;

    public delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult> vkGetPipelineExecutableStatisticsKHR;

    public delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult> vkGetPipelineExecutableInternalRepresentationsKHR;

    public delegate* unmanaged<VkDevice, VkMemoryMapInfo*, void**, VkResult> vkMapMemory2KHR;

    public delegate* unmanaged<VkDevice, VkMemoryUnmapInfo*, VkResult> vkUnmapMemory2KHR;

    public delegate* unmanaged<VkDevice, VkVideoEncodeSessionParametersGetInfoKHR*, VkVideoEncodeSessionParametersFeedbackInfoKHR*, nuint*, void*, VkResult> vkGetEncodedVideoSessionParametersKHR;

    public delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceBufferMemoryRequirementsKHR;

    public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceImageMemoryRequirementsKHR;

    public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetDeviceImageSparseMemoryRequirementsKHR;

    public delegate* unmanaged<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void> vkGetRenderingAreaGranularityKHR;

    public delegate* unmanaged<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void> vkGetDeviceImageSubresourceLayoutKHR;

    public delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void> vkGetImageSubresourceLayout2KHR;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkPresentWait2InfoKHR*, VkResult> vkWaitForPresent2KHR;

    public delegate* unmanaged<VkDevice, VkPipelineBinaryCreateInfoKHR*, VkAllocationCallbacks*, VkPipelineBinaryHandlesInfoKHR*, VkResult> vkCreatePipelineBinariesKHR;

    public delegate* unmanaged<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void> vkDestroyPipelineBinaryKHR;

    public delegate* unmanaged<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult> vkGetPipelineKeyKHR;

    public delegate* unmanaged<VkDevice, VkPipelineBinaryDataInfoKHR*, VkPipelineBinaryKeyKHR*, nuint*, void*, VkResult> vkGetPipelineBinaryDataKHR;

    public delegate* unmanaged<VkDevice, VkReleaseCapturedPipelineDataInfoKHR*, VkAllocationCallbacks*, VkResult> vkReleaseCapturedPipelineDataKHR;

    public delegate* unmanaged<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult> vkReleaseSwapchainImagesKHR;

    public delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoKHR*, ulong*, ulong*, VkResult> vkGetCalibratedTimestampsKHR;

    public delegate* unmanaged<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> vkDebugMarkerSetObjectTagEXT;

    public delegate* unmanaged<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> vkDebugMarkerSetObjectNameEXT;

    public delegate* unmanaged<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult> vkCreateCuModuleNVX;

    public delegate* unmanaged<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult> vkCreateCuFunctionNVX;

    public delegate* unmanaged<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> vkDestroyCuModuleNVX;

    public delegate* unmanaged<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> vkDestroyCuFunctionNVX;

    public delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, uint> vkGetImageViewHandleNVX;

    public delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, ulong> vkGetImageViewHandle64NVX;

    public delegate* unmanaged<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> vkGetImageViewAddressNVX;

    public delegate* unmanaged<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, nuint*, void*, VkResult> vkGetShaderInfoAMD;

    public delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> vkDisplayPowerControlEXT;

    public delegate* unmanaged<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> vkRegisterDeviceEventEXT;

    public delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> vkRegisterDisplayEventEXT;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagsEXT, ulong*, VkResult> vkGetSwapchainCounterEXT;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult> vkGetRefreshCycleDurationGOOGLE;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult> vkGetPastPresentationTimingGOOGLE;

    public delegate* unmanaged<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void> vkSetHdrMetadataEXT;

    public delegate* unmanaged<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> vkSetDebugUtilsObjectNameEXT;

    public delegate* unmanaged<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> vkSetDebugUtilsObjectTagEXT;

    public delegate* unmanaged<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> vkGetImageDrmFormatModifierPropertiesEXT;

    public delegate* unmanaged<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult> vkCreateValidationCacheEXT;

    public delegate* unmanaged<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void> vkDestroyValidationCacheEXT;

    public delegate* unmanaged<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult> vkMergeValidationCachesEXT;

    public delegate* unmanaged<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult> vkGetValidationCacheDataEXT;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult> vkCreateAccelerationStructureNV;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void> vkDestroyAccelerationStructureNV;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetAccelerationStructureMemoryRequirementsNV;

    public delegate* unmanaged<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> vkBindAccelerationStructureMemoryNV;

    public delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateRayTracingPipelinesNV;

    public delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> vkGetRayTracingShaderGroupHandlesKHR;

    public delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> vkGetRayTracingShaderGroupHandlesNV;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult> vkGetAccelerationStructureHandleNV;

    public delegate* unmanaged<VkDevice, VkPipeline, uint, VkResult> vkCompileDeferredNV;

    public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlags, void*, VkMemoryHostPointerPropertiesEXT*, VkResult> vkGetMemoryHostPointerPropertiesEXT;

    public delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoKHR*, ulong*, ulong*, VkResult> vkGetCalibratedTimestampsEXT;

    public delegate* unmanaged<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> vkInitializePerformanceApiINTEL;

    public delegate* unmanaged<VkDevice, void> vkUninitializePerformanceApiINTEL;

    public delegate* unmanaged<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult> vkAcquirePerformanceConfigurationINTEL;

    public delegate* unmanaged<VkDevice, VkPerformanceConfigurationINTEL, VkResult> vkReleasePerformanceConfigurationINTEL;

    public delegate* unmanaged<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> vkGetPerformanceParameterINTEL;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, uint, void> vkSetLocalDimmingAMD;

    public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferDeviceAddressEXT;

    public delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void> vkResetQueryPoolEXT;

    public delegate* unmanaged<VkDevice, VkCopyMemoryToImageInfo*, VkResult> vkCopyMemoryToImageEXT;

    public delegate* unmanaged<VkDevice, VkCopyImageToMemoryInfo*, VkResult> vkCopyImageToMemoryEXT;

    public delegate* unmanaged<VkDevice, VkCopyImageToImageInfo*, VkResult> vkCopyImageToImageEXT;

    public delegate* unmanaged<VkDevice, uint, VkHostImageLayoutTransitionInfo*, VkResult> vkTransitionImageLayoutEXT;

    public delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void> vkGetImageSubresourceLayout2EXT;

    public delegate* unmanaged<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult> vkReleaseSwapchainImagesEXT;

    public delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetGeneratedCommandsMemoryRequirementsNV;

    public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult> vkCreateIndirectCommandsLayoutNV;

    public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> vkDestroyIndirectCommandsLayoutNV;

    public delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> vkCreatePrivateDataSlotEXT;

    public delegate* unmanaged<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> vkDestroyPrivateDataSlotEXT;

    public delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> vkSetPrivateDataEXT;

    public delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> vkGetPrivateDataEXT;

    public delegate* unmanaged<VkDevice, VkDescriptorSetLayout, ulong*, void> vkGetDescriptorSetLayoutSizeEXT;

    public delegate* unmanaged<VkDevice, VkDescriptorSetLayout, uint, ulong*, void> vkGetDescriptorSetLayoutBindingOffsetEXT;

    public delegate* unmanaged<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void> vkGetDescriptorEXT;

    public delegate* unmanaged<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetBufferOpaqueCaptureDescriptorDataEXT;

    public delegate* unmanaged<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetImageOpaqueCaptureDescriptorDataEXT;

    public delegate* unmanaged<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetImageViewOpaqueCaptureDescriptorDataEXT;

    public delegate* unmanaged<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetSamplerOpaqueCaptureDescriptorDataEXT;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult> vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT;

    public delegate* unmanaged<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult> vkGetDeviceFaultInfoEXT;

    public delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, VkResult> vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI;

    public delegate* unmanaged<VkDevice, VkMemoryGetRemoteAddressInfoNV*, void**, VkResult> vkGetMemoryRemoteAddressNV;

    public delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> vkGetPipelinePropertiesEXT;

    public delegate* unmanaged<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult> vkCreateMicromapEXT;

    public delegate* unmanaged<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void> vkDestroyMicromapEXT;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult> vkBuildMicromapsEXT;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult> vkCopyMicromapEXT;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult> vkCopyMicromapToMemoryEXT;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult> vkCopyMemoryToMicromapEXT;

    public delegate* unmanaged<VkDevice, uint, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult> vkWriteMicromapsPropertiesEXT;

    public delegate* unmanaged<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void> vkGetDeviceMicromapCompatibilityEXT;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void> vkGetMicromapBuildSizesEXT;

    public delegate* unmanaged<VkDevice, VkDeviceMemory, float, void> vkSetDeviceMemoryPriorityEXT;

    public delegate* unmanaged<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void> vkGetDescriptorSetLayoutHostMappingInfoVALVE;

    public delegate* unmanaged<VkDevice, VkDescriptorSet, void**, void> vkGetDescriptorSetHostMappingVALVE;

    public delegate* unmanaged<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void> vkGetPipelineIndirectMemoryRequirementsNV;

    public delegate* unmanaged<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, ulong> vkGetPipelineIndirectDeviceAddressNV;

    public delegate* unmanaged<VkDevice, VkTensorCreateInfoARM*, VkAllocationCallbacks*, VkTensorARM*, VkResult> vkCreateTensorARM;

    public delegate* unmanaged<VkDevice, VkTensorARM, VkAllocationCallbacks*, void> vkDestroyTensorARM;

    public delegate* unmanaged<VkDevice, VkTensorViewCreateInfoARM*, VkAllocationCallbacks*, VkTensorViewARM*, VkResult> vkCreateTensorViewARM;

    public delegate* unmanaged<VkDevice, VkTensorViewARM, VkAllocationCallbacks*, void> vkDestroyTensorViewARM;

    public delegate* unmanaged<VkDevice, VkTensorMemoryRequirementsInfoARM*, VkMemoryRequirements2*, void> vkGetTensorMemoryRequirementsARM;

    public delegate* unmanaged<VkDevice, uint, VkBindTensorMemoryInfoARM*, VkResult> vkBindTensorMemoryARM;

    public delegate* unmanaged<VkDevice, VkDeviceTensorMemoryRequirementsARM*, VkMemoryRequirements2*, void> vkGetDeviceTensorMemoryRequirementsARM;

    public delegate* unmanaged<VkDevice, VkTensorCaptureDescriptorDataInfoARM*, void*, VkResult> vkGetTensorOpaqueCaptureDescriptorDataARM;

    public delegate* unmanaged<VkDevice, VkTensorViewCaptureDescriptorDataInfoARM*, void*, VkResult> vkGetTensorViewOpaqueCaptureDescriptorDataARM;

    public delegate* unmanaged<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void> vkGetShaderModuleIdentifierEXT;

    public delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void> vkGetShaderModuleCreateInfoIdentifierEXT;

    public delegate* unmanaged<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult> vkCreateOpticalFlowSessionNV;

    public delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void> vkDestroyOpticalFlowSessionNV;

    public delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult> vkBindOpticalFlowSessionImageNV;

    public delegate* unmanaged<VkDevice, VkAntiLagDataAMD*, void> vkAntiLagUpdateAMD;

    public delegate* unmanaged<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult> vkCreateShadersEXT;

    public delegate* unmanaged<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void> vkDestroyShaderEXT;

    public delegate* unmanaged<VkDevice, VkShaderEXT, nuint*, void*, VkResult> vkGetShaderBinaryDataEXT;

    public delegate* unmanaged<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult> vkGetFramebufferTilePropertiesQCOM;

    public delegate* unmanaged<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> vkGetDynamicRenderingTilePropertiesQCOM;

    public delegate* unmanaged<VkDevice, VkConvertCooperativeVectorMatrixInfoNV*, VkResult> vkConvertCooperativeVectorMatrixNV;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult> vkSetLatencySleepModeNV;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult> vkLatencySleepNV;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void> vkSetLatencyMarkerNV;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkGetLatencyMarkerInfoNV*, void> vkGetLatencyTimingsNV;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkDataGraphPipelineCreateInfoARM*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateDataGraphPipelinesARM;

    public delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionCreateInfoARM*, VkAllocationCallbacks*, VkDataGraphPipelineSessionARM*, VkResult> vkCreateDataGraphPipelineSessionARM;

    public delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionBindPointRequirementsInfoARM*, uint*, VkDataGraphPipelineSessionBindPointRequirementARM*, VkResult> vkGetDataGraphPipelineSessionBindPointRequirementsARM;

    public delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionMemoryRequirementsInfoARM*, VkMemoryRequirements2*, void> vkGetDataGraphPipelineSessionMemoryRequirementsARM;

    public delegate* unmanaged<VkDevice, uint, VkBindDataGraphPipelineSessionMemoryInfoARM*, VkResult> vkBindDataGraphPipelineSessionMemoryARM;

    public delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionARM, VkAllocationCallbacks*, void> vkDestroyDataGraphPipelineSessionARM;

    public delegate* unmanaged<VkDevice, VkDataGraphPipelineInfoARM*, uint*, VkDataGraphPipelinePropertyARM*, VkResult> vkGetDataGraphPipelineAvailablePropertiesARM;

    public delegate* unmanaged<VkDevice, VkDataGraphPipelineInfoARM*, uint, VkDataGraphPipelinePropertyQueryResultARM*, VkResult> vkGetDataGraphPipelinePropertiesARM;

    public delegate* unmanaged<VkDevice, VkExternalComputeQueueCreateInfoNV*, VkAllocationCallbacks*, VkExternalComputeQueueNV*, VkResult> vkCreateExternalComputeQueueNV;

    public delegate* unmanaged<VkDevice, VkExternalComputeQueueNV, VkAllocationCallbacks*, void> vkDestroyExternalComputeQueueNV;

    public delegate* unmanaged<VkExternalComputeQueueNV, VkExternalComputeQueueDataParamsNV*, void*, void> vkGetExternalComputeQueueDataNV;

    public delegate* unmanaged<VkDevice, VkClusterAccelerationStructureInputInfoNV*, VkAccelerationStructureBuildSizesInfoKHR*, void> vkGetClusterAccelerationStructureBuildSizesNV;

    public delegate* unmanaged<VkDevice, VkPartitionedAccelerationStructureInstancesInputNV*, VkAccelerationStructureBuildSizesInfoKHR*, void> vkGetPartitionedAccelerationStructuresBuildSizesNV;

    public delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoEXT*, VkMemoryRequirements2*, void> vkGetGeneratedCommandsMemoryRequirementsEXT;

    public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectCommandsLayoutEXT*, VkResult> vkCreateIndirectCommandsLayoutEXT;

    public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutEXT, VkAllocationCallbacks*, void> vkDestroyIndirectCommandsLayoutEXT;

    public delegate* unmanaged<VkDevice, VkIndirectExecutionSetCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectExecutionSetEXT*, VkResult> vkCreateIndirectExecutionSetEXT;

    public delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, VkAllocationCallbacks*, void> vkDestroyIndirectExecutionSetEXT;

    public delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetPipelineEXT*, void> vkUpdateIndirectExecutionSetPipelineEXT;

    public delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetShaderEXT*, void> vkUpdateIndirectExecutionSetShaderEXT;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult> vkCreateAccelerationStructureKHR;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void> vkDestroyAccelerationStructureKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> vkBuildAccelerationStructuresKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult> vkCopyAccelerationStructureKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult> vkCopyAccelerationStructureToMemoryKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult> vkCopyMemoryToAccelerationStructureKHR;

    public delegate* unmanaged<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult> vkWriteAccelerationStructuresPropertiesKHR;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, ulong> vkGetAccelerationStructureDeviceAddressKHR;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void> vkGetDeviceAccelerationStructureCompatibilityKHR;

    public delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void> vkGetAccelerationStructureBuildSizesKHR;

    public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateRayTracingPipelinesKHR;

    public delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR;

    public delegate* unmanaged<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, ulong> vkGetRayTracingShaderGroupStackSizeKHR;
}
