// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", EntryPoint = "vkCreateInstance", ExactSpelling = true)]
        public static extern VkResult vkCreateInstance([NativeTypeName("const VkInstanceCreateInfo *")] VkInstanceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkInstance *")] IntPtr* pInstance);

        [DllImport("vulkan", EntryPoint = "vkDestroyInstance", ExactSpelling = true)]
        public static extern void vkDestroyInstance([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkEnumeratePhysicalDevices", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDevices([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceCount, [NativeTypeName("VkPhysicalDevice *")] IntPtr* pPhysicalDevices);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures *")] VkPhysicalDeviceFeatures* pFeatures);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties *")] VkFormatProperties* pFormatProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, [NativeTypeName("VkImageUsageFlags")] uint usage, [NativeTypeName("VkImageCreateFlags")] uint flags, [NativeTypeName("VkImageFormatProperties *")] VkImageFormatProperties* pImageFormatProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties *")] VkPhysicalDeviceProperties* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties *")] VkQueueFamilyProperties* pQueueFamilyProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties *")] VkPhysicalDeviceMemoryProperties* pMemoryProperties);

        [DllImport("vulkan", EntryPoint = "vkGetInstanceProcAddr", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern IntPtr vkGetInstanceProcAddr([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceProcAddr", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern IntPtr vkGetDeviceProcAddr([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport("vulkan", EntryPoint = "vkCreateDevice", ExactSpelling = true)]
        public static extern VkResult vkCreateDevice([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkDeviceCreateInfo *")] VkDeviceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDevice *")] IntPtr* pDevice);

        [DllImport("vulkan", EntryPoint = "vkDestroyDevice", ExactSpelling = true)]
        public static extern void vkDestroyDevice([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkEnumerateInstanceExtensionProperties", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceExtensionProperties([NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkExtensionProperties *")] VkExtensionProperties* pProperties);

        [DllImport("vulkan", EntryPoint = "vkEnumerateDeviceExtensionProperties", ExactSpelling = true)]
        public static extern VkResult vkEnumerateDeviceExtensionProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkExtensionProperties *")] VkExtensionProperties* pProperties);

        [DllImport("vulkan", EntryPoint = "vkEnumerateInstanceLayerProperties", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceLayerProperties([NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        [DllImport("vulkan", EntryPoint = "vkEnumerateDeviceLayerProperties", ExactSpelling = true)]
        public static extern VkResult vkEnumerateDeviceLayerProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceQueue", ExactSpelling = true)]
        public static extern void vkGetDeviceQueue([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("uint32_t")] uint queueIndex, [NativeTypeName("VkQueue *")] IntPtr* pQueue);

        [DllImport("vulkan", EntryPoint = "vkQueueSubmit", ExactSpelling = true)]
        public static extern VkResult vkQueueSubmit([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t")] uint submitCount, [NativeTypeName("const VkSubmitInfo *")] VkSubmitInfo* pSubmits, [NativeTypeName("VkFence")] ulong fence);

        [DllImport("vulkan", EntryPoint = "vkQueueWaitIdle", ExactSpelling = true)]
        public static extern VkResult vkQueueWaitIdle([NativeTypeName("VkQueue")] IntPtr queue);

        [DllImport("vulkan", EntryPoint = "vkDeviceWaitIdle", ExactSpelling = true)]
        public static extern VkResult vkDeviceWaitIdle([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport("vulkan", EntryPoint = "vkAllocateMemory", ExactSpelling = true)]
        public static extern VkResult vkAllocateMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryAllocateInfo *")] VkMemoryAllocateInfo* pAllocateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDeviceMemory *")] ulong* pMemory);

        [DllImport("vulkan", EntryPoint = "vkFreeMemory", ExactSpelling = true)]
        public static extern void vkFreeMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkMapMemory", ExactSpelling = true)]
        public static extern VkResult vkMapMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("VkMemoryMapFlags")] uint flags, [NativeTypeName("void **")] void** ppData);

        [DllImport("vulkan", EntryPoint = "vkUnmapMemory", ExactSpelling = true)]
        public static extern void vkUnmapMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory);

        [DllImport("vulkan", EntryPoint = "vkFlushMappedMemoryRanges", ExactSpelling = true)]
        public static extern VkResult vkFlushMappedMemoryRanges([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

        [DllImport("vulkan", EntryPoint = "vkInvalidateMappedMemoryRanges", ExactSpelling = true)]
        public static extern VkResult vkInvalidateMappedMemoryRanges([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceMemoryCommitment", ExactSpelling = true)]
        public static extern void vkGetDeviceMemoryCommitment([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize *")] ulong* pCommittedMemoryInBytes);

        [DllImport("vulkan", EntryPoint = "vkBindBufferMemory", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

        [DllImport("vulkan", EntryPoint = "vkBindImageMemory", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

        [DllImport("vulkan", EntryPoint = "vkGetBufferMemoryRequirements", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkMemoryRequirements *")] VkMemoryRequirements* pMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkGetImageMemoryRequirements", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkMemoryRequirements *")] VkMemoryRequirements* pMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements *")] VkSparseImageMemoryRequirements* pSparseMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, [NativeTypeName("VkImageUsageFlags")] uint usage, VkImageTiling tiling, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties *")] VkSparseImageFormatProperties* pProperties);

        [DllImport("vulkan", EntryPoint = "vkQueueBindSparse", ExactSpelling = true)]
        public static extern VkResult vkQueueBindSparse([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindSparseInfo *")] VkBindSparseInfo* pBindInfo, [NativeTypeName("VkFence")] ulong fence);

        [DllImport("vulkan", EntryPoint = "vkCreateFence", ExactSpelling = true)]
        public static extern VkResult vkCreateFence([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceCreateInfo *")] VkFenceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport("vulkan", EntryPoint = "vkDestroyFence", ExactSpelling = true)]
        public static extern void vkDestroyFence([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFence")] ulong fence, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkResetFences", ExactSpelling = true)]
        public static extern VkResult vkResetFences([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] ulong* pFences);

        [DllImport("vulkan", EntryPoint = "vkGetFenceStatus", ExactSpelling = true)]
        public static extern VkResult vkGetFenceStatus([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFence")] ulong fence);

        [DllImport("vulkan", EntryPoint = "vkWaitForFences", ExactSpelling = true)]
        public static extern VkResult vkWaitForFences([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] ulong* pFences, [NativeTypeName("VkBool32")] uint waitAll, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport("vulkan", EntryPoint = "vkCreateSemaphore", ExactSpelling = true)]
        public static extern VkResult vkCreateSemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreCreateInfo *")] VkSemaphoreCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSemaphore *")] ulong* pSemaphore);

        [DllImport("vulkan", EntryPoint = "vkDestroySemaphore", ExactSpelling = true)]
        public static extern void vkDestroySemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateEvent", ExactSpelling = true)]
        public static extern VkResult vkCreateEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkEventCreateInfo *")] VkEventCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkEvent *")] ulong* pEvent);

        [DllImport("vulkan", EntryPoint = "vkDestroyEvent", ExactSpelling = true)]
        public static extern void vkDestroyEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkGetEventStatus", ExactSpelling = true)]
        public static extern VkResult vkGetEventStatus([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport("vulkan", EntryPoint = "vkSetEvent", ExactSpelling = true)]
        public static extern VkResult vkSetEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport("vulkan", EntryPoint = "vkResetEvent", ExactSpelling = true)]
        public static extern VkResult vkResetEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport("vulkan", EntryPoint = "vkCreateQueryPool", ExactSpelling = true)]
        public static extern VkResult vkCreateQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkQueryPoolCreateInfo *")] VkQueryPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkQueryPool *")] ulong* pQueryPool);

        [DllImport("vulkan", EntryPoint = "vkDestroyQueryPool", ExactSpelling = true)]
        public static extern void vkDestroyQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkGetQueryPoolResults", ExactSpelling = true)]
        public static extern VkResult vkGetQueryPoolResults([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);

        [DllImport("vulkan", EntryPoint = "vkCreateBuffer", ExactSpelling = true)]
        public static extern VkResult vkCreateBuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferCreateInfo *")] VkBufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkBuffer *")] ulong* pBuffer);

        [DllImport("vulkan", EntryPoint = "vkDestroyBuffer", ExactSpelling = true)]
        public static extern void vkDestroyBuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateBufferView", ExactSpelling = true)]
        public static extern VkResult vkCreateBufferView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferViewCreateInfo *")] VkBufferViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkBufferView *")] ulong* pView);

        [DllImport("vulkan", EntryPoint = "vkDestroyBufferView", ExactSpelling = true)]
        public static extern void vkDestroyBufferView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBufferView")] ulong bufferView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateImage", ExactSpelling = true)]
        public static extern VkResult vkCreateImage([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageCreateInfo *")] VkImageCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkImage *")] ulong* pImage);

        [DllImport("vulkan", EntryPoint = "vkDestroyImage", ExactSpelling = true)]
        public static extern void vkDestroyImage([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkGetImageSubresourceLayout", ExactSpelling = true)]
        public static extern void vkGetImageSubresourceLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("const VkImageSubresource *")] VkImageSubresource* pSubresource, [NativeTypeName("VkSubresourceLayout *")] VkSubresourceLayout* pLayout);

        [DllImport("vulkan", EntryPoint = "vkCreateImageView", ExactSpelling = true)]
        public static extern VkResult vkCreateImageView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageViewCreateInfo *")] VkImageViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkImageView *")] ulong* pView);

        [DllImport("vulkan", EntryPoint = "vkDestroyImageView", ExactSpelling = true)]
        public static extern void vkDestroyImageView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImageView")] ulong imageView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateShaderModule", ExactSpelling = true)]
        public static extern VkResult vkCreateShaderModule([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkShaderModuleCreateInfo *")] VkShaderModuleCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkShaderModule *")] ulong* pShaderModule);

        [DllImport("vulkan", EntryPoint = "vkDestroyShaderModule", ExactSpelling = true)]
        public static extern void vkDestroyShaderModule([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkShaderModule")] ulong shaderModule, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreatePipelineCache", ExactSpelling = true)]
        public static extern VkResult vkCreatePipelineCache([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineCacheCreateInfo *")] VkPipelineCacheCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipelineCache *")] ulong* pPipelineCache);

        [DllImport("vulkan", EntryPoint = "vkDestroyPipelineCache", ExactSpelling = true)]
        public static extern void vkDestroyPipelineCache([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkGetPipelineCacheData", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineCacheData([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("size_t *")] nuint* pDataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkMergePipelineCaches", ExactSpelling = true)]
        public static extern VkResult vkMergePipelineCaches([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkPipelineCache *")] ulong* pSrcCaches);

        [DllImport("vulkan", EntryPoint = "vkCreateGraphicsPipelines", ExactSpelling = true)]
        public static extern VkResult vkCreateGraphicsPipelines([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkGraphicsPipelineCreateInfo *")] VkGraphicsPipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport("vulkan", EntryPoint = "vkCreateComputePipelines", ExactSpelling = true)]
        public static extern VkResult vkCreateComputePipelines([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkComputePipelineCreateInfo *")] VkComputePipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport("vulkan", EntryPoint = "vkDestroyPipeline", ExactSpelling = true)]
        public static extern void vkDestroyPipeline([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreatePipelineLayout", ExactSpelling = true)]
        public static extern VkResult vkCreatePipelineLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineLayoutCreateInfo *")] VkPipelineLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipelineLayout *")] ulong* pPipelineLayout);

        [DllImport("vulkan", EntryPoint = "vkDestroyPipelineLayout", ExactSpelling = true)]
        public static extern void vkDestroyPipelineLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineLayout")] ulong pipelineLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateSampler", ExactSpelling = true)]
        public static extern VkResult vkCreateSampler([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerCreateInfo *")] VkSamplerCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSampler *")] ulong* pSampler);

        [DllImport("vulkan", EntryPoint = "vkDestroySampler", ExactSpelling = true)]
        public static extern void vkDestroySampler([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSampler")] ulong sampler, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateDescriptorSetLayout", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorSetLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorSetLayout *")] ulong* pSetLayout);

        [DllImport("vulkan", EntryPoint = "vkDestroyDescriptorSetLayout", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorSetLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSetLayout")] ulong descriptorSetLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateDescriptorPool", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorPoolCreateInfo *")] VkDescriptorPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorPool *")] ulong* pDescriptorPool);

        [DllImport("vulkan", EntryPoint = "vkDestroyDescriptorPool", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkResetDescriptorPool", ExactSpelling = true)]
        public static extern VkResult vkResetDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("VkDescriptorPoolResetFlags")] uint flags);

        [DllImport("vulkan", EntryPoint = "vkAllocateDescriptorSets", ExactSpelling = true)]
        public static extern VkResult vkAllocateDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetAllocateInfo *")] VkDescriptorSetAllocateInfo* pAllocateInfo, [NativeTypeName("VkDescriptorSet *")] ulong* pDescriptorSets);

        [DllImport("vulkan", EntryPoint = "vkFreeDescriptorSets", ExactSpelling = true)]
        public static extern VkResult vkFreeDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] ulong* pDescriptorSets);

        [DllImport("vulkan", EntryPoint = "vkUpdateDescriptorSets", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites, [NativeTypeName("uint32_t")] uint descriptorCopyCount, [NativeTypeName("const VkCopyDescriptorSet *")] VkCopyDescriptorSet* pDescriptorCopies);

        [DllImport("vulkan", EntryPoint = "vkCreateFramebuffer", ExactSpelling = true)]
        public static extern VkResult vkCreateFramebuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFramebufferCreateInfo *")] VkFramebufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFramebuffer *")] ulong* pFramebuffer);

        [DllImport("vulkan", EntryPoint = "vkDestroyFramebuffer", ExactSpelling = true)]
        public static extern void vkDestroyFramebuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFramebuffer")] ulong framebuffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateRenderPass", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo *")] VkRenderPassCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport("vulkan", EntryPoint = "vkDestroyRenderPass", ExactSpelling = true)]
        public static extern void vkDestroyRenderPass([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkRenderPass")] ulong renderPass, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkGetRenderAreaGranularity", ExactSpelling = true)]
        public static extern void vkGetRenderAreaGranularity([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkRenderPass")] ulong renderPass, [NativeTypeName("VkExtent2D *")] VkExtent2D* pGranularity);

        [DllImport("vulkan", EntryPoint = "vkCreateCommandPool", ExactSpelling = true)]
        public static extern VkResult vkCreateCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCommandPoolCreateInfo *")] VkCommandPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkCommandPool *")] ulong* pCommandPool);

        [DllImport("vulkan", EntryPoint = "vkDestroyCommandPool", ExactSpelling = true)]
        public static extern void vkDestroyCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkResetCommandPool", ExactSpelling = true)]
        public static extern VkResult vkResetCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolResetFlags")] uint flags);

        [DllImport("vulkan", EntryPoint = "vkAllocateCommandBuffers", ExactSpelling = true)]
        public static extern VkResult vkAllocateCommandBuffers([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCommandBufferAllocateInfo *")] VkCommandBufferAllocateInfo* pAllocateInfo, [NativeTypeName("VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport("vulkan", EntryPoint = "vkFreeCommandBuffers", ExactSpelling = true)]
        public static extern void vkFreeCommandBuffers([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport("vulkan", EntryPoint = "vkBeginCommandBuffer", ExactSpelling = true)]
        public static extern VkResult vkBeginCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCommandBufferBeginInfo *")] VkCommandBufferBeginInfo* pBeginInfo);

        [DllImport("vulkan", EntryPoint = "vkEndCommandBuffer", ExactSpelling = true)]
        public static extern VkResult vkEndCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", EntryPoint = "vkResetCommandBuffer", ExactSpelling = true)]
        public static extern VkResult vkResetCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkCommandBufferResetFlags")] uint flags);

        [DllImport("vulkan", EntryPoint = "vkCmdBindPipeline", ExactSpelling = true)]
        public static extern void vkCmdBindPipeline([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipeline")] ulong pipeline);

        [DllImport("vulkan", EntryPoint = "vkCmdSetViewport", ExactSpelling = true)]
        public static extern void vkCmdSetViewport([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewport *")] VkViewport* pViewports);

        [DllImport("vulkan", EntryPoint = "vkCmdSetScissor", ExactSpelling = true)]
        public static extern void vkCmdSetScissor([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstScissor, [NativeTypeName("uint32_t")] uint scissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pScissors);

        [DllImport("vulkan", EntryPoint = "vkCmdSetLineWidth", ExactSpelling = true)]
        public static extern void vkCmdSetLineWidth([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float lineWidth);

        [DllImport("vulkan", EntryPoint = "vkCmdSetDepthBias", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBias([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

        [DllImport("vulkan", EntryPoint = "vkCmdSetBlendConstants", ExactSpelling = true)]
        public static extern void vkCmdSetBlendConstants([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const float [4]")] float* blendConstants);

        [DllImport("vulkan", EntryPoint = "vkCmdSetDepthBounds", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBounds([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float minDepthBounds, float maxDepthBounds);

        [DllImport("vulkan", EntryPoint = "vkCmdSetStencilCompareMask", ExactSpelling = true)]
        public static extern void vkCmdSetStencilCompareMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint compareMask);

        [DllImport("vulkan", EntryPoint = "vkCmdSetStencilWriteMask", ExactSpelling = true)]
        public static extern void vkCmdSetStencilWriteMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint writeMask);

        [DllImport("vulkan", EntryPoint = "vkCmdSetStencilReference", ExactSpelling = true)]
        public static extern void vkCmdSetStencilReference([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint reference);

        [DllImport("vulkan", EntryPoint = "vkCmdBindDescriptorSets", ExactSpelling = true)]
        public static extern void vkCmdBindDescriptorSets([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint firstSet, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] ulong* pDescriptorSets, [NativeTypeName("uint32_t")] uint dynamicOffsetCount, [NativeTypeName("const uint32_t *")] uint* pDynamicOffsets);

        [DllImport("vulkan", EntryPoint = "vkCmdBindIndexBuffer", ExactSpelling = true)]
        public static extern void vkCmdBindIndexBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkIndexType indexType);

        [DllImport("vulkan", EntryPoint = "vkCmdBindVertexBuffers", ExactSpelling = true)]
        public static extern void vkCmdBindVertexBuffers([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets);

        [DllImport("vulkan", EntryPoint = "vkCmdDraw", ExactSpelling = true)]
        public static extern void vkCmdDraw([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint vertexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstVertex, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndexed", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexed([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint indexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstIndex, [NativeTypeName("int32_t")] int vertexOffset, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndirect", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndexedIndirect", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkCmdDispatch", ExactSpelling = true)]
        public static extern void vkCmdDispatch([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport("vulkan", EntryPoint = "vkCmdDispatchIndirect", ExactSpelling = true)]
        public static extern void vkCmdDispatchIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset);

        [DllImport("vulkan", EntryPoint = "vkCmdCopyBuffer", ExactSpelling = true)]
        public static extern void vkCmdCopyBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong srcBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferCopy *")] VkBufferCopy* pRegions);

        [DllImport("vulkan", EntryPoint = "vkCmdCopyImage", ExactSpelling = true)]
        public static extern void vkCmdCopyImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageCopy *")] VkImageCopy* pRegions);

        [DllImport("vulkan", EntryPoint = "vkCmdBlitImage", ExactSpelling = true)]
        public static extern void vkCmdBlitImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageBlit *")] VkImageBlit* pRegions, VkFilter filter);

        [DllImport("vulkan", EntryPoint = "vkCmdCopyBufferToImage", ExactSpelling = true)]
        public static extern void vkCmdCopyBufferToImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong srcBuffer, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

        [DllImport("vulkan", EntryPoint = "vkCmdCopyImageToBuffer", ExactSpelling = true)]
        public static extern void vkCmdCopyImageToBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

        [DllImport("vulkan", EntryPoint = "vkCmdUpdateBuffer", ExactSpelling = true)]
        public static extern void vkCmdUpdateBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong dataSize, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkCmdFillBuffer", ExactSpelling = true)]
        public static extern void vkCmdFillBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("uint32_t")] uint data);

        [DllImport("vulkan", EntryPoint = "vkCmdClearColorImage", ExactSpelling = true)]
        public static extern void vkCmdClearColorImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong image, VkImageLayout imageLayout, [NativeTypeName("const VkClearColorValue *")] VkClearColorValue* pColor, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

        [DllImport("vulkan", EntryPoint = "vkCmdClearDepthStencilImage", ExactSpelling = true)]
        public static extern void vkCmdClearDepthStencilImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong image, VkImageLayout imageLayout, [NativeTypeName("const VkClearDepthStencilValue *")] VkClearDepthStencilValue* pDepthStencil, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

        [DllImport("vulkan", EntryPoint = "vkCmdClearAttachments", ExactSpelling = true)]
        public static extern void vkCmdClearAttachments([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint attachmentCount, [NativeTypeName("const VkClearAttachment *")] VkClearAttachment* pAttachments, [NativeTypeName("uint32_t")] uint rectCount, [NativeTypeName("const VkClearRect *")] VkClearRect* pRects);

        [DllImport("vulkan", EntryPoint = "vkCmdResolveImage", ExactSpelling = true)]
        public static extern void vkCmdResolveImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageResolve *")] VkImageResolve* pRegions);

        [DllImport("vulkan", EntryPoint = "vkCmdSetEvent", ExactSpelling = true)]
        public static extern void vkCmdSetEvent([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("VkPipelineStageFlags")] uint stageMask);

        [DllImport("vulkan", EntryPoint = "vkCmdResetEvent", ExactSpelling = true)]
        public static extern void vkCmdResetEvent([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("VkPipelineStageFlags")] uint stageMask);

        [DllImport("vulkan", EntryPoint = "vkCmdWaitEvents", ExactSpelling = true)]
        public static extern void vkCmdWaitEvents([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint eventCount, [NativeTypeName("const VkEvent *")] ulong* pEvents, [NativeTypeName("VkPipelineStageFlags")] uint srcStageMask, [NativeTypeName("VkPipelineStageFlags")] uint dstStageMask, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

        [DllImport("vulkan", EntryPoint = "vkCmdPipelineBarrier", ExactSpelling = true)]
        public static extern void vkCmdPipelineBarrier([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkPipelineStageFlags")] uint srcStageMask, [NativeTypeName("VkPipelineStageFlags")] uint dstStageMask, [NativeTypeName("VkDependencyFlags")] uint dependencyFlags, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

        [DllImport("vulkan", EntryPoint = "vkCmdBeginQuery", ExactSpelling = true)]
        public static extern void vkCmdBeginQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags);

        [DllImport("vulkan", EntryPoint = "vkCmdEndQuery", ExactSpelling = true)]
        public static extern void vkCmdEndQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport("vulkan", EntryPoint = "vkCmdResetQueryPool", ExactSpelling = true)]
        public static extern void vkCmdResetQueryPool([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport("vulkan", EntryPoint = "vkCmdWriteTimestamp", ExactSpelling = true)]
        public static extern void vkCmdWriteTimestamp([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport("vulkan", EntryPoint = "vkCmdCopyQueryPoolResults", ExactSpelling = true)]
        public static extern void vkCmdCopyQueryPoolResults([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);

        [DllImport("vulkan", EntryPoint = "vkCmdPushConstants", ExactSpelling = true)]
        public static extern void vkCmdPushConstants([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("VkShaderStageFlags")] uint stageFlags, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint size, [NativeTypeName("const void *")] void* pValues);

        [DllImport("vulkan", EntryPoint = "vkCmdBeginRenderPass", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);

        [DllImport("vulkan", EntryPoint = "vkCmdNextSubpass", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkSubpassContents contents);

        [DllImport("vulkan", EntryPoint = "vkCmdEndRenderPass", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", EntryPoint = "vkCmdExecuteCommands", ExactSpelling = true)]
        public static extern void vkCmdExecuteCommands([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport("vulkan", EntryPoint = "vkEnumerateInstanceVersion", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceVersion([NativeTypeName("uint32_t *")] uint* pApiVersion);

        [DllImport("vulkan", EntryPoint = "vkBindBufferMemory2", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport("vulkan", EntryPoint = "vkBindImageMemory2", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures", ExactSpelling = true)]
        public static extern void vkGetDeviceGroupPeerMemoryFeatures([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);

        [DllImport("vulkan", EntryPoint = "vkCmdSetDeviceMask", ExactSpelling = true)]
        public static extern void vkCmdSetDeviceMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport("vulkan", EntryPoint = "vkCmdDispatchBase", ExactSpelling = true)]
        public static extern void vkCmdDispatchBase([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroups", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroups([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, [NativeTypeName("VkPhysicalDeviceGroupProperties *")] VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport("vulkan", EntryPoint = "vkGetImageMemoryRequirements2", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements2 *")] VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures2 *")] VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties2 *")] VkPhysicalDeviceProperties2* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties2 *")] VkFormatProperties2* pFormatProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, [NativeTypeName("VkImageFormatProperties2 *")] VkImageFormatProperties2* pImageFormatProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties2 *")] VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties2 *")] VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties2 *")] VkSparseImageFormatProperties2* pProperties);

        [DllImport("vulkan", EntryPoint = "vkTrimCommandPool", ExactSpelling = true)]
        public static extern void vkTrimCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceQueue2", ExactSpelling = true)]
        public static extern void vkGetDeviceQueue2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceQueueInfo2 *")] VkDeviceQueueInfo2* pQueueInfo, [NativeTypeName("VkQueue *")] IntPtr* pQueue);

        [DllImport("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversion", ExactSpelling = true)]
        public static extern VkResult vkCreateSamplerYcbcrConversion([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSamplerYcbcrConversion *")] ulong* pYcbcrConversion);

        [DllImport("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversion", ExactSpelling = true)]
        public static extern void vkDestroySamplerYcbcrConversion([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSamplerYcbcrConversion")] ulong ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplate", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorUpdateTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorUpdateTemplate *")] ulong* pDescriptorUpdateTemplate);

        [DllImport("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplate", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorUpdateTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplate", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSetWithTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSet")] ulong descriptorSet, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalBufferProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [NativeTypeName("VkExternalBufferProperties *")] VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalFenceProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [NativeTypeName("VkExternalFenceProperties *")] VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalSemaphoreProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [NativeTypeName("VkExternalSemaphoreProperties *")] VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupport", ExactSpelling = true)]
        public static extern void vkGetDescriptorSetLayoutSupport([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("VkDescriptorSetLayoutSupport *")] VkDescriptorSetLayoutSupport* pSupport);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndirectCount", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCount([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCount", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCount([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkCreateRenderPass2", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo2 *")] VkRenderPassCreateInfo2* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport("vulkan", EntryPoint = "vkCmdBeginRenderPass2", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass2([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdNextSubpass2", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass2([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdEndRenderPass2", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass2([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", EntryPoint = "vkResetQueryPool", ExactSpelling = true)]
        public static extern void vkResetQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport("vulkan", EntryPoint = "vkGetSemaphoreCounterValue", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreCounterValue([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("uint64_t *")] ulong* pValue);

        [DllImport("vulkan", EntryPoint = "vkWaitSemaphores", ExactSpelling = true)]
        public static extern VkResult vkWaitSemaphores([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreWaitInfo *")] VkSemaphoreWaitInfo* pWaitInfo, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport("vulkan", EntryPoint = "vkSignalSemaphore", ExactSpelling = true)]
        public static extern VkResult vkSignalSemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreSignalInfo *")] VkSemaphoreSignalInfo* pSignalInfo);

        [DllImport("vulkan", EntryPoint = "vkGetBufferDeviceAddress", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddress([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddress", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetBufferOpaqueCaptureAddress([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetDeviceMemoryOpaqueCaptureAddress([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceMemoryOpaqueCaptureAddressInfo *")] VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        [DllImport("vulkan", EntryPoint = "vkDestroySurfaceKHR", ExactSpelling = true)]
        public static extern void vkDestroySurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkBool32 *")] uint* pSupported);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkSurfaceCapabilitiesKHR *")] VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormatsKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, [NativeTypeName("VkSurfaceFormatKHR *")] VkSurfaceFormatKHR* pSurfaceFormats);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfacePresentModesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pPresentModeCount, [NativeTypeName("VkPresentModeKHR *")] VkPresentModeKHR* pPresentModes);

        [DllImport("vulkan", EntryPoint = "vkCreateSwapchainKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateSwapchainKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSwapchainKHR *")] ulong* pSwapchain);

        [DllImport("vulkan", EntryPoint = "vkDestroySwapchainKHR", ExactSpelling = true)]
        public static extern void vkDestroySwapchainKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkGetSwapchainImagesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainImagesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint32_t *")] uint* pSwapchainImageCount, [NativeTypeName("VkImage *")] ulong* pSwapchainImages);

        [DllImport("vulkan", EntryPoint = "vkAcquireNextImageKHR", ExactSpelling = true)]
        public static extern VkResult vkAcquireNextImageKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint64_t")] ulong timeout, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("VkFence")] ulong fence, [NativeTypeName("uint32_t *")] uint* pImageIndex);

        [DllImport("vulkan", EntryPoint = "vkQueuePresentKHR", ExactSpelling = true)]
        public static extern VkResult vkQueuePresentKHR([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkPresentInfoKHR *")] VkPresentInfoKHR* pPresentInfo);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceGroupPresentCapabilitiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceGroupPresentCapabilitiesKHR *")] VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceGroupSurfacePresentModesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkDeviceGroupPresentModeFlagsKHR *")] uint* pModes);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDevicePresentRectanglesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pRectCount, [NativeTypeName("VkRect2D *")] VkRect2D* pRects);

        [DllImport("vulkan", EntryPoint = "vkAcquireNextImage2KHR", ExactSpelling = true)]
        public static extern VkResult vkAcquireNextImage2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAcquireNextImageInfoKHR *")] VkAcquireNextImageInfoKHR* pAcquireInfo, [NativeTypeName("uint32_t *")] uint* pImageIndex);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPropertiesKHR *")] VkDisplayPropertiesKHR* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPlanePropertiesKHR *")] VkDisplayPlanePropertiesKHR* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneSupportedDisplaysKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("uint32_t *")] uint* pDisplayCount, [NativeTypeName("VkDisplayKHR *")] ulong* pDisplays);

        [DllImport("vulkan", EntryPoint = "vkGetDisplayModePropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayModePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayModePropertiesKHR *")] VkDisplayModePropertiesKHR* pProperties);

        [DllImport("vulkan", EntryPoint = "vkCreateDisplayModeKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateDisplayModeKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayModeCreateInfoKHR *")] VkDisplayModeCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDisplayModeKHR *")] ulong* pMode);

        [DllImport("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayModeKHR")] ulong mode, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("VkDisplayPlaneCapabilitiesKHR *")] VkDisplayPlaneCapabilitiesKHR* pCapabilities);

        [DllImport("vulkan", EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateDisplayPlaneSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDisplaySurfaceCreateInfoKHR *")] VkDisplaySurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport("vulkan", EntryPoint = "vkCreateSharedSwapchainsKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateSharedSwapchainsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSwapchainKHR *")] ulong* pSwapchains);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceFeatures2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures2 *")] VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties2 *")] VkPhysicalDeviceProperties2* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties2 *")] VkFormatProperties2* pFormatProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, [NativeTypeName("VkImageFormatProperties2 *")] VkImageFormatProperties2* pImageFormatProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties2 *")] VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties2 *")] VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties2 *")] VkSparseImageFormatProperties2* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR", ExactSpelling = true)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);

        [DllImport("vulkan", EntryPoint = "vkCmdSetDeviceMaskKHR", ExactSpelling = true)]
        public static extern void vkCmdSetDeviceMaskKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport("vulkan", EntryPoint = "vkCmdDispatchBaseKHR", ExactSpelling = true)]
        public static extern void vkCmdDispatchBaseKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport("vulkan", EntryPoint = "vkTrimCommandPoolKHR", ExactSpelling = true)]
        public static extern void vkTrimCommandPoolKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroupsKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, [NativeTypeName("VkPhysicalDeviceGroupProperties *")] VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalBufferPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [NativeTypeName("VkExternalBufferProperties *")] VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport("vulkan", EntryPoint = "vkGetMemoryFdKHR", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryGetFdInfoKHR *")] VkMemoryGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport("vulkan", EntryPoint = "vkGetMemoryFdPropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryFdPropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, [NativeTypeName("VkMemoryFdPropertiesKHR *")] VkMemoryFdPropertiesKHR* pMemoryFdProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [NativeTypeName("VkExternalSemaphoreProperties *")] VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport("vulkan", EntryPoint = "vkImportSemaphoreFdKHR", ExactSpelling = true)]
        public static extern VkResult vkImportSemaphoreFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportSemaphoreFdInfoKHR *")] VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        [DllImport("vulkan", EntryPoint = "vkGetSemaphoreFdKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreGetFdInfoKHR *")] VkSemaphoreGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport("vulkan", EntryPoint = "vkCmdPushDescriptorSetKHR", ExactSpelling = true)]
        public static extern void vkCmdPushDescriptorSetKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites);

        [DllImport("vulkan", EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR", ExactSpelling = true)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkCreateDescriptorUpdateTemplateKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorUpdateTemplate *")] ulong* pDescriptorUpdateTemplate);

        [DllImport("vulkan", EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSetWithTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSet")] ulong descriptorSet, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkCreateRenderPass2KHR", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo2 *")] VkRenderPassCreateInfo2* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport("vulkan", EntryPoint = "vkCmdBeginRenderPass2KHR", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdNextSubpass2KHR", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdEndRenderPass2KHR", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", EntryPoint = "vkGetSwapchainStatusKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainStatusKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalFencePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [NativeTypeName("VkExternalFenceProperties *")] VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport("vulkan", EntryPoint = "vkImportFenceFdKHR", ExactSpelling = true)]
        public static extern VkResult vkImportFenceFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportFenceFdInfoKHR *")] VkImportFenceFdInfoKHR* pImportFenceFdInfo);

        [DllImport("vulkan", EntryPoint = "vkGetFenceFdKHR", ExactSpelling = true)]
        public static extern VkResult vkGetFenceFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceGetFdInfoKHR *")] VkFenceGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport("vulkan", EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("uint32_t *")] uint* pCounterCount, [NativeTypeName("VkPerformanceCounterKHR *")] VkPerformanceCounterKHR* pCounters, [NativeTypeName("VkPerformanceCounterDescriptionKHR *")] VkPerformanceCounterDescriptionKHR* pCounterDescriptions);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkQueryPoolPerformanceCreateInfoKHR *")] VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [NativeTypeName("uint32_t *")] uint* pNumPasses);

        [DllImport("vulkan", EntryPoint = "vkAcquireProfilingLockKHR", ExactSpelling = true)]
        public static extern VkResult vkAcquireProfilingLockKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAcquireProfilingLockInfoKHR *")] VkAcquireProfilingLockInfoKHR* pInfo);

        [DllImport("vulkan", EntryPoint = "vkReleaseProfilingLockKHR", ExactSpelling = true)]
        public static extern void vkReleaseProfilingLockKHR([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("VkSurfaceCapabilities2KHR *")] VkSurfaceCapabilities2KHR* pSurfaceCapabilities);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormats2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, [NativeTypeName("VkSurfaceFormat2KHR *")] VkSurfaceFormat2KHR* pSurfaceFormats);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayProperties2KHR *")] VkDisplayProperties2KHR* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPlaneProperties2KHR *")] VkDisplayPlaneProperties2KHR* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetDisplayModeProperties2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayModeProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayModeProperties2KHR *")] VkDisplayModeProperties2KHR* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetDisplayPlaneCapabilities2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkDisplayPlaneInfo2KHR *")] VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, [NativeTypeName("VkDisplayPlaneCapabilities2KHR *")] VkDisplayPlaneCapabilities2KHR* pCapabilities);

        [DllImport("vulkan", EntryPoint = "vkGetImageMemoryRequirements2KHR", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkGetBufferMemoryRequirements2KHR", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements2 *")] VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkCreateSamplerYcbcrConversionKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateSamplerYcbcrConversionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSamplerYcbcrConversion *")] ulong* pYcbcrConversion);

        [DllImport("vulkan", EntryPoint = "vkDestroySamplerYcbcrConversionKHR", ExactSpelling = true)]
        public static extern void vkDestroySamplerYcbcrConversionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSamplerYcbcrConversion")] ulong ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkBindBufferMemory2KHR", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport("vulkan", EntryPoint = "vkBindImageMemory2KHR", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport("vulkan", EntryPoint = "vkGetDescriptorSetLayoutSupportKHR", ExactSpelling = true)]
        public static extern void vkGetDescriptorSetLayoutSupportKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("VkDescriptorSetLayoutSupport *")] VkDescriptorSetLayoutSupport* pSupport);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndirectCountKHR", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCountKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCountKHR", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCountKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkGetSemaphoreCounterValueKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreCounterValueKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("uint64_t *")] ulong* pValue);

        [DllImport("vulkan", EntryPoint = "vkWaitSemaphoresKHR", ExactSpelling = true)]
        public static extern VkResult vkWaitSemaphoresKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreWaitInfo *")] VkSemaphoreWaitInfo* pWaitInfo, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport("vulkan", EntryPoint = "vkSignalSemaphoreKHR", ExactSpelling = true)]
        public static extern VkResult vkSignalSemaphoreKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreSignalInfo *")] VkSemaphoreSignalInfo* pSignalInfo);

        [DllImport("vulkan", EntryPoint = "vkGetBufferDeviceAddressKHR", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddressKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetBufferOpaqueCaptureAddressKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetDeviceMemoryOpaqueCaptureAddressKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceMemoryOpaqueCaptureAddressInfo *")] VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        [DllImport("vulkan", EntryPoint = "vkGetPipelineExecutablePropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutablePropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineInfoKHR *")] VkPipelineInfoKHR* pPipelineInfo, [NativeTypeName("uint32_t *")] uint* pExecutableCount, [NativeTypeName("VkPipelineExecutablePropertiesKHR *")] VkPipelineExecutablePropertiesKHR* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPipelineExecutableStatisticsKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutableStatisticsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pStatisticCount, [NativeTypeName("VkPipelineExecutableStatisticKHR *")] VkPipelineExecutableStatisticKHR* pStatistics);

        [DllImport("vulkan", EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutableInternalRepresentationsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pInternalRepresentationCount, [NativeTypeName("VkPipelineExecutableInternalRepresentationKHR *")] VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        [DllImport("vulkan", EntryPoint = "vkCreateDebugReportCallbackEXT", ExactSpelling = true)]
        public static extern VkResult vkCreateDebugReportCallbackEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDebugReportCallbackCreateInfoEXT *")] VkDebugReportCallbackCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDebugReportCallbackEXT *")] ulong* pCallback);

        [DllImport("vulkan", EntryPoint = "vkDestroyDebugReportCallbackEXT", ExactSpelling = true)]
        public static extern void vkDestroyDebugReportCallbackEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugReportCallbackEXT")] ulong callback, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkDebugReportMessageEXT", ExactSpelling = true)]
        public static extern void vkDebugReportMessageEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugReportFlagsEXT")] uint flags, VkDebugReportObjectTypeEXT objectType, [NativeTypeName("uint64_t")] ulong @object, [NativeTypeName("size_t")] nuint location, [NativeTypeName("int32_t")] int messageCode, [NativeTypeName("const char *")] sbyte* pLayerPrefix, [NativeTypeName("const char *")] sbyte* pMessage);

        [DllImport("vulkan", EntryPoint = "vkDebugMarkerSetObjectTagEXT", ExactSpelling = true)]
        public static extern VkResult vkDebugMarkerSetObjectTagEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugMarkerObjectTagInfoEXT *")] VkDebugMarkerObjectTagInfoEXT* pTagInfo);

        [DllImport("vulkan", EntryPoint = "vkDebugMarkerSetObjectNameEXT", ExactSpelling = true)]
        public static extern VkResult vkDebugMarkerSetObjectNameEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugMarkerObjectNameInfoEXT *")] VkDebugMarkerObjectNameInfoEXT* pNameInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdDebugMarkerBeginEXT", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerBeginEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdDebugMarkerEndEXT", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerEndEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", EntryPoint = "vkCmdDebugMarkerInsertEXT", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerInsertEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", ExactSpelling = true)]
        public static extern void vkCmdBindTransformFeedbackBuffersEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets, [NativeTypeName("const VkDeviceSize *")] ulong* pSizes);

        [DllImport("vulkan", EntryPoint = "vkCmdBeginTransformFeedbackEXT", ExactSpelling = true)]
        public static extern void vkCmdBeginTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] ulong* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport("vulkan", EntryPoint = "vkCmdEndTransformFeedbackEXT", ExactSpelling = true)]
        public static extern void vkCmdEndTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] ulong* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport("vulkan", EntryPoint = "vkCmdBeginQueryIndexedEXT", ExactSpelling = true)]
        public static extern void vkCmdBeginQueryIndexedEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags, [NativeTypeName("uint32_t")] uint index);

        [DllImport("vulkan", EntryPoint = "vkCmdEndQueryIndexedEXT", ExactSpelling = true)]
        public static extern void vkCmdEndQueryIndexedEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("uint32_t")] uint index);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndirectByteCountEXT", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectByteCountEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstInstance, [NativeTypeName("VkBuffer")] ulong counterBuffer, [NativeTypeName("VkDeviceSize")] ulong counterBufferOffset, [NativeTypeName("uint32_t")] uint counterOffset, [NativeTypeName("uint32_t")] uint vertexStride);

        [DllImport("vulkan", EntryPoint = "vkGetImageViewHandleNVX", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint vkGetImageViewHandleNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageViewHandleInfoNVX *")] VkImageViewHandleInfoNVX* pInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndirectCountAMD", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCountAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawIndexedIndirectCountAMD", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkGetShaderInfoAMD", ExactSpelling = true)]
        public static extern VkResult vkGetShaderInfoAMD([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, [NativeTypeName("size_t *")] nuint* pInfoSize, [NativeTypeName("void *")] void* pInfo);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, [NativeTypeName("VkImageUsageFlags")] uint usage, [NativeTypeName("VkImageCreateFlags")] uint flags, [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")] uint externalHandleType, [NativeTypeName("VkExternalImageFormatPropertiesNV *")] VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

        [DllImport("vulkan", EntryPoint = "vkCmdBeginConditionalRenderingEXT", ExactSpelling = true)]
        public static extern void vkCmdBeginConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkConditionalRenderingBeginInfoEXT *")] VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

        [DllImport("vulkan", EntryPoint = "vkCmdEndConditionalRenderingEXT", ExactSpelling = true)]
        public static extern void vkCmdEndConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", EntryPoint = "vkCmdSetViewportWScalingNV", ExactSpelling = true)]
        public static extern void vkCmdSetViewportWScalingNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewportWScalingNV *")] VkViewportWScalingNV* pViewportWScalings);

        [DllImport("vulkan", EntryPoint = "vkReleaseDisplayEXT", ExactSpelling = true)]
        public static extern VkResult vkReleaseDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkSurfaceCapabilities2EXT *")] VkSurfaceCapabilities2EXT* pSurfaceCapabilities);

        [DllImport("vulkan", EntryPoint = "vkDisplayPowerControlEXT", ExactSpelling = true)]
        public static extern VkResult vkDisplayPowerControlEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayPowerInfoEXT *")] VkDisplayPowerInfoEXT* pDisplayPowerInfo);

        [DllImport("vulkan", EntryPoint = "vkRegisterDeviceEventEXT", ExactSpelling = true)]
        public static extern VkResult vkRegisterDeviceEventEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceEventInfoEXT *")] VkDeviceEventInfoEXT* pDeviceEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport("vulkan", EntryPoint = "vkRegisterDisplayEventEXT", ExactSpelling = true)]
        public static extern VkResult vkRegisterDisplayEventEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayEventInfoEXT *")] VkDisplayEventInfoEXT* pDisplayEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport("vulkan", EntryPoint = "vkGetSwapchainCounterEXT", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainCounterEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, VkSurfaceCounterFlagBitsEXT counter, [NativeTypeName("uint64_t *")] ulong* pCounterValue);

        [DllImport("vulkan", EntryPoint = "vkGetRefreshCycleDurationGOOGLE", ExactSpelling = true)]
        public static extern VkResult vkGetRefreshCycleDurationGOOGLE([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("VkRefreshCycleDurationGOOGLE *")] VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPastPresentationTimingGOOGLE", ExactSpelling = true)]
        public static extern VkResult vkGetPastPresentationTimingGOOGLE([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint32_t *")] uint* pPresentationTimingCount, [NativeTypeName("VkPastPresentationTimingGOOGLE *")] VkPastPresentationTimingGOOGLE* pPresentationTimings);

        [DllImport("vulkan", EntryPoint = "vkCmdSetDiscardRectangleEXT", ExactSpelling = true)]
        public static extern void vkCmdSetDiscardRectangleEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstDiscardRectangle, [NativeTypeName("uint32_t")] uint discardRectangleCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pDiscardRectangles);

        [DllImport("vulkan", EntryPoint = "vkSetHdrMetadataEXT", ExactSpelling = true)]
        public static extern void vkSetHdrMetadataEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainKHR *")] ulong* pSwapchains, [NativeTypeName("const VkHdrMetadataEXT *")] VkHdrMetadataEXT* pMetadata);

        [DllImport("vulkan", EntryPoint = "vkSetDebugUtilsObjectNameEXT", ExactSpelling = true)]
        public static extern VkResult vkSetDebugUtilsObjectNameEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")] VkDebugUtilsObjectNameInfoEXT* pNameInfo);

        [DllImport("vulkan", EntryPoint = "vkSetDebugUtilsObjectTagEXT", ExactSpelling = true)]
        public static extern VkResult vkSetDebugUtilsObjectTagEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugUtilsObjectTagInfoEXT *")] VkDebugUtilsObjectTagInfoEXT* pTagInfo);

        [DllImport("vulkan", EntryPoint = "vkQueueBeginDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkQueueBeginDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", EntryPoint = "vkQueueEndDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkQueueEndDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue);

        [DllImport("vulkan", EntryPoint = "vkQueueInsertDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkQueueInsertDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdBeginDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkCmdBeginDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdEndDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkCmdEndDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", EntryPoint = "vkCmdInsertDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkCmdInsertDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", EntryPoint = "vkCreateDebugUtilsMessengerEXT", ExactSpelling = true)]
        public static extern VkResult vkCreateDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDebugUtilsMessengerCreateInfoEXT *")] VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDebugUtilsMessengerEXT *")] ulong* pMessenger);

        [DllImport("vulkan", EntryPoint = "vkDestroyDebugUtilsMessengerEXT", ExactSpelling = true)]
        public static extern void vkDestroyDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugUtilsMessengerEXT")] ulong messenger, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkSubmitDebugUtilsMessageEXT", ExactSpelling = true)]
        public static extern void vkSubmitDebugUtilsMessageEXT([NativeTypeName("VkInstance")] IntPtr instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")] uint messageTypes, [NativeTypeName("const VkDebugUtilsMessengerCallbackDataEXT *")] VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);

        [DllImport("vulkan", EntryPoint = "vkCmdSetSampleLocationsEXT", ExactSpelling = true)]
        public static extern void vkCmdSetSampleLocationsEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSampleLocationsInfoEXT *")] VkSampleLocationsInfoEXT* pSampleLocationsInfo);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMultisamplePropertiesEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkSampleCountFlagBits samples, [NativeTypeName("VkMultisamplePropertiesEXT *")] VkMultisamplePropertiesEXT* pMultisampleProperties);

        [DllImport("vulkan", EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT", ExactSpelling = true)]
        public static extern VkResult vkGetImageDrmFormatModifierPropertiesEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkImageDrmFormatModifierPropertiesEXT *")] VkImageDrmFormatModifierPropertiesEXT* pProperties);

        [DllImport("vulkan", EntryPoint = "vkCreateValidationCacheEXT", ExactSpelling = true)]
        public static extern VkResult vkCreateValidationCacheEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkValidationCacheCreateInfoEXT *")] VkValidationCacheCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkValidationCacheEXT *")] ulong* pValidationCache);

        [DllImport("vulkan", EntryPoint = "vkDestroyValidationCacheEXT", ExactSpelling = true)]
        public static extern void vkDestroyValidationCacheEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong validationCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkMergeValidationCachesEXT", ExactSpelling = true)]
        public static extern VkResult vkMergeValidationCachesEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkValidationCacheEXT *")] ulong* pSrcCaches);

        [DllImport("vulkan", EntryPoint = "vkGetValidationCacheDataEXT", ExactSpelling = true)]
        public static extern VkResult vkGetValidationCacheDataEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong validationCache, [NativeTypeName("size_t *")] nuint* pDataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkCmdBindShadingRateImageNV", ExactSpelling = true)]
        public static extern void vkCmdBindShadingRateImageNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImageView")] ulong imageView, VkImageLayout imageLayout);

        [DllImport("vulkan", EntryPoint = "vkCmdSetViewportShadingRatePaletteNV", ExactSpelling = true)]
        public static extern void vkCmdSetViewportShadingRatePaletteNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkShadingRatePaletteNV *")] VkShadingRatePaletteNV* pShadingRatePalettes);

        [DllImport("vulkan", EntryPoint = "vkCmdSetCoarseSampleOrderNV", ExactSpelling = true)]
        public static extern void vkCmdSetCoarseSampleOrderNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, [NativeTypeName("uint32_t")] uint customSampleOrderCount, [NativeTypeName("const VkCoarseSampleOrderCustomNV *")] VkCoarseSampleOrderCustomNV* pCustomSampleOrders);

        [DllImport("vulkan", EntryPoint = "vkCreateAccelerationStructureNV", ExactSpelling = true)]
        public static extern VkResult vkCreateAccelerationStructureNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureCreateInfoNV *")] VkAccelerationStructureCreateInfoNV* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkAccelerationStructureNV *")] ulong* pAccelerationStructure);

        [DllImport("vulkan", EntryPoint = "vkDestroyAccelerationStructureKHR", ExactSpelling = true)]
        public static extern void vkDestroyAccelerationStructureKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureKHR")] ulong accelerationStructure, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkDestroyAccelerationStructureNV", ExactSpelling = true)]
        public static extern void vkDestroyAccelerationStructureNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureKHR")] ulong accelerationStructure, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV", ExactSpelling = true)]
        public static extern void vkGetAccelerationStructureMemoryRequirementsNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureMemoryRequirementsInfoNV *")] VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, [NativeTypeName("VkMemoryRequirements2KHR *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkBindAccelerationStructureMemoryKHR", ExactSpelling = true)]
        public static extern VkResult vkBindAccelerationStructureMemoryKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindAccelerationStructureMemoryInfoKHR *")] VkBindAccelerationStructureMemoryInfoKHR* pBindInfos);

        [DllImport("vulkan", EntryPoint = "vkBindAccelerationStructureMemoryNV", ExactSpelling = true)]
        public static extern VkResult vkBindAccelerationStructureMemoryNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindAccelerationStructureMemoryInfoKHR *")] VkBindAccelerationStructureMemoryInfoKHR* pBindInfos);

        [DllImport("vulkan", EntryPoint = "vkCmdBuildAccelerationStructureNV", ExactSpelling = true)]
        public static extern void vkCmdBuildAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkAccelerationStructureInfoNV *")] VkAccelerationStructureInfoNV* pInfo, [NativeTypeName("VkBuffer")] ulong instanceData, [NativeTypeName("VkDeviceSize")] ulong instanceOffset, [NativeTypeName("VkBool32")] uint update, [NativeTypeName("VkAccelerationStructureKHR")] ulong dst, [NativeTypeName("VkAccelerationStructureKHR")] ulong src, [NativeTypeName("VkBuffer")] ulong scratch, [NativeTypeName("VkDeviceSize")] ulong scratchOffset);

        [DllImport("vulkan", EntryPoint = "vkCmdCopyAccelerationStructureNV", ExactSpelling = true)]
        public static extern void vkCmdCopyAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkAccelerationStructureKHR")] ulong dst, [NativeTypeName("VkAccelerationStructureKHR")] ulong src, VkCopyAccelerationStructureModeKHR mode);

        [DllImport("vulkan", EntryPoint = "vkCmdTraceRaysNV", ExactSpelling = true)]
        public static extern void vkCmdTraceRaysNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong raygenShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong raygenShaderBindingOffset, [NativeTypeName("VkBuffer")] ulong missShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingStride, [NativeTypeName("VkBuffer")] ulong hitShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingStride, [NativeTypeName("VkBuffer")] ulong callableShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingStride, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth);

        [DllImport("vulkan", EntryPoint = "vkCreateRayTracingPipelinesNV", ExactSpelling = true)]
        public static extern VkResult vkCreateRayTracingPipelinesNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkRayTracingPipelineCreateInfoNV *")] VkRayTracingPipelineCreateInfoNV* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkGetRayTracingShaderGroupHandlesNV", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkGetAccelerationStructureHandleNV", ExactSpelling = true)]
        public static extern VkResult vkGetAccelerationStructureHandleNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureKHR")] ulong accelerationStructure, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR", ExactSpelling = true)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureKHR *")] ulong* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery);

        [DllImport("vulkan", EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV", ExactSpelling = true)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureKHR *")] ulong* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery);

        [DllImport("vulkan", EntryPoint = "vkCompileDeferredNV", ExactSpelling = true)]
        public static extern VkResult vkCompileDeferredNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint shader);

        [DllImport("vulkan", EntryPoint = "vkGetMemoryHostPointerPropertiesEXT", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryHostPointerPropertiesEXT([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, [NativeTypeName("const void *")] void* pHostPointer, [NativeTypeName("VkMemoryHostPointerPropertiesEXT *")] VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

        [DllImport("vulkan", EntryPoint = "vkCmdWriteBufferMarkerAMD", ExactSpelling = true)]
        public static extern void vkCmdWriteBufferMarkerAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("uint32_t")] uint marker);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pTimeDomainCount, [NativeTypeName("VkTimeDomainEXT *")] VkTimeDomainEXT* pTimeDomains);

        [DllImport("vulkan", EntryPoint = "vkGetCalibratedTimestampsEXT", ExactSpelling = true)]
        public static extern VkResult vkGetCalibratedTimestampsEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint timestampCount, [NativeTypeName("const VkCalibratedTimestampInfoEXT *")] VkCalibratedTimestampInfoEXT* pTimestampInfos, [NativeTypeName("uint64_t *")] ulong* pTimestamps, [NativeTypeName("uint64_t *")] ulong* pMaxDeviation);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawMeshTasksNV", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint taskCount, [NativeTypeName("uint32_t")] uint firstTask);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectNV", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksIndirectNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksIndirectCountNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", EntryPoint = "vkCmdSetExclusiveScissorNV", ExactSpelling = true)]
        public static extern void vkCmdSetExclusiveScissorNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstExclusiveScissor, [NativeTypeName("uint32_t")] uint exclusiveScissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pExclusiveScissors);

        [DllImport("vulkan", EntryPoint = "vkCmdSetCheckpointNV", ExactSpelling = true)]
        public static extern void vkCmdSetCheckpointNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const void *")] void* pCheckpointMarker);

        [DllImport("vulkan", EntryPoint = "vkGetQueueCheckpointDataNV", ExactSpelling = true)]
        public static extern void vkGetQueueCheckpointDataNV([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t *")] uint* pCheckpointDataCount, [NativeTypeName("VkCheckpointDataNV *")] VkCheckpointDataNV* pCheckpointData);

        [DllImport("vulkan", EntryPoint = "vkInitializePerformanceApiINTEL", ExactSpelling = true)]
        public static extern VkResult vkInitializePerformanceApiINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkInitializePerformanceApiInfoINTEL *")] VkInitializePerformanceApiInfoINTEL* pInitializeInfo);

        [DllImport("vulkan", EntryPoint = "vkUninitializePerformanceApiINTEL", ExactSpelling = true)]
        public static extern void vkUninitializePerformanceApiINTEL([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport("vulkan", EntryPoint = "vkCmdSetPerformanceMarkerINTEL", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceMarkerINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceMarkerInfoINTEL *")] VkPerformanceMarkerInfoINTEL* pMarkerInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceStreamMarkerInfoINTEL *")] VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdSetPerformanceOverrideINTEL", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceOverrideINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceOverrideInfoINTEL *")] VkPerformanceOverrideInfoINTEL* pOverrideInfo);

        [DllImport("vulkan", EntryPoint = "vkAcquirePerformanceConfigurationINTEL", ExactSpelling = true)]
        public static extern VkResult vkAcquirePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPerformanceConfigurationAcquireInfoINTEL *")] VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [NativeTypeName("VkPerformanceConfigurationINTEL *")] ulong* pConfiguration);

        [DllImport("vulkan", EntryPoint = "vkReleasePerformanceConfigurationINTEL", ExactSpelling = true)]
        public static extern VkResult vkReleasePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPerformanceConfigurationINTEL")] ulong configuration);

        [DllImport("vulkan", EntryPoint = "vkQueueSetPerformanceConfigurationINTEL", ExactSpelling = true)]
        public static extern VkResult vkQueueSetPerformanceConfigurationINTEL([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("VkPerformanceConfigurationINTEL")] ulong configuration);

        [DllImport("vulkan", EntryPoint = "vkGetPerformanceParameterINTEL", ExactSpelling = true)]
        public static extern VkResult vkGetPerformanceParameterINTEL([NativeTypeName("VkDevice")] IntPtr device, VkPerformanceParameterTypeINTEL parameter, [NativeTypeName("VkPerformanceValueINTEL *")] VkPerformanceValueINTEL* pValue);

        [DllImport("vulkan", EntryPoint = "vkSetLocalDimmingAMD", ExactSpelling = true)]
        public static extern void vkSetLocalDimmingAMD([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapChain, [NativeTypeName("VkBool32")] uint localDimmingEnable);

        [DllImport("vulkan", EntryPoint = "vkGetBufferDeviceAddressEXT", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddressEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceToolPropertiesEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pToolCount, [NativeTypeName("VkPhysicalDeviceToolPropertiesEXT *")] VkPhysicalDeviceToolPropertiesEXT* pToolProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkCooperativeMatrixPropertiesNV *")] VkCooperativeMatrixPropertiesNV* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pCombinationCount, [NativeTypeName("VkFramebufferMixedSamplesCombinationNV *")] VkFramebufferMixedSamplesCombinationNV* pCombinations);

        [DllImport("vulkan", EntryPoint = "vkCreateHeadlessSurfaceEXT", ExactSpelling = true)]
        public static extern VkResult vkCreateHeadlessSurfaceEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkHeadlessSurfaceCreateInfoEXT *")] VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport("vulkan", EntryPoint = "vkCmdSetLineStippleEXT", ExactSpelling = true)]
        public static extern void vkCmdSetLineStippleEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint lineStippleFactor, [NativeTypeName("uint16_t")] ushort lineStipplePattern);

        [DllImport("vulkan", EntryPoint = "vkResetQueryPoolEXT", ExactSpelling = true)]
        public static extern void vkResetQueryPoolEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport("vulkan", EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV", ExactSpelling = true)]
        public static extern void vkGetGeneratedCommandsMemoryRequirementsNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkGeneratedCommandsMemoryRequirementsInfoNV *")] VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", EntryPoint = "vkCmdPreprocessGeneratedCommandsNV", ExactSpelling = true)]
        public static extern void vkCmdPreprocessGeneratedCommandsNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkGeneratedCommandsInfoNV *")] VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdExecuteGeneratedCommandsNV", ExactSpelling = true)]
        public static extern void vkCmdExecuteGeneratedCommandsNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBool32")] uint isPreprocessed, [NativeTypeName("const VkGeneratedCommandsInfoNV *")] VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        [DllImport("vulkan", EntryPoint = "vkCmdBindPipelineShaderGroupNV", ExactSpelling = true)]
        public static extern void vkCmdBindPipelineShaderGroupNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint groupIndex);

        [DllImport("vulkan", EntryPoint = "vkCreateIndirectCommandsLayoutNV", ExactSpelling = true)]
        public static extern VkResult vkCreateIndirectCommandsLayoutNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkIndirectCommandsLayoutCreateInfoNV *")] VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkIndirectCommandsLayoutNV *")] ulong* pIndirectCommandsLayout);

        [DllImport("vulkan", EntryPoint = "vkDestroyIndirectCommandsLayoutNV", ExactSpelling = true)]
        public static extern void vkDestroyIndirectCommandsLayoutNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkIndirectCommandsLayoutNV")] ulong indirectCommandsLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);
    }
}
