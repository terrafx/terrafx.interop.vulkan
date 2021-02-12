// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
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
        public static extern delegate* unmanaged<void> vkGetInstanceProcAddr([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern delegate* unmanaged<void> vkGetDeviceProcAddr([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const char *")] sbyte* pName);

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
        public static extern void vkCmdCopyBuffer2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCopyBufferInfo2KHR *")] VkCopyBufferInfo2KHR* pCopyBufferInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyImage2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCopyImageInfo2KHR *")] VkCopyImageInfo2KHR* pCopyImageInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyBufferToImage2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCopyBufferToImageInfo2KHR *")] VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyImageToBuffer2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCopyImageToBufferInfo2KHR *")] VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBlitImage2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkBlitImageInfo2KHR *")] VkBlitImageInfo2KHR* pBlitImageInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdResolveImage2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkResolveImageInfo2KHR *")] VkResolveImageInfo2KHR* pResolveImageInfo);

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
        public static extern VkResult vkGetImageViewAddressNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImageView")] ulong imageView, [NativeTypeName("VkImageViewAddressPropertiesNVX *")] VkImageViewAddressPropertiesNVX* pProperties);

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
        public static extern void vkCmdSetCullModeEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkCullModeFlags")] uint cullMode);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetFrontFaceEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkFrontFace frontFace);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetPrimitiveTopologyEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPrimitiveTopology primitiveTopology);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetViewportWithCountEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewport *")] VkViewport* pViewports);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetScissorWithCountEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint scissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pScissors);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindVertexBuffers2EXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets, [NativeTypeName("const VkDeviceSize *")] ulong* pSizes, [NativeTypeName("const VkDeviceSize *")] ulong* pStrides);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthTestEnableEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBool32")] uint depthTestEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthWriteEnableEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBool32")] uint depthWriteEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthCompareOpEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkCompareOp depthCompareOp);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBoundsTestEnableEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBool32")] uint depthBoundsTestEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetStencilTestEnableEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBool32")] uint stencilTestEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetStencilOpEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);

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

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreatePrivateDataSlotEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPrivateDataSlotCreateInfoEXT *")] VkPrivateDataSlotCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPrivateDataSlotEXT *")] ulong* pPrivateDataSlot);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyPrivateDataSlotEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPrivateDataSlotEXT")] ulong privateDataSlot, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSetPrivateDataEXT([NativeTypeName("VkDevice")] IntPtr device, VkObjectType objectType, [NativeTypeName("uint64_t")] ulong objectHandle, [NativeTypeName("VkPrivateDataSlotEXT")] ulong privateDataSlot, [NativeTypeName("uint64_t")] ulong data);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPrivateDataEXT([NativeTypeName("VkDevice")] IntPtr device, VkObjectType objectType, [NativeTypeName("uint64_t")] ulong objectHandle, [NativeTypeName("VkPrivateDataSlotEXT")] ulong privateDataSlot, [NativeTypeName("uint64_t *")] ulong* pData);

        [NativeTypeName("#define VK_VERSION_1_0 1")]
        public const int VK_VERSION_1_0 = 1;

        [NativeTypeName("#define VK_API_VERSION_1_0 VK_MAKE_VERSION(1, 0, 0)")]
        public const uint VK_API_VERSION_1_0 = ((((uint)(1)) << 22) | (((uint)(0)) << 12) | ((uint)(0)));

        [NativeTypeName("#define VK_HEADER_VERSION 154")]
        public const int VK_HEADER_VERSION = 154;

        [NativeTypeName("#define VK_HEADER_VERSION_COMPLETE VK_MAKE_VERSION(1, 2, VK_HEADER_VERSION)")]
        public const uint VK_HEADER_VERSION_COMPLETE = ((((uint)(1)) << 22) | (((uint)(2)) << 12) | ((uint)(154)));

        [NativeTypeName("#define VK_NULL_HANDLE 0")]
        public const int VK_NULL_HANDLE = 0;

        [NativeTypeName("#define VK_ATTACHMENT_UNUSED (~0U)")]
        public const uint VK_ATTACHMENT_UNUSED = (~0U);

        [NativeTypeName("#define VK_FALSE 0")]
        public const int VK_FALSE = 0;

        [NativeTypeName("#define VK_LOD_CLAMP_NONE 1000.0f")]
        public const float VK_LOD_CLAMP_NONE = 1000.0f;

        [NativeTypeName("#define VK_QUEUE_FAMILY_IGNORED (~0U)")]
        public const uint VK_QUEUE_FAMILY_IGNORED = (~0U);

        [NativeTypeName("#define VK_REMAINING_ARRAY_LAYERS (~0U)")]
        public const uint VK_REMAINING_ARRAY_LAYERS = (~0U);

        [NativeTypeName("#define VK_REMAINING_MIP_LEVELS (~0U)")]
        public const uint VK_REMAINING_MIP_LEVELS = (~0U);

        [NativeTypeName("#define VK_SUBPASS_EXTERNAL (~0U)")]
        public const uint VK_SUBPASS_EXTERNAL = (~0U);

        [NativeTypeName("#define VK_TRUE 1")]
        public const int VK_TRUE = 1;

        [NativeTypeName("#define VK_WHOLE_SIZE (~0ULL)")]
        public const ulong VK_WHOLE_SIZE = (~0UL);

        [NativeTypeName("#define VK_MAX_MEMORY_TYPES 32")]
        public const int VK_MAX_MEMORY_TYPES = 32;

        [NativeTypeName("#define VK_MAX_MEMORY_HEAPS 16")]
        public const int VK_MAX_MEMORY_HEAPS = 16;

        [NativeTypeName("#define VK_MAX_PHYSICAL_DEVICE_NAME_SIZE 256")]
        public const int VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256;

        [NativeTypeName("#define VK_UUID_SIZE 16")]
        public const int VK_UUID_SIZE = 16;

        [NativeTypeName("#define VK_MAX_EXTENSION_NAME_SIZE 256")]
        public const int VK_MAX_EXTENSION_NAME_SIZE = 256;

        [NativeTypeName("#define VK_MAX_DESCRIPTION_SIZE 256")]
        public const int VK_MAX_DESCRIPTION_SIZE = 256;

        [NativeTypeName("#define VK_VERSION_1_1 1")]
        public const int VK_VERSION_1_1 = 1;

        [NativeTypeName("#define VK_API_VERSION_1_1 VK_MAKE_VERSION(1, 1, 0)")]
        public const uint VK_API_VERSION_1_1 = ((((uint)(1)) << 22) | (((uint)(1)) << 12) | ((uint)(0)));

        [NativeTypeName("#define VK_MAX_DEVICE_GROUP_SIZE 32")]
        public const int VK_MAX_DEVICE_GROUP_SIZE = 32;

        [NativeTypeName("#define VK_LUID_SIZE 8")]
        public const int VK_LUID_SIZE = 8;

        [NativeTypeName("#define VK_QUEUE_FAMILY_EXTERNAL (~0U-1)")]
        public const uint VK_QUEUE_FAMILY_EXTERNAL = (~0U - 1);

        [NativeTypeName("#define VK_VERSION_1_2 1")]
        public const int VK_VERSION_1_2 = 1;

        [NativeTypeName("#define VK_API_VERSION_1_2 VK_MAKE_VERSION(1, 2, 0)")]
        public const uint VK_API_VERSION_1_2 = ((((uint)(1)) << 22) | (((uint)(2)) << 12) | ((uint)(0)));

        [NativeTypeName("#define VK_MAX_DRIVER_NAME_SIZE 256")]
        public const int VK_MAX_DRIVER_NAME_SIZE = 256;

        [NativeTypeName("#define VK_MAX_DRIVER_INFO_SIZE 256")]
        public const int VK_MAX_DRIVER_INFO_SIZE = 256;

        [NativeTypeName("#define VK_KHR_surface 1")]
        public const int VK_KHR_surface = 1;

        [NativeTypeName("#define VK_KHR_SURFACE_SPEC_VERSION 25")]
        public const int VK_KHR_SURFACE_SPEC_VERSION = 25;

        [NativeTypeName("#define VK_KHR_SURFACE_EXTENSION_NAME \"VK_KHR_surface\"")]
        public static ReadOnlySpan<byte> VK_KHR_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_swapchain 1")]
        public const int VK_KHR_swapchain = 1;

        [NativeTypeName("#define VK_KHR_SWAPCHAIN_SPEC_VERSION 70")]
        public const int VK_KHR_SWAPCHAIN_SPEC_VERSION = 70;

        [NativeTypeName("#define VK_KHR_SWAPCHAIN_EXTENSION_NAME \"VK_KHR_swapchain\"")]
        public static ReadOnlySpan<byte> VK_KHR_SWAPCHAIN_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x77, 0x61, 0x70, 0x63, 0x68, 0x61, 0x69, 0x6E, 0x00 };

        [NativeTypeName("#define VK_KHR_display 1")]
        public const int VK_KHR_display = 1;

        [NativeTypeName("#define VK_KHR_DISPLAY_SPEC_VERSION 23")]
        public const int VK_KHR_DISPLAY_SPEC_VERSION = 23;

        [NativeTypeName("#define VK_KHR_DISPLAY_EXTENSION_NAME \"VK_KHR_display\"")]
        public static ReadOnlySpan<byte> VK_KHR_DISPLAY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };

        [NativeTypeName("#define VK_KHR_display_swapchain 1")]
        public const int VK_KHR_display_swapchain = 1;

        [NativeTypeName("#define VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION 10")]
        public const int VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION = 10;

        [NativeTypeName("#define VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME \"VK_KHR_display_swapchain\"")]
        public static ReadOnlySpan<byte> VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x5F, 0x73, 0x77, 0x61, 0x70, 0x63, 0x68, 0x61, 0x69, 0x6E, 0x00 };

        [NativeTypeName("#define VK_KHR_sampler_mirror_clamp_to_edge 1")]
        public const int VK_KHR_sampler_mirror_clamp_to_edge = 1;

        [NativeTypeName("#define VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION 3")]
        public const int VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME \"VK_KHR_sampler_mirror_clamp_to_edge\"")]
        public static ReadOnlySpan<byte> VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x72, 0x5F, 0x6D, 0x69, 0x72, 0x72, 0x6F, 0x72, 0x5F, 0x63, 0x6C, 0x61, 0x6D, 0x70, 0x5F, 0x74, 0x6F, 0x5F, 0x65, 0x64, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_multiview 1")]
        public const int VK_KHR_multiview = 1;

        [NativeTypeName("#define VK_KHR_MULTIVIEW_SPEC_VERSION 1")]
        public const int VK_KHR_MULTIVIEW_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MULTIVIEW_EXTENSION_NAME \"VK_KHR_multiview\"")]
        public static ReadOnlySpan<byte> VK_KHR_MULTIVIEW_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x6D, 0x75, 0x6C, 0x74, 0x69, 0x76, 0x69, 0x65, 0x77, 0x00 };

        [NativeTypeName("#define VK_KHR_get_physical_device_properties2 1")]
        public const int VK_KHR_get_physical_device_properties2 = 1;

        [NativeTypeName("#define VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION 2")]
        public const int VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME \"VK_KHR_get_physical_device_properties2\"")]
        public static ReadOnlySpan<byte> VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x67, 0x65, 0x74, 0x5F, 0x70, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x70, 0x72, 0x6F, 0x70, 0x65, 0x72, 0x74, 0x69, 0x65, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_device_group 1")]
        public const int VK_KHR_device_group = 1;

        [NativeTypeName("#define VK_KHR_DEVICE_GROUP_SPEC_VERSION 4")]
        public const int VK_KHR_DEVICE_GROUP_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_KHR_DEVICE_GROUP_EXTENSION_NAME \"VK_KHR_device_group\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEVICE_GROUP_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x00 };

        [NativeTypeName("#define VK_KHR_shader_draw_parameters 1")]
        public const int VK_KHR_shader_draw_parameters = 1;

        [NativeTypeName("#define VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME \"VK_KHR_shader_draw_parameters\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x64, 0x72, 0x61, 0x77, 0x5F, 0x70, 0x61, 0x72, 0x61, 0x6D, 0x65, 0x74, 0x65, 0x72, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_maintenance1 1")]
        public const int VK_KHR_maintenance1 = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE1_SPEC_VERSION 2")]
        public const int VK_KHR_MAINTENANCE1_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_MAINTENANCE1_EXTENSION_NAME \"VK_KHR_maintenance1\"")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE1_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x6D, 0x61, 0x69, 0x6E, 0x74, 0x65, 0x6E, 0x61, 0x6E, 0x63, 0x65, 0x31, 0x00 };

        [NativeTypeName("#define VK_KHR_device_group_creation 1")]
        public const int VK_KHR_device_group_creation = 1;

        [NativeTypeName("#define VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION 1")]
        public const int VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME \"VK_KHR_device_group_creation\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x63, 0x72, 0x65, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define VK_MAX_DEVICE_GROUP_SIZE_KHR VK_MAX_DEVICE_GROUP_SIZE")]
        public const int VK_MAX_DEVICE_GROUP_SIZE_KHR = 32;

        [NativeTypeName("#define VK_KHR_external_memory_capabilities 1")]
        public const int VK_KHR_external_memory_capabilities = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_memory_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x63, 0x61, 0x70, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_LUID_SIZE_KHR VK_LUID_SIZE")]
        public const int VK_LUID_SIZE_KHR = 8;

        [NativeTypeName("#define VK_KHR_external_memory 1")]
        public const int VK_KHR_external_memory = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_KHR_external_memory\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_QUEUE_FAMILY_EXTERNAL_KHR VK_QUEUE_FAMILY_EXTERNAL")]
        public const uint VK_QUEUE_FAMILY_EXTERNAL_KHR = (~0U - 1);

        [NativeTypeName("#define VK_KHR_external_memory_fd 1")]
        public const int VK_KHR_external_memory_fd = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME \"VK_KHR_external_memory_fd\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x66, 0x64, 0x00 };

        [NativeTypeName("#define VK_KHR_external_semaphore_capabilities 1")]
        public const int VK_KHR_external_semaphore_capabilities = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_semaphore_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x70, 0x68, 0x6F, 0x72, 0x65, 0x5F, 0x63, 0x61, 0x70, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_external_semaphore 1")]
        public const int VK_KHR_external_semaphore = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME \"VK_KHR_external_semaphore\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x70, 0x68, 0x6F, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_external_semaphore_fd 1")]
        public const int VK_KHR_external_semaphore_fd = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME \"VK_KHR_external_semaphore_fd\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x70, 0x68, 0x6F, 0x72, 0x65, 0x5F, 0x66, 0x64, 0x00 };

        [NativeTypeName("#define VK_KHR_push_descriptor 1")]
        public const int VK_KHR_push_descriptor = 1;

        [NativeTypeName("#define VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION 2")]
        public const int VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME \"VK_KHR_push_descriptor\"")]
        public static ReadOnlySpan<byte> VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x75, 0x73, 0x68, 0x5F, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define VK_KHR_shader_float16_int8 1")]
        public const int VK_KHR_shader_float16_int8 = 1;

        [NativeTypeName("#define VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME \"VK_KHR_shader_float16_int8\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x66, 0x6C, 0x6F, 0x61, 0x74, 0x31, 0x36, 0x5F, 0x69, 0x6E, 0x74, 0x38, 0x00 };

        [NativeTypeName("#define VK_KHR_16bit_storage 1")]
        public const int VK_KHR_16bit_storage = 1;

        [NativeTypeName("#define VK_KHR_16BIT_STORAGE_SPEC_VERSION 1")]
        public const int VK_KHR_16BIT_STORAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_16BIT_STORAGE_EXTENSION_NAME \"VK_KHR_16bit_storage\"")]
        public static ReadOnlySpan<byte> VK_KHR_16BIT_STORAGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x31, 0x36, 0x62, 0x69, 0x74, 0x5F, 0x73, 0x74, 0x6F, 0x72, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_incremental_present 1")]
        public const int VK_KHR_incremental_present = 1;

        [NativeTypeName("#define VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION 1")]
        public const int VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME \"VK_KHR_incremental_present\"")]
        public static ReadOnlySpan<byte> VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x69, 0x6E, 0x63, 0x72, 0x65, 0x6D, 0x65, 0x6E, 0x74, 0x61, 0x6C, 0x5F, 0x70, 0x72, 0x65, 0x73, 0x65, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define VK_KHR_descriptor_update_template 1")]
        public const int VK_KHR_descriptor_update_template = 1;

        [NativeTypeName("#define VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION 1")]
        public const int VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME \"VK_KHR_descriptor_update_template\"")]
        public static ReadOnlySpan<byte> VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x6F, 0x72, 0x5F, 0x75, 0x70, 0x64, 0x61, 0x74, 0x65, 0x5F, 0x74, 0x65, 0x6D, 0x70, 0x6C, 0x61, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_imageless_framebuffer 1")]
        public const int VK_KHR_imageless_framebuffer = 1;

        [NativeTypeName("#define VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION 1")]
        public const int VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME \"VK_KHR_imageless_framebuffer\"")]
        public static ReadOnlySpan<byte> VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x6C, 0x65, 0x73, 0x73, 0x5F, 0x66, 0x72, 0x61, 0x6D, 0x65, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_KHR_create_renderpass2 1")]
        public const int VK_KHR_create_renderpass2 = 1;

        [NativeTypeName("#define VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION 1")]
        public const int VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME \"VK_KHR_create_renderpass2\"")]
        public static ReadOnlySpan<byte> VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x5F, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x70, 0x61, 0x73, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_shared_presentable_image 1")]
        public const int VK_KHR_shared_presentable_image = 1;

        [NativeTypeName("#define VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION 1")]
        public const int VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME \"VK_KHR_shared_presentable_image\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x72, 0x65, 0x64, 0x5F, 0x70, 0x72, 0x65, 0x73, 0x65, 0x6E, 0x74, 0x61, 0x62, 0x6C, 0x65, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_external_fence_capabilities 1")]
        public const int VK_KHR_external_fence_capabilities = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_fence_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x66, 0x65, 0x6E, 0x63, 0x65, 0x5F, 0x63, 0x61, 0x70, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_external_fence 1")]
        public const int VK_KHR_external_fence = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_FENCE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME \"VK_KHR_external_fence\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x66, 0x65, 0x6E, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_external_fence_fd 1")]
        public const int VK_KHR_external_fence_fd = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME \"VK_KHR_external_fence_fd\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x66, 0x65, 0x6E, 0x63, 0x65, 0x5F, 0x66, 0x64, 0x00 };

        [NativeTypeName("#define VK_KHR_performance_query 1")]
        public const int VK_KHR_performance_query = 1;

        [NativeTypeName("#define VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION 1")]
        public const int VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME \"VK_KHR_performance_query\"")]
        public static ReadOnlySpan<byte> VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x65, 0x72, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x6E, 0x63, 0x65, 0x5F, 0x71, 0x75, 0x65, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_KHR_maintenance2 1")]
        public const int VK_KHR_maintenance2 = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE2_SPEC_VERSION 1")]
        public const int VK_KHR_MAINTENANCE2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE2_EXTENSION_NAME \"VK_KHR_maintenance2\"")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x6D, 0x61, 0x69, 0x6E, 0x74, 0x65, 0x6E, 0x61, 0x6E, 0x63, 0x65, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_get_surface_capabilities2 1")]
        public const int VK_KHR_get_surface_capabilities2 = 1;

        [NativeTypeName("#define VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION 1")]
        public const int VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME \"VK_KHR_get_surface_capabilities2\"")]
        public static ReadOnlySpan<byte> VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x67, 0x65, 0x74, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x5F, 0x63, 0x61, 0x70, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x69, 0x65, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_variable_pointers 1")]
        public const int VK_KHR_variable_pointers = 1;

        [NativeTypeName("#define VK_KHR_VARIABLE_POINTERS_SPEC_VERSION 1")]
        public const int VK_KHR_VARIABLE_POINTERS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME \"VK_KHR_variable_pointers\"")]
        public static ReadOnlySpan<byte> VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x76, 0x61, 0x72, 0x69, 0x61, 0x62, 0x6C, 0x65, 0x5F, 0x70, 0x6F, 0x69, 0x6E, 0x74, 0x65, 0x72, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_get_display_properties2 1")]
        public const int VK_KHR_get_display_properties2 = 1;

        [NativeTypeName("#define VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION 1")]
        public const int VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME \"VK_KHR_get_display_properties2\"")]
        public static ReadOnlySpan<byte> VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x67, 0x65, 0x74, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x5F, 0x70, 0x72, 0x6F, 0x70, 0x65, 0x72, 0x74, 0x69, 0x65, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_dedicated_allocation 1")]
        public const int VK_KHR_dedicated_allocation = 1;

        [NativeTypeName("#define VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION 3")]
        public const int VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME \"VK_KHR_dedicated_allocation\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x65, 0x64, 0x69, 0x63, 0x61, 0x74, 0x65, 0x64, 0x5F, 0x61, 0x6C, 0x6C, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define VK_KHR_storage_buffer_storage_class 1")]
        public const int VK_KHR_storage_buffer_storage_class = 1;

        [NativeTypeName("#define VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION 1")]
        public const int VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME \"VK_KHR_storage_buffer_storage_class\"")]
        public static ReadOnlySpan<byte> VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x74, 0x6F, 0x72, 0x61, 0x67, 0x65, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x5F, 0x73, 0x74, 0x6F, 0x72, 0x61, 0x67, 0x65, 0x5F, 0x63, 0x6C, 0x61, 0x73, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_relaxed_block_layout 1")]
        public const int VK_KHR_relaxed_block_layout = 1;

        [NativeTypeName("#define VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION 1")]
        public const int VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME \"VK_KHR_relaxed_block_layout\"")]
        public static ReadOnlySpan<byte> VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x72, 0x65, 0x6C, 0x61, 0x78, 0x65, 0x64, 0x5F, 0x62, 0x6C, 0x6F, 0x63, 0x6B, 0x5F, 0x6C, 0x61, 0x79, 0x6F, 0x75, 0x74, 0x00 };

        [NativeTypeName("#define VK_KHR_get_memory_requirements2 1")]
        public const int VK_KHR_get_memory_requirements2 = 1;

        [NativeTypeName("#define VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION 1")]
        public const int VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME \"VK_KHR_get_memory_requirements2\"")]
        public static ReadOnlySpan<byte> VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x67, 0x65, 0x74, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x72, 0x65, 0x71, 0x75, 0x69, 0x72, 0x65, 0x6D, 0x65, 0x6E, 0x74, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_image_format_list 1")]
        public const int VK_KHR_image_format_list = 1;

        [NativeTypeName("#define VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION 1")]
        public const int VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME \"VK_KHR_image_format_list\"")]
        public static ReadOnlySpan<byte> VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x5F, 0x6C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define VK_KHR_sampler_ycbcr_conversion 1")]
        public const int VK_KHR_sampler_ycbcr_conversion = 1;

        [NativeTypeName("#define VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION 14")]
        public const int VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION = 14;

        [NativeTypeName("#define VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME \"VK_KHR_sampler_ycbcr_conversion\"")]
        public static ReadOnlySpan<byte> VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x72, 0x5F, 0x79, 0x63, 0x62, 0x63, 0x72, 0x5F, 0x63, 0x6F, 0x6E, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define VK_KHR_bind_memory2 1")]
        public const int VK_KHR_bind_memory2 = 1;

        [NativeTypeName("#define VK_KHR_BIND_MEMORY_2_SPEC_VERSION 1")]
        public const int VK_KHR_BIND_MEMORY_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_BIND_MEMORY_2_EXTENSION_NAME \"VK_KHR_bind_memory2\"")]
        public static ReadOnlySpan<byte> VK_KHR_BIND_MEMORY_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x62, 0x69, 0x6E, 0x64, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_maintenance3 1")]
        public const int VK_KHR_maintenance3 = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE3_SPEC_VERSION 1")]
        public const int VK_KHR_MAINTENANCE3_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE3_EXTENSION_NAME \"VK_KHR_maintenance3\"")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE3_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x6D, 0x61, 0x69, 0x6E, 0x74, 0x65, 0x6E, 0x61, 0x6E, 0x63, 0x65, 0x33, 0x00 };

        [NativeTypeName("#define VK_KHR_draw_indirect_count 1")]
        public const int VK_KHR_draw_indirect_count = 1;

        [NativeTypeName("#define VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION 1")]
        public const int VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME \"VK_KHR_draw_indirect_count\"")]
        public static ReadOnlySpan<byte> VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x72, 0x61, 0x77, 0x5F, 0x69, 0x6E, 0x64, 0x69, 0x72, 0x65, 0x63, 0x74, 0x5F, 0x63, 0x6F, 0x75, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define VK_KHR_shader_subgroup_extended_types 1")]
        public const int VK_KHR_shader_subgroup_extended_types = 1;

        [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_EXTENSION_NAME \"VK_KHR_shader_subgroup_extended_types\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x73, 0x75, 0x62, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x6E, 0x64, 0x65, 0x64, 0x5F, 0x74, 0x79, 0x70, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_8bit_storage 1")]
        public const int VK_KHR_8bit_storage = 1;

        [NativeTypeName("#define VK_KHR_8BIT_STORAGE_SPEC_VERSION 1")]
        public const int VK_KHR_8BIT_STORAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_8BIT_STORAGE_EXTENSION_NAME \"VK_KHR_8bit_storage\"")]
        public static ReadOnlySpan<byte> VK_KHR_8BIT_STORAGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x38, 0x62, 0x69, 0x74, 0x5F, 0x73, 0x74, 0x6F, 0x72, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_shader_atomic_int64 1")]
        public const int VK_KHR_shader_atomic_int64 = 1;

        [NativeTypeName("#define VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME \"VK_KHR_shader_atomic_int64\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x61, 0x74, 0x6F, 0x6D, 0x69, 0x63, 0x5F, 0x69, 0x6E, 0x74, 0x36, 0x34, 0x00 };

        [NativeTypeName("#define VK_KHR_shader_clock 1")]
        public const int VK_KHR_shader_clock = 1;

        [NativeTypeName("#define VK_KHR_SHADER_CLOCK_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_CLOCK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_CLOCK_EXTENSION_NAME \"VK_KHR_shader_clock\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_CLOCK_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x63, 0x6C, 0x6F, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define VK_KHR_driver_properties 1")]
        public const int VK_KHR_driver_properties = 1;

        [NativeTypeName("#define VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION 1")]
        public const int VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME \"VK_KHR_driver_properties\"")]
        public static ReadOnlySpan<byte> VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x72, 0x69, 0x76, 0x65, 0x72, 0x5F, 0x70, 0x72, 0x6F, 0x70, 0x65, 0x72, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_MAX_DRIVER_NAME_SIZE_KHR VK_MAX_DRIVER_NAME_SIZE")]
        public const int VK_MAX_DRIVER_NAME_SIZE_KHR = 256;

        [NativeTypeName("#define VK_MAX_DRIVER_INFO_SIZE_KHR VK_MAX_DRIVER_INFO_SIZE")]
        public const int VK_MAX_DRIVER_INFO_SIZE_KHR = 256;

        [NativeTypeName("#define VK_KHR_shader_float_controls 1")]
        public const int VK_KHR_shader_float_controls = 1;

        [NativeTypeName("#define VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION 4")]
        public const int VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME \"VK_KHR_shader_float_controls\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x66, 0x6C, 0x6F, 0x61, 0x74, 0x5F, 0x63, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_depth_stencil_resolve 1")]
        public const int VK_KHR_depth_stencil_resolve = 1;

        [NativeTypeName("#define VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION 1")]
        public const int VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME \"VK_KHR_depth_stencil_resolve\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x65, 0x70, 0x74, 0x68, 0x5F, 0x73, 0x74, 0x65, 0x6E, 0x63, 0x69, 0x6C, 0x5F, 0x72, 0x65, 0x73, 0x6F, 0x6C, 0x76, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_swapchain_mutable_format 1")]
        public const int VK_KHR_swapchain_mutable_format = 1;

        [NativeTypeName("#define VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION 1")]
        public const int VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME \"VK_KHR_swapchain_mutable_format\"")]
        public static ReadOnlySpan<byte> VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x77, 0x61, 0x70, 0x63, 0x68, 0x61, 0x69, 0x6E, 0x5F, 0x6D, 0x75, 0x74, 0x61, 0x62, 0x6C, 0x65, 0x5F, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x00 };

        [NativeTypeName("#define VK_KHR_timeline_semaphore 1")]
        public const int VK_KHR_timeline_semaphore = 1;

        [NativeTypeName("#define VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION 2")]
        public const int VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME \"VK_KHR_timeline_semaphore\"")]
        public static ReadOnlySpan<byte> VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x74, 0x69, 0x6D, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x70, 0x68, 0x6F, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_vulkan_memory_model 1")]
        public const int VK_KHR_vulkan_memory_model = 1;

        [NativeTypeName("#define VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION 3")]
        public const int VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME \"VK_KHR_vulkan_memory_model\"")]
        public static ReadOnlySpan<byte> VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x6D, 0x6F, 0x64, 0x65, 0x6C, 0x00 };

        [NativeTypeName("#define VK_KHR_spirv_1_4 1")]
        public const int VK_KHR_spirv_1_4 = 1;

        [NativeTypeName("#define VK_KHR_SPIRV_1_4_SPEC_VERSION 1")]
        public const int VK_KHR_SPIRV_1_4_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SPIRV_1_4_EXTENSION_NAME \"VK_KHR_spirv_1_4\"")]
        public static ReadOnlySpan<byte> VK_KHR_SPIRV_1_4_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x70, 0x69, 0x72, 0x76, 0x5F, 0x31, 0x5F, 0x34, 0x00 };

        [NativeTypeName("#define VK_KHR_surface_protected_capabilities 1")]
        public const int VK_KHR_surface_protected_capabilities = 1;

        [NativeTypeName("#define VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME \"VK_KHR_surface_protected_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x5F, 0x70, 0x72, 0x6F, 0x74, 0x65, 0x63, 0x74, 0x65, 0x64, 0x5F, 0x63, 0x61, 0x70, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_separate_depth_stencil_layouts 1")]
        public const int VK_KHR_separate_depth_stencil_layouts = 1;

        [NativeTypeName("#define VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION 1")]
        public const int VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME \"VK_KHR_separate_depth_stencil_layouts\"")]
        public static ReadOnlySpan<byte> VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x65, 0x70, 0x61, 0x72, 0x61, 0x74, 0x65, 0x5F, 0x64, 0x65, 0x70, 0x74, 0x68, 0x5F, 0x73, 0x74, 0x65, 0x6E, 0x63, 0x69, 0x6C, 0x5F, 0x6C, 0x61, 0x79, 0x6F, 0x75, 0x74, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_uniform_buffer_standard_layout 1")]
        public const int VK_KHR_uniform_buffer_standard_layout = 1;

        [NativeTypeName("#define VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION 1")]
        public const int VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME \"VK_KHR_uniform_buffer_standard_layout\"")]
        public static ReadOnlySpan<byte> VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x75, 0x6E, 0x69, 0x66, 0x6F, 0x72, 0x6D, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x5F, 0x73, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x5F, 0x6C, 0x61, 0x79, 0x6F, 0x75, 0x74, 0x00 };

        [NativeTypeName("#define VK_KHR_buffer_device_address 1")]
        public const int VK_KHR_buffer_device_address = 1;

        [NativeTypeName("#define VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION 1")]
        public const int VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME \"VK_KHR_buffer_device_address\"")]
        public static ReadOnlySpan<byte> VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x61, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_pipeline_executable_properties 1")]
        public const int VK_KHR_pipeline_executable_properties = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION 1")]
        public const int VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME \"VK_KHR_pipeline_executable_properties\"")]
        public static ReadOnlySpan<byte> VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x65, 0x78, 0x65, 0x63, 0x75, 0x74, 0x61, 0x62, 0x6C, 0x65, 0x5F, 0x70, 0x72, 0x6F, 0x70, 0x65, 0x72, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_shader_non_semantic_info 1")]
        public const int VK_KHR_shader_non_semantic_info = 1;

        [NativeTypeName("#define VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME \"VK_KHR_shader_non_semantic_info\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x6E, 0x6F, 0x6E, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x6E, 0x74, 0x69, 0x63, 0x5F, 0x69, 0x6E, 0x66, 0x6F, 0x00 };

        [NativeTypeName("#define VK_KHR_copy_commands2 1")]
        public const int VK_KHR_copy_commands2 = 1;

        [NativeTypeName("#define VK_KHR_COPY_COMMANDS_2_SPEC_VERSION 1")]
        public const int VK_KHR_COPY_COMMANDS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME \"VK_KHR_copy_commands2\"")]
        public static ReadOnlySpan<byte> VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x63, 0x6F, 0x70, 0x79, 0x5F, 0x63, 0x6F, 0x6D, 0x6D, 0x61, 0x6E, 0x64, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_EXT_debug_report 1")]
        public const int VK_EXT_debug_report = 1;

        [NativeTypeName("#define VK_EXT_DEBUG_REPORT_SPEC_VERSION 9")]
        public const int VK_EXT_DEBUG_REPORT_SPEC_VERSION = 9;

        [NativeTypeName("#define VK_EXT_DEBUG_REPORT_EXTENSION_NAME \"VK_EXT_debug_report\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEBUG_REPORT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x65, 0x62, 0x75, 0x67, 0x5F, 0x72, 0x65, 0x70, 0x6F, 0x72, 0x74, 0x00 };

        [NativeTypeName("#define VK_NV_glsl_shader 1")]
        public const int VK_NV_glsl_shader = 1;

        [NativeTypeName("#define VK_NV_GLSL_SHADER_SPEC_VERSION 1")]
        public const int VK_NV_GLSL_SHADER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_GLSL_SHADER_EXTENSION_NAME \"VK_NV_glsl_shader\"")]
        public static ReadOnlySpan<byte> VK_NV_GLSL_SHADER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x67, 0x6C, 0x73, 0x6C, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_depth_range_unrestricted 1")]
        public const int VK_EXT_depth_range_unrestricted = 1;

        [NativeTypeName("#define VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION 1")]
        public const int VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME \"VK_EXT_depth_range_unrestricted\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x65, 0x70, 0x74, 0x68, 0x5F, 0x72, 0x61, 0x6E, 0x67, 0x65, 0x5F, 0x75, 0x6E, 0x72, 0x65, 0x73, 0x74, 0x72, 0x69, 0x63, 0x74, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define VK_IMG_filter_cubic 1")]
        public const int VK_IMG_filter_cubic = 1;

        [NativeTypeName("#define VK_IMG_FILTER_CUBIC_SPEC_VERSION 1")]
        public const int VK_IMG_FILTER_CUBIC_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_IMG_FILTER_CUBIC_EXTENSION_NAME \"VK_IMG_filter_cubic\"")]
        public static ReadOnlySpan<byte> VK_IMG_FILTER_CUBIC_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x49, 0x4D, 0x47, 0x5F, 0x66, 0x69, 0x6C, 0x74, 0x65, 0x72, 0x5F, 0x63, 0x75, 0x62, 0x69, 0x63, 0x00 };

        [NativeTypeName("#define VK_AMD_rasterization_order 1")]
        public const int VK_AMD_rasterization_order = 1;

        [NativeTypeName("#define VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION 1")]
        public const int VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME \"VK_AMD_rasterization_order\"")]
        public static ReadOnlySpan<byte> VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x72, 0x61, 0x73, 0x74, 0x65, 0x72, 0x69, 0x7A, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x6F, 0x72, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_AMD_shader_trinary_minmax 1")]
        public const int VK_AMD_shader_trinary_minmax = 1;

        [NativeTypeName("#define VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME \"VK_AMD_shader_trinary_minmax\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x74, 0x72, 0x69, 0x6E, 0x61, 0x72, 0x79, 0x5F, 0x6D, 0x69, 0x6E, 0x6D, 0x61, 0x78, 0x00 };

        [NativeTypeName("#define VK_AMD_shader_explicit_vertex_parameter 1")]
        public const int VK_AMD_shader_explicit_vertex_parameter = 1;

        [NativeTypeName("#define VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME \"VK_AMD_shader_explicit_vertex_parameter\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x65, 0x78, 0x70, 0x6C, 0x69, 0x63, 0x69, 0x74, 0x5F, 0x76, 0x65, 0x72, 0x74, 0x65, 0x78, 0x5F, 0x70, 0x61, 0x72, 0x61, 0x6D, 0x65, 0x74, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_debug_marker 1")]
        public const int VK_EXT_debug_marker = 1;

        [NativeTypeName("#define VK_EXT_DEBUG_MARKER_SPEC_VERSION 4")]
        public const int VK_EXT_DEBUG_MARKER_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_EXT_DEBUG_MARKER_EXTENSION_NAME \"VK_EXT_debug_marker\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEBUG_MARKER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x65, 0x62, 0x75, 0x67, 0x5F, 0x6D, 0x61, 0x72, 0x6B, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_AMD_gcn_shader 1")]
        public const int VK_AMD_gcn_shader = 1;

        [NativeTypeName("#define VK_AMD_GCN_SHADER_SPEC_VERSION 1")]
        public const int VK_AMD_GCN_SHADER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_GCN_SHADER_EXTENSION_NAME \"VK_AMD_gcn_shader\"")]
        public static ReadOnlySpan<byte> VK_AMD_GCN_SHADER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x67, 0x63, 0x6E, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_NV_dedicated_allocation 1")]
        public const int VK_NV_dedicated_allocation = 1;

        [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION 1")]
        public const int VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME \"VK_NV_dedicated_allocation\"")]
        public static ReadOnlySpan<byte> VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x64, 0x65, 0x64, 0x69, 0x63, 0x61, 0x74, 0x65, 0x64, 0x5F, 0x61, 0x6C, 0x6C, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define VK_EXT_transform_feedback 1")]
        public const int VK_EXT_transform_feedback = 1;

        [NativeTypeName("#define VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION 1")]
        public const int VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME \"VK_EXT_transform_feedback\"")]
        public static ReadOnlySpan<byte> VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x74, 0x72, 0x61, 0x6E, 0x73, 0x66, 0x6F, 0x72, 0x6D, 0x5F, 0x66, 0x65, 0x65, 0x64, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define VK_NVX_image_view_handle 1")]
        public const int VK_NVX_image_view_handle = 1;

        [NativeTypeName("#define VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION 2")]
        public const int VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME \"VK_NVX_image_view_handle\"")]
        public static ReadOnlySpan<byte> VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x58, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x5F, 0x68, 0x61, 0x6E, 0x64, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define VK_AMD_draw_indirect_count 1")]
        public const int VK_AMD_draw_indirect_count = 1;

        [NativeTypeName("#define VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION 2")]
        public const int VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME \"VK_AMD_draw_indirect_count\"")]
        public static ReadOnlySpan<byte> VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x64, 0x72, 0x61, 0x77, 0x5F, 0x69, 0x6E, 0x64, 0x69, 0x72, 0x65, 0x63, 0x74, 0x5F, 0x63, 0x6F, 0x75, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define VK_AMD_negative_viewport_height 1")]
        public const int VK_AMD_negative_viewport_height = 1;

        [NativeTypeName("#define VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION 1")]
        public const int VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME \"VK_AMD_negative_viewport_height\"")]
        public static ReadOnlySpan<byte> VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x6E, 0x65, 0x67, 0x61, 0x74, 0x69, 0x76, 0x65, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x70, 0x6F, 0x72, 0x74, 0x5F, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x00 };

        [NativeTypeName("#define VK_AMD_gpu_shader_half_float 1")]
        public const int VK_AMD_gpu_shader_half_float = 1;

        [NativeTypeName("#define VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION 2")]
        public const int VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME \"VK_AMD_gpu_shader_half_float\"")]
        public static ReadOnlySpan<byte> VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x67, 0x70, 0x75, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x68, 0x61, 0x6C, 0x66, 0x5F, 0x66, 0x6C, 0x6F, 0x61, 0x74, 0x00 };

        [NativeTypeName("#define VK_AMD_shader_ballot 1")]
        public const int VK_AMD_shader_ballot = 1;

        [NativeTypeName("#define VK_AMD_SHADER_BALLOT_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_BALLOT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_BALLOT_EXTENSION_NAME \"VK_AMD_shader_ballot\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_BALLOT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x62, 0x61, 0x6C, 0x6C, 0x6F, 0x74, 0x00 };

        [NativeTypeName("#define VK_AMD_texture_gather_bias_lod 1")]
        public const int VK_AMD_texture_gather_bias_lod = 1;

        [NativeTypeName("#define VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION 1")]
        public const int VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME \"VK_AMD_texture_gather_bias_lod\"")]
        public static ReadOnlySpan<byte> VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x67, 0x61, 0x74, 0x68, 0x65, 0x72, 0x5F, 0x62, 0x69, 0x61, 0x73, 0x5F, 0x6C, 0x6F, 0x64, 0x00 };

        [NativeTypeName("#define VK_AMD_shader_info 1")]
        public const int VK_AMD_shader_info = 1;

        [NativeTypeName("#define VK_AMD_SHADER_INFO_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_INFO_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_INFO_EXTENSION_NAME \"VK_AMD_shader_info\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_INFO_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x69, 0x6E, 0x66, 0x6F, 0x00 };

        [NativeTypeName("#define VK_AMD_shader_image_load_store_lod 1")]
        public const int VK_AMD_shader_image_load_store_lod = 1;

        [NativeTypeName("#define VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME \"VK_AMD_shader_image_load_store_lod\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x6C, 0x6F, 0x61, 0x64, 0x5F, 0x73, 0x74, 0x6F, 0x72, 0x65, 0x5F, 0x6C, 0x6F, 0x64, 0x00 };

        [NativeTypeName("#define VK_NV_corner_sampled_image 1")]
        public const int VK_NV_corner_sampled_image = 1;

        [NativeTypeName("#define VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION 2")]
        public const int VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME \"VK_NV_corner_sampled_image\"")]
        public static ReadOnlySpan<byte> VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x63, 0x6F, 0x72, 0x6E, 0x65, 0x72, 0x5F, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x64, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_IMG_format_pvrtc 1")]
        public const int VK_IMG_format_pvrtc = 1;

        [NativeTypeName("#define VK_IMG_FORMAT_PVRTC_SPEC_VERSION 1")]
        public const int VK_IMG_FORMAT_PVRTC_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_IMG_FORMAT_PVRTC_EXTENSION_NAME \"VK_IMG_format_pvrtc\"")]
        public static ReadOnlySpan<byte> VK_IMG_FORMAT_PVRTC_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x49, 0x4D, 0x47, 0x5F, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x5F, 0x70, 0x76, 0x72, 0x74, 0x63, 0x00 };

        [NativeTypeName("#define VK_NV_external_memory_capabilities 1")]
        public const int VK_NV_external_memory_capabilities = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME \"VK_NV_external_memory_capabilities\"")]
        public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x63, 0x61, 0x70, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_NV_external_memory 1")]
        public const int VK_NV_external_memory = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_SPEC_VERSION 1")]
        public const int VK_NV_EXTERNAL_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_NV_external_memory\"")]
        public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_EXT_validation_flags 1")]
        public const int VK_EXT_validation_flags = 1;

        [NativeTypeName("#define VK_EXT_VALIDATION_FLAGS_SPEC_VERSION 2")]
        public const int VK_EXT_VALIDATION_FLAGS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME \"VK_EXT_validation_flags\"")]
        public static ReadOnlySpan<byte> VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x76, 0x61, 0x6C, 0x69, 0x64, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x66, 0x6C, 0x61, 0x67, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_shader_subgroup_ballot 1")]
        public const int VK_EXT_shader_subgroup_ballot = 1;

        [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME \"VK_EXT_shader_subgroup_ballot\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x73, 0x75, 0x62, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x62, 0x61, 0x6C, 0x6C, 0x6F, 0x74, 0x00 };

        [NativeTypeName("#define VK_EXT_shader_subgroup_vote 1")]
        public const int VK_EXT_shader_subgroup_vote = 1;

        [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME \"VK_EXT_shader_subgroup_vote\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x73, 0x75, 0x62, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x76, 0x6F, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_texture_compression_astc_hdr 1")]
        public const int VK_EXT_texture_compression_astc_hdr = 1;

        [NativeTypeName("#define VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION 1")]
        public const int VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME \"VK_EXT_texture_compression_astc_hdr\"")]
        public static ReadOnlySpan<byte> VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x69, 0x6F, 0x6E, 0x5F, 0x61, 0x73, 0x74, 0x63, 0x5F, 0x68, 0x64, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_astc_decode_mode 1")]
        public const int VK_EXT_astc_decode_mode = 1;

        [NativeTypeName("#define VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION 1")]
        public const int VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME \"VK_EXT_astc_decode_mode\"")]
        public static ReadOnlySpan<byte> VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x61, 0x73, 0x74, 0x63, 0x5F, 0x64, 0x65, 0x63, 0x6F, 0x64, 0x65, 0x5F, 0x6D, 0x6F, 0x64, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_conditional_rendering 1")]
        public const int VK_EXT_conditional_rendering = 1;

        [NativeTypeName("#define VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION 2")]
        public const int VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME \"VK_EXT_conditional_rendering\"")]
        public static ReadOnlySpan<byte> VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x63, 0x6F, 0x6E, 0x64, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x61, 0x6C, 0x5F, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define VK_NV_clip_space_w_scaling 1")]
        public const int VK_NV_clip_space_w_scaling = 1;

        [NativeTypeName("#define VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION 1")]
        public const int VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME \"VK_NV_clip_space_w_scaling\"")]
        public static ReadOnlySpan<byte> VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x63, 0x6C, 0x69, 0x70, 0x5F, 0x73, 0x70, 0x61, 0x63, 0x65, 0x5F, 0x77, 0x5F, 0x73, 0x63, 0x61, 0x6C, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define VK_EXT_direct_mode_display 1")]
        public const int VK_EXT_direct_mode_display = 1;

        [NativeTypeName("#define VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION 1")]
        public const int VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME \"VK_EXT_direct_mode_display\"")]
        public static ReadOnlySpan<byte> VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x69, 0x72, 0x65, 0x63, 0x74, 0x5F, 0x6D, 0x6F, 0x64, 0x65, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };

        [NativeTypeName("#define VK_EXT_display_surface_counter 1")]
        public const int VK_EXT_display_surface_counter = 1;

        [NativeTypeName("#define VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION 1")]
        public const int VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME \"VK_EXT_display_surface_counter\"")]
        public static ReadOnlySpan<byte> VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x5F, 0x63, 0x6F, 0x75, 0x6E, 0x74, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_display_control 1")]
        public const int VK_EXT_display_control = 1;

        [NativeTypeName("#define VK_EXT_DISPLAY_CONTROL_SPEC_VERSION 1")]
        public const int VK_EXT_DISPLAY_CONTROL_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME \"VK_EXT_display_control\"")]
        public static ReadOnlySpan<byte> VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x5F, 0x63, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x00 };

        [NativeTypeName("#define VK_GOOGLE_display_timing 1")]
        public const int VK_GOOGLE_display_timing = 1;

        [NativeTypeName("#define VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION 1")]
        public const int VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME \"VK_GOOGLE_display_timing\"")]
        public static ReadOnlySpan<byte> VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x47, 0x4F, 0x4F, 0x47, 0x4C, 0x45, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x5F, 0x74, 0x69, 0x6D, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define VK_NV_sample_mask_override_coverage 1")]
        public const int VK_NV_sample_mask_override_coverage = 1;

        [NativeTypeName("#define VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION 1")]
        public const int VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME \"VK_NV_sample_mask_override_coverage\"")]
        public static ReadOnlySpan<byte> VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x5F, 0x6D, 0x61, 0x73, 0x6B, 0x5F, 0x6F, 0x76, 0x65, 0x72, 0x72, 0x69, 0x64, 0x65, 0x5F, 0x63, 0x6F, 0x76, 0x65, 0x72, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_NV_geometry_shader_passthrough 1")]
        public const int VK_NV_geometry_shader_passthrough = 1;

        [NativeTypeName("#define VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION 1")]
        public const int VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME \"VK_NV_geometry_shader_passthrough\"")]
        public static ReadOnlySpan<byte> VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x67, 0x65, 0x6F, 0x6D, 0x65, 0x74, 0x72, 0x79, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x70, 0x61, 0x73, 0x73, 0x74, 0x68, 0x72, 0x6F, 0x75, 0x67, 0x68, 0x00 };

        [NativeTypeName("#define VK_NV_viewport_array2 1")]
        public const int VK_NV_viewport_array2 = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION 1")]
        public const int VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME \"VK_NV_viewport_array2\"")]
        public static ReadOnlySpan<byte> VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x70, 0x6F, 0x72, 0x74, 0x5F, 0x61, 0x72, 0x72, 0x61, 0x79, 0x32, 0x00 };

        [NativeTypeName("#define VK_NVX_multiview_per_view_attributes 1")]
        public const int VK_NVX_multiview_per_view_attributes = 1;

        [NativeTypeName("#define VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION 1")]
        public const int VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME \"VK_NVX_multiview_per_view_attributes\"")]
        public static ReadOnlySpan<byte> VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x58, 0x5F, 0x6D, 0x75, 0x6C, 0x74, 0x69, 0x76, 0x69, 0x65, 0x77, 0x5F, 0x70, 0x65, 0x72, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x5F, 0x61, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_NV_viewport_swizzle 1")]
        public const int VK_NV_viewport_swizzle = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION 1")]
        public const int VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME \"VK_NV_viewport_swizzle\"")]
        public static ReadOnlySpan<byte> VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x70, 0x6F, 0x72, 0x74, 0x5F, 0x73, 0x77, 0x69, 0x7A, 0x7A, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_discard_rectangles 1")]
        public const int VK_EXT_discard_rectangles = 1;

        [NativeTypeName("#define VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION 1")]
        public const int VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME \"VK_EXT_discard_rectangles\"")]
        public static ReadOnlySpan<byte> VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x69, 0x73, 0x63, 0x61, 0x72, 0x64, 0x5F, 0x72, 0x65, 0x63, 0x74, 0x61, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_conservative_rasterization 1")]
        public const int VK_EXT_conservative_rasterization = 1;

        [NativeTypeName("#define VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION 1")]
        public const int VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME \"VK_EXT_conservative_rasterization\"")]
        public static ReadOnlySpan<byte> VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x63, 0x6F, 0x6E, 0x73, 0x65, 0x72, 0x76, 0x61, 0x74, 0x69, 0x76, 0x65, 0x5F, 0x72, 0x61, 0x73, 0x74, 0x65, 0x72, 0x69, 0x7A, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define VK_EXT_depth_clip_enable 1")]
        public const int VK_EXT_depth_clip_enable = 1;

        [NativeTypeName("#define VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION 1")]
        public const int VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME \"VK_EXT_depth_clip_enable\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x65, 0x70, 0x74, 0x68, 0x5F, 0x63, 0x6C, 0x69, 0x70, 0x5F, 0x65, 0x6E, 0x61, 0x62, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_swapchain_colorspace 1")]
        public const int VK_EXT_swapchain_colorspace = 1;

        [NativeTypeName("#define VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION 4")]
        public const int VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME \"VK_EXT_swapchain_colorspace\"")]
        public static ReadOnlySpan<byte> VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x77, 0x61, 0x70, 0x63, 0x68, 0x61, 0x69, 0x6E, 0x5F, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x73, 0x70, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_hdr_metadata 1")]
        public const int VK_EXT_hdr_metadata = 1;

        [NativeTypeName("#define VK_EXT_HDR_METADATA_SPEC_VERSION 2")]
        public const int VK_EXT_HDR_METADATA_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_HDR_METADATA_EXTENSION_NAME \"VK_EXT_hdr_metadata\"")]
        public static ReadOnlySpan<byte> VK_EXT_HDR_METADATA_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x68, 0x64, 0x72, 0x5F, 0x6D, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x00 };

        [NativeTypeName("#define VK_EXT_external_memory_dma_buf 1")]
        public const int VK_EXT_external_memory_dma_buf = 1;

        [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION 1")]
        public const int VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME \"VK_EXT_external_memory_dma_buf\"")]
        public static ReadOnlySpan<byte> VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x64, 0x6D, 0x61, 0x5F, 0x62, 0x75, 0x66, 0x00 };

        [NativeTypeName("#define VK_EXT_queue_family_foreign 1")]
        public const int VK_EXT_queue_family_foreign = 1;

        [NativeTypeName("#define VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION 1")]
        public const int VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME \"VK_EXT_queue_family_foreign\"")]
        public static ReadOnlySpan<byte> VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x5F, 0x66, 0x61, 0x6D, 0x69, 0x6C, 0x79, 0x5F, 0x66, 0x6F, 0x72, 0x65, 0x69, 0x67, 0x6E, 0x00 };

        [NativeTypeName("#define VK_QUEUE_FAMILY_FOREIGN_EXT (~0U-2)")]
        public const uint VK_QUEUE_FAMILY_FOREIGN_EXT = (~0U - 2);

        [NativeTypeName("#define VK_EXT_debug_utils 1")]
        public const int VK_EXT_debug_utils = 1;

        [NativeTypeName("#define VK_EXT_DEBUG_UTILS_SPEC_VERSION 2")]
        public const int VK_EXT_DEBUG_UTILS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_DEBUG_UTILS_EXTENSION_NAME \"VK_EXT_debug_utils\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEBUG_UTILS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x65, 0x62, 0x75, 0x67, 0x5F, 0x75, 0x74, 0x69, 0x6C, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_sampler_filter_minmax 1")]
        public const int VK_EXT_sampler_filter_minmax = 1;

        [NativeTypeName("#define VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION 2")]
        public const int VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME \"VK_EXT_sampler_filter_minmax\"")]
        public static ReadOnlySpan<byte> VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x72, 0x5F, 0x66, 0x69, 0x6C, 0x74, 0x65, 0x72, 0x5F, 0x6D, 0x69, 0x6E, 0x6D, 0x61, 0x78, 0x00 };

        [NativeTypeName("#define VK_AMD_gpu_shader_int16 1")]
        public const int VK_AMD_gpu_shader_int16 = 1;

        [NativeTypeName("#define VK_AMD_GPU_SHADER_INT16_SPEC_VERSION 2")]
        public const int VK_AMD_GPU_SHADER_INT16_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME \"VK_AMD_gpu_shader_int16\"")]
        public static ReadOnlySpan<byte> VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x67, 0x70, 0x75, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x69, 0x6E, 0x74, 0x31, 0x36, 0x00 };

        [NativeTypeName("#define VK_AMD_mixed_attachment_samples 1")]
        public const int VK_AMD_mixed_attachment_samples = 1;

        [NativeTypeName("#define VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION 1")]
        public const int VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME \"VK_AMD_mixed_attachment_samples\"")]
        public static ReadOnlySpan<byte> VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x6D, 0x69, 0x78, 0x65, 0x64, 0x5F, 0x61, 0x74, 0x74, 0x61, 0x63, 0x68, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_AMD_shader_fragment_mask 1")]
        public const int VK_AMD_shader_fragment_mask = 1;

        [NativeTypeName("#define VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME \"VK_AMD_shader_fragment_mask\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x6D, 0x61, 0x73, 0x6B, 0x00 };

        [NativeTypeName("#define VK_EXT_inline_uniform_block 1")]
        public const int VK_EXT_inline_uniform_block = 1;

        [NativeTypeName("#define VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION 1")]
        public const int VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME \"VK_EXT_inline_uniform_block\"")]
        public static ReadOnlySpan<byte> VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x69, 0x6E, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x75, 0x6E, 0x69, 0x66, 0x6F, 0x72, 0x6D, 0x5F, 0x62, 0x6C, 0x6F, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define VK_EXT_shader_stencil_export 1")]
        public const int VK_EXT_shader_stencil_export = 1;

        [NativeTypeName("#define VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME \"VK_EXT_shader_stencil_export\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x73, 0x74, 0x65, 0x6E, 0x63, 0x69, 0x6C, 0x5F, 0x65, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x00 };

        [NativeTypeName("#define VK_EXT_sample_locations 1")]
        public const int VK_EXT_sample_locations = 1;

        [NativeTypeName("#define VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION 1")]
        public const int VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME \"VK_EXT_sample_locations\"")]
        public static ReadOnlySpan<byte> VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x5F, 0x6C, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_blend_operation_advanced 1")]
        public const int VK_EXT_blend_operation_advanced = 1;

        [NativeTypeName("#define VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION 2")]
        public const int VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME \"VK_EXT_blend_operation_advanced\"")]
        public static ReadOnlySpan<byte> VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x62, 0x6C, 0x65, 0x6E, 0x64, 0x5F, 0x6F, 0x70, 0x65, 0x72, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x61, 0x64, 0x76, 0x61, 0x6E, 0x63, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define VK_NV_fragment_coverage_to_color 1")]
        public const int VK_NV_fragment_coverage_to_color = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION 1")]
        public const int VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME \"VK_NV_fragment_coverage_to_color\"")]
        public static ReadOnlySpan<byte> VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x63, 0x6F, 0x76, 0x65, 0x72, 0x61, 0x67, 0x65, 0x5F, 0x74, 0x6F, 0x5F, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define VK_NV_framebuffer_mixed_samples 1")]
        public const int VK_NV_framebuffer_mixed_samples = 1;

        [NativeTypeName("#define VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION 1")]
        public const int VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME \"VK_NV_framebuffer_mixed_samples\"")]
        public static ReadOnlySpan<byte> VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x66, 0x72, 0x61, 0x6D, 0x65, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x5F, 0x6D, 0x69, 0x78, 0x65, 0x64, 0x5F, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_NV_fill_rectangle 1")]
        public const int VK_NV_fill_rectangle = 1;

        [NativeTypeName("#define VK_NV_FILL_RECTANGLE_SPEC_VERSION 1")]
        public const int VK_NV_FILL_RECTANGLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FILL_RECTANGLE_EXTENSION_NAME \"VK_NV_fill_rectangle\"")]
        public static ReadOnlySpan<byte> VK_NV_FILL_RECTANGLE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x66, 0x69, 0x6C, 0x6C, 0x5F, 0x72, 0x65, 0x63, 0x74, 0x61, 0x6E, 0x67, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define VK_NV_shader_sm_builtins 1")]
        public const int VK_NV_shader_sm_builtins = 1;

        [NativeTypeName("#define VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION 1")]
        public const int VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME \"VK_NV_shader_sm_builtins\"")]
        public static ReadOnlySpan<byte> VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x73, 0x6D, 0x5F, 0x62, 0x75, 0x69, 0x6C, 0x74, 0x69, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_post_depth_coverage 1")]
        public const int VK_EXT_post_depth_coverage = 1;

        [NativeTypeName("#define VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION 1")]
        public const int VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME \"VK_EXT_post_depth_coverage\"")]
        public static ReadOnlySpan<byte> VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x70, 0x6F, 0x73, 0x74, 0x5F, 0x64, 0x65, 0x70, 0x74, 0x68, 0x5F, 0x63, 0x6F, 0x76, 0x65, 0x72, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_image_drm_format_modifier 1")]
        public const int VK_EXT_image_drm_format_modifier = 1;

        [NativeTypeName("#define VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION 1")]
        public const int VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME \"VK_EXT_image_drm_format_modifier\"")]
        public static ReadOnlySpan<byte> VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x64, 0x72, 0x6D, 0x5F, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x5F, 0x6D, 0x6F, 0x64, 0x69, 0x66, 0x69, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_validation_cache 1")]
        public const int VK_EXT_validation_cache = 1;

        [NativeTypeName("#define VK_EXT_VALIDATION_CACHE_SPEC_VERSION 1")]
        public const int VK_EXT_VALIDATION_CACHE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_VALIDATION_CACHE_EXTENSION_NAME \"VK_EXT_validation_cache\"")]
        public static ReadOnlySpan<byte> VK_EXT_VALIDATION_CACHE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x76, 0x61, 0x6C, 0x69, 0x64, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x63, 0x61, 0x63, 0x68, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_descriptor_indexing 1")]
        public const int VK_EXT_descriptor_indexing = 1;

        [NativeTypeName("#define VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION 2")]
        public const int VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME \"VK_EXT_descriptor_indexing\"")]
        public static ReadOnlySpan<byte> VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x6F, 0x72, 0x5F, 0x69, 0x6E, 0x64, 0x65, 0x78, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define VK_EXT_shader_viewport_index_layer 1")]
        public const int VK_EXT_shader_viewport_index_layer = 1;

        [NativeTypeName("#define VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME \"VK_EXT_shader_viewport_index_layer\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x70, 0x6F, 0x72, 0x74, 0x5F, 0x69, 0x6E, 0x64, 0x65, 0x78, 0x5F, 0x6C, 0x61, 0x79, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_NV_shading_rate_image 1")]
        public const int VK_NV_shading_rate_image = 1;

        [NativeTypeName("#define VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION 3")]
        public const int VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME \"VK_NV_shading_rate_image\"")]
        public static ReadOnlySpan<byte> VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x69, 0x6E, 0x67, 0x5F, 0x72, 0x61, 0x74, 0x65, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_NV_ray_tracing 1")]
        public const int VK_NV_ray_tracing = 1;

        [NativeTypeName("#define VK_NV_RAY_TRACING_SPEC_VERSION 3")]
        public const int VK_NV_RAY_TRACING_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_NV_RAY_TRACING_EXTENSION_NAME \"VK_NV_ray_tracing\"")]
        public static ReadOnlySpan<byte> VK_NV_RAY_TRACING_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x72, 0x61, 0x79, 0x5F, 0x74, 0x72, 0x61, 0x63, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define VK_SHADER_UNUSED_KHR (~0U)")]
        public const uint VK_SHADER_UNUSED_KHR = (~0U);

        [NativeTypeName("#define VK_SHADER_UNUSED_NV VK_SHADER_UNUSED_KHR")]
        public const uint VK_SHADER_UNUSED_NV = (~0U);

        [NativeTypeName("#define VK_NV_representative_fragment_test 1")]
        public const int VK_NV_representative_fragment_test = 1;

        [NativeTypeName("#define VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION 2")]
        public const int VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME \"VK_NV_representative_fragment_test\"")]
        public static ReadOnlySpan<byte> VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x72, 0x65, 0x70, 0x72, 0x65, 0x73, 0x65, 0x6E, 0x74, 0x61, 0x74, 0x69, 0x76, 0x65, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x74, 0x65, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define VK_EXT_filter_cubic 1")]
        public const int VK_EXT_filter_cubic = 1;

        [NativeTypeName("#define VK_EXT_FILTER_CUBIC_SPEC_VERSION 3")]
        public const int VK_EXT_FILTER_CUBIC_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_EXT_FILTER_CUBIC_EXTENSION_NAME \"VK_EXT_filter_cubic\"")]
        public static ReadOnlySpan<byte> VK_EXT_FILTER_CUBIC_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x66, 0x69, 0x6C, 0x74, 0x65, 0x72, 0x5F, 0x63, 0x75, 0x62, 0x69, 0x63, 0x00 };

        [NativeTypeName("#define VK_QCOM_render_pass_shader_resolve 1")]
        public const int VK_QCOM_render_pass_shader_resolve = 1;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION 4")]
        public const int VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME \"VK_QCOM_render_pass_shader_resolve\"")]
        public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x51, 0x43, 0x4F, 0x4D, 0x5F, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x5F, 0x70, 0x61, 0x73, 0x73, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x72, 0x65, 0x73, 0x6F, 0x6C, 0x76, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_global_priority 1")]
        public const int VK_EXT_global_priority = 1;

        [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION 2")]
        public const int VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME \"VK_EXT_global_priority\"")]
        public static ReadOnlySpan<byte> VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x67, 0x6C, 0x6F, 0x62, 0x61, 0x6C, 0x5F, 0x70, 0x72, 0x69, 0x6F, 0x72, 0x69, 0x74, 0x79, 0x00 };

        [NativeTypeName("#define VK_EXT_external_memory_host 1")]
        public const int VK_EXT_external_memory_host = 1;

        [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION 1")]
        public const int VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME \"VK_EXT_external_memory_host\"")]
        public static ReadOnlySpan<byte> VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x68, 0x6F, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define VK_AMD_buffer_marker 1")]
        public const int VK_AMD_buffer_marker = 1;

        [NativeTypeName("#define VK_AMD_BUFFER_MARKER_SPEC_VERSION 1")]
        public const int VK_AMD_BUFFER_MARKER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_BUFFER_MARKER_EXTENSION_NAME \"VK_AMD_buffer_marker\"")]
        public static ReadOnlySpan<byte> VK_AMD_BUFFER_MARKER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x5F, 0x6D, 0x61, 0x72, 0x6B, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_AMD_pipeline_compiler_control 1")]
        public const int VK_AMD_pipeline_compiler_control = 1;

        [NativeTypeName("#define VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION 1")]
        public const int VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME \"VK_AMD_pipeline_compiler_control\"")]
        public static ReadOnlySpan<byte> VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x63, 0x6F, 0x6D, 0x70, 0x69, 0x6C, 0x65, 0x72, 0x5F, 0x63, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x00 };

        [NativeTypeName("#define VK_EXT_calibrated_timestamps 1")]
        public const int VK_EXT_calibrated_timestamps = 1;

        [NativeTypeName("#define VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION 1")]
        public const int VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME \"VK_EXT_calibrated_timestamps\"")]
        public static ReadOnlySpan<byte> VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x63, 0x61, 0x6C, 0x69, 0x62, 0x72, 0x61, 0x74, 0x65, 0x64, 0x5F, 0x74, 0x69, 0x6D, 0x65, 0x73, 0x74, 0x61, 0x6D, 0x70, 0x73, 0x00 };

        [NativeTypeName("#define VK_AMD_shader_core_properties 1")]
        public const int VK_AMD_shader_core_properties = 1;

        [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION 2")]
        public const int VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME \"VK_AMD_shader_core_properties\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x63, 0x6F, 0x72, 0x65, 0x5F, 0x70, 0x72, 0x6F, 0x70, 0x65, 0x72, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_AMD_memory_overallocation_behavior 1")]
        public const int VK_AMD_memory_overallocation_behavior = 1;

        [NativeTypeName("#define VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION 1")]
        public const int VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME \"VK_AMD_memory_overallocation_behavior\"")]
        public static ReadOnlySpan<byte> VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x6F, 0x76, 0x65, 0x72, 0x61, 0x6C, 0x6C, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x62, 0x65, 0x68, 0x61, 0x76, 0x69, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_vertex_attribute_divisor 1")]
        public const int VK_EXT_vertex_attribute_divisor = 1;

        [NativeTypeName("#define VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION 3")]
        public const int VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME \"VK_EXT_vertex_attribute_divisor\"")]
        public static ReadOnlySpan<byte> VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x76, 0x65, 0x72, 0x74, 0x65, 0x78, 0x5F, 0x61, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x5F, 0x64, 0x69, 0x76, 0x69, 0x73, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_pipeline_creation_feedback 1")]
        public const int VK_EXT_pipeline_creation_feedback = 1;

        [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION 1")]
        public const int VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME \"VK_EXT_pipeline_creation_feedback\"")]
        public static ReadOnlySpan<byte> VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x63, 0x72, 0x65, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x66, 0x65, 0x65, 0x64, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define VK_NV_shader_subgroup_partitioned 1")]
        public const int VK_NV_shader_subgroup_partitioned = 1;

        [NativeTypeName("#define VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION 1")]
        public const int VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME \"VK_NV_shader_subgroup_partitioned\"")]
        public static ReadOnlySpan<byte> VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x73, 0x75, 0x62, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x70, 0x61, 0x72, 0x74, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define VK_NV_compute_shader_derivatives 1")]
        public const int VK_NV_compute_shader_derivatives = 1;

        [NativeTypeName("#define VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION 1")]
        public const int VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME \"VK_NV_compute_shader_derivatives\"")]
        public static ReadOnlySpan<byte> VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x63, 0x6F, 0x6D, 0x70, 0x75, 0x74, 0x65, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x64, 0x65, 0x72, 0x69, 0x76, 0x61, 0x74, 0x69, 0x76, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_NV_mesh_shader 1")]
        public const int VK_NV_mesh_shader = 1;

        [NativeTypeName("#define VK_NV_MESH_SHADER_SPEC_VERSION 1")]
        public const int VK_NV_MESH_SHADER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_MESH_SHADER_EXTENSION_NAME \"VK_NV_mesh_shader\"")]
        public static ReadOnlySpan<byte> VK_NV_MESH_SHADER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x6D, 0x65, 0x73, 0x68, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define VK_NV_fragment_shader_barycentric 1")]
        public const int VK_NV_fragment_shader_barycentric = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION 1")]
        public const int VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME \"VK_NV_fragment_shader_barycentric\"")]
        public static ReadOnlySpan<byte> VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x62, 0x61, 0x72, 0x79, 0x63, 0x65, 0x6E, 0x74, 0x72, 0x69, 0x63, 0x00 };

        [NativeTypeName("#define VK_NV_shader_image_footprint 1")]
        public const int VK_NV_shader_image_footprint = 1;

        [NativeTypeName("#define VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION 2")]
        public const int VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME \"VK_NV_shader_image_footprint\"")]
        public static ReadOnlySpan<byte> VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x66, 0x6F, 0x6F, 0x74, 0x70, 0x72, 0x69, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define VK_NV_scissor_exclusive 1")]
        public const int VK_NV_scissor_exclusive = 1;

        [NativeTypeName("#define VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION 1")]
        public const int VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME \"VK_NV_scissor_exclusive\"")]
        public static ReadOnlySpan<byte> VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x73, 0x63, 0x69, 0x73, 0x73, 0x6F, 0x72, 0x5F, 0x65, 0x78, 0x63, 0x6C, 0x75, 0x73, 0x69, 0x76, 0x65, 0x00 };

        [NativeTypeName("#define VK_NV_device_diagnostic_checkpoints 1")]
        public const int VK_NV_device_diagnostic_checkpoints = 1;

        [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION 2")]
        public const int VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME \"VK_NV_device_diagnostic_checkpoints\"")]
        public static ReadOnlySpan<byte> VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x64, 0x69, 0x61, 0x67, 0x6E, 0x6F, 0x73, 0x74, 0x69, 0x63, 0x5F, 0x63, 0x68, 0x65, 0x63, 0x6B, 0x70, 0x6F, 0x69, 0x6E, 0x74, 0x73, 0x00 };

        [NativeTypeName("#define VK_INTEL_shader_integer_functions2 1")]
        public const int VK_INTEL_shader_integer_functions2 = 1;

        [NativeTypeName("#define VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION 1")]
        public const int VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME \"VK_INTEL_shader_integer_functions2\"")]
        public static ReadOnlySpan<byte> VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x49, 0x4E, 0x54, 0x45, 0x4C, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x69, 0x6E, 0x74, 0x65, 0x67, 0x65, 0x72, 0x5F, 0x66, 0x75, 0x6E, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_INTEL_performance_query 1")]
        public const int VK_INTEL_performance_query = 1;

        [NativeTypeName("#define VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION 2")]
        public const int VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME \"VK_INTEL_performance_query\"")]
        public static ReadOnlySpan<byte> VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x49, 0x4E, 0x54, 0x45, 0x4C, 0x5F, 0x70, 0x65, 0x72, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x6E, 0x63, 0x65, 0x5F, 0x71, 0x75, 0x65, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_EXT_pci_bus_info 1")]
        public const int VK_EXT_pci_bus_info = 1;

        [NativeTypeName("#define VK_EXT_PCI_BUS_INFO_SPEC_VERSION 2")]
        public const int VK_EXT_PCI_BUS_INFO_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_PCI_BUS_INFO_EXTENSION_NAME \"VK_EXT_pci_bus_info\"")]
        public static ReadOnlySpan<byte> VK_EXT_PCI_BUS_INFO_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x70, 0x63, 0x69, 0x5F, 0x62, 0x75, 0x73, 0x5F, 0x69, 0x6E, 0x66, 0x6F, 0x00 };

        [NativeTypeName("#define VK_AMD_display_native_hdr 1")]
        public const int VK_AMD_display_native_hdr = 1;

        [NativeTypeName("#define VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION 1")]
        public const int VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME \"VK_AMD_display_native_hdr\"")]
        public static ReadOnlySpan<byte> VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x5F, 0x6E, 0x61, 0x74, 0x69, 0x76, 0x65, 0x5F, 0x68, 0x64, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_fragment_density_map 1")]
        public const int VK_EXT_fragment_density_map = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION 1")]
        public const int VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME \"VK_EXT_fragment_density_map\"")]
        public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x64, 0x65, 0x6E, 0x73, 0x69, 0x74, 0x79, 0x5F, 0x6D, 0x61, 0x70, 0x00 };

        [NativeTypeName("#define VK_EXT_scalar_block_layout 1")]
        public const int VK_EXT_scalar_block_layout = 1;

        [NativeTypeName("#define VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION 1")]
        public const int VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME \"VK_EXT_scalar_block_layout\"")]
        public static ReadOnlySpan<byte> VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x63, 0x61, 0x6C, 0x61, 0x72, 0x5F, 0x62, 0x6C, 0x6F, 0x63, 0x6B, 0x5F, 0x6C, 0x61, 0x79, 0x6F, 0x75, 0x74, 0x00 };

        [NativeTypeName("#define VK_GOOGLE_hlsl_functionality1 1")]
        public const int VK_GOOGLE_hlsl_functionality1 = 1;

        [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION 1")]
        public const int VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME \"VK_GOOGLE_hlsl_functionality1\"")]
        public static ReadOnlySpan<byte> VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x47, 0x4F, 0x4F, 0x47, 0x4C, 0x45, 0x5F, 0x68, 0x6C, 0x73, 0x6C, 0x5F, 0x66, 0x75, 0x6E, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x61, 0x6C, 0x69, 0x74, 0x79, 0x31, 0x00 };

        [NativeTypeName("#define VK_GOOGLE_decorate_string 1")]
        public const int VK_GOOGLE_decorate_string = 1;

        [NativeTypeName("#define VK_GOOGLE_DECORATE_STRING_SPEC_VERSION 1")]
        public const int VK_GOOGLE_DECORATE_STRING_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME \"VK_GOOGLE_decorate_string\"")]
        public static ReadOnlySpan<byte> VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x47, 0x4F, 0x4F, 0x47, 0x4C, 0x45, 0x5F, 0x64, 0x65, 0x63, 0x6F, 0x72, 0x61, 0x74, 0x65, 0x5F, 0x73, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define VK_EXT_subgroup_size_control 1")]
        public const int VK_EXT_subgroup_size_control = 1;

        [NativeTypeName("#define VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION 2")]
        public const int VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME \"VK_EXT_subgroup_size_control\"")]
        public static ReadOnlySpan<byte> VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x75, 0x62, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x73, 0x69, 0x7A, 0x65, 0x5F, 0x63, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x00 };

        [NativeTypeName("#define VK_AMD_shader_core_properties2 1")]
        public const int VK_AMD_shader_core_properties2 = 1;

        [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME \"VK_AMD_shader_core_properties2\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x63, 0x6F, 0x72, 0x65, 0x5F, 0x70, 0x72, 0x6F, 0x70, 0x65, 0x72, 0x74, 0x69, 0x65, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_AMD_device_coherent_memory 1")]
        public const int VK_AMD_device_coherent_memory = 1;

        [NativeTypeName("#define VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION 1")]
        public const int VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME \"VK_AMD_device_coherent_memory\"")]
        public static ReadOnlySpan<byte> VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4D, 0x44, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x63, 0x6F, 0x68, 0x65, 0x72, 0x65, 0x6E, 0x74, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_EXT_memory_budget 1")]
        public const int VK_EXT_memory_budget = 1;

        [NativeTypeName("#define VK_EXT_MEMORY_BUDGET_SPEC_VERSION 1")]
        public const int VK_EXT_MEMORY_BUDGET_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_MEMORY_BUDGET_EXTENSION_NAME \"VK_EXT_memory_budget\"")]
        public static ReadOnlySpan<byte> VK_EXT_MEMORY_BUDGET_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x62, 0x75, 0x64, 0x67, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define VK_EXT_memory_priority 1")]
        public const int VK_EXT_memory_priority = 1;

        [NativeTypeName("#define VK_EXT_MEMORY_PRIORITY_SPEC_VERSION 1")]
        public const int VK_EXT_MEMORY_PRIORITY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME \"VK_EXT_memory_priority\"")]
        public static ReadOnlySpan<byte> VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x70, 0x72, 0x69, 0x6F, 0x72, 0x69, 0x74, 0x79, 0x00 };

        [NativeTypeName("#define VK_NV_dedicated_allocation_image_aliasing 1")]
        public const int VK_NV_dedicated_allocation_image_aliasing = 1;

        [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION 1")]
        public const int VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME \"VK_NV_dedicated_allocation_image_aliasing\"")]
        public static ReadOnlySpan<byte> VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x64, 0x65, 0x64, 0x69, 0x63, 0x61, 0x74, 0x65, 0x64, 0x5F, 0x61, 0x6C, 0x6C, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x61, 0x6C, 0x69, 0x61, 0x73, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define VK_EXT_buffer_device_address 1")]
        public const int VK_EXT_buffer_device_address = 1;

        [NativeTypeName("#define VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION 2")]
        public const int VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME \"VK_EXT_buffer_device_address\"")]
        public static ReadOnlySpan<byte> VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x61, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_tooling_info 1")]
        public const int VK_EXT_tooling_info = 1;

        [NativeTypeName("#define VK_EXT_TOOLING_INFO_SPEC_VERSION 1")]
        public const int VK_EXT_TOOLING_INFO_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_TOOLING_INFO_EXTENSION_NAME \"VK_EXT_tooling_info\"")]
        public static ReadOnlySpan<byte> VK_EXT_TOOLING_INFO_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x74, 0x6F, 0x6F, 0x6C, 0x69, 0x6E, 0x67, 0x5F, 0x69, 0x6E, 0x66, 0x6F, 0x00 };

        [NativeTypeName("#define VK_EXT_separate_stencil_usage 1")]
        public const int VK_EXT_separate_stencil_usage = 1;

        [NativeTypeName("#define VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION 1")]
        public const int VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME \"VK_EXT_separate_stencil_usage\"")]
        public static ReadOnlySpan<byte> VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x65, 0x70, 0x61, 0x72, 0x61, 0x74, 0x65, 0x5F, 0x73, 0x74, 0x65, 0x6E, 0x63, 0x69, 0x6C, 0x5F, 0x75, 0x73, 0x61, 0x67, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_validation_features 1")]
        public const int VK_EXT_validation_features = 1;

        [NativeTypeName("#define VK_EXT_VALIDATION_FEATURES_SPEC_VERSION 4")]
        public const int VK_EXT_VALIDATION_FEATURES_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME \"VK_EXT_validation_features\"")]
        public static ReadOnlySpan<byte> VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x76, 0x61, 0x6C, 0x69, 0x64, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x66, 0x65, 0x61, 0x74, 0x75, 0x72, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_NV_cooperative_matrix 1")]
        public const int VK_NV_cooperative_matrix = 1;

        [NativeTypeName("#define VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION 1")]
        public const int VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME \"VK_NV_cooperative_matrix\"")]
        public static ReadOnlySpan<byte> VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x63, 0x6F, 0x6F, 0x70, 0x65, 0x72, 0x61, 0x74, 0x69, 0x76, 0x65, 0x5F, 0x6D, 0x61, 0x74, 0x72, 0x69, 0x78, 0x00 };

        [NativeTypeName("#define VK_NV_coverage_reduction_mode 1")]
        public const int VK_NV_coverage_reduction_mode = 1;

        [NativeTypeName("#define VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION 1")]
        public const int VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME \"VK_NV_coverage_reduction_mode\"")]
        public static ReadOnlySpan<byte> VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x63, 0x6F, 0x76, 0x65, 0x72, 0x61, 0x67, 0x65, 0x5F, 0x72, 0x65, 0x64, 0x75, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x6D, 0x6F, 0x64, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_fragment_shader_interlock 1")]
        public const int VK_EXT_fragment_shader_interlock = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION 1")]
        public const int VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME \"VK_EXT_fragment_shader_interlock\"")]
        public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x69, 0x6E, 0x74, 0x65, 0x72, 0x6C, 0x6F, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define VK_EXT_ycbcr_image_arrays 1")]
        public const int VK_EXT_ycbcr_image_arrays = 1;

        [NativeTypeName("#define VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION 1")]
        public const int VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME \"VK_EXT_ycbcr_image_arrays\"")]
        public static ReadOnlySpan<byte> VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x79, 0x63, 0x62, 0x63, 0x72, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x61, 0x72, 0x72, 0x61, 0x79, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_headless_surface 1")]
        public const int VK_EXT_headless_surface = 1;

        [NativeTypeName("#define VK_EXT_HEADLESS_SURFACE_SPEC_VERSION 1")]
        public const int VK_EXT_HEADLESS_SURFACE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME \"VK_EXT_headless_surface\"")]
        public static ReadOnlySpan<byte> VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x68, 0x65, 0x61, 0x64, 0x6C, 0x65, 0x73, 0x73, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_line_rasterization 1")]
        public const int VK_EXT_line_rasterization = 1;

        [NativeTypeName("#define VK_EXT_LINE_RASTERIZATION_SPEC_VERSION 1")]
        public const int VK_EXT_LINE_RASTERIZATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME \"VK_EXT_line_rasterization\"")]
        public static ReadOnlySpan<byte> VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x72, 0x61, 0x73, 0x74, 0x65, 0x72, 0x69, 0x7A, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define VK_EXT_shader_atomic_float 1")]
        public const int VK_EXT_shader_atomic_float = 1;

        [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME \"VK_EXT_shader_atomic_float\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x61, 0x74, 0x6F, 0x6D, 0x69, 0x63, 0x5F, 0x66, 0x6C, 0x6F, 0x61, 0x74, 0x00 };

        [NativeTypeName("#define VK_EXT_host_query_reset 1")]
        public const int VK_EXT_host_query_reset = 1;

        [NativeTypeName("#define VK_EXT_HOST_QUERY_RESET_SPEC_VERSION 1")]
        public const int VK_EXT_HOST_QUERY_RESET_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME \"VK_EXT_host_query_reset\"")]
        public static ReadOnlySpan<byte> VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x68, 0x6F, 0x73, 0x74, 0x5F, 0x71, 0x75, 0x65, 0x72, 0x79, 0x5F, 0x72, 0x65, 0x73, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define VK_EXT_index_type_uint8 1")]
        public const int VK_EXT_index_type_uint8 = 1;

        [NativeTypeName("#define VK_EXT_INDEX_TYPE_UINT8_SPEC_VERSION 1")]
        public const int VK_EXT_INDEX_TYPE_UINT8_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME \"VK_EXT_index_type_uint8\"")]
        public static ReadOnlySpan<byte> VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x69, 0x6E, 0x64, 0x65, 0x78, 0x5F, 0x74, 0x79, 0x70, 0x65, 0x5F, 0x75, 0x69, 0x6E, 0x74, 0x38, 0x00 };

        [NativeTypeName("#define VK_EXT_extended_dynamic_state 1")]
        public const int VK_EXT_extended_dynamic_state = 1;

        [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION 1")]
        public const int VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME \"VK_EXT_extended_dynamic_state\"")]
        public static ReadOnlySpan<byte> VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x6E, 0x64, 0x65, 0x64, 0x5F, 0x64, 0x79, 0x6E, 0x61, 0x6D, 0x69, 0x63, 0x5F, 0x73, 0x74, 0x61, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_shader_demote_to_helper_invocation 1")]
        public const int VK_EXT_shader_demote_to_helper_invocation = 1;

        [NativeTypeName("#define VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_EXTENSION_NAME \"VK_EXT_shader_demote_to_helper_invocation\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x64, 0x65, 0x6D, 0x6F, 0x74, 0x65, 0x5F, 0x74, 0x6F, 0x5F, 0x68, 0x65, 0x6C, 0x70, 0x65, 0x72, 0x5F, 0x69, 0x6E, 0x76, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define VK_NV_device_generated_commands 1")]
        public const int VK_NV_device_generated_commands = 1;

        [NativeTypeName("#define VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION 3")]
        public const int VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME \"VK_NV_device_generated_commands\"")]
        public static ReadOnlySpan<byte> VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x67, 0x65, 0x6E, 0x65, 0x72, 0x61, 0x74, 0x65, 0x64, 0x5F, 0x63, 0x6F, 0x6D, 0x6D, 0x61, 0x6E, 0x64, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_texel_buffer_alignment 1")]
        public const int VK_EXT_texel_buffer_alignment = 1;

        [NativeTypeName("#define VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION 1")]
        public const int VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME \"VK_EXT_texel_buffer_alignment\"")]
        public static ReadOnlySpan<byte> VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x74, 0x65, 0x78, 0x65, 0x6C, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x5F, 0x61, 0x6C, 0x69, 0x67, 0x6E, 0x6D, 0x65, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define VK_QCOM_render_pass_transform 1")]
        public const int VK_QCOM_render_pass_transform = 1;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION 1")]
        public const int VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME \"VK_QCOM_render_pass_transform\"")]
        public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x51, 0x43, 0x4F, 0x4D, 0x5F, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x5F, 0x70, 0x61, 0x73, 0x73, 0x5F, 0x74, 0x72, 0x61, 0x6E, 0x73, 0x66, 0x6F, 0x72, 0x6D, 0x00 };

        [NativeTypeName("#define VK_EXT_robustness2 1")]
        public const int VK_EXT_robustness2 = 1;

        [NativeTypeName("#define VK_EXT_ROBUSTNESS_2_SPEC_VERSION 1")]
        public const int VK_EXT_ROBUSTNESS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_ROBUSTNESS_2_EXTENSION_NAME \"VK_EXT_robustness2\"")]
        public static ReadOnlySpan<byte> VK_EXT_ROBUSTNESS_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x72, 0x6F, 0x62, 0x75, 0x73, 0x74, 0x6E, 0x65, 0x73, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_EXT_custom_border_color 1")]
        public const int VK_EXT_custom_border_color = 1;

        [NativeTypeName("#define VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION 12")]
        public const int VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION = 12;

        [NativeTypeName("#define VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME \"VK_EXT_custom_border_color\"")]
        public static ReadOnlySpan<byte> VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x63, 0x75, 0x73, 0x74, 0x6F, 0x6D, 0x5F, 0x62, 0x6F, 0x72, 0x64, 0x65, 0x72, 0x5F, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define VK_GOOGLE_user_type 1")]
        public const int VK_GOOGLE_user_type = 1;

        [NativeTypeName("#define VK_GOOGLE_USER_TYPE_SPEC_VERSION 1")]
        public const int VK_GOOGLE_USER_TYPE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_USER_TYPE_EXTENSION_NAME \"VK_GOOGLE_user_type\"")]
        public static ReadOnlySpan<byte> VK_GOOGLE_USER_TYPE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x47, 0x4F, 0x4F, 0x47, 0x4C, 0x45, 0x5F, 0x75, 0x73, 0x65, 0x72, 0x5F, 0x74, 0x79, 0x70, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_private_data 1")]
        public const int VK_EXT_private_data = 1;

        [NativeTypeName("#define VK_EXT_PRIVATE_DATA_SPEC_VERSION 1")]
        public const int VK_EXT_PRIVATE_DATA_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PRIVATE_DATA_EXTENSION_NAME \"VK_EXT_private_data\"")]
        public static ReadOnlySpan<byte> VK_EXT_PRIVATE_DATA_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x70, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x5F, 0x64, 0x61, 0x74, 0x61, 0x00 };

        [NativeTypeName("#define VK_EXT_pipeline_creation_cache_control 1")]
        public const int VK_EXT_pipeline_creation_cache_control = 1;

        [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION 3")]
        public const int VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME \"VK_EXT_pipeline_creation_cache_control\"")]
        public static ReadOnlySpan<byte> VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x63, 0x72, 0x65, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x63, 0x61, 0x63, 0x68, 0x65, 0x5F, 0x63, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x00 };

        [NativeTypeName("#define VK_NV_device_diagnostics_config 1")]
        public const int VK_NV_device_diagnostics_config = 1;

        [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION 1")]
        public const int VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME \"VK_NV_device_diagnostics_config\"")]
        public static ReadOnlySpan<byte> VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x64, 0x69, 0x61, 0x67, 0x6E, 0x6F, 0x73, 0x74, 0x69, 0x63, 0x73, 0x5F, 0x63, 0x6F, 0x6E, 0x66, 0x69, 0x67, 0x00 };

        [NativeTypeName("#define VK_QCOM_render_pass_store_ops 1")]
        public const int VK_QCOM_render_pass_store_ops = 1;

        [NativeTypeName("#define VK_QCOM_render_pass_store_ops_SPEC_VERSION 2")]
        public const int VK_QCOM_render_pass_store_ops_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_QCOM_render_pass_store_ops_EXTENSION_NAME \"VK_QCOM_render_pass_store_ops\"")]
        public static ReadOnlySpan<byte> VK_QCOM_render_pass_store_ops_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x51, 0x43, 0x4F, 0x4D, 0x5F, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x5F, 0x70, 0x61, 0x73, 0x73, 0x5F, 0x73, 0x74, 0x6F, 0x72, 0x65, 0x5F, 0x6F, 0x70, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_fragment_density_map2 1")]
        public const int VK_EXT_fragment_density_map2 = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION 1")]
        public const int VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME \"VK_EXT_fragment_density_map2\"")]
        public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x64, 0x65, 0x6E, 0x73, 0x69, 0x74, 0x79, 0x5F, 0x6D, 0x61, 0x70, 0x32, 0x00 };

        [NativeTypeName("#define VK_EXT_image_robustness 1")]
        public const int VK_EXT_image_robustness = 1;

        [NativeTypeName("#define VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION 1")]
        public const int VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME \"VK_EXT_image_robustness\"")]
        public static ReadOnlySpan<byte> VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x72, 0x6F, 0x62, 0x75, 0x73, 0x74, 0x6E, 0x65, 0x73, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_4444_formats 1")]
        public const int VK_EXT_4444_formats = 1;

        [NativeTypeName("#define VK_EXT_4444_FORMATS_SPEC_VERSION 1")]
        public const int VK_EXT_4444_FORMATS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_4444_FORMATS_EXTENSION_NAME \"VK_EXT_4444_formats\"")]
        public static ReadOnlySpan<byte> VK_EXT_4444_FORMATS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x34, 0x34, 0x34, 0x34, 0x5F, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x73, 0x00 };
    }
}
