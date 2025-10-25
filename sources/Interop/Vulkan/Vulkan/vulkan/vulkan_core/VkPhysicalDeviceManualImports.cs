// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceManualImports
{
    public delegate* unmanaged<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult> vkGetPhysicalDeviceVideoCapabilitiesKHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult> vkGetPhysicalDeviceVideoFormatPropertiesKHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> vkGetPhysicalDeviceFeatures2KHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> vkGetPhysicalDeviceProperties2KHR;

    public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> vkGetPhysicalDeviceFormatProperties2KHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> vkGetPhysicalDeviceImageFormatProperties2KHR;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> vkGetPhysicalDeviceQueueFamilyProperties2KHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> vkGetPhysicalDeviceMemoryProperties2KHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> vkGetPhysicalDeviceSparseImageFormatProperties2KHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> vkGetPhysicalDeviceExternalBufferPropertiesKHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> vkGetPhysicalDeviceExternalSemaphorePropertiesKHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> vkGetPhysicalDeviceExternalFencePropertiesKHR;

    public delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;

    public delegate* unmanaged<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2KHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult> vkGetPhysicalDeviceSurfaceFormats2KHR;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> vkGetPhysicalDeviceFragmentShadingRatesKHR;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*, VkVideoEncodeQualityLevelPropertiesKHR*, VkResult> vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesKHR*, VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainKHR*, VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsKHR;

    public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, VkExternalMemoryHandleTypeFlagsNV, VkExternalImageFormatPropertiesNV*, VkResult> vkGetPhysicalDeviceExternalImageFormatPropertiesNV;

    public delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> vkReleaseDisplayEXT;

    public delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2EXT;

    public delegate* unmanaged<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void> vkGetPhysicalDeviceMultisamplePropertiesEXT;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainKHR*, VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> vkGetPhysicalDeviceToolPropertiesEXT;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;

    public delegate* unmanaged<VkPhysicalDevice, int, VkDisplayKHR, VkResult> vkAcquireDrmDisplayEXT;

    public delegate* unmanaged<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult> vkGetDrmDisplayEXT;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalTensorInfoARM*, VkExternalTensorPropertiesARM*, void> vkGetPhysicalDeviceExternalTensorPropertiesARM;

    public delegate* unmanaged<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult> vkGetPhysicalDeviceOpticalFlowImageFormatsNV;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeVectorPropertiesNV*, VkResult> vkGetPhysicalDeviceCooperativeVectorPropertiesNV;

    public delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkQueueFamilyDataGraphPropertiesARM*, VkResult> vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM;

    public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM*, VkQueueFamilyDataGraphProcessingEnginePropertiesARM*, void> vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM;

    public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixFlexibleDimensionsPropertiesNV*, VkResult> vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV;
}
