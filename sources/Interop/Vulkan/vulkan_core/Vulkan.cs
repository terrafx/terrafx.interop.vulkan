// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateInstance([NativeTypeName("const VkInstanceCreateInfo *")] VkInstanceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkInstance *")] IntPtr* pInstance);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyInstance([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDevices([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceCount, [NativeTypeName("VkPhysicalDevice *")] IntPtr* pPhysicalDevices);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures *")] VkPhysicalDeviceFeatures* pFeatures);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties *")] VkFormatProperties* pFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, [NativeTypeName("VkImageUsageFlags")] uint usage, [NativeTypeName("VkImageCreateFlags")] uint flags, [NativeTypeName("VkImageFormatProperties *")] VkImageFormatProperties* pImageFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties *")] VkPhysicalDeviceProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties *")] VkQueueFamilyProperties* pQueueFamilyProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties *")] VkPhysicalDeviceMemoryProperties* pMemoryProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern IntPtr vkGetInstanceProcAddr([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern IntPtr vkGetDeviceProcAddr([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDevice([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkDeviceCreateInfo *")] VkDeviceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDevice *")] IntPtr* pDevice);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDevice([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceExtensionProperties([NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkExtensionProperties *")] VkExtensionProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumerateDeviceExtensionProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkExtensionProperties *")] VkExtensionProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceLayerProperties([NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumerateDeviceLayerProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDeviceQueue([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("uint32_t")] uint queueIndex, [NativeTypeName("VkQueue *")] IntPtr* pQueue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkQueueSubmit([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t")] uint submitCount, [NativeTypeName("const VkSubmitInfo *")] VkSubmitInfo* pSubmits, [NativeTypeName("VkFence")] ulong fence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkQueueWaitIdle([NativeTypeName("VkQueue")] IntPtr queue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDeviceWaitIdle([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAllocateMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryAllocateInfo *")] VkMemoryAllocateInfo* pAllocateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDeviceMemory *")] ulong* pMemory);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkFreeMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkMapMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("VkMemoryMapFlags")] uint flags, [NativeTypeName("void **")] void** ppData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkUnmapMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkFlushMappedMemoryRanges([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkInvalidateMappedMemoryRanges([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDeviceMemoryCommitment([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize *")] ulong* pCommittedMemoryInBytes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkMemoryRequirements *")] VkMemoryRequirements* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkMemoryRequirements *")] VkMemoryRequirements* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements *")] VkSparseImageMemoryRequirements* pSparseMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, [NativeTypeName("VkImageUsageFlags")] uint usage, VkImageTiling tiling, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties *")] VkSparseImageFormatProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkQueueBindSparse([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindSparseInfo *")] VkBindSparseInfo* pBindInfo, [NativeTypeName("VkFence")] ulong fence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateFence([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceCreateInfo *")] VkFenceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyFence([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFence")] ulong fence, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkResetFences([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] ulong* pFences);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetFenceStatus([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFence")] ulong fence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkWaitForFences([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] ulong* pFences, [NativeTypeName("VkBool32")] uint waitAll, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateSemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreCreateInfo *")] VkSemaphoreCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSemaphore *")] ulong* pSemaphore);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroySemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkEventCreateInfo *")] VkEventCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkEvent *")] ulong* pEvent);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetEventStatus([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSetEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkResetEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkQueryPoolCreateInfo *")] VkQueryPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkQueryPool *")] ulong* pQueryPool);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetQueryPoolResults([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateBuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferCreateInfo *")] VkBufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkBuffer *")] ulong* pBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyBuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateBufferView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferViewCreateInfo *")] VkBufferViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkBufferView *")] ulong* pView);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyBufferView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBufferView")] ulong bufferView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateImage([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageCreateInfo *")] VkImageCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkImage *")] ulong* pImage);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyImage([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageSubresourceLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("const VkImageSubresource *")] VkImageSubresource* pSubresource, [NativeTypeName("VkSubresourceLayout *")] VkSubresourceLayout* pLayout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateImageView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageViewCreateInfo *")] VkImageViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkImageView *")] ulong* pView);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyImageView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImageView")] ulong imageView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateShaderModule([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkShaderModuleCreateInfo *")] VkShaderModuleCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkShaderModule *")] ulong* pShaderModule);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyShaderModule([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkShaderModule")] ulong shaderModule, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreatePipelineCache([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineCacheCreateInfo *")] VkPipelineCacheCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipelineCache *")] ulong* pPipelineCache);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyPipelineCache([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineCacheData([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("size_t *")] nuint* pDataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkMergePipelineCaches([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkPipelineCache *")] ulong* pSrcCaches);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateGraphicsPipelines([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkGraphicsPipelineCreateInfo *")] VkGraphicsPipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateComputePipelines([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkComputePipelineCreateInfo *")] VkComputePipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyPipeline([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreatePipelineLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineLayoutCreateInfo *")] VkPipelineLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipelineLayout *")] ulong* pPipelineLayout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyPipelineLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineLayout")] ulong pipelineLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateSampler([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerCreateInfo *")] VkSamplerCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSampler *")] ulong* pSampler);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroySampler([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSampler")] ulong sampler, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorSetLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorSetLayout *")] ulong* pSetLayout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorSetLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSetLayout")] ulong descriptorSetLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorPoolCreateInfo *")] VkDescriptorPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorPool *")] ulong* pDescriptorPool);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkResetDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("VkDescriptorPoolResetFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAllocateDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetAllocateInfo *")] VkDescriptorSetAllocateInfo* pAllocateInfo, [NativeTypeName("VkDescriptorSet *")] ulong* pDescriptorSets);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkFreeDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] ulong* pDescriptorSets);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites, [NativeTypeName("uint32_t")] uint descriptorCopyCount, [NativeTypeName("const VkCopyDescriptorSet *")] VkCopyDescriptorSet* pDescriptorCopies);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateFramebuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFramebufferCreateInfo *")] VkFramebufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFramebuffer *")] ulong* pFramebuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyFramebuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFramebuffer")] ulong framebuffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo *")] VkRenderPassCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyRenderPass([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkRenderPass")] ulong renderPass, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetRenderAreaGranularity([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkRenderPass")] ulong renderPass, [NativeTypeName("VkExtent2D *")] VkExtent2D* pGranularity);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCommandPoolCreateInfo *")] VkCommandPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkCommandPool *")] ulong* pCommandPool);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkResetCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolResetFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAllocateCommandBuffers([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCommandBufferAllocateInfo *")] VkCommandBufferAllocateInfo* pAllocateInfo, [NativeTypeName("VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkFreeCommandBuffers([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBeginCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCommandBufferBeginInfo *")] VkCommandBufferBeginInfo* pBeginInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEndCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkResetCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkCommandBufferResetFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindPipeline([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipeline")] ulong pipeline);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetViewport([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewport *")] VkViewport* pViewports);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetScissor([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstScissor, [NativeTypeName("uint32_t")] uint scissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pScissors);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetLineWidth([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float lineWidth);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBias([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetBlendConstants([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const float [4]")] float* blendConstants);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBounds([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float minDepthBounds, float maxDepthBounds);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetStencilCompareMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint compareMask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetStencilWriteMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint writeMask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetStencilReference([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint reference);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindDescriptorSets([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint firstSet, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] ulong* pDescriptorSets, [NativeTypeName("uint32_t")] uint dynamicOffsetCount, [NativeTypeName("const uint32_t *")] uint* pDynamicOffsets);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindIndexBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkIndexType indexType);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindVertexBuffers([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDraw([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint vertexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstVertex, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexed([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint indexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstIndex, [NativeTypeName("int32_t")] int vertexOffset, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDispatch([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDispatchIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong srcBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferCopy *")] VkBufferCopy* pRegions);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageCopy *")] VkImageCopy* pRegions);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBlitImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageBlit *")] VkImageBlit* pRegions, VkFilter filter);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyBufferToImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong srcBuffer, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyImageToBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdUpdateBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong dataSize, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdFillBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("uint32_t")] uint data);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdClearColorImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong image, VkImageLayout imageLayout, [NativeTypeName("const VkClearColorValue *")] VkClearColorValue* pColor, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdClearDepthStencilImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong image, VkImageLayout imageLayout, [NativeTypeName("const VkClearDepthStencilValue *")] VkClearDepthStencilValue* pDepthStencil, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdClearAttachments([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint attachmentCount, [NativeTypeName("const VkClearAttachment *")] VkClearAttachment* pAttachments, [NativeTypeName("uint32_t")] uint rectCount, [NativeTypeName("const VkClearRect *")] VkClearRect* pRects);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdResolveImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageResolve *")] VkImageResolve* pRegions);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetEvent([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("VkPipelineStageFlags")] uint stageMask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdResetEvent([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("VkPipelineStageFlags")] uint stageMask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWaitEvents([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint eventCount, [NativeTypeName("const VkEvent *")] ulong* pEvents, [NativeTypeName("VkPipelineStageFlags")] uint srcStageMask, [NativeTypeName("VkPipelineStageFlags")] uint dstStageMask, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPipelineBarrier([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkPipelineStageFlags")] uint srcStageMask, [NativeTypeName("VkPipelineStageFlags")] uint dstStageMask, [NativeTypeName("VkDependencyFlags")] uint dependencyFlags, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdResetQueryPool([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteTimestamp([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyQueryPoolResults([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPushConstants([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("VkShaderStageFlags")] uint stageFlags, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint size, [NativeTypeName("const void *")] void* pValues);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkSubpassContents contents);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdExecuteCommands([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceVersion([NativeTypeName("uint32_t *")] uint* pApiVersion);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDeviceGroupPeerMemoryFeatures([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDeviceMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDispatchBase([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroups([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, [NativeTypeName("VkPhysicalDeviceGroupProperties *")] VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements2 *")] VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures2 *")] VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties2 *")] VkPhysicalDeviceProperties2* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties2 *")] VkFormatProperties2* pFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, [NativeTypeName("VkImageFormatProperties2 *")] VkImageFormatProperties2* pImageFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties2 *")] VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties2 *")] VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties2 *")] VkSparseImageFormatProperties2* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkTrimCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDeviceQueue2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceQueueInfo2 *")] VkDeviceQueueInfo2* pQueueInfo, [NativeTypeName("VkQueue *")] IntPtr* pQueue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateSamplerYcbcrConversion([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSamplerYcbcrConversion *")] ulong* pYcbcrConversion);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroySamplerYcbcrConversion([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSamplerYcbcrConversion")] ulong ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorUpdateTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorUpdateTemplate *")] ulong* pDescriptorUpdateTemplate);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorUpdateTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSetWithTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSet")] ulong descriptorSet, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalBufferProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [NativeTypeName("VkExternalBufferProperties *")] VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalFenceProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [NativeTypeName("VkExternalFenceProperties *")] VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalSemaphoreProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [NativeTypeName("VkExternalSemaphoreProperties *")] VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDescriptorSetLayoutSupport([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("VkDescriptorSetLayoutSupport *")] VkDescriptorSetLayoutSupport* pSupport);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCount([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCount([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo2 *")] VkRenderPassCreateInfo2* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass2([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass2([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass2([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkResetQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreCounterValue([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("uint64_t *")] ulong* pValue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkWaitSemaphores([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreWaitInfo *")] VkSemaphoreWaitInfo* pWaitInfo, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSignalSemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreSignalInfo *")] VkSemaphoreSignalInfo* pSignalInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddress([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetBufferOpaqueCaptureAddress([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetDeviceMemoryOpaqueCaptureAddress([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceMemoryOpaqueCaptureAddressInfo *")] VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroySurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkBool32 *")] uint* pSupported);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkSurfaceCapabilitiesKHR *")] VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormatsKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, [NativeTypeName("VkSurfaceFormatKHR *")] VkSurfaceFormatKHR* pSurfaceFormats);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfacePresentModesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pPresentModeCount, [NativeTypeName("VkPresentModeKHR *")] VkPresentModeKHR* pPresentModes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateSwapchainKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSwapchainKHR *")] ulong* pSwapchain);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroySwapchainKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainImagesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint32_t *")] uint* pSwapchainImageCount, [NativeTypeName("VkImage *")] ulong* pSwapchainImages);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquireNextImageKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint64_t")] ulong timeout, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("VkFence")] ulong fence, [NativeTypeName("uint32_t *")] uint* pImageIndex);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkQueuePresentKHR([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkPresentInfoKHR *")] VkPresentInfoKHR* pPresentInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceGroupPresentCapabilitiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceGroupPresentCapabilitiesKHR *")] VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceGroupSurfacePresentModesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkDeviceGroupPresentModeFlagsKHR *")] uint* pModes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDevicePresentRectanglesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pRectCount, [NativeTypeName("VkRect2D *")] VkRect2D* pRects);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquireNextImage2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAcquireNextImageInfoKHR *")] VkAcquireNextImageInfoKHR* pAcquireInfo, [NativeTypeName("uint32_t *")] uint* pImageIndex);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPropertiesKHR *")] VkDisplayPropertiesKHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPlanePropertiesKHR *")] VkDisplayPlanePropertiesKHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneSupportedDisplaysKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("uint32_t *")] uint* pDisplayCount, [NativeTypeName("VkDisplayKHR *")] ulong* pDisplays);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayModePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayModePropertiesKHR *")] VkDisplayModePropertiesKHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDisplayModeKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayModeCreateInfoKHR *")] VkDisplayModeCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDisplayModeKHR *")] ulong* pMode);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayModeKHR")] ulong mode, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("VkDisplayPlaneCapabilitiesKHR *")] VkDisplayPlaneCapabilitiesKHR* pCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDisplayPlaneSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDisplaySurfaceCreateInfoKHR *")] VkDisplaySurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateSharedSwapchainsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSwapchainKHR *")] ulong* pSwapchains);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures2 *")] VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties2 *")] VkPhysicalDeviceProperties2* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties2 *")] VkFormatProperties2* pFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, [NativeTypeName("VkImageFormatProperties2 *")] VkImageFormatProperties2* pImageFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties2 *")] VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties2 *")] VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties2 *")] VkSparseImageFormatProperties2* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDeviceMaskKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDispatchBaseKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkTrimCommandPoolKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroupsKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, [NativeTypeName("VkPhysicalDeviceGroupProperties *")] VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalBufferPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [NativeTypeName("VkExternalBufferProperties *")] VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryGetFdInfoKHR *")] VkMemoryGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryFdPropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, [NativeTypeName("VkMemoryFdPropertiesKHR *")] VkMemoryFdPropertiesKHR* pMemoryFdProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [NativeTypeName("VkExternalSemaphoreProperties *")] VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkImportSemaphoreFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportSemaphoreFdInfoKHR *")] VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreGetFdInfoKHR *")] VkSemaphoreGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPushDescriptorSetKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorUpdateTemplate *")] ulong* pDescriptorUpdateTemplate);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSetWithTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSet")] ulong descriptorSet, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo2 *")] VkRenderPassCreateInfo2* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainStatusKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalFencePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [NativeTypeName("VkExternalFenceProperties *")] VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkImportFenceFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportFenceFdInfoKHR *")] VkImportFenceFdInfoKHR* pImportFenceFdInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetFenceFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceGetFdInfoKHR *")] VkFenceGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("uint32_t *")] uint* pCounterCount, [NativeTypeName("VkPerformanceCounterKHR *")] VkPerformanceCounterKHR* pCounters, [NativeTypeName("VkPerformanceCounterDescriptionKHR *")] VkPerformanceCounterDescriptionKHR* pCounterDescriptions);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkQueryPoolPerformanceCreateInfoKHR *")] VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [NativeTypeName("uint32_t *")] uint* pNumPasses);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquireProfilingLockKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAcquireProfilingLockInfoKHR *")] VkAcquireProfilingLockInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkReleaseProfilingLockKHR([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("VkSurfaceCapabilities2KHR *")] VkSurfaceCapabilities2KHR* pSurfaceCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormats2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, [NativeTypeName("VkSurfaceFormat2KHR *")] VkSurfaceFormat2KHR* pSurfaceFormats);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayProperties2KHR *")] VkDisplayProperties2KHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPlaneProperties2KHR *")] VkDisplayPlaneProperties2KHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayModeProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayModeProperties2KHR *")] VkDisplayModeProperties2KHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkDisplayPlaneInfo2KHR *")] VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, [NativeTypeName("VkDisplayPlaneCapabilities2KHR *")] VkDisplayPlaneCapabilities2KHR* pCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements2 *")] VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateSamplerYcbcrConversionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSamplerYcbcrConversion *")] ulong* pYcbcrConversion);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroySamplerYcbcrConversionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSamplerYcbcrConversion")] ulong ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDescriptorSetLayoutSupportKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("VkDescriptorSetLayoutSupport *")] VkDescriptorSetLayoutSupport* pSupport);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCountKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCountKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreCounterValueKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("uint64_t *")] ulong* pValue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkWaitSemaphoresKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreWaitInfo *")] VkSemaphoreWaitInfo* pWaitInfo, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSignalSemaphoreKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreSignalInfo *")] VkSemaphoreSignalInfo* pSignalInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddressKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetBufferOpaqueCaptureAddressKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetDeviceMemoryOpaqueCaptureAddressKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceMemoryOpaqueCaptureAddressInfo *")] VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutablePropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineInfoKHR *")] VkPipelineInfoKHR* pPipelineInfo, [NativeTypeName("uint32_t *")] uint* pExecutableCount, [NativeTypeName("VkPipelineExecutablePropertiesKHR *")] VkPipelineExecutablePropertiesKHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutableStatisticsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pStatisticCount, [NativeTypeName("VkPipelineExecutableStatisticKHR *")] VkPipelineExecutableStatisticKHR* pStatistics);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutableInternalRepresentationsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pInternalRepresentationCount, [NativeTypeName("VkPipelineExecutableInternalRepresentationKHR *")] VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDebugReportCallbackEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDebugReportCallbackCreateInfoEXT *")] VkDebugReportCallbackCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDebugReportCallbackEXT *")] ulong* pCallback);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDebugReportCallbackEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugReportCallbackEXT")] ulong callback, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDebugReportMessageEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugReportFlagsEXT")] uint flags, VkDebugReportObjectTypeEXT objectType, [NativeTypeName("uint64_t")] ulong @object, [NativeTypeName("size_t")] nuint location, [NativeTypeName("int32_t")] int messageCode, [NativeTypeName("const char *")] sbyte* pLayerPrefix, [NativeTypeName("const char *")] sbyte* pMessage);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDebugMarkerSetObjectTagEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugMarkerObjectTagInfoEXT *")] VkDebugMarkerObjectTagInfoEXT* pTagInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDebugMarkerSetObjectNameEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugMarkerObjectNameInfoEXT *")] VkDebugMarkerObjectNameInfoEXT* pNameInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerBeginEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerEndEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerInsertEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindTransformFeedbackBuffersEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets, [NativeTypeName("const VkDeviceSize *")] ulong* pSizes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] ulong* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] ulong* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginQueryIndexedEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags, [NativeTypeName("uint32_t")] uint index);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndQueryIndexedEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("uint32_t")] uint index);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectByteCountEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstInstance, [NativeTypeName("VkBuffer")] ulong counterBuffer, [NativeTypeName("VkDeviceSize")] ulong counterBufferOffset, [NativeTypeName("uint32_t")] uint counterOffset, [NativeTypeName("uint32_t")] uint vertexStride);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint vkGetImageViewHandleNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageViewHandleInfoNVX *")] VkImageViewHandleInfoNVX* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCountAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetShaderInfoAMD([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, [NativeTypeName("size_t *")] nuint* pInfoSize, [NativeTypeName("void *")] void* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, [NativeTypeName("VkImageUsageFlags")] uint usage, [NativeTypeName("VkImageCreateFlags")] uint flags, [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")] uint externalHandleType, [NativeTypeName("VkExternalImageFormatPropertiesNV *")] VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkConditionalRenderingBeginInfoEXT *")] VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetViewportWScalingNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewportWScalingNV *")] VkViewportWScalingNV* pViewportWScalings);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkReleaseDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkSurfaceCapabilities2EXT *")] VkSurfaceCapabilities2EXT* pSurfaceCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDisplayPowerControlEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayPowerInfoEXT *")] VkDisplayPowerInfoEXT* pDisplayPowerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkRegisterDeviceEventEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceEventInfoEXT *")] VkDeviceEventInfoEXT* pDeviceEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkRegisterDisplayEventEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayEventInfoEXT *")] VkDisplayEventInfoEXT* pDisplayEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainCounterEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, VkSurfaceCounterFlagBitsEXT counter, [NativeTypeName("uint64_t *")] ulong* pCounterValue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRefreshCycleDurationGOOGLE([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("VkRefreshCycleDurationGOOGLE *")] VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPastPresentationTimingGOOGLE([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint32_t *")] uint* pPresentationTimingCount, [NativeTypeName("VkPastPresentationTimingGOOGLE *")] VkPastPresentationTimingGOOGLE* pPresentationTimings);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDiscardRectangleEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstDiscardRectangle, [NativeTypeName("uint32_t")] uint discardRectangleCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pDiscardRectangles);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkSetHdrMetadataEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainKHR *")] ulong* pSwapchains, [NativeTypeName("const VkHdrMetadataEXT *")] VkHdrMetadataEXT* pMetadata);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSetDebugUtilsObjectNameEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")] VkDebugUtilsObjectNameInfoEXT* pNameInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSetDebugUtilsObjectTagEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugUtilsObjectTagInfoEXT *")] VkDebugUtilsObjectTagInfoEXT* pTagInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkQueueBeginDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkQueueEndDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkQueueInsertDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdInsertDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDebugUtilsMessengerCreateInfoEXT *")] VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDebugUtilsMessengerEXT *")] ulong* pMessenger);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugUtilsMessengerEXT")] ulong messenger, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkSubmitDebugUtilsMessageEXT([NativeTypeName("VkInstance")] IntPtr instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")] uint messageTypes, [NativeTypeName("const VkDebugUtilsMessengerCallbackDataEXT *")] VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetSampleLocationsEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSampleLocationsInfoEXT *")] VkSampleLocationsInfoEXT* pSampleLocationsInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMultisamplePropertiesEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkSampleCountFlagBits samples, [NativeTypeName("VkMultisamplePropertiesEXT *")] VkMultisamplePropertiesEXT* pMultisampleProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetImageDrmFormatModifierPropertiesEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkImageDrmFormatModifierPropertiesEXT *")] VkImageDrmFormatModifierPropertiesEXT* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateValidationCacheEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkValidationCacheCreateInfoEXT *")] VkValidationCacheCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkValidationCacheEXT *")] ulong* pValidationCache);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyValidationCacheEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong validationCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkMergeValidationCachesEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkValidationCacheEXT *")] ulong* pSrcCaches);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetValidationCacheDataEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong validationCache, [NativeTypeName("size_t *")] nuint* pDataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindShadingRateImageNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImageView")] ulong imageView, VkImageLayout imageLayout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetViewportShadingRatePaletteNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkShadingRatePaletteNV *")] VkShadingRatePaletteNV* pShadingRatePalettes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetCoarseSampleOrderNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, [NativeTypeName("uint32_t")] uint customSampleOrderCount, [NativeTypeName("const VkCoarseSampleOrderCustomNV *")] VkCoarseSampleOrderCustomNV* pCustomSampleOrders);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateAccelerationStructureNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureCreateInfoNV *")] VkAccelerationStructureCreateInfoNV* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkAccelerationStructureNV *")] ulong* pAccelerationStructure);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyAccelerationStructureKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureKHR")] ulong accelerationStructure, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyAccelerationStructureNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureKHR")] ulong accelerationStructure, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetAccelerationStructureMemoryRequirementsNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureMemoryRequirementsInfoNV *")] VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, [NativeTypeName("VkMemoryRequirements2KHR *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindAccelerationStructureMemoryKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindAccelerationStructureMemoryInfoKHR *")] VkBindAccelerationStructureMemoryInfoKHR* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindAccelerationStructureMemoryNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindAccelerationStructureMemoryInfoKHR *")] VkBindAccelerationStructureMemoryInfoKHR* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBuildAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkAccelerationStructureInfoNV *")] VkAccelerationStructureInfoNV* pInfo, [NativeTypeName("VkBuffer")] ulong instanceData, [NativeTypeName("VkDeviceSize")] ulong instanceOffset, [NativeTypeName("VkBool32")] uint update, [NativeTypeName("VkAccelerationStructureKHR")] ulong dst, [NativeTypeName("VkAccelerationStructureKHR")] ulong src, [NativeTypeName("VkBuffer")] ulong scratch, [NativeTypeName("VkDeviceSize")] ulong scratchOffset);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkAccelerationStructureKHR")] ulong dst, [NativeTypeName("VkAccelerationStructureKHR")] ulong src, VkCopyAccelerationStructureModeKHR mode);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdTraceRaysNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong raygenShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong raygenShaderBindingOffset, [NativeTypeName("VkBuffer")] ulong missShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingStride, [NativeTypeName("VkBuffer")] ulong hitShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingStride, [NativeTypeName("VkBuffer")] ulong callableShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingStride, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateRayTracingPipelinesNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkRayTracingPipelineCreateInfoNV *")] VkRayTracingPipelineCreateInfoNV* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetAccelerationStructureHandleNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureKHR")] ulong accelerationStructure, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureKHR *")] ulong* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureKHR *")] ulong* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCompileDeferredNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint shader);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryHostPointerPropertiesEXT([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, [NativeTypeName("const void *")] void* pHostPointer, [NativeTypeName("VkMemoryHostPointerPropertiesEXT *")] VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteBufferMarkerAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("uint32_t")] uint marker);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pTimeDomainCount, [NativeTypeName("VkTimeDomainEXT *")] VkTimeDomainEXT* pTimeDomains);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetCalibratedTimestampsEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint timestampCount, [NativeTypeName("const VkCalibratedTimestampInfoEXT *")] VkCalibratedTimestampInfoEXT* pTimestampInfos, [NativeTypeName("uint64_t *")] ulong* pTimestamps, [NativeTypeName("uint64_t *")] ulong* pMaxDeviation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint taskCount, [NativeTypeName("uint32_t")] uint firstTask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksIndirectNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksIndirectCountNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetExclusiveScissorNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstExclusiveScissor, [NativeTypeName("uint32_t")] uint exclusiveScissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pExclusiveScissors);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetCheckpointNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const void *")] void* pCheckpointMarker);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetQueueCheckpointDataNV([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t *")] uint* pCheckpointDataCount, [NativeTypeName("VkCheckpointDataNV *")] VkCheckpointDataNV* pCheckpointData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkInitializePerformanceApiINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkInitializePerformanceApiInfoINTEL *")] VkInitializePerformanceApiInfoINTEL* pInitializeInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkUninitializePerformanceApiINTEL([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceMarkerINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceMarkerInfoINTEL *")] VkPerformanceMarkerInfoINTEL* pMarkerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceStreamMarkerInfoINTEL *")] VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceOverrideINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceOverrideInfoINTEL *")] VkPerformanceOverrideInfoINTEL* pOverrideInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquirePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPerformanceConfigurationAcquireInfoINTEL *")] VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [NativeTypeName("VkPerformanceConfigurationINTEL *")] ulong* pConfiguration);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkReleasePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPerformanceConfigurationINTEL")] ulong configuration);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkQueueSetPerformanceConfigurationINTEL([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("VkPerformanceConfigurationINTEL")] ulong configuration);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPerformanceParameterINTEL([NativeTypeName("VkDevice")] IntPtr device, VkPerformanceParameterTypeINTEL parameter, [NativeTypeName("VkPerformanceValueINTEL *")] VkPerformanceValueINTEL* pValue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkSetLocalDimmingAMD([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapChain, [NativeTypeName("VkBool32")] uint localDimmingEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddressEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceToolPropertiesEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pToolCount, [NativeTypeName("VkPhysicalDeviceToolPropertiesEXT *")] VkPhysicalDeviceToolPropertiesEXT* pToolProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkCooperativeMatrixPropertiesNV *")] VkCooperativeMatrixPropertiesNV* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pCombinationCount, [NativeTypeName("VkFramebufferMixedSamplesCombinationNV *")] VkFramebufferMixedSamplesCombinationNV* pCombinations);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateHeadlessSurfaceEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkHeadlessSurfaceCreateInfoEXT *")] VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetLineStippleEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint lineStippleFactor, [NativeTypeName("uint16_t")] ushort lineStipplePattern);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkResetQueryPoolEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetGeneratedCommandsMemoryRequirementsNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkGeneratedCommandsMemoryRequirementsInfoNV *")] VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPreprocessGeneratedCommandsNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkGeneratedCommandsInfoNV *")] VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdExecuteGeneratedCommandsNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBool32")] uint isPreprocessed, [NativeTypeName("const VkGeneratedCommandsInfoNV *")] VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindPipelineShaderGroupNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint groupIndex);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateIndirectCommandsLayoutNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkIndirectCommandsLayoutCreateInfoNV *")] VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkIndirectCommandsLayoutNV *")] ulong* pIndirectCommandsLayout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyIndirectCommandsLayoutNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkIndirectCommandsLayoutNV")] ulong indirectCommandsLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);
    }
}
