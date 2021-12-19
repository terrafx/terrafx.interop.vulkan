// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceManualImports
    {
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

        public delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> vkGetPhysicalDeviceFragmentShadingRatesKHR;

        public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, VkExternalMemoryHandleTypeFlagsNV, VkExternalImageFormatPropertiesNV*, VkResult> vkGetPhysicalDeviceExternalImageFormatPropertiesNV;

        public delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> vkReleaseDisplayEXT;

        public delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2EXT;

        public delegate* unmanaged<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void> vkGetPhysicalDeviceMultisamplePropertiesEXT;

        public delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainEXT*, VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;

        public delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolPropertiesEXT*, VkResult> vkGetPhysicalDeviceToolPropertiesEXT;

        public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;

        public delegate* unmanaged<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;

        public delegate* unmanaged<VkPhysicalDevice, int, VkDisplayKHR, VkResult> vkAcquireDrmDisplayEXT;

        public delegate* unmanaged<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult> vkGetDrmDisplayEXT;

        public delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> vkAcquireWinrtDisplayNV;

        public delegate* unmanaged<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult> vkGetWinrtDisplayNV;
    }
}
