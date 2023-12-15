// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

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

    public delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceBufferMemoryRequirementsKHR;

    public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceImageMemoryRequirementsKHR;

    public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetDeviceImageSparseMemoryRequirementsKHR;

    public delegate* unmanaged<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> vkDebugMarkerSetObjectTagEXT;

    public delegate* unmanaged<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> vkDebugMarkerSetObjectNameEXT;

    public delegate* unmanaged<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult> vkCreateCuModuleNVX;

    public delegate* unmanaged<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult> vkCreateCuFunctionNVX;

    public delegate* unmanaged<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> vkDestroyCuModuleNVX;

    public delegate* unmanaged<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> vkDestroyCuFunctionNVX;

    public delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, uint> vkGetImageViewHandleNVX;

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

    public delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoEXT*, ulong*, ulong*, VkResult> vkGetCalibratedTimestampsEXT;

    public delegate* unmanaged<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> vkInitializePerformanceApiINTEL;

    public delegate* unmanaged<VkDevice, void> vkUninitializePerformanceApiINTEL;

    public delegate* unmanaged<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult> vkAcquirePerformanceConfigurationINTEL;

    public delegate* unmanaged<VkDevice, VkPerformanceConfigurationINTEL, VkResult> vkReleasePerformanceConfigurationINTEL;

    public delegate* unmanaged<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> vkGetPerformanceParameterINTEL;

    public delegate* unmanaged<VkDevice, VkSwapchainKHR, uint, void> vkSetLocalDimmingAMD;

    public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferDeviceAddressEXT;

    public delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void> vkResetQueryPoolEXT;

    public delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> vkGetImageSubresourceLayout2EXT;

    public delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetGeneratedCommandsMemoryRequirementsNV;

    public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult> vkCreateIndirectCommandsLayoutNV;

    public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> vkDestroyIndirectCommandsLayoutNV;

    public delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> vkCreatePrivateDataSlotEXT;

    public delegate* unmanaged<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> vkDestroyPrivateDataSlotEXT;

    public delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> vkSetPrivateDataEXT;

    public delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> vkGetPrivateDataEXT;

    public delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, VkResult> vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI;

    public delegate* unmanaged<VkDevice, VkMemoryGetRemoteAddressInfoNV*, void**, VkResult> vkGetMemoryRemoteAddressNV;

    public delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> vkGetPipelinePropertiesEXT;

    public delegate* unmanaged<VkDevice, VkDeviceMemory, float, void> vkSetDeviceMemoryPriorityEXT;

    public delegate* unmanaged<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void> vkGetDescriptorSetLayoutHostMappingInfoVALVE;

    public delegate* unmanaged<VkDevice, VkDescriptorSet, void**, void> vkGetDescriptorSetHostMappingVALVE;

    public delegate* unmanaged<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void> vkGetShaderModuleIdentifierEXT;

    public delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void> vkGetShaderModuleCreateInfoIdentifierEXT;

    public delegate* unmanaged<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult> vkGetFramebufferTilePropertiesQCOM;

    public delegate* unmanaged<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> vkGetDynamicRenderingTilePropertiesQCOM;

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
