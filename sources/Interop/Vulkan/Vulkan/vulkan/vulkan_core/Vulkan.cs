// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public static unsafe partial class Vulkan
{
    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateInstance([NativeTypeName("const VkInstanceCreateInfo *")] VkInstanceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkInstance* pInstance);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyInstance(VkInstance instance, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkEnumeratePhysicalDevices(VkInstance instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    [return: NativeTypeName("PFN_vkVoidFunction")]
    public static extern delegate* unmanaged<void> vkGetInstanceProcAddr(VkInstance instance, [NativeTypeName("const char *")] sbyte* pName);

    [DllImport("vulkan", ExactSpelling = true)]
    [return: NativeTypeName("PFN_vkVoidFunction")]
    public static extern delegate* unmanaged<void> vkGetDeviceProcAddr(VkDevice device, [NativeTypeName("const char *")] sbyte* pName);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkDeviceCreateInfo *")] VkDeviceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDevice* pDevice);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyDevice(VkDevice device, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkEnumerateInstanceExtensionProperties([NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkExtensionProperties* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, [NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkExtensionProperties* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkEnumerateInstanceLayerProperties([NativeTypeName("uint32_t *")] uint* pPropertyCount, VkLayerProperties* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkLayerProperties* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDeviceQueue(VkDevice device, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("uint32_t")] uint queueIndex, VkQueue* pQueue);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkQueueSubmit(VkQueue queue, [NativeTypeName("uint32_t")] uint submitCount, [NativeTypeName("const VkSubmitInfo *")] VkSubmitInfo* pSubmits, VkFence fence);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkQueueWaitIdle(VkQueue queue);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkDeviceWaitIdle(VkDevice device);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkAllocateMemory(VkDevice device, [NativeTypeName("const VkMemoryAllocateInfo *")] VkMemoryAllocateInfo* pAllocateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkFreeMemory(VkDevice device, VkDeviceMemory memory, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkMapMemory(VkDevice device, VkDeviceMemory memory, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size, VkMemoryMapFlags flags, void** ppData);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkUnmapMemory(VkDevice device, VkDeviceMemory memory);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkFlushMappedMemoryRanges(VkDevice device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkInvalidateMappedMemoryRanges(VkDevice device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, [NativeTypeName("VkDeviceSize *")] ulong* pCommittedMemoryInBytes);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, [NativeTypeName("VkSampleCountFlagBits")] VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkSparseImageFormatProperties* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkQueueBindSparse(VkQueue queue, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindSparseInfo *")] VkBindSparseInfo* pBindInfo, VkFence fence);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateFence(VkDevice device, [NativeTypeName("const VkFenceCreateInfo *")] VkFenceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkFence* pFence);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyFence(VkDevice device, VkFence fence, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkResetFences(VkDevice device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] VkFence* pFences);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetFenceStatus(VkDevice device, VkFence fence);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkWaitForFences(VkDevice device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] VkFence* pFences, [NativeTypeName("VkBool32")] uint waitAll, [NativeTypeName("uint64_t")] ulong timeout);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateSemaphore(VkDevice device, [NativeTypeName("const VkSemaphoreCreateInfo *")] VkSemaphoreCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroySemaphore(VkDevice device, VkSemaphore semaphore, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateEvent(VkDevice device, [NativeTypeName("const VkEventCreateInfo *")] VkEventCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkEvent* pEvent);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyEvent(VkDevice device, VkEvent @event, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetEventStatus(VkDevice device, VkEvent @event);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkSetEvent(VkDevice device, VkEvent @event);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkResetEvent(VkDevice device, VkEvent @event);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateQueryPool(VkDevice device, [NativeTypeName("const VkQueryPoolCreateInfo *")] VkQueryPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyQueryPool(VkDevice device, VkQueryPool queryPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("size_t")] nuint dataSize, void* pData, [NativeTypeName("VkDeviceSize")] ulong stride, VkQueryResultFlags flags);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateBuffer(VkDevice device, [NativeTypeName("const VkBufferCreateInfo *")] VkBufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyBuffer(VkDevice device, VkBuffer buffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateBufferView(VkDevice device, [NativeTypeName("const VkBufferViewCreateInfo *")] VkBufferViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkBufferView* pView);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyBufferView(VkDevice device, VkBufferView bufferView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateImage(VkDevice device, [NativeTypeName("const VkImageCreateInfo *")] VkImageCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkImage* pImage);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyImage(VkDevice device, VkImage image, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetImageSubresourceLayout(VkDevice device, VkImage image, [NativeTypeName("const VkImageSubresource *")] VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateImageView(VkDevice device, [NativeTypeName("const VkImageViewCreateInfo *")] VkImageViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkImageView* pView);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyImageView(VkDevice device, VkImageView imageView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateShaderModule(VkDevice device, [NativeTypeName("const VkShaderModuleCreateInfo *")] VkShaderModuleCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreatePipelineCache(VkDevice device, [NativeTypeName("const VkPipelineCacheCreateInfo *")] VkPipelineCacheCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, [NativeTypeName("size_t *")] nuint* pDataSize, void* pData);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkPipelineCache *")] VkPipelineCache* pSrcCaches);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkGraphicsPipelineCreateInfo *")] VkGraphicsPipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkComputePipelineCreateInfo *")] VkComputePipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyPipeline(VkDevice device, VkPipeline pipeline, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreatePipelineLayout(VkDevice device, [NativeTypeName("const VkPipelineLayoutCreateInfo *")] VkPipelineLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateSampler(VkDevice device, [NativeTypeName("const VkSamplerCreateInfo *")] VkSamplerCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSampler* pSampler);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroySampler(VkDevice device, VkSampler sampler, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateDescriptorSetLayout(VkDevice device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateDescriptorPool(VkDevice device, [NativeTypeName("const VkDescriptorPoolCreateInfo *")] VkDescriptorPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkAllocateDescriptorSets(VkDevice device, [NativeTypeName("const VkDescriptorSetAllocateInfo *")] VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] VkDescriptorSet* pDescriptorSets);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkUpdateDescriptorSets(VkDevice device, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites, [NativeTypeName("uint32_t")] uint descriptorCopyCount, [NativeTypeName("const VkCopyDescriptorSet *")] VkCopyDescriptorSet* pDescriptorCopies);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateFramebuffer(VkDevice device, [NativeTypeName("const VkFramebufferCreateInfo *")] VkFramebufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateRenderPass(VkDevice device, [NativeTypeName("const VkRenderPassCreateInfo *")] VkRenderPassCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyRenderPass(VkDevice device, VkRenderPass renderPass, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateCommandPool(VkDevice device, [NativeTypeName("const VkCommandPoolCreateInfo *")] VkCommandPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyCommandPool(VkDevice device, VkCommandPool commandPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkAllocateCommandBuffers(VkDevice device, [NativeTypeName("const VkCommandBufferAllocateInfo *")] VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] VkCommandBuffer* pCommandBuffers);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkBeginCommandBuffer(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCommandBufferBeginInfo *")] VkCommandBufferBeginInfo* pBeginInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetViewport(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewport *")] VkViewport* pViewports);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetScissor(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstScissor, [NativeTypeName("uint32_t")] uint scissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pScissors);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetBlendConstants(VkCommandBuffer commandBuffer, [NativeTypeName("const float[4]")] float* blendConstants);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, [NativeTypeName("uint32_t")] uint compareMask);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, [NativeTypeName("uint32_t")] uint writeMask);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, [NativeTypeName("uint32_t")] uint reference);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, [NativeTypeName("uint32_t")] uint firstSet, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] VkDescriptorSet* pDescriptorSets, [NativeTypeName("uint32_t")] uint dynamicOffsetCount, [NativeTypeName("const uint32_t *")] uint* pDynamicOffsets);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkIndexType indexType);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] VkBuffer* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDraw(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint vertexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstVertex, [NativeTypeName("uint32_t")] uint firstInstance);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDrawIndexed(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint indexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstIndex, [NativeTypeName("int32_t")] int vertexOffset, [NativeTypeName("uint32_t")] uint firstInstance);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDispatch(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferCopy *")] VkBufferCopy* pRegions);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageCopy *")] VkImageCopy* pRegions);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageBlit *")] VkImageBlit* pRegions, VkFilter filter);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong dataSize, [NativeTypeName("const void *")] void* pData);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("uint32_t")] uint data);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, [NativeTypeName("const VkClearColorValue *")] VkClearColorValue* pColor, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, [NativeTypeName("const VkClearDepthStencilValue *")] VkClearDepthStencilValue* pDepthStencil, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdClearAttachments(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint attachmentCount, [NativeTypeName("const VkClearAttachment *")] VkClearAttachment* pAttachments, [NativeTypeName("uint32_t")] uint rectCount, [NativeTypeName("const VkClearRect *")] VkClearRect* pRects);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageResolve *")] VkImageResolve* pRegions);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdWaitEvents(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint eventCount, [NativeTypeName("const VkEvent *")] VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint query, VkQueryControlFlags flags);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint query);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, [NativeTypeName("VkPipelineStageFlagBits")] VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint query);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, VkBuffer dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong stride, VkQueryResultFlags flags);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint size, [NativeTypeName("const void *")] void* pValues);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBeginRenderPass(VkCommandBuffer commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdEndRenderPass(VkCommandBuffer commandBuffer);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] VkCommandBuffer* pCommandBuffers);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkEnumerateInstanceVersion([NativeTypeName("uint32_t *")] uint* pApiVersion);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkBindBufferMemory2(VkDevice device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkBindImageMemory2(VkDevice device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDeviceGroupPeerMemoryFeatures(VkDevice device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetDeviceMask(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDispatchBase(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkEnumeratePhysicalDeviceGroups(VkInstance instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetImageMemoryRequirements2(VkDevice device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetBufferMemoryRequirements2(VkDevice device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetImageSparseMemoryRequirements2(VkDevice device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkTrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDeviceQueue2(VkDevice device, [NativeTypeName("const VkDeviceQueueInfo2 *")] VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateSamplerYcbcrConversion(VkDevice device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateDescriptorUpdateTemplate(VkDevice device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDescriptorSetLayoutSupport(VkDevice device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkBuffer countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkBuffer countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateRenderPass2(VkDevice device, [NativeTypeName("const VkRenderPassCreateInfo2 *")] VkRenderPassCreateInfo2* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdNextSubpass2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdEndRenderPass2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkResetQueryPool(VkDevice device, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, [NativeTypeName("uint64_t *")] ulong* pValue);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkWaitSemaphores(VkDevice device, [NativeTypeName("const VkSemaphoreWaitInfo *")] VkSemaphoreWaitInfo* pWaitInfo, [NativeTypeName("uint64_t")] ulong timeout);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkSignalSemaphore(VkDevice device, [NativeTypeName("const VkSemaphoreSignalInfo *")] VkSemaphoreSignalInfo* pSignalInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    [return: NativeTypeName("VkDeviceAddress")]
    public static extern ulong vkGetBufferDeviceAddress(VkDevice device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong vkGetBufferOpaqueCaptureAddress(VkDevice device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong vkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, [NativeTypeName("const VkDeviceMemoryOpaqueCaptureAddressInfo *")] VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreatePrivateDataSlot(VkDevice device, [NativeTypeName("const VkPrivateDataSlotCreateInfo *")] VkPrivateDataSlotCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkSetPrivateData(VkDevice device, VkObjectType objectType, [NativeTypeName("uint64_t")] ulong objectHandle, VkPrivateDataSlot privateDataSlot, [NativeTypeName("uint64_t")] ulong data);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetPrivateData(VkDevice device, VkObjectType objectType, [NativeTypeName("uint64_t")] ulong objectHandle, VkPrivateDataSlot privateDataSlot, [NativeTypeName("uint64_t *")] ulong* pData);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, [NativeTypeName("const VkDependencyInfo *")] VkDependencyInfo* pDependencyInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdResetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2 stageMask);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdWaitEvents2(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint eventCount, [NativeTypeName("const VkEvent *")] VkEvent* pEvents, [NativeTypeName("const VkDependencyInfo *")] VkDependencyInfo* pDependencyInfos);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdPipelineBarrier2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkDependencyInfo *")] VkDependencyInfo* pDependencyInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdWriteTimestamp2(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint query);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkQueueSubmit2(VkQueue queue, [NativeTypeName("uint32_t")] uint submitCount, [NativeTypeName("const VkSubmitInfo2 *")] VkSubmitInfo2* pSubmits, VkFence fence);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyBuffer2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyBufferInfo2 *")] VkCopyBufferInfo2* pCopyBufferInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyImage2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyImageInfo2 *")] VkCopyImageInfo2* pCopyImageInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyBufferToImage2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyBufferToImageInfo2 *")] VkCopyBufferToImageInfo2* pCopyBufferToImageInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdCopyImageToBuffer2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyImageToBufferInfo2 *")] VkCopyImageToBufferInfo2* pCopyImageToBufferInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBlitImage2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkBlitImageInfo2 *")] VkBlitImageInfo2* pBlitImageInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdResolveImage2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkResolveImageInfo2 *")] VkResolveImageInfo2* pResolveImageInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBeginRendering(VkCommandBuffer commandBuffer, [NativeTypeName("const VkRenderingInfo *")] VkRenderingInfo* pRenderingInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdEndRendering(VkCommandBuffer commandBuffer);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetViewportWithCount(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewport *")] VkViewport* pViewports);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetScissorWithCount(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint scissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pScissors);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBindVertexBuffers2(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] VkBuffer* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets, [NativeTypeName("const VkDeviceSize *")] ulong* pSizes, [NativeTypeName("const VkDeviceSize *")] ulong* pStrides);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetDepthTestEnable(VkCommandBuffer commandBuffer, [NativeTypeName("VkBool32")] uint depthTestEnable);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetDepthWriteEnable(VkCommandBuffer commandBuffer, [NativeTypeName("VkBool32")] uint depthWriteEnable);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, [NativeTypeName("VkBool32")] uint depthBoundsTestEnable);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetStencilTestEnable(VkCommandBuffer commandBuffer, [NativeTypeName("VkBool32")] uint stencilTestEnable);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, [NativeTypeName("VkBool32")] uint rasterizerDiscardEnable);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetDepthBiasEnable(VkCommandBuffer commandBuffer, [NativeTypeName("VkBool32")] uint depthBiasEnable);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, [NativeTypeName("VkBool32")] uint primitiveRestartEnable);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDeviceBufferMemoryRequirements(VkDevice device, [NativeTypeName("const VkDeviceBufferMemoryRequirements *")] VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDeviceImageMemoryRequirements(VkDevice device, [NativeTypeName("const VkDeviceImageMemoryRequirements *")] VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDeviceImageSparseMemoryRequirements(VkDevice device, [NativeTypeName("const VkDeviceImageMemoryRequirements *")] VkDeviceImageMemoryRequirements* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetLineStipple(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint lineStippleFactor, [NativeTypeName("uint16_t")] ushort lineStipplePattern);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkMapMemory2(VkDevice device, [NativeTypeName("const VkMemoryMapInfo *")] VkMemoryMapInfo* pMemoryMapInfo, void** ppData);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkUnmapMemory2(VkDevice device, [NativeTypeName("const VkMemoryUnmapInfo *")] VkMemoryUnmapInfo* pMemoryUnmapInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBindIndexBuffer2(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size, VkIndexType indexType);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetRenderingAreaGranularity(VkDevice device, [NativeTypeName("const VkRenderingAreaInfo *")] VkRenderingAreaInfo* pRenderingAreaInfo, VkExtent2D* pGranularity);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetDeviceImageSubresourceLayout(VkDevice device, [NativeTypeName("const VkDeviceImageSubresourceInfo *")] VkDeviceImageSubresourceInfo* pInfo, VkSubresourceLayout2* pLayout);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkGetImageSubresourceLayout2(VkDevice device, VkImage image, [NativeTypeName("const VkImageSubresource2 *")] VkImageSubresource2* pSubresource, VkSubresourceLayout2* pLayout);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdPushDescriptorSet(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdPushDescriptorSetWithTemplate(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("const void *")] void* pData);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetRenderingAttachmentLocations(VkCommandBuffer commandBuffer, [NativeTypeName("const VkRenderingAttachmentLocationInfo *")] VkRenderingAttachmentLocationInfo* pLocationInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdSetRenderingInputAttachmentIndices(VkCommandBuffer commandBuffer, [NativeTypeName("const VkRenderingInputAttachmentIndexInfo *")] VkRenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdBindDescriptorSets2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkBindDescriptorSetsInfo *")] VkBindDescriptorSetsInfo* pBindDescriptorSetsInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdPushConstants2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkPushConstantsInfo *")] VkPushConstantsInfo* pPushConstantsInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdPushDescriptorSet2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkPushDescriptorSetInfo *")] VkPushDescriptorSetInfo* pPushDescriptorSetInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdPushDescriptorSetWithTemplate2(VkCommandBuffer commandBuffer, [NativeTypeName("const VkPushDescriptorSetWithTemplateInfo *")] VkPushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCopyMemoryToImage(VkDevice device, [NativeTypeName("const VkCopyMemoryToImageInfo *")] VkCopyMemoryToImageInfo* pCopyMemoryToImageInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCopyImageToMemory(VkDevice device, [NativeTypeName("const VkCopyImageToMemoryInfo *")] VkCopyImageToMemoryInfo* pCopyImageToMemoryInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCopyImageToImage(VkDevice device, [NativeTypeName("const VkCopyImageToImageInfo *")] VkCopyImageToImageInfo* pCopyImageToImageInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkTransitionImageLayout(VkDevice device, [NativeTypeName("uint32_t")] uint transitionCount, [NativeTypeName("const VkHostImageLayoutTransitionInfo *")] VkHostImageLayoutTransitionInfo* pTransitions);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, VkSurfaceKHR surface, [NativeTypeName("VkBool32 *")] uint* pSupported);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, [NativeTypeName("uint32_t *")] uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateSwapchainKHR(VkDevice device, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, [NativeTypeName("uint32_t *")] uint* pSwapchainImageCount, VkImage* pSwapchainImages);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, [NativeTypeName("uint64_t")] ulong timeout, VkSemaphore semaphore, VkFence fence, [NativeTypeName("uint32_t *")] uint* pImageIndex);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkQueuePresentKHR(VkQueue queue, [NativeTypeName("const VkPresentInfoKHR *")] VkPresentInfoKHR* pPresentInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, [NativeTypeName("uint32_t *")] uint* pRectCount, VkRect2D* pRects);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkAcquireNextImage2KHR(VkDevice device, [NativeTypeName("const VkAcquireNextImageInfoKHR *")] VkAcquireNextImageInfoKHR* pAcquireInfo, [NativeTypeName("uint32_t *")] uint* pImageIndex);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("uint32_t *")] uint* pDisplayCount, VkDisplayKHR* pDisplays);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, [NativeTypeName("const VkDisplayModeCreateInfoKHR *")] VkDisplayModeCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, [NativeTypeName("uint32_t")] uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, [NativeTypeName("const VkDisplaySurfaceCreateInfoKHR *")] VkDisplaySurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateSharedSwapchainsKHR(VkDevice device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayProperties2KHR* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkDisplayPlaneInfo2KHR *")] VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities);

    [NativeTypeName("#define VK_VERSION_1_0 1")]
    public const int VK_VERSION_1_0 = 1;

    [NativeTypeName("#define VK_USE_64_BIT_PTR_DEFINES 1")]
    public const int VK_USE_64_BIT_PTR_DEFINES = 1;

    [NativeTypeName("#define VK_API_VERSION_1_0 VK_MAKE_API_VERSION(0, 1, 0, 0)")]
    public const uint VK_API_VERSION_1_0 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(0)) << 12) | ((uint)(0)));

    [NativeTypeName("#define VK_HEADER_VERSION 328")]
    public const int VK_HEADER_VERSION = 328;

    [NativeTypeName("#define VK_HEADER_VERSION_COMPLETE VK_MAKE_API_VERSION(0, 1, 4, VK_HEADER_VERSION)")]
    public const uint VK_HEADER_VERSION_COMPLETE = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(4)) << 12) | ((uint)(328)));

    [NativeTypeName("#define VK_ATTACHMENT_UNUSED (~0U)")]
    public const uint VK_ATTACHMENT_UNUSED = (~0U);

    [NativeTypeName("#define VK_FALSE 0U")]
    public const uint VK_FALSE = 0U;

    [NativeTypeName("#define VK_LOD_CLAMP_NONE 1000.0F")]
    public const float VK_LOD_CLAMP_NONE = 1000.0F;

    [NativeTypeName("#define VK_QUEUE_FAMILY_IGNORED (~0U)")]
    public const uint VK_QUEUE_FAMILY_IGNORED = (~0U);

    [NativeTypeName("#define VK_REMAINING_ARRAY_LAYERS (~0U)")]
    public const uint VK_REMAINING_ARRAY_LAYERS = (~0U);

    [NativeTypeName("#define VK_REMAINING_MIP_LEVELS (~0U)")]
    public const uint VK_REMAINING_MIP_LEVELS = (~0U);

    [NativeTypeName("#define VK_SUBPASS_EXTERNAL (~0U)")]
    public const uint VK_SUBPASS_EXTERNAL = (~0U);

    [NativeTypeName("#define VK_TRUE 1U")]
    public const uint VK_TRUE = 1U;

    [NativeTypeName("#define VK_WHOLE_SIZE (~0ULL)")]
    public const ulong VK_WHOLE_SIZE = (~0UL);

    [NativeTypeName("#define VK_MAX_MEMORY_TYPES 32U")]
    public const uint VK_MAX_MEMORY_TYPES = 32U;

    [NativeTypeName("#define VK_MAX_PHYSICAL_DEVICE_NAME_SIZE 256U")]
    public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256U;

    [NativeTypeName("#define VK_UUID_SIZE 16U")]
    public const uint VK_UUID_SIZE = 16U;

    [NativeTypeName("#define VK_MAX_EXTENSION_NAME_SIZE 256U")]
    public const uint VK_MAX_EXTENSION_NAME_SIZE = 256U;

    [NativeTypeName("#define VK_MAX_DESCRIPTION_SIZE 256U")]
    public const uint VK_MAX_DESCRIPTION_SIZE = 256U;

    [NativeTypeName("#define VK_MAX_MEMORY_HEAPS 16U")]
    public const uint VK_MAX_MEMORY_HEAPS = 16U;

    [NativeTypeName("#define VK_VERSION_1_1 1")]
    public const int VK_VERSION_1_1 = 1;

    [NativeTypeName("#define VK_API_VERSION_1_1 VK_MAKE_API_VERSION(0, 1, 1, 0)")]
    public const uint VK_API_VERSION_1_1 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(1)) << 12) | ((uint)(0)));

    [NativeTypeName("#define VK_MAX_DEVICE_GROUP_SIZE 32U")]
    public const uint VK_MAX_DEVICE_GROUP_SIZE = 32U;

    [NativeTypeName("#define VK_LUID_SIZE 8U")]
    public const uint VK_LUID_SIZE = 8U;

    [NativeTypeName("#define VK_QUEUE_FAMILY_EXTERNAL (~1U)")]
    public const uint VK_QUEUE_FAMILY_EXTERNAL = (~1U);

    [NativeTypeName("#define VK_VERSION_1_2 1")]
    public const int VK_VERSION_1_2 = 1;

    [NativeTypeName("#define VK_API_VERSION_1_2 VK_MAKE_API_VERSION(0, 1, 2, 0)")]
    public const uint VK_API_VERSION_1_2 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(2)) << 12) | ((uint)(0)));

    [NativeTypeName("#define VK_MAX_DRIVER_NAME_SIZE 256U")]
    public const uint VK_MAX_DRIVER_NAME_SIZE = 256U;

    [NativeTypeName("#define VK_MAX_DRIVER_INFO_SIZE 256U")]
    public const uint VK_MAX_DRIVER_INFO_SIZE = 256U;

    [NativeTypeName("#define VK_VERSION_1_3 1")]
    public const int VK_VERSION_1_3 = 1;

    [NativeTypeName("#define VK_API_VERSION_1_3 VK_MAKE_API_VERSION(0, 1, 3, 0)")]
    public const uint VK_API_VERSION_1_3 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(3)) << 12) | ((uint)(0)));

    [NativeTypeName("#define VK_VERSION_1_4 1")]
    public const int VK_VERSION_1_4 = 1;

    [NativeTypeName("#define VK_API_VERSION_1_4 VK_MAKE_API_VERSION(0, 1, 4, 0)")]
    public const uint VK_API_VERSION_1_4 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(4)) << 12) | ((uint)(0)));

    [NativeTypeName("#define VK_MAX_GLOBAL_PRIORITY_SIZE 16U")]
    public const uint VK_MAX_GLOBAL_PRIORITY_SIZE = 16U;

    [NativeTypeName("#define VK_KHR_surface 1")]
    public const int VK_KHR_surface = 1;

    [NativeTypeName("#define VK_KHR_SURFACE_SPEC_VERSION 25")]
    public const int VK_KHR_SURFACE_SPEC_VERSION = 25;

    [NativeTypeName("#define VK_KHR_SURFACE_EXTENSION_NAME \"VK_KHR_surface\"")]
    public static ReadOnlySpan<byte> VK_KHR_SURFACE_EXTENSION_NAME => "VK_KHR_surface"u8;

    [NativeTypeName("#define VK_KHR_swapchain 1")]
    public const int VK_KHR_swapchain = 1;

    [NativeTypeName("#define VK_KHR_SWAPCHAIN_SPEC_VERSION 70")]
    public const int VK_KHR_SWAPCHAIN_SPEC_VERSION = 70;

    [NativeTypeName("#define VK_KHR_SWAPCHAIN_EXTENSION_NAME \"VK_KHR_swapchain\"")]
    public static ReadOnlySpan<byte> VK_KHR_SWAPCHAIN_EXTENSION_NAME => "VK_KHR_swapchain"u8;

    [NativeTypeName("#define VK_KHR_display 1")]
    public const int VK_KHR_display = 1;

    [NativeTypeName("#define VK_KHR_DISPLAY_SPEC_VERSION 23")]
    public const int VK_KHR_DISPLAY_SPEC_VERSION = 23;

    [NativeTypeName("#define VK_KHR_DISPLAY_EXTENSION_NAME \"VK_KHR_display\"")]
    public static ReadOnlySpan<byte> VK_KHR_DISPLAY_EXTENSION_NAME => "VK_KHR_display"u8;

    [NativeTypeName("#define VK_KHR_display_swapchain 1")]
    public const int VK_KHR_display_swapchain = 1;

    [NativeTypeName("#define VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION 10")]
    public const int VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION = 10;

    [NativeTypeName("#define VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME \"VK_KHR_display_swapchain\"")]
    public static ReadOnlySpan<byte> VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME => "VK_KHR_display_swapchain"u8;

    [NativeTypeName("#define VK_KHR_sampler_mirror_clamp_to_edge 1")]
    public const int VK_KHR_sampler_mirror_clamp_to_edge = 1;

    [NativeTypeName("#define VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION 3")]
    public const int VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME \"VK_KHR_sampler_mirror_clamp_to_edge\"")]
    public static ReadOnlySpan<byte> VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME => "VK_KHR_sampler_mirror_clamp_to_edge"u8;

    [NativeTypeName("#define VK_KHR_video_queue 1")]
    public const int VK_KHR_video_queue = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_QUEUE_SPEC_VERSION 8")]
    public const int VK_KHR_VIDEO_QUEUE_SPEC_VERSION = 8;

    [NativeTypeName("#define VK_KHR_VIDEO_QUEUE_EXTENSION_NAME \"VK_KHR_video_queue\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_QUEUE_EXTENSION_NAME => "VK_KHR_video_queue"u8;

    [NativeTypeName("#define VK_KHR_video_decode_queue 1")]
    public const int VK_KHR_video_decode_queue = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_QUEUE_SPEC_VERSION 8")]
    public const int VK_KHR_VIDEO_DECODE_QUEUE_SPEC_VERSION = 8;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME \"VK_KHR_video_decode_queue\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME => "VK_KHR_video_decode_queue"u8;

    [NativeTypeName("#define VK_KHR_video_encode_h264 1")]
    public const int VK_KHR_video_encode_h264 = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_H264_SPEC_VERSION 14")]
    public const int VK_KHR_VIDEO_ENCODE_H264_SPEC_VERSION = 14;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_H264_EXTENSION_NAME \"VK_KHR_video_encode_h264\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_H264_EXTENSION_NAME => "VK_KHR_video_encode_h264"u8;

    [NativeTypeName("#define VK_KHR_video_encode_h265 1")]
    public const int VK_KHR_video_encode_h265 = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_H265_SPEC_VERSION 14")]
    public const int VK_KHR_VIDEO_ENCODE_H265_SPEC_VERSION = 14;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_H265_EXTENSION_NAME \"VK_KHR_video_encode_h265\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_H265_EXTENSION_NAME => "VK_KHR_video_encode_h265"u8;

    [NativeTypeName("#define VK_KHR_video_decode_h264 1")]
    public const int VK_KHR_video_decode_h264 = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_H264_SPEC_VERSION 9")]
    public const int VK_KHR_VIDEO_DECODE_H264_SPEC_VERSION = 9;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_H264_EXTENSION_NAME \"VK_KHR_video_decode_h264\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_DECODE_H264_EXTENSION_NAME => "VK_KHR_video_decode_h264"u8;

    [NativeTypeName("#define VK_KHR_dynamic_rendering 1")]
    public const int VK_KHR_dynamic_rendering = 1;

    [NativeTypeName("#define VK_KHR_DYNAMIC_RENDERING_SPEC_VERSION 1")]
    public const int VK_KHR_DYNAMIC_RENDERING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME \"VK_KHR_dynamic_rendering\"")]
    public static ReadOnlySpan<byte> VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME => "VK_KHR_dynamic_rendering"u8;

    [NativeTypeName("#define VK_KHR_multiview 1")]
    public const int VK_KHR_multiview = 1;

    [NativeTypeName("#define VK_KHR_MULTIVIEW_SPEC_VERSION 1")]
    public const int VK_KHR_MULTIVIEW_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MULTIVIEW_EXTENSION_NAME \"VK_KHR_multiview\"")]
    public static ReadOnlySpan<byte> VK_KHR_MULTIVIEW_EXTENSION_NAME => "VK_KHR_multiview"u8;

    [NativeTypeName("#define VK_KHR_get_physical_device_properties2 1")]
    public const int VK_KHR_get_physical_device_properties2 = 1;

    [NativeTypeName("#define VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION 2")]
    public const int VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME \"VK_KHR_get_physical_device_properties2\"")]
    public static ReadOnlySpan<byte> VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME => "VK_KHR_get_physical_device_properties2"u8;

    [NativeTypeName("#define VK_KHR_device_group 1")]
    public const int VK_KHR_device_group = 1;

    [NativeTypeName("#define VK_KHR_DEVICE_GROUP_SPEC_VERSION 4")]
    public const int VK_KHR_DEVICE_GROUP_SPEC_VERSION = 4;

    [NativeTypeName("#define VK_KHR_DEVICE_GROUP_EXTENSION_NAME \"VK_KHR_device_group\"")]
    public static ReadOnlySpan<byte> VK_KHR_DEVICE_GROUP_EXTENSION_NAME => "VK_KHR_device_group"u8;

    [NativeTypeName("#define VK_KHR_shader_draw_parameters 1")]
    public const int VK_KHR_shader_draw_parameters = 1;

    [NativeTypeName("#define VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME \"VK_KHR_shader_draw_parameters\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME => "VK_KHR_shader_draw_parameters"u8;

    [NativeTypeName("#define VK_KHR_maintenance1 1")]
    public const int VK_KHR_maintenance1 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_1_SPEC_VERSION 2")]
    public const int VK_KHR_MAINTENANCE_1_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_1_EXTENSION_NAME \"VK_KHR_maintenance1\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_1_EXTENSION_NAME => "VK_KHR_maintenance1"u8;

    [NativeTypeName("#define VK_KHR_MAINTENANCE1_SPEC_VERSION VK_KHR_MAINTENANCE_1_SPEC_VERSION")]
    public const int VK_KHR_MAINTENANCE1_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_MAINTENANCE1_EXTENSION_NAME VK_KHR_MAINTENANCE_1_EXTENSION_NAME")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE1_EXTENSION_NAME => "VK_KHR_maintenance1"u8;

    [NativeTypeName("#define VK_KHR_device_group_creation 1")]
    public const int VK_KHR_device_group_creation = 1;

    [NativeTypeName("#define VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION 1")]
    public const int VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME \"VK_KHR_device_group_creation\"")]
    public static ReadOnlySpan<byte> VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME => "VK_KHR_device_group_creation"u8;

    [NativeTypeName("#define VK_MAX_DEVICE_GROUP_SIZE_KHR VK_MAX_DEVICE_GROUP_SIZE")]
    public const uint VK_MAX_DEVICE_GROUP_SIZE_KHR = 32U;

    [NativeTypeName("#define VK_KHR_external_memory_capabilities 1")]
    public const int VK_KHR_external_memory_capabilities = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_memory_capabilities\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME => "VK_KHR_external_memory_capabilities"u8;

    [NativeTypeName("#define VK_LUID_SIZE_KHR VK_LUID_SIZE")]
    public const uint VK_LUID_SIZE_KHR = 8U;

    [NativeTypeName("#define VK_KHR_external_memory 1")]
    public const int VK_KHR_external_memory = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_KHR_external_memory\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME => "VK_KHR_external_memory"u8;

    [NativeTypeName("#define VK_QUEUE_FAMILY_EXTERNAL_KHR VK_QUEUE_FAMILY_EXTERNAL")]
    public const uint VK_QUEUE_FAMILY_EXTERNAL_KHR = (~1U);

    [NativeTypeName("#define VK_KHR_external_memory_fd 1")]
    public const int VK_KHR_external_memory_fd = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME \"VK_KHR_external_memory_fd\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME => "VK_KHR_external_memory_fd"u8;

    [NativeTypeName("#define VK_KHR_external_semaphore_capabilities 1")]
    public const int VK_KHR_external_semaphore_capabilities = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_semaphore_capabilities\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME => "VK_KHR_external_semaphore_capabilities"u8;

    [NativeTypeName("#define VK_KHR_external_semaphore 1")]
    public const int VK_KHR_external_semaphore = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME \"VK_KHR_external_semaphore\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME => "VK_KHR_external_semaphore"u8;

    [NativeTypeName("#define VK_KHR_external_semaphore_fd 1")]
    public const int VK_KHR_external_semaphore_fd = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME \"VK_KHR_external_semaphore_fd\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME => "VK_KHR_external_semaphore_fd"u8;

    [NativeTypeName("#define VK_KHR_push_descriptor 1")]
    public const int VK_KHR_push_descriptor = 1;

    [NativeTypeName("#define VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION 2")]
    public const int VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME \"VK_KHR_push_descriptor\"")]
    public static ReadOnlySpan<byte> VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME => "VK_KHR_push_descriptor"u8;

    [NativeTypeName("#define VK_KHR_shader_float16_int8 1")]
    public const int VK_KHR_shader_float16_int8 = 1;

    [NativeTypeName("#define VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME \"VK_KHR_shader_float16_int8\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME => "VK_KHR_shader_float16_int8"u8;

    [NativeTypeName("#define VK_KHR_16bit_storage 1")]
    public const int VK_KHR_16bit_storage = 1;

    [NativeTypeName("#define VK_KHR_16BIT_STORAGE_SPEC_VERSION 1")]
    public const int VK_KHR_16BIT_STORAGE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_16BIT_STORAGE_EXTENSION_NAME \"VK_KHR_16bit_storage\"")]
    public static ReadOnlySpan<byte> VK_KHR_16BIT_STORAGE_EXTENSION_NAME => "VK_KHR_16bit_storage"u8;

    [NativeTypeName("#define VK_KHR_incremental_present 1")]
    public const int VK_KHR_incremental_present = 1;

    [NativeTypeName("#define VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION 2")]
    public const int VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME \"VK_KHR_incremental_present\"")]
    public static ReadOnlySpan<byte> VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME => "VK_KHR_incremental_present"u8;

    [NativeTypeName("#define VK_KHR_descriptor_update_template 1")]
    public const int VK_KHR_descriptor_update_template = 1;

    [NativeTypeName("#define VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION 1")]
    public const int VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME \"VK_KHR_descriptor_update_template\"")]
    public static ReadOnlySpan<byte> VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME => "VK_KHR_descriptor_update_template"u8;

    [NativeTypeName("#define VK_KHR_imageless_framebuffer 1")]
    public const int VK_KHR_imageless_framebuffer = 1;

    [NativeTypeName("#define VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION 1")]
    public const int VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME \"VK_KHR_imageless_framebuffer\"")]
    public static ReadOnlySpan<byte> VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME => "VK_KHR_imageless_framebuffer"u8;

    [NativeTypeName("#define VK_KHR_create_renderpass2 1")]
    public const int VK_KHR_create_renderpass2 = 1;

    [NativeTypeName("#define VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION 1")]
    public const int VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME \"VK_KHR_create_renderpass2\"")]
    public static ReadOnlySpan<byte> VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME => "VK_KHR_create_renderpass2"u8;

    [NativeTypeName("#define VK_KHR_shared_presentable_image 1")]
    public const int VK_KHR_shared_presentable_image = 1;

    [NativeTypeName("#define VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION 1")]
    public const int VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME \"VK_KHR_shared_presentable_image\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME => "VK_KHR_shared_presentable_image"u8;

    [NativeTypeName("#define VK_KHR_external_fence_capabilities 1")]
    public const int VK_KHR_external_fence_capabilities = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_fence_capabilities\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME => "VK_KHR_external_fence_capabilities"u8;

    [NativeTypeName("#define VK_KHR_external_fence 1")]
    public const int VK_KHR_external_fence = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_FENCE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME \"VK_KHR_external_fence\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME => "VK_KHR_external_fence"u8;

    [NativeTypeName("#define VK_KHR_external_fence_fd 1")]
    public const int VK_KHR_external_fence_fd = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME \"VK_KHR_external_fence_fd\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME => "VK_KHR_external_fence_fd"u8;

    [NativeTypeName("#define VK_KHR_performance_query 1")]
    public const int VK_KHR_performance_query = 1;

    [NativeTypeName("#define VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION 1")]
    public const int VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME \"VK_KHR_performance_query\"")]
    public static ReadOnlySpan<byte> VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME => "VK_KHR_performance_query"u8;

    [NativeTypeName("#define VK_KHR_maintenance2 1")]
    public const int VK_KHR_maintenance2 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_2_SPEC_VERSION 1")]
    public const int VK_KHR_MAINTENANCE_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_2_EXTENSION_NAME \"VK_KHR_maintenance2\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_2_EXTENSION_NAME => "VK_KHR_maintenance2"u8;

    [NativeTypeName("#define VK_KHR_MAINTENANCE2_SPEC_VERSION VK_KHR_MAINTENANCE_2_SPEC_VERSION")]
    public const int VK_KHR_MAINTENANCE2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE2_EXTENSION_NAME VK_KHR_MAINTENANCE_2_EXTENSION_NAME")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE2_EXTENSION_NAME => "VK_KHR_maintenance2"u8;

    [NativeTypeName("#define VK_KHR_get_surface_capabilities2 1")]
    public const int VK_KHR_get_surface_capabilities2 = 1;

    [NativeTypeName("#define VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION 1")]
    public const int VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME \"VK_KHR_get_surface_capabilities2\"")]
    public static ReadOnlySpan<byte> VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME => "VK_KHR_get_surface_capabilities2"u8;

    [NativeTypeName("#define VK_KHR_variable_pointers 1")]
    public const int VK_KHR_variable_pointers = 1;

    [NativeTypeName("#define VK_KHR_VARIABLE_POINTERS_SPEC_VERSION 1")]
    public const int VK_KHR_VARIABLE_POINTERS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME \"VK_KHR_variable_pointers\"")]
    public static ReadOnlySpan<byte> VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME => "VK_KHR_variable_pointers"u8;

    [NativeTypeName("#define VK_KHR_get_display_properties2 1")]
    public const int VK_KHR_get_display_properties2 = 1;

    [NativeTypeName("#define VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION 1")]
    public const int VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME \"VK_KHR_get_display_properties2\"")]
    public static ReadOnlySpan<byte> VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME => "VK_KHR_get_display_properties2"u8;

    [NativeTypeName("#define VK_KHR_dedicated_allocation 1")]
    public const int VK_KHR_dedicated_allocation = 1;

    [NativeTypeName("#define VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION 3")]
    public const int VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME \"VK_KHR_dedicated_allocation\"")]
    public static ReadOnlySpan<byte> VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME => "VK_KHR_dedicated_allocation"u8;

    [NativeTypeName("#define VK_KHR_storage_buffer_storage_class 1")]
    public const int VK_KHR_storage_buffer_storage_class = 1;

    [NativeTypeName("#define VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION 1")]
    public const int VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME \"VK_KHR_storage_buffer_storage_class\"")]
    public static ReadOnlySpan<byte> VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME => "VK_KHR_storage_buffer_storage_class"u8;

    [NativeTypeName("#define VK_KHR_shader_bfloat16 1")]
    public const int VK_KHR_shader_bfloat16 = 1;

    [NativeTypeName("#define VK_KHR_SHADER_BFLOAT16_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_BFLOAT16_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_BFLOAT16_EXTENSION_NAME \"VK_KHR_shader_bfloat16\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_BFLOAT16_EXTENSION_NAME => "VK_KHR_shader_bfloat16"u8;

    [NativeTypeName("#define VK_KHR_relaxed_block_layout 1")]
    public const int VK_KHR_relaxed_block_layout = 1;

    [NativeTypeName("#define VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION 1")]
    public const int VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME \"VK_KHR_relaxed_block_layout\"")]
    public static ReadOnlySpan<byte> VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME => "VK_KHR_relaxed_block_layout"u8;

    [NativeTypeName("#define VK_KHR_get_memory_requirements2 1")]
    public const int VK_KHR_get_memory_requirements2 = 1;

    [NativeTypeName("#define VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION 1")]
    public const int VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME \"VK_KHR_get_memory_requirements2\"")]
    public static ReadOnlySpan<byte> VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME => "VK_KHR_get_memory_requirements2"u8;

    [NativeTypeName("#define VK_KHR_image_format_list 1")]
    public const int VK_KHR_image_format_list = 1;

    [NativeTypeName("#define VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION 1")]
    public const int VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME \"VK_KHR_image_format_list\"")]
    public static ReadOnlySpan<byte> VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME => "VK_KHR_image_format_list"u8;

    [NativeTypeName("#define VK_KHR_sampler_ycbcr_conversion 1")]
    public const int VK_KHR_sampler_ycbcr_conversion = 1;

    [NativeTypeName("#define VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION 14")]
    public const int VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION = 14;

    [NativeTypeName("#define VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME \"VK_KHR_sampler_ycbcr_conversion\"")]
    public static ReadOnlySpan<byte> VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME => "VK_KHR_sampler_ycbcr_conversion"u8;

    [NativeTypeName("#define VK_KHR_bind_memory2 1")]
    public const int VK_KHR_bind_memory2 = 1;

    [NativeTypeName("#define VK_KHR_BIND_MEMORY_2_SPEC_VERSION 1")]
    public const int VK_KHR_BIND_MEMORY_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_BIND_MEMORY_2_EXTENSION_NAME \"VK_KHR_bind_memory2\"")]
    public static ReadOnlySpan<byte> VK_KHR_BIND_MEMORY_2_EXTENSION_NAME => "VK_KHR_bind_memory2"u8;

    [NativeTypeName("#define VK_KHR_maintenance3 1")]
    public const int VK_KHR_maintenance3 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_3_SPEC_VERSION 1")]
    public const int VK_KHR_MAINTENANCE_3_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_3_EXTENSION_NAME \"VK_KHR_maintenance3\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_3_EXTENSION_NAME => "VK_KHR_maintenance3"u8;

    [NativeTypeName("#define VK_KHR_MAINTENANCE3_SPEC_VERSION VK_KHR_MAINTENANCE_3_SPEC_VERSION")]
    public const int VK_KHR_MAINTENANCE3_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE3_EXTENSION_NAME VK_KHR_MAINTENANCE_3_EXTENSION_NAME")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE3_EXTENSION_NAME => "VK_KHR_maintenance3"u8;

    [NativeTypeName("#define VK_KHR_draw_indirect_count 1")]
    public const int VK_KHR_draw_indirect_count = 1;

    [NativeTypeName("#define VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION 1")]
    public const int VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME \"VK_KHR_draw_indirect_count\"")]
    public static ReadOnlySpan<byte> VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME => "VK_KHR_draw_indirect_count"u8;

    [NativeTypeName("#define VK_KHR_shader_subgroup_extended_types 1")]
    public const int VK_KHR_shader_subgroup_extended_types = 1;

    [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_EXTENSION_NAME \"VK_KHR_shader_subgroup_extended_types\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_EXTENSION_NAME => "VK_KHR_shader_subgroup_extended_types"u8;

    [NativeTypeName("#define VK_KHR_8bit_storage 1")]
    public const int VK_KHR_8bit_storage = 1;

    [NativeTypeName("#define VK_KHR_8BIT_STORAGE_SPEC_VERSION 1")]
    public const int VK_KHR_8BIT_STORAGE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_8BIT_STORAGE_EXTENSION_NAME \"VK_KHR_8bit_storage\"")]
    public static ReadOnlySpan<byte> VK_KHR_8BIT_STORAGE_EXTENSION_NAME => "VK_KHR_8bit_storage"u8;

    [NativeTypeName("#define VK_KHR_shader_atomic_int64 1")]
    public const int VK_KHR_shader_atomic_int64 = 1;

    [NativeTypeName("#define VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME \"VK_KHR_shader_atomic_int64\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME => "VK_KHR_shader_atomic_int64"u8;

    [NativeTypeName("#define VK_KHR_shader_clock 1")]
    public const int VK_KHR_shader_clock = 1;

    [NativeTypeName("#define VK_KHR_SHADER_CLOCK_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_CLOCK_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_CLOCK_EXTENSION_NAME \"VK_KHR_shader_clock\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_CLOCK_EXTENSION_NAME => "VK_KHR_shader_clock"u8;

    [NativeTypeName("#define VK_KHR_video_decode_h265 1")]
    public const int VK_KHR_video_decode_h265 = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_H265_SPEC_VERSION 8")]
    public const int VK_KHR_VIDEO_DECODE_H265_SPEC_VERSION = 8;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_H265_EXTENSION_NAME \"VK_KHR_video_decode_h265\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_DECODE_H265_EXTENSION_NAME => "VK_KHR_video_decode_h265"u8;

    [NativeTypeName("#define VK_KHR_global_priority 1")]
    public const int VK_KHR_global_priority = 1;

    [NativeTypeName("#define VK_KHR_GLOBAL_PRIORITY_SPEC_VERSION 1")]
    public const int VK_KHR_GLOBAL_PRIORITY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_GLOBAL_PRIORITY_EXTENSION_NAME \"VK_KHR_global_priority\"")]
    public static ReadOnlySpan<byte> VK_KHR_GLOBAL_PRIORITY_EXTENSION_NAME => "VK_KHR_global_priority"u8;

    [NativeTypeName("#define VK_MAX_GLOBAL_PRIORITY_SIZE_KHR VK_MAX_GLOBAL_PRIORITY_SIZE")]
    public const uint VK_MAX_GLOBAL_PRIORITY_SIZE_KHR = 16U;

    [NativeTypeName("#define VK_KHR_driver_properties 1")]
    public const int VK_KHR_driver_properties = 1;

    [NativeTypeName("#define VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION 1")]
    public const int VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME \"VK_KHR_driver_properties\"")]
    public static ReadOnlySpan<byte> VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME => "VK_KHR_driver_properties"u8;

    [NativeTypeName("#define VK_MAX_DRIVER_NAME_SIZE_KHR VK_MAX_DRIVER_NAME_SIZE")]
    public const uint VK_MAX_DRIVER_NAME_SIZE_KHR = 256U;

    [NativeTypeName("#define VK_MAX_DRIVER_INFO_SIZE_KHR VK_MAX_DRIVER_INFO_SIZE")]
    public const uint VK_MAX_DRIVER_INFO_SIZE_KHR = 256U;

    [NativeTypeName("#define VK_KHR_shader_float_controls 1")]
    public const int VK_KHR_shader_float_controls = 1;

    [NativeTypeName("#define VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION 4")]
    public const int VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION = 4;

    [NativeTypeName("#define VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME \"VK_KHR_shader_float_controls\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME => "VK_KHR_shader_float_controls"u8;

    [NativeTypeName("#define VK_KHR_depth_stencil_resolve 1")]
    public const int VK_KHR_depth_stencil_resolve = 1;

    [NativeTypeName("#define VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION 1")]
    public const int VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME \"VK_KHR_depth_stencil_resolve\"")]
    public static ReadOnlySpan<byte> VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME => "VK_KHR_depth_stencil_resolve"u8;

    [NativeTypeName("#define VK_KHR_swapchain_mutable_format 1")]
    public const int VK_KHR_swapchain_mutable_format = 1;

    [NativeTypeName("#define VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION 1")]
    public const int VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME \"VK_KHR_swapchain_mutable_format\"")]
    public static ReadOnlySpan<byte> VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME => "VK_KHR_swapchain_mutable_format"u8;

    [NativeTypeName("#define VK_KHR_timeline_semaphore 1")]
    public const int VK_KHR_timeline_semaphore = 1;

    [NativeTypeName("#define VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION 2")]
    public const int VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME \"VK_KHR_timeline_semaphore\"")]
    public static ReadOnlySpan<byte> VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME => "VK_KHR_timeline_semaphore"u8;

    [NativeTypeName("#define VK_KHR_vulkan_memory_model 1")]
    public const int VK_KHR_vulkan_memory_model = 1;

    [NativeTypeName("#define VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION 3")]
    public const int VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME \"VK_KHR_vulkan_memory_model\"")]
    public static ReadOnlySpan<byte> VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME => "VK_KHR_vulkan_memory_model"u8;

    [NativeTypeName("#define VK_KHR_shader_terminate_invocation 1")]
    public const int VK_KHR_shader_terminate_invocation = 1;

    [NativeTypeName("#define VK_KHR_SHADER_TERMINATE_INVOCATION_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_TERMINATE_INVOCATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_TERMINATE_INVOCATION_EXTENSION_NAME \"VK_KHR_shader_terminate_invocation\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_TERMINATE_INVOCATION_EXTENSION_NAME => "VK_KHR_shader_terminate_invocation"u8;

    [NativeTypeName("#define VK_KHR_fragment_shading_rate 1")]
    public const int VK_KHR_fragment_shading_rate = 1;

    [NativeTypeName("#define VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION 2")]
    public const int VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME \"VK_KHR_fragment_shading_rate\"")]
    public static ReadOnlySpan<byte> VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME => "VK_KHR_fragment_shading_rate"u8;

    [NativeTypeName("#define VK_KHR_dynamic_rendering_local_read 1")]
    public const int VK_KHR_dynamic_rendering_local_read = 1;

    [NativeTypeName("#define VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_SPEC_VERSION 1")]
    public const int VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_EXTENSION_NAME \"VK_KHR_dynamic_rendering_local_read\"")]
    public static ReadOnlySpan<byte> VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_EXTENSION_NAME => "VK_KHR_dynamic_rendering_local_read"u8;

    [NativeTypeName("#define VK_KHR_shader_quad_control 1")]
    public const int VK_KHR_shader_quad_control = 1;

    [NativeTypeName("#define VK_KHR_SHADER_QUAD_CONTROL_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_QUAD_CONTROL_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_QUAD_CONTROL_EXTENSION_NAME \"VK_KHR_shader_quad_control\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_QUAD_CONTROL_EXTENSION_NAME => "VK_KHR_shader_quad_control"u8;

    [NativeTypeName("#define VK_KHR_spirv_1_4 1")]
    public const int VK_KHR_spirv_1_4 = 1;

    [NativeTypeName("#define VK_KHR_SPIRV_1_4_SPEC_VERSION 1")]
    public const int VK_KHR_SPIRV_1_4_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SPIRV_1_4_EXTENSION_NAME \"VK_KHR_spirv_1_4\"")]
    public static ReadOnlySpan<byte> VK_KHR_SPIRV_1_4_EXTENSION_NAME => "VK_KHR_spirv_1_4"u8;

    [NativeTypeName("#define VK_KHR_surface_protected_capabilities 1")]
    public const int VK_KHR_surface_protected_capabilities = 1;

    [NativeTypeName("#define VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION 1")]
    public const int VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME \"VK_KHR_surface_protected_capabilities\"")]
    public static ReadOnlySpan<byte> VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME => "VK_KHR_surface_protected_capabilities"u8;

    [NativeTypeName("#define VK_KHR_separate_depth_stencil_layouts 1")]
    public const int VK_KHR_separate_depth_stencil_layouts = 1;

    [NativeTypeName("#define VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION 1")]
    public const int VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME \"VK_KHR_separate_depth_stencil_layouts\"")]
    public static ReadOnlySpan<byte> VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME => "VK_KHR_separate_depth_stencil_layouts"u8;

    [NativeTypeName("#define VK_KHR_present_wait 1")]
    public const int VK_KHR_present_wait = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_WAIT_SPEC_VERSION 1")]
    public const int VK_KHR_PRESENT_WAIT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_WAIT_EXTENSION_NAME \"VK_KHR_present_wait\"")]
    public static ReadOnlySpan<byte> VK_KHR_PRESENT_WAIT_EXTENSION_NAME => "VK_KHR_present_wait"u8;

    [NativeTypeName("#define VK_KHR_uniform_buffer_standard_layout 1")]
    public const int VK_KHR_uniform_buffer_standard_layout = 1;

    [NativeTypeName("#define VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION 1")]
    public const int VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME \"VK_KHR_uniform_buffer_standard_layout\"")]
    public static ReadOnlySpan<byte> VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME => "VK_KHR_uniform_buffer_standard_layout"u8;

    [NativeTypeName("#define VK_KHR_buffer_device_address 1")]
    public const int VK_KHR_buffer_device_address = 1;

    [NativeTypeName("#define VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION 1")]
    public const int VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME \"VK_KHR_buffer_device_address\"")]
    public static ReadOnlySpan<byte> VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME => "VK_KHR_buffer_device_address"u8;

    [NativeTypeName("#define VK_KHR_deferred_host_operations 1")]
    public const int VK_KHR_deferred_host_operations = 1;

    [NativeTypeName("#define VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION 4")]
    public const int VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION = 4;

    [NativeTypeName("#define VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME \"VK_KHR_deferred_host_operations\"")]
    public static ReadOnlySpan<byte> VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME => "VK_KHR_deferred_host_operations"u8;

    [NativeTypeName("#define VK_KHR_pipeline_executable_properties 1")]
    public const int VK_KHR_pipeline_executable_properties = 1;

    [NativeTypeName("#define VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION 1")]
    public const int VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME \"VK_KHR_pipeline_executable_properties\"")]
    public static ReadOnlySpan<byte> VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME => "VK_KHR_pipeline_executable_properties"u8;

    [NativeTypeName("#define VK_KHR_map_memory2 1")]
    public const int VK_KHR_map_memory2 = 1;

    [NativeTypeName("#define VK_KHR_MAP_MEMORY_2_SPEC_VERSION 1")]
    public const int VK_KHR_MAP_MEMORY_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAP_MEMORY_2_EXTENSION_NAME \"VK_KHR_map_memory2\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAP_MEMORY_2_EXTENSION_NAME => "VK_KHR_map_memory2"u8;

    [NativeTypeName("#define VK_KHR_shader_integer_dot_product 1")]
    public const int VK_KHR_shader_integer_dot_product = 1;

    [NativeTypeName("#define VK_KHR_SHADER_INTEGER_DOT_PRODUCT_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_INTEGER_DOT_PRODUCT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_INTEGER_DOT_PRODUCT_EXTENSION_NAME \"VK_KHR_shader_integer_dot_product\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_INTEGER_DOT_PRODUCT_EXTENSION_NAME => "VK_KHR_shader_integer_dot_product"u8;

    [NativeTypeName("#define VK_KHR_pipeline_library 1")]
    public const int VK_KHR_pipeline_library = 1;

    [NativeTypeName("#define VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION 1")]
    public const int VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME \"VK_KHR_pipeline_library\"")]
    public static ReadOnlySpan<byte> VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME => "VK_KHR_pipeline_library"u8;

    [NativeTypeName("#define VK_KHR_shader_non_semantic_info 1")]
    public const int VK_KHR_shader_non_semantic_info = 1;

    [NativeTypeName("#define VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME \"VK_KHR_shader_non_semantic_info\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME => "VK_KHR_shader_non_semantic_info"u8;

    [NativeTypeName("#define VK_KHR_present_id 1")]
    public const int VK_KHR_present_id = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_ID_SPEC_VERSION 1")]
    public const int VK_KHR_PRESENT_ID_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_ID_EXTENSION_NAME \"VK_KHR_present_id\"")]
    public static ReadOnlySpan<byte> VK_KHR_PRESENT_ID_EXTENSION_NAME => "VK_KHR_present_id"u8;

    [NativeTypeName("#define VK_KHR_video_encode_queue 1")]
    public const int VK_KHR_video_encode_queue = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION 12")]
    public const int VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION = 12;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME \"VK_KHR_video_encode_queue\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME => "VK_KHR_video_encode_queue"u8;

    [NativeTypeName("#define VK_KHR_synchronization2 1")]
    public const int VK_KHR_synchronization2 = 1;

    [NativeTypeName("#define VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION 1")]
    public const int VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME \"VK_KHR_synchronization2\"")]
    public static ReadOnlySpan<byte> VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME => "VK_KHR_synchronization2"u8;

    [NativeTypeName("#define VK_KHR_fragment_shader_barycentric 1")]
    public const int VK_KHR_fragment_shader_barycentric = 1;

    [NativeTypeName("#define VK_KHR_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION 1")]
    public const int VK_KHR_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME \"VK_KHR_fragment_shader_barycentric\"")]
    public static ReadOnlySpan<byte> VK_KHR_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME => "VK_KHR_fragment_shader_barycentric"u8;

    [NativeTypeName("#define VK_KHR_shader_subgroup_uniform_control_flow 1")]
    public const int VK_KHR_shader_subgroup_uniform_control_flow = 1;

    [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME \"VK_KHR_shader_subgroup_uniform_control_flow\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME => "VK_KHR_shader_subgroup_uniform_control_flow"u8;

    [NativeTypeName("#define VK_KHR_zero_initialize_workgroup_memory 1")]
    public const int VK_KHR_zero_initialize_workgroup_memory = 1;

    [NativeTypeName("#define VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION 1")]
    public const int VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME \"VK_KHR_zero_initialize_workgroup_memory\"")]
    public static ReadOnlySpan<byte> VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME => "VK_KHR_zero_initialize_workgroup_memory"u8;

    [NativeTypeName("#define VK_KHR_workgroup_memory_explicit_layout 1")]
    public const int VK_KHR_workgroup_memory_explicit_layout = 1;

    [NativeTypeName("#define VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION 1")]
    public const int VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME \"VK_KHR_workgroup_memory_explicit_layout\"")]
    public static ReadOnlySpan<byte> VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME => "VK_KHR_workgroup_memory_explicit_layout"u8;

    [NativeTypeName("#define VK_KHR_copy_commands2 1")]
    public const int VK_KHR_copy_commands2 = 1;

    [NativeTypeName("#define VK_KHR_COPY_COMMANDS_2_SPEC_VERSION 1")]
    public const int VK_KHR_COPY_COMMANDS_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME \"VK_KHR_copy_commands2\"")]
    public static ReadOnlySpan<byte> VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME => "VK_KHR_copy_commands2"u8;

    [NativeTypeName("#define VK_KHR_format_feature_flags2 1")]
    public const int VK_KHR_format_feature_flags2 = 1;

    [NativeTypeName("#define VK_KHR_FORMAT_FEATURE_FLAGS_2_SPEC_VERSION 2")]
    public const int VK_KHR_FORMAT_FEATURE_FLAGS_2_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_FORMAT_FEATURE_FLAGS_2_EXTENSION_NAME \"VK_KHR_format_feature_flags2\"")]
    public static ReadOnlySpan<byte> VK_KHR_FORMAT_FEATURE_FLAGS_2_EXTENSION_NAME => "VK_KHR_format_feature_flags2"u8;

    [NativeTypeName("#define VK_KHR_ray_tracing_maintenance1 1")]
    public const int VK_KHR_ray_tracing_maintenance1 = 1;

    [NativeTypeName("#define VK_KHR_RAY_TRACING_MAINTENANCE_1_SPEC_VERSION 1")]
    public const int VK_KHR_RAY_TRACING_MAINTENANCE_1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_RAY_TRACING_MAINTENANCE_1_EXTENSION_NAME \"VK_KHR_ray_tracing_maintenance1\"")]
    public static ReadOnlySpan<byte> VK_KHR_RAY_TRACING_MAINTENANCE_1_EXTENSION_NAME => "VK_KHR_ray_tracing_maintenance1"u8;

    [NativeTypeName("#define VK_KHR_shader_untyped_pointers 1")]
    public const int VK_KHR_shader_untyped_pointers = 1;

    [NativeTypeName("#define VK_KHR_SHADER_UNTYPED_POINTERS_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_UNTYPED_POINTERS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_UNTYPED_POINTERS_EXTENSION_NAME \"VK_KHR_shader_untyped_pointers\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_UNTYPED_POINTERS_EXTENSION_NAME => "VK_KHR_shader_untyped_pointers"u8;

    [NativeTypeName("#define VK_KHR_portability_enumeration 1")]
    public const int VK_KHR_portability_enumeration = 1;

    [NativeTypeName("#define VK_KHR_PORTABILITY_ENUMERATION_SPEC_VERSION 1")]
    public const int VK_KHR_PORTABILITY_ENUMERATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PORTABILITY_ENUMERATION_EXTENSION_NAME \"VK_KHR_portability_enumeration\"")]
    public static ReadOnlySpan<byte> VK_KHR_PORTABILITY_ENUMERATION_EXTENSION_NAME => "VK_KHR_portability_enumeration"u8;

    [NativeTypeName("#define VK_KHR_maintenance4 1")]
    public const int VK_KHR_maintenance4 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_4_SPEC_VERSION 2")]
    public const int VK_KHR_MAINTENANCE_4_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_4_EXTENSION_NAME \"VK_KHR_maintenance4\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_4_EXTENSION_NAME => "VK_KHR_maintenance4"u8;

    [NativeTypeName("#define VK_KHR_shader_subgroup_rotate 1")]
    public const int VK_KHR_shader_subgroup_rotate = 1;

    [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_ROTATE_SPEC_VERSION 2")]
    public const int VK_KHR_SHADER_SUBGROUP_ROTATE_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_ROTATE_EXTENSION_NAME \"VK_KHR_shader_subgroup_rotate\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_SUBGROUP_ROTATE_EXTENSION_NAME => "VK_KHR_shader_subgroup_rotate"u8;

    [NativeTypeName("#define VK_KHR_shader_maximal_reconvergence 1")]
    public const int VK_KHR_shader_maximal_reconvergence = 1;

    [NativeTypeName("#define VK_KHR_SHADER_MAXIMAL_RECONVERGENCE_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_MAXIMAL_RECONVERGENCE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_MAXIMAL_RECONVERGENCE_EXTENSION_NAME \"VK_KHR_shader_maximal_reconvergence\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_MAXIMAL_RECONVERGENCE_EXTENSION_NAME => "VK_KHR_shader_maximal_reconvergence"u8;

    [NativeTypeName("#define VK_KHR_maintenance5 1")]
    public const int VK_KHR_maintenance5 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_5_SPEC_VERSION 1")]
    public const int VK_KHR_MAINTENANCE_5_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_5_EXTENSION_NAME \"VK_KHR_maintenance5\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_5_EXTENSION_NAME => "VK_KHR_maintenance5"u8;

    [NativeTypeName("#define VK_KHR_present_id2 1")]
    public const int VK_KHR_present_id2 = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_ID_2_SPEC_VERSION 1")]
    public const int VK_KHR_PRESENT_ID_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_ID_2_EXTENSION_NAME \"VK_KHR_present_id2\"")]
    public static ReadOnlySpan<byte> VK_KHR_PRESENT_ID_2_EXTENSION_NAME => "VK_KHR_present_id2"u8;

    [NativeTypeName("#define VK_KHR_present_wait2 1")]
    public const int VK_KHR_present_wait2 = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_WAIT_2_SPEC_VERSION 1")]
    public const int VK_KHR_PRESENT_WAIT_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_WAIT_2_EXTENSION_NAME \"VK_KHR_present_wait2\"")]
    public static ReadOnlySpan<byte> VK_KHR_PRESENT_WAIT_2_EXTENSION_NAME => "VK_KHR_present_wait2"u8;

    [NativeTypeName("#define VK_KHR_ray_tracing_position_fetch 1")]
    public const int VK_KHR_ray_tracing_position_fetch = 1;

    [NativeTypeName("#define VK_KHR_RAY_TRACING_POSITION_FETCH_SPEC_VERSION 1")]
    public const int VK_KHR_RAY_TRACING_POSITION_FETCH_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_RAY_TRACING_POSITION_FETCH_EXTENSION_NAME \"VK_KHR_ray_tracing_position_fetch\"")]
    public static ReadOnlySpan<byte> VK_KHR_RAY_TRACING_POSITION_FETCH_EXTENSION_NAME => "VK_KHR_ray_tracing_position_fetch"u8;

    [NativeTypeName("#define VK_KHR_pipeline_binary 1")]
    public const int VK_KHR_pipeline_binary = 1;

    [NativeTypeName("#define VK_MAX_PIPELINE_BINARY_KEY_SIZE_KHR 32U")]
    public const uint VK_MAX_PIPELINE_BINARY_KEY_SIZE_KHR = 32U;

    [NativeTypeName("#define VK_KHR_PIPELINE_BINARY_SPEC_VERSION 1")]
    public const int VK_KHR_PIPELINE_BINARY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PIPELINE_BINARY_EXTENSION_NAME \"VK_KHR_pipeline_binary\"")]
    public static ReadOnlySpan<byte> VK_KHR_PIPELINE_BINARY_EXTENSION_NAME => "VK_KHR_pipeline_binary"u8;

    [NativeTypeName("#define VK_KHR_surface_maintenance1 1")]
    public const int VK_KHR_surface_maintenance1 = 1;

    [NativeTypeName("#define VK_KHR_SURFACE_MAINTENANCE_1_SPEC_VERSION 1")]
    public const int VK_KHR_SURFACE_MAINTENANCE_1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SURFACE_MAINTENANCE_1_EXTENSION_NAME \"VK_KHR_surface_maintenance1\"")]
    public static ReadOnlySpan<byte> VK_KHR_SURFACE_MAINTENANCE_1_EXTENSION_NAME => "VK_KHR_surface_maintenance1"u8;

    [NativeTypeName("#define VK_KHR_swapchain_maintenance1 1")]
    public const int VK_KHR_swapchain_maintenance1 = 1;

    [NativeTypeName("#define VK_KHR_SWAPCHAIN_MAINTENANCE_1_SPEC_VERSION 1")]
    public const int VK_KHR_SWAPCHAIN_MAINTENANCE_1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME \"VK_KHR_swapchain_maintenance1\"")]
    public static ReadOnlySpan<byte> VK_KHR_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME => "VK_KHR_swapchain_maintenance1"u8;

    [NativeTypeName("#define VK_KHR_cooperative_matrix 1")]
    public const int VK_KHR_cooperative_matrix = 1;

    [NativeTypeName("#define VK_KHR_COOPERATIVE_MATRIX_SPEC_VERSION 2")]
    public const int VK_KHR_COOPERATIVE_MATRIX_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_COOPERATIVE_MATRIX_EXTENSION_NAME \"VK_KHR_cooperative_matrix\"")]
    public static ReadOnlySpan<byte> VK_KHR_COOPERATIVE_MATRIX_EXTENSION_NAME => "VK_KHR_cooperative_matrix"u8;

    [NativeTypeName("#define VK_KHR_compute_shader_derivatives 1")]
    public const int VK_KHR_compute_shader_derivatives = 1;

    [NativeTypeName("#define VK_KHR_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION 1")]
    public const int VK_KHR_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME \"VK_KHR_compute_shader_derivatives\"")]
    public static ReadOnlySpan<byte> VK_KHR_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME => "VK_KHR_compute_shader_derivatives"u8;

    [NativeTypeName("#define VK_KHR_video_decode_av1 1")]
    public const int VK_KHR_video_decode_av1 = 1;

    [NativeTypeName("#define VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR 7U")]
    public const uint VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR = 7U;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_AV1_SPEC_VERSION 1")]
    public const int VK_KHR_VIDEO_DECODE_AV1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_AV1_EXTENSION_NAME \"VK_KHR_video_decode_av1\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_DECODE_AV1_EXTENSION_NAME => "VK_KHR_video_decode_av1"u8;

    [NativeTypeName("#define VK_KHR_video_encode_av1 1")]
    public const int VK_KHR_video_encode_av1 = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_AV1_SPEC_VERSION 1")]
    public const int VK_KHR_VIDEO_ENCODE_AV1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_AV1_EXTENSION_NAME \"VK_KHR_video_encode_av1\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_AV1_EXTENSION_NAME => "VK_KHR_video_encode_av1"u8;

    [NativeTypeName("#define VK_KHR_video_decode_vp9 1")]
    public const int VK_KHR_video_decode_vp9 = 1;

    [NativeTypeName("#define VK_MAX_VIDEO_VP9_REFERENCES_PER_FRAME_KHR 3U")]
    public const uint VK_MAX_VIDEO_VP9_REFERENCES_PER_FRAME_KHR = 3U;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_VP9_SPEC_VERSION 1")]
    public const int VK_KHR_VIDEO_DECODE_VP9_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_DECODE_VP9_EXTENSION_NAME \"VK_KHR_video_decode_vp9\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_DECODE_VP9_EXTENSION_NAME => "VK_KHR_video_decode_vp9"u8;

    [NativeTypeName("#define VK_KHR_video_maintenance1 1")]
    public const int VK_KHR_video_maintenance1 = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_MAINTENANCE_1_SPEC_VERSION 1")]
    public const int VK_KHR_VIDEO_MAINTENANCE_1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_MAINTENANCE_1_EXTENSION_NAME \"VK_KHR_video_maintenance1\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_MAINTENANCE_1_EXTENSION_NAME => "VK_KHR_video_maintenance1"u8;

    [NativeTypeName("#define VK_KHR_vertex_attribute_divisor 1")]
    public const int VK_KHR_vertex_attribute_divisor = 1;

    [NativeTypeName("#define VK_KHR_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION 1")]
    public const int VK_KHR_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME \"VK_KHR_vertex_attribute_divisor\"")]
    public static ReadOnlySpan<byte> VK_KHR_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME => "VK_KHR_vertex_attribute_divisor"u8;

    [NativeTypeName("#define VK_KHR_load_store_op_none 1")]
    public const int VK_KHR_load_store_op_none = 1;

    [NativeTypeName("#define VK_KHR_LOAD_STORE_OP_NONE_SPEC_VERSION 1")]
    public const int VK_KHR_LOAD_STORE_OP_NONE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_LOAD_STORE_OP_NONE_EXTENSION_NAME \"VK_KHR_load_store_op_none\"")]
    public static ReadOnlySpan<byte> VK_KHR_LOAD_STORE_OP_NONE_EXTENSION_NAME => "VK_KHR_load_store_op_none"u8;

    [NativeTypeName("#define VK_KHR_unified_image_layouts 1")]
    public const int VK_KHR_unified_image_layouts = 1;

    [NativeTypeName("#define VK_KHR_UNIFIED_IMAGE_LAYOUTS_SPEC_VERSION 1")]
    public const int VK_KHR_UNIFIED_IMAGE_LAYOUTS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_UNIFIED_IMAGE_LAYOUTS_EXTENSION_NAME \"VK_KHR_unified_image_layouts\"")]
    public static ReadOnlySpan<byte> VK_KHR_UNIFIED_IMAGE_LAYOUTS_EXTENSION_NAME => "VK_KHR_unified_image_layouts"u8;

    [NativeTypeName("#define VK_KHR_shader_float_controls2 1")]
    public const int VK_KHR_shader_float_controls2 = 1;

    [NativeTypeName("#define VK_KHR_SHADER_FLOAT_CONTROLS_2_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_FLOAT_CONTROLS_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_FLOAT_CONTROLS_2_EXTENSION_NAME \"VK_KHR_shader_float_controls2\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_FLOAT_CONTROLS_2_EXTENSION_NAME => "VK_KHR_shader_float_controls2"u8;

    [NativeTypeName("#define VK_KHR_index_type_uint8 1")]
    public const int VK_KHR_index_type_uint8 = 1;

    [NativeTypeName("#define VK_KHR_INDEX_TYPE_UINT8_SPEC_VERSION 1")]
    public const int VK_KHR_INDEX_TYPE_UINT8_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_INDEX_TYPE_UINT8_EXTENSION_NAME \"VK_KHR_index_type_uint8\"")]
    public static ReadOnlySpan<byte> VK_KHR_INDEX_TYPE_UINT8_EXTENSION_NAME => "VK_KHR_index_type_uint8"u8;

    [NativeTypeName("#define VK_KHR_line_rasterization 1")]
    public const int VK_KHR_line_rasterization = 1;

    [NativeTypeName("#define VK_KHR_LINE_RASTERIZATION_SPEC_VERSION 1")]
    public const int VK_KHR_LINE_RASTERIZATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_LINE_RASTERIZATION_EXTENSION_NAME \"VK_KHR_line_rasterization\"")]
    public static ReadOnlySpan<byte> VK_KHR_LINE_RASTERIZATION_EXTENSION_NAME => "VK_KHR_line_rasterization"u8;

    [NativeTypeName("#define VK_KHR_calibrated_timestamps 1")]
    public const int VK_KHR_calibrated_timestamps = 1;

    [NativeTypeName("#define VK_KHR_CALIBRATED_TIMESTAMPS_SPEC_VERSION 1")]
    public const int VK_KHR_CALIBRATED_TIMESTAMPS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_CALIBRATED_TIMESTAMPS_EXTENSION_NAME \"VK_KHR_calibrated_timestamps\"")]
    public static ReadOnlySpan<byte> VK_KHR_CALIBRATED_TIMESTAMPS_EXTENSION_NAME => "VK_KHR_calibrated_timestamps"u8;

    [NativeTypeName("#define VK_KHR_shader_expect_assume 1")]
    public const int VK_KHR_shader_expect_assume = 1;

    [NativeTypeName("#define VK_KHR_SHADER_EXPECT_ASSUME_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_EXPECT_ASSUME_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_EXPECT_ASSUME_EXTENSION_NAME \"VK_KHR_shader_expect_assume\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_EXPECT_ASSUME_EXTENSION_NAME => "VK_KHR_shader_expect_assume"u8;

    [NativeTypeName("#define VK_KHR_maintenance6 1")]
    public const int VK_KHR_maintenance6 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_6_SPEC_VERSION 1")]
    public const int VK_KHR_MAINTENANCE_6_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_6_EXTENSION_NAME \"VK_KHR_maintenance6\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_6_EXTENSION_NAME => "VK_KHR_maintenance6"u8;

    [NativeTypeName("#define VK_KHR_copy_memory_indirect 1")]
    public const int VK_KHR_copy_memory_indirect = 1;

    [NativeTypeName("#define VK_KHR_COPY_MEMORY_INDIRECT_SPEC_VERSION 1")]
    public const int VK_KHR_COPY_MEMORY_INDIRECT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_COPY_MEMORY_INDIRECT_EXTENSION_NAME \"VK_KHR_copy_memory_indirect\"")]
    public static ReadOnlySpan<byte> VK_KHR_COPY_MEMORY_INDIRECT_EXTENSION_NAME => "VK_KHR_copy_memory_indirect"u8;

    [NativeTypeName("#define VK_KHR_video_encode_intra_refresh 1")]
    public const int VK_KHR_video_encode_intra_refresh = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_INTRA_REFRESH_SPEC_VERSION 1")]
    public const int VK_KHR_VIDEO_ENCODE_INTRA_REFRESH_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_INTRA_REFRESH_EXTENSION_NAME \"VK_KHR_video_encode_intra_refresh\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_INTRA_REFRESH_EXTENSION_NAME => "VK_KHR_video_encode_intra_refresh"u8;

    [NativeTypeName("#define VK_KHR_video_encode_quantization_map 1")]
    public const int VK_KHR_video_encode_quantization_map = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUANTIZATION_MAP_SPEC_VERSION 2")]
    public const int VK_KHR_VIDEO_ENCODE_QUANTIZATION_MAP_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUANTIZATION_MAP_EXTENSION_NAME \"VK_KHR_video_encode_quantization_map\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_QUANTIZATION_MAP_EXTENSION_NAME => "VK_KHR_video_encode_quantization_map"u8;

    [NativeTypeName("#define VK_KHR_shader_relaxed_extended_instruction 1")]
    public const int VK_KHR_shader_relaxed_extended_instruction = 1;

    [NativeTypeName("#define VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_SPEC_VERSION 1")]
    public const int VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_EXTENSION_NAME \"VK_KHR_shader_relaxed_extended_instruction\"")]
    public static ReadOnlySpan<byte> VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_EXTENSION_NAME => "VK_KHR_shader_relaxed_extended_instruction"u8;

    [NativeTypeName("#define VK_KHR_maintenance7 1")]
    public const int VK_KHR_maintenance7 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_7_SPEC_VERSION 1")]
    public const int VK_KHR_MAINTENANCE_7_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_7_EXTENSION_NAME \"VK_KHR_maintenance7\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_7_EXTENSION_NAME => "VK_KHR_maintenance7"u8;

    [NativeTypeName("#define VK_KHR_maintenance8 1")]
    public const int VK_KHR_maintenance8 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_8_SPEC_VERSION 1")]
    public const int VK_KHR_MAINTENANCE_8_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_8_EXTENSION_NAME \"VK_KHR_maintenance8\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_8_EXTENSION_NAME => "VK_KHR_maintenance8"u8;

    [NativeTypeName("#define VK_KHR_maintenance9 1")]
    public const int VK_KHR_maintenance9 = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_9_SPEC_VERSION 1")]
    public const int VK_KHR_MAINTENANCE_9_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_MAINTENANCE_9_EXTENSION_NAME \"VK_KHR_maintenance9\"")]
    public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_9_EXTENSION_NAME => "VK_KHR_maintenance9"u8;

    [NativeTypeName("#define VK_KHR_video_maintenance2 1")]
    public const int VK_KHR_video_maintenance2 = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_MAINTENANCE_2_SPEC_VERSION 1")]
    public const int VK_KHR_VIDEO_MAINTENANCE_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_MAINTENANCE_2_EXTENSION_NAME \"VK_KHR_video_maintenance2\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_MAINTENANCE_2_EXTENSION_NAME => "VK_KHR_video_maintenance2"u8;

    [NativeTypeName("#define VK_KHR_depth_clamp_zero_one 1")]
    public const int VK_KHR_depth_clamp_zero_one = 1;

    [NativeTypeName("#define VK_KHR_DEPTH_CLAMP_ZERO_ONE_SPEC_VERSION 1")]
    public const int VK_KHR_DEPTH_CLAMP_ZERO_ONE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_DEPTH_CLAMP_ZERO_ONE_EXTENSION_NAME \"VK_KHR_depth_clamp_zero_one\"")]
    public static ReadOnlySpan<byte> VK_KHR_DEPTH_CLAMP_ZERO_ONE_EXTENSION_NAME => "VK_KHR_depth_clamp_zero_one"u8;

    [NativeTypeName("#define VK_KHR_robustness2 1")]
    public const int VK_KHR_robustness2 = 1;

    [NativeTypeName("#define VK_KHR_ROBUSTNESS_2_SPEC_VERSION 1")]
    public const int VK_KHR_ROBUSTNESS_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_ROBUSTNESS_2_EXTENSION_NAME \"VK_KHR_robustness2\"")]
    public static ReadOnlySpan<byte> VK_KHR_ROBUSTNESS_2_EXTENSION_NAME => "VK_KHR_robustness2"u8;

    [NativeTypeName("#define VK_KHR_present_mode_fifo_latest_ready 1")]
    public const int VK_KHR_present_mode_fifo_latest_ready = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_MODE_FIFO_LATEST_READY_SPEC_VERSION 1")]
    public const int VK_KHR_PRESENT_MODE_FIFO_LATEST_READY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PRESENT_MODE_FIFO_LATEST_READY_EXTENSION_NAME \"VK_KHR_present_mode_fifo_latest_ready\"")]
    public static ReadOnlySpan<byte> VK_KHR_PRESENT_MODE_FIFO_LATEST_READY_EXTENSION_NAME => "VK_KHR_present_mode_fifo_latest_ready"u8;

    [NativeTypeName("#define VK_EXT_debug_report 1")]
    public const int VK_EXT_debug_report = 1;

    [NativeTypeName("#define VK_EXT_DEBUG_REPORT_SPEC_VERSION 10")]
    public const int VK_EXT_DEBUG_REPORT_SPEC_VERSION = 10;

    [NativeTypeName("#define VK_EXT_DEBUG_REPORT_EXTENSION_NAME \"VK_EXT_debug_report\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEBUG_REPORT_EXTENSION_NAME => "VK_EXT_debug_report"u8;

    [NativeTypeName("#define VK_NV_glsl_shader 1")]
    public const int VK_NV_glsl_shader = 1;

    [NativeTypeName("#define VK_NV_GLSL_SHADER_SPEC_VERSION 1")]
    public const int VK_NV_GLSL_SHADER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_GLSL_SHADER_EXTENSION_NAME \"VK_NV_glsl_shader\"")]
    public static ReadOnlySpan<byte> VK_NV_GLSL_SHADER_EXTENSION_NAME => "VK_NV_glsl_shader"u8;

    [NativeTypeName("#define VK_EXT_depth_range_unrestricted 1")]
    public const int VK_EXT_depth_range_unrestricted = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION 1")]
    public const int VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME \"VK_EXT_depth_range_unrestricted\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME => "VK_EXT_depth_range_unrestricted"u8;

    [NativeTypeName("#define VK_IMG_filter_cubic 1")]
    public const int VK_IMG_filter_cubic = 1;

    [NativeTypeName("#define VK_IMG_FILTER_CUBIC_SPEC_VERSION 1")]
    public const int VK_IMG_FILTER_CUBIC_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_IMG_FILTER_CUBIC_EXTENSION_NAME \"VK_IMG_filter_cubic\"")]
    public static ReadOnlySpan<byte> VK_IMG_FILTER_CUBIC_EXTENSION_NAME => "VK_IMG_filter_cubic"u8;

    [NativeTypeName("#define VK_AMD_rasterization_order 1")]
    public const int VK_AMD_rasterization_order = 1;

    [NativeTypeName("#define VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION 1")]
    public const int VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME \"VK_AMD_rasterization_order\"")]
    public static ReadOnlySpan<byte> VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME => "VK_AMD_rasterization_order"u8;

    [NativeTypeName("#define VK_AMD_shader_trinary_minmax 1")]
    public const int VK_AMD_shader_trinary_minmax = 1;

    [NativeTypeName("#define VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION 1")]
    public const int VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME \"VK_AMD_shader_trinary_minmax\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME => "VK_AMD_shader_trinary_minmax"u8;

    [NativeTypeName("#define VK_AMD_shader_explicit_vertex_parameter 1")]
    public const int VK_AMD_shader_explicit_vertex_parameter = 1;

    [NativeTypeName("#define VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION 1")]
    public const int VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME \"VK_AMD_shader_explicit_vertex_parameter\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME => "VK_AMD_shader_explicit_vertex_parameter"u8;

    [NativeTypeName("#define VK_EXT_debug_marker 1")]
    public const int VK_EXT_debug_marker = 1;

    [NativeTypeName("#define VK_EXT_DEBUG_MARKER_SPEC_VERSION 4")]
    public const int VK_EXT_DEBUG_MARKER_SPEC_VERSION = 4;

    [NativeTypeName("#define VK_EXT_DEBUG_MARKER_EXTENSION_NAME \"VK_EXT_debug_marker\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEBUG_MARKER_EXTENSION_NAME => "VK_EXT_debug_marker"u8;

    [NativeTypeName("#define VK_AMD_gcn_shader 1")]
    public const int VK_AMD_gcn_shader = 1;

    [NativeTypeName("#define VK_AMD_GCN_SHADER_SPEC_VERSION 1")]
    public const int VK_AMD_GCN_SHADER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_GCN_SHADER_EXTENSION_NAME \"VK_AMD_gcn_shader\"")]
    public static ReadOnlySpan<byte> VK_AMD_GCN_SHADER_EXTENSION_NAME => "VK_AMD_gcn_shader"u8;

    [NativeTypeName("#define VK_NV_dedicated_allocation 1")]
    public const int VK_NV_dedicated_allocation = 1;

    [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION 1")]
    public const int VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME \"VK_NV_dedicated_allocation\"")]
    public static ReadOnlySpan<byte> VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME => "VK_NV_dedicated_allocation"u8;

    [NativeTypeName("#define VK_EXT_transform_feedback 1")]
    public const int VK_EXT_transform_feedback = 1;

    [NativeTypeName("#define VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION 1")]
    public const int VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME \"VK_EXT_transform_feedback\"")]
    public static ReadOnlySpan<byte> VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME => "VK_EXT_transform_feedback"u8;

    [NativeTypeName("#define VK_NVX_binary_import 1")]
    public const int VK_NVX_binary_import = 1;

    [NativeTypeName("#define VK_NVX_BINARY_IMPORT_SPEC_VERSION 2")]
    public const int VK_NVX_BINARY_IMPORT_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NVX_BINARY_IMPORT_EXTENSION_NAME \"VK_NVX_binary_import\"")]
    public static ReadOnlySpan<byte> VK_NVX_BINARY_IMPORT_EXTENSION_NAME => "VK_NVX_binary_import"u8;

    [NativeTypeName("#define VK_NVX_image_view_handle 1")]
    public const int VK_NVX_image_view_handle = 1;

    [NativeTypeName("#define VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION 3")]
    public const int VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME \"VK_NVX_image_view_handle\"")]
    public static ReadOnlySpan<byte> VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME => "VK_NVX_image_view_handle"u8;

    [NativeTypeName("#define VK_AMD_draw_indirect_count 1")]
    public const int VK_AMD_draw_indirect_count = 1;

    [NativeTypeName("#define VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION 2")]
    public const int VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME \"VK_AMD_draw_indirect_count\"")]
    public static ReadOnlySpan<byte> VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME => "VK_AMD_draw_indirect_count"u8;

    [NativeTypeName("#define VK_AMD_negative_viewport_height 1")]
    public const int VK_AMD_negative_viewport_height = 1;

    [NativeTypeName("#define VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION 1")]
    public const int VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME \"VK_AMD_negative_viewport_height\"")]
    public static ReadOnlySpan<byte> VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME => "VK_AMD_negative_viewport_height"u8;

    [NativeTypeName("#define VK_AMD_gpu_shader_half_float 1")]
    public const int VK_AMD_gpu_shader_half_float = 1;

    [NativeTypeName("#define VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION 2")]
    public const int VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME \"VK_AMD_gpu_shader_half_float\"")]
    public static ReadOnlySpan<byte> VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME => "VK_AMD_gpu_shader_half_float"u8;

    [NativeTypeName("#define VK_AMD_shader_ballot 1")]
    public const int VK_AMD_shader_ballot = 1;

    [NativeTypeName("#define VK_AMD_SHADER_BALLOT_SPEC_VERSION 1")]
    public const int VK_AMD_SHADER_BALLOT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_SHADER_BALLOT_EXTENSION_NAME \"VK_AMD_shader_ballot\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_BALLOT_EXTENSION_NAME => "VK_AMD_shader_ballot"u8;

    [NativeTypeName("#define VK_AMD_texture_gather_bias_lod 1")]
    public const int VK_AMD_texture_gather_bias_lod = 1;

    [NativeTypeName("#define VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION 1")]
    public const int VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME \"VK_AMD_texture_gather_bias_lod\"")]
    public static ReadOnlySpan<byte> VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME => "VK_AMD_texture_gather_bias_lod"u8;

    [NativeTypeName("#define VK_AMD_shader_info 1")]
    public const int VK_AMD_shader_info = 1;

    [NativeTypeName("#define VK_AMD_SHADER_INFO_SPEC_VERSION 1")]
    public const int VK_AMD_SHADER_INFO_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_SHADER_INFO_EXTENSION_NAME \"VK_AMD_shader_info\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_INFO_EXTENSION_NAME => "VK_AMD_shader_info"u8;

    [NativeTypeName("#define VK_AMD_shader_image_load_store_lod 1")]
    public const int VK_AMD_shader_image_load_store_lod = 1;

    [NativeTypeName("#define VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION 1")]
    public const int VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME \"VK_AMD_shader_image_load_store_lod\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME => "VK_AMD_shader_image_load_store_lod"u8;

    [NativeTypeName("#define VK_NV_corner_sampled_image 1")]
    public const int VK_NV_corner_sampled_image = 1;

    [NativeTypeName("#define VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION 2")]
    public const int VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME \"VK_NV_corner_sampled_image\"")]
    public static ReadOnlySpan<byte> VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME => "VK_NV_corner_sampled_image"u8;

    [NativeTypeName("#define VK_IMG_format_pvrtc 1")]
    public const int VK_IMG_format_pvrtc = 1;

    [NativeTypeName("#define VK_IMG_FORMAT_PVRTC_SPEC_VERSION 1")]
    public const int VK_IMG_FORMAT_PVRTC_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_IMG_FORMAT_PVRTC_EXTENSION_NAME \"VK_IMG_format_pvrtc\"")]
    public static ReadOnlySpan<byte> VK_IMG_FORMAT_PVRTC_EXTENSION_NAME => "VK_IMG_format_pvrtc"u8;

    [NativeTypeName("#define VK_NV_external_memory_capabilities 1")]
    public const int VK_NV_external_memory_capabilities = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION 1")]
    public const int VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME \"VK_NV_external_memory_capabilities\"")]
    public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME => "VK_NV_external_memory_capabilities"u8;

    [NativeTypeName("#define VK_NV_external_memory 1")]
    public const int VK_NV_external_memory = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_SPEC_VERSION 1")]
    public const int VK_NV_EXTERNAL_MEMORY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_NV_external_memory\"")]
    public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME => "VK_NV_external_memory"u8;

    [NativeTypeName("#define VK_EXT_validation_flags 1")]
    public const int VK_EXT_validation_flags = 1;

    [NativeTypeName("#define VK_EXT_VALIDATION_FLAGS_SPEC_VERSION 3")]
    public const int VK_EXT_VALIDATION_FLAGS_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME \"VK_EXT_validation_flags\"")]
    public static ReadOnlySpan<byte> VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME => "VK_EXT_validation_flags"u8;

    [NativeTypeName("#define VK_EXT_shader_subgroup_ballot 1")]
    public const int VK_EXT_shader_subgroup_ballot = 1;

    [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME \"VK_EXT_shader_subgroup_ballot\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME => "VK_EXT_shader_subgroup_ballot"u8;

    [NativeTypeName("#define VK_EXT_shader_subgroup_vote 1")]
    public const int VK_EXT_shader_subgroup_vote = 1;

    [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME \"VK_EXT_shader_subgroup_vote\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME => "VK_EXT_shader_subgroup_vote"u8;

    [NativeTypeName("#define VK_EXT_texture_compression_astc_hdr 1")]
    public const int VK_EXT_texture_compression_astc_hdr = 1;

    [NativeTypeName("#define VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION 1")]
    public const int VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME \"VK_EXT_texture_compression_astc_hdr\"")]
    public static ReadOnlySpan<byte> VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME => "VK_EXT_texture_compression_astc_hdr"u8;

    [NativeTypeName("#define VK_EXT_astc_decode_mode 1")]
    public const int VK_EXT_astc_decode_mode = 1;

    [NativeTypeName("#define VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION 1")]
    public const int VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME \"VK_EXT_astc_decode_mode\"")]
    public static ReadOnlySpan<byte> VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME => "VK_EXT_astc_decode_mode"u8;

    [NativeTypeName("#define VK_EXT_pipeline_robustness 1")]
    public const int VK_EXT_pipeline_robustness = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_ROBUSTNESS_SPEC_VERSION 1")]
    public const int VK_EXT_PIPELINE_ROBUSTNESS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_ROBUSTNESS_EXTENSION_NAME \"VK_EXT_pipeline_robustness\"")]
    public static ReadOnlySpan<byte> VK_EXT_PIPELINE_ROBUSTNESS_EXTENSION_NAME => "VK_EXT_pipeline_robustness"u8;

    [NativeTypeName("#define VK_EXT_conditional_rendering 1")]
    public const int VK_EXT_conditional_rendering = 1;

    [NativeTypeName("#define VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION 2")]
    public const int VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME \"VK_EXT_conditional_rendering\"")]
    public static ReadOnlySpan<byte> VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME => "VK_EXT_conditional_rendering"u8;

    [NativeTypeName("#define VK_NV_clip_space_w_scaling 1")]
    public const int VK_NV_clip_space_w_scaling = 1;

    [NativeTypeName("#define VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION 1")]
    public const int VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME \"VK_NV_clip_space_w_scaling\"")]
    public static ReadOnlySpan<byte> VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME => "VK_NV_clip_space_w_scaling"u8;

    [NativeTypeName("#define VK_EXT_direct_mode_display 1")]
    public const int VK_EXT_direct_mode_display = 1;

    [NativeTypeName("#define VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION 1")]
    public const int VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME \"VK_EXT_direct_mode_display\"")]
    public static ReadOnlySpan<byte> VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME => "VK_EXT_direct_mode_display"u8;

    [NativeTypeName("#define VK_EXT_display_surface_counter 1")]
    public const int VK_EXT_display_surface_counter = 1;

    [NativeTypeName("#define VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION 1")]
    public const int VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME \"VK_EXT_display_surface_counter\"")]
    public static ReadOnlySpan<byte> VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME => "VK_EXT_display_surface_counter"u8;

    [NativeTypeName("#define VK_EXT_display_control 1")]
    public const int VK_EXT_display_control = 1;

    [NativeTypeName("#define VK_EXT_DISPLAY_CONTROL_SPEC_VERSION 1")]
    public const int VK_EXT_DISPLAY_CONTROL_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME \"VK_EXT_display_control\"")]
    public static ReadOnlySpan<byte> VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME => "VK_EXT_display_control"u8;

    [NativeTypeName("#define VK_GOOGLE_display_timing 1")]
    public const int VK_GOOGLE_display_timing = 1;

    [NativeTypeName("#define VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION 1")]
    public const int VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME \"VK_GOOGLE_display_timing\"")]
    public static ReadOnlySpan<byte> VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME => "VK_GOOGLE_display_timing"u8;

    [NativeTypeName("#define VK_NV_sample_mask_override_coverage 1")]
    public const int VK_NV_sample_mask_override_coverage = 1;

    [NativeTypeName("#define VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION 1")]
    public const int VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME \"VK_NV_sample_mask_override_coverage\"")]
    public static ReadOnlySpan<byte> VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME => "VK_NV_sample_mask_override_coverage"u8;

    [NativeTypeName("#define VK_NV_geometry_shader_passthrough 1")]
    public const int VK_NV_geometry_shader_passthrough = 1;

    [NativeTypeName("#define VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION 1")]
    public const int VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME \"VK_NV_geometry_shader_passthrough\"")]
    public static ReadOnlySpan<byte> VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME => "VK_NV_geometry_shader_passthrough"u8;

    [NativeTypeName("#define VK_NV_viewport_array2 1")]
    public const int VK_NV_viewport_array2 = 1;

    [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION 1")]
    public const int VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME \"VK_NV_viewport_array2\"")]
    public static ReadOnlySpan<byte> VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME => "VK_NV_viewport_array2"u8;

    [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION")]
    public const int VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME")]
    public static ReadOnlySpan<byte> VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME => "VK_NV_viewport_array2"u8;

    [NativeTypeName("#define VK_NVX_multiview_per_view_attributes 1")]
    public const int VK_NVX_multiview_per_view_attributes = 1;

    [NativeTypeName("#define VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION 1")]
    public const int VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME \"VK_NVX_multiview_per_view_attributes\"")]
    public static ReadOnlySpan<byte> VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME => "VK_NVX_multiview_per_view_attributes"u8;

    [NativeTypeName("#define VK_NV_viewport_swizzle 1")]
    public const int VK_NV_viewport_swizzle = 1;

    [NativeTypeName("#define VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION 1")]
    public const int VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME \"VK_NV_viewport_swizzle\"")]
    public static ReadOnlySpan<byte> VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME => "VK_NV_viewport_swizzle"u8;

    [NativeTypeName("#define VK_EXT_discard_rectangles 1")]
    public const int VK_EXT_discard_rectangles = 1;

    [NativeTypeName("#define VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION 2")]
    public const int VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME \"VK_EXT_discard_rectangles\"")]
    public static ReadOnlySpan<byte> VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME => "VK_EXT_discard_rectangles"u8;

    [NativeTypeName("#define VK_EXT_conservative_rasterization 1")]
    public const int VK_EXT_conservative_rasterization = 1;

    [NativeTypeName("#define VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION 1")]
    public const int VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME \"VK_EXT_conservative_rasterization\"")]
    public static ReadOnlySpan<byte> VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME => "VK_EXT_conservative_rasterization"u8;

    [NativeTypeName("#define VK_EXT_depth_clip_enable 1")]
    public const int VK_EXT_depth_clip_enable = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION 1")]
    public const int VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME \"VK_EXT_depth_clip_enable\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME => "VK_EXT_depth_clip_enable"u8;

    [NativeTypeName("#define VK_EXT_swapchain_colorspace 1")]
    public const int VK_EXT_swapchain_colorspace = 1;

    [NativeTypeName("#define VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION 5")]
    public const int VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION = 5;

    [NativeTypeName("#define VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME \"VK_EXT_swapchain_colorspace\"")]
    public static ReadOnlySpan<byte> VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME => "VK_EXT_swapchain_colorspace"u8;

    [NativeTypeName("#define VK_EXT_hdr_metadata 1")]
    public const int VK_EXT_hdr_metadata = 1;

    [NativeTypeName("#define VK_EXT_HDR_METADATA_SPEC_VERSION 3")]
    public const int VK_EXT_HDR_METADATA_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_EXT_HDR_METADATA_EXTENSION_NAME \"VK_EXT_hdr_metadata\"")]
    public static ReadOnlySpan<byte> VK_EXT_HDR_METADATA_EXTENSION_NAME => "VK_EXT_hdr_metadata"u8;

    [NativeTypeName("#define VK_IMG_relaxed_line_rasterization 1")]
    public const int VK_IMG_relaxed_line_rasterization = 1;

    [NativeTypeName("#define VK_IMG_RELAXED_LINE_RASTERIZATION_SPEC_VERSION 1")]
    public const int VK_IMG_RELAXED_LINE_RASTERIZATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_IMG_RELAXED_LINE_RASTERIZATION_EXTENSION_NAME \"VK_IMG_relaxed_line_rasterization\"")]
    public static ReadOnlySpan<byte> VK_IMG_RELAXED_LINE_RASTERIZATION_EXTENSION_NAME => "VK_IMG_relaxed_line_rasterization"u8;

    [NativeTypeName("#define VK_EXT_external_memory_dma_buf 1")]
    public const int VK_EXT_external_memory_dma_buf = 1;

    [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION 1")]
    public const int VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME \"VK_EXT_external_memory_dma_buf\"")]
    public static ReadOnlySpan<byte> VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME => "VK_EXT_external_memory_dma_buf"u8;

    [NativeTypeName("#define VK_EXT_queue_family_foreign 1")]
    public const int VK_EXT_queue_family_foreign = 1;

    [NativeTypeName("#define VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION 1")]
    public const int VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME \"VK_EXT_queue_family_foreign\"")]
    public static ReadOnlySpan<byte> VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME => "VK_EXT_queue_family_foreign"u8;

    [NativeTypeName("#define VK_QUEUE_FAMILY_FOREIGN_EXT (~2U)")]
    public const uint VK_QUEUE_FAMILY_FOREIGN_EXT = (~2U);

    [NativeTypeName("#define VK_EXT_debug_utils 1")]
    public const int VK_EXT_debug_utils = 1;

    [NativeTypeName("#define VK_EXT_DEBUG_UTILS_SPEC_VERSION 2")]
    public const int VK_EXT_DEBUG_UTILS_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_DEBUG_UTILS_EXTENSION_NAME \"VK_EXT_debug_utils\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEBUG_UTILS_EXTENSION_NAME => "VK_EXT_debug_utils"u8;

    [NativeTypeName("#define VK_EXT_sampler_filter_minmax 1")]
    public const int VK_EXT_sampler_filter_minmax = 1;

    [NativeTypeName("#define VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION 2")]
    public const int VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME \"VK_EXT_sampler_filter_minmax\"")]
    public static ReadOnlySpan<byte> VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME => "VK_EXT_sampler_filter_minmax"u8;

    [NativeTypeName("#define VK_AMD_gpu_shader_int16 1")]
    public const int VK_AMD_gpu_shader_int16 = 1;

    [NativeTypeName("#define VK_AMD_GPU_SHADER_INT16_SPEC_VERSION 2")]
    public const int VK_AMD_GPU_SHADER_INT16_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME \"VK_AMD_gpu_shader_int16\"")]
    public static ReadOnlySpan<byte> VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME => "VK_AMD_gpu_shader_int16"u8;

    [NativeTypeName("#define VK_AMD_mixed_attachment_samples 1")]
    public const int VK_AMD_mixed_attachment_samples = 1;

    [NativeTypeName("#define VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION 1")]
    public const int VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME \"VK_AMD_mixed_attachment_samples\"")]
    public static ReadOnlySpan<byte> VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME => "VK_AMD_mixed_attachment_samples"u8;

    [NativeTypeName("#define VK_AMD_shader_fragment_mask 1")]
    public const int VK_AMD_shader_fragment_mask = 1;

    [NativeTypeName("#define VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION 1")]
    public const int VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME \"VK_AMD_shader_fragment_mask\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME => "VK_AMD_shader_fragment_mask"u8;

    [NativeTypeName("#define VK_EXT_inline_uniform_block 1")]
    public const int VK_EXT_inline_uniform_block = 1;

    [NativeTypeName("#define VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION 1")]
    public const int VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME \"VK_EXT_inline_uniform_block\"")]
    public static ReadOnlySpan<byte> VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME => "VK_EXT_inline_uniform_block"u8;

    [NativeTypeName("#define VK_EXT_shader_stencil_export 1")]
    public const int VK_EXT_shader_stencil_export = 1;

    [NativeTypeName("#define VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME \"VK_EXT_shader_stencil_export\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME => "VK_EXT_shader_stencil_export"u8;

    [NativeTypeName("#define VK_EXT_sample_locations 1")]
    public const int VK_EXT_sample_locations = 1;

    [NativeTypeName("#define VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION 1")]
    public const int VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME \"VK_EXT_sample_locations\"")]
    public static ReadOnlySpan<byte> VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME => "VK_EXT_sample_locations"u8;

    [NativeTypeName("#define VK_EXT_blend_operation_advanced 1")]
    public const int VK_EXT_blend_operation_advanced = 1;

    [NativeTypeName("#define VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION 2")]
    public const int VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME \"VK_EXT_blend_operation_advanced\"")]
    public static ReadOnlySpan<byte> VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME => "VK_EXT_blend_operation_advanced"u8;

    [NativeTypeName("#define VK_NV_fragment_coverage_to_color 1")]
    public const int VK_NV_fragment_coverage_to_color = 1;

    [NativeTypeName("#define VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION 1")]
    public const int VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME \"VK_NV_fragment_coverage_to_color\"")]
    public static ReadOnlySpan<byte> VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME => "VK_NV_fragment_coverage_to_color"u8;

    [NativeTypeName("#define VK_NV_framebuffer_mixed_samples 1")]
    public const int VK_NV_framebuffer_mixed_samples = 1;

    [NativeTypeName("#define VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION 1")]
    public const int VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME \"VK_NV_framebuffer_mixed_samples\"")]
    public static ReadOnlySpan<byte> VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME => "VK_NV_framebuffer_mixed_samples"u8;

    [NativeTypeName("#define VK_NV_fill_rectangle 1")]
    public const int VK_NV_fill_rectangle = 1;

    [NativeTypeName("#define VK_NV_FILL_RECTANGLE_SPEC_VERSION 1")]
    public const int VK_NV_FILL_RECTANGLE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_FILL_RECTANGLE_EXTENSION_NAME \"VK_NV_fill_rectangle\"")]
    public static ReadOnlySpan<byte> VK_NV_FILL_RECTANGLE_EXTENSION_NAME => "VK_NV_fill_rectangle"u8;

    [NativeTypeName("#define VK_NV_shader_sm_builtins 1")]
    public const int VK_NV_shader_sm_builtins = 1;

    [NativeTypeName("#define VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION 1")]
    public const int VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME \"VK_NV_shader_sm_builtins\"")]
    public static ReadOnlySpan<byte> VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME => "VK_NV_shader_sm_builtins"u8;

    [NativeTypeName("#define VK_EXT_post_depth_coverage 1")]
    public const int VK_EXT_post_depth_coverage = 1;

    [NativeTypeName("#define VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION 1")]
    public const int VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME \"VK_EXT_post_depth_coverage\"")]
    public static ReadOnlySpan<byte> VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME => "VK_EXT_post_depth_coverage"u8;

    [NativeTypeName("#define VK_EXT_image_drm_format_modifier 1")]
    public const int VK_EXT_image_drm_format_modifier = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION 2")]
    public const int VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME \"VK_EXT_image_drm_format_modifier\"")]
    public static ReadOnlySpan<byte> VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME => "VK_EXT_image_drm_format_modifier"u8;

    [NativeTypeName("#define VK_EXT_validation_cache 1")]
    public const int VK_EXT_validation_cache = 1;

    [NativeTypeName("#define VK_EXT_VALIDATION_CACHE_SPEC_VERSION 1")]
    public const int VK_EXT_VALIDATION_CACHE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_VALIDATION_CACHE_EXTENSION_NAME \"VK_EXT_validation_cache\"")]
    public static ReadOnlySpan<byte> VK_EXT_VALIDATION_CACHE_EXTENSION_NAME => "VK_EXT_validation_cache"u8;

    [NativeTypeName("#define VK_EXT_descriptor_indexing 1")]
    public const int VK_EXT_descriptor_indexing = 1;

    [NativeTypeName("#define VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION 2")]
    public const int VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME \"VK_EXT_descriptor_indexing\"")]
    public static ReadOnlySpan<byte> VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME => "VK_EXT_descriptor_indexing"u8;

    [NativeTypeName("#define VK_EXT_shader_viewport_index_layer 1")]
    public const int VK_EXT_shader_viewport_index_layer = 1;

    [NativeTypeName("#define VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME \"VK_EXT_shader_viewport_index_layer\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME => "VK_EXT_shader_viewport_index_layer"u8;

    [NativeTypeName("#define VK_NV_shading_rate_image 1")]
    public const int VK_NV_shading_rate_image = 1;

    [NativeTypeName("#define VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION 3")]
    public const int VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME \"VK_NV_shading_rate_image\"")]
    public static ReadOnlySpan<byte> VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME => "VK_NV_shading_rate_image"u8;

    [NativeTypeName("#define VK_NV_ray_tracing 1")]
    public const int VK_NV_ray_tracing = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_SPEC_VERSION 3")]
    public const int VK_NV_RAY_TRACING_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_NV_RAY_TRACING_EXTENSION_NAME \"VK_NV_ray_tracing\"")]
    public static ReadOnlySpan<byte> VK_NV_RAY_TRACING_EXTENSION_NAME => "VK_NV_ray_tracing"u8;

    [NativeTypeName("#define VK_SHADER_UNUSED_KHR (~0U)")]
    public const uint VK_SHADER_UNUSED_KHR = (~0U);

    [NativeTypeName("#define VK_SHADER_UNUSED_NV VK_SHADER_UNUSED_KHR")]
    public const uint VK_SHADER_UNUSED_NV = (~0U);

    [NativeTypeName("#define VK_NV_representative_fragment_test 1")]
    public const int VK_NV_representative_fragment_test = 1;

    [NativeTypeName("#define VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION 2")]
    public const int VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME \"VK_NV_representative_fragment_test\"")]
    public static ReadOnlySpan<byte> VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME => "VK_NV_representative_fragment_test"u8;

    [NativeTypeName("#define VK_EXT_filter_cubic 1")]
    public const int VK_EXT_filter_cubic = 1;

    [NativeTypeName("#define VK_EXT_FILTER_CUBIC_SPEC_VERSION 3")]
    public const int VK_EXT_FILTER_CUBIC_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_EXT_FILTER_CUBIC_EXTENSION_NAME \"VK_EXT_filter_cubic\"")]
    public static ReadOnlySpan<byte> VK_EXT_FILTER_CUBIC_EXTENSION_NAME => "VK_EXT_filter_cubic"u8;

    [NativeTypeName("#define VK_QCOM_render_pass_shader_resolve 1")]
    public const int VK_QCOM_render_pass_shader_resolve = 1;

    [NativeTypeName("#define VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION 4")]
    public const int VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION = 4;

    [NativeTypeName("#define VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME \"VK_QCOM_render_pass_shader_resolve\"")]
    public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME => "VK_QCOM_render_pass_shader_resolve"u8;

    [NativeTypeName("#define VK_EXT_global_priority 1")]
    public const int VK_EXT_global_priority = 1;

    [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION 2")]
    public const int VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME \"VK_EXT_global_priority\"")]
    public static ReadOnlySpan<byte> VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME => "VK_EXT_global_priority"u8;

    [NativeTypeName("#define VK_EXT_external_memory_host 1")]
    public const int VK_EXT_external_memory_host = 1;

    [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION 1")]
    public const int VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME \"VK_EXT_external_memory_host\"")]
    public static ReadOnlySpan<byte> VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME => "VK_EXT_external_memory_host"u8;

    [NativeTypeName("#define VK_AMD_buffer_marker 1")]
    public const int VK_AMD_buffer_marker = 1;

    [NativeTypeName("#define VK_AMD_BUFFER_MARKER_SPEC_VERSION 1")]
    public const int VK_AMD_BUFFER_MARKER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_BUFFER_MARKER_EXTENSION_NAME \"VK_AMD_buffer_marker\"")]
    public static ReadOnlySpan<byte> VK_AMD_BUFFER_MARKER_EXTENSION_NAME => "VK_AMD_buffer_marker"u8;

    [NativeTypeName("#define VK_AMD_pipeline_compiler_control 1")]
    public const int VK_AMD_pipeline_compiler_control = 1;

    [NativeTypeName("#define VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION 1")]
    public const int VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME \"VK_AMD_pipeline_compiler_control\"")]
    public static ReadOnlySpan<byte> VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME => "VK_AMD_pipeline_compiler_control"u8;

    [NativeTypeName("#define VK_EXT_calibrated_timestamps 1")]
    public const int VK_EXT_calibrated_timestamps = 1;

    [NativeTypeName("#define VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION 2")]
    public const int VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME \"VK_EXT_calibrated_timestamps\"")]
    public static ReadOnlySpan<byte> VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME => "VK_EXT_calibrated_timestamps"u8;

    [NativeTypeName("#define VK_AMD_shader_core_properties 1")]
    public const int VK_AMD_shader_core_properties = 1;

    [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION 2")]
    public const int VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME \"VK_AMD_shader_core_properties\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME => "VK_AMD_shader_core_properties"u8;

    [NativeTypeName("#define VK_AMD_memory_overallocation_behavior 1")]
    public const int VK_AMD_memory_overallocation_behavior = 1;

    [NativeTypeName("#define VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION 1")]
    public const int VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME \"VK_AMD_memory_overallocation_behavior\"")]
    public static ReadOnlySpan<byte> VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME => "VK_AMD_memory_overallocation_behavior"u8;

    [NativeTypeName("#define VK_EXT_vertex_attribute_divisor 1")]
    public const int VK_EXT_vertex_attribute_divisor = 1;

    [NativeTypeName("#define VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION 3")]
    public const int VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME \"VK_EXT_vertex_attribute_divisor\"")]
    public static ReadOnlySpan<byte> VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME => "VK_EXT_vertex_attribute_divisor"u8;

    [NativeTypeName("#define VK_EXT_pipeline_creation_feedback 1")]
    public const int VK_EXT_pipeline_creation_feedback = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION 1")]
    public const int VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME \"VK_EXT_pipeline_creation_feedback\"")]
    public static ReadOnlySpan<byte> VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME => "VK_EXT_pipeline_creation_feedback"u8;

    [NativeTypeName("#define VK_NV_shader_subgroup_partitioned 1")]
    public const int VK_NV_shader_subgroup_partitioned = 1;

    [NativeTypeName("#define VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION 1")]
    public const int VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME \"VK_NV_shader_subgroup_partitioned\"")]
    public static ReadOnlySpan<byte> VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME => "VK_NV_shader_subgroup_partitioned"u8;

    [NativeTypeName("#define VK_NV_compute_shader_derivatives 1")]
    public const int VK_NV_compute_shader_derivatives = 1;

    [NativeTypeName("#define VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION 1")]
    public const int VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME \"VK_NV_compute_shader_derivatives\"")]
    public static ReadOnlySpan<byte> VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME => "VK_NV_compute_shader_derivatives"u8;

    [NativeTypeName("#define VK_NV_mesh_shader 1")]
    public const int VK_NV_mesh_shader = 1;

    [NativeTypeName("#define VK_NV_MESH_SHADER_SPEC_VERSION 1")]
    public const int VK_NV_MESH_SHADER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_MESH_SHADER_EXTENSION_NAME \"VK_NV_mesh_shader\"")]
    public static ReadOnlySpan<byte> VK_NV_MESH_SHADER_EXTENSION_NAME => "VK_NV_mesh_shader"u8;

    [NativeTypeName("#define VK_NV_fragment_shader_barycentric 1")]
    public const int VK_NV_fragment_shader_barycentric = 1;

    [NativeTypeName("#define VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION 1")]
    public const int VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME \"VK_NV_fragment_shader_barycentric\"")]
    public static ReadOnlySpan<byte> VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME => "VK_NV_fragment_shader_barycentric"u8;

    [NativeTypeName("#define VK_NV_shader_image_footprint 1")]
    public const int VK_NV_shader_image_footprint = 1;

    [NativeTypeName("#define VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION 2")]
    public const int VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME \"VK_NV_shader_image_footprint\"")]
    public static ReadOnlySpan<byte> VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME => "VK_NV_shader_image_footprint"u8;

    [NativeTypeName("#define VK_NV_scissor_exclusive 1")]
    public const int VK_NV_scissor_exclusive = 1;

    [NativeTypeName("#define VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION 2")]
    public const int VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME \"VK_NV_scissor_exclusive\"")]
    public static ReadOnlySpan<byte> VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME => "VK_NV_scissor_exclusive"u8;

    [NativeTypeName("#define VK_NV_device_diagnostic_checkpoints 1")]
    public const int VK_NV_device_diagnostic_checkpoints = 1;

    [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION 2")]
    public const int VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME \"VK_NV_device_diagnostic_checkpoints\"")]
    public static ReadOnlySpan<byte> VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME => "VK_NV_device_diagnostic_checkpoints"u8;

    [NativeTypeName("#define VK_INTEL_shader_integer_functions2 1")]
    public const int VK_INTEL_shader_integer_functions2 = 1;

    [NativeTypeName("#define VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION 1")]
    public const int VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME \"VK_INTEL_shader_integer_functions2\"")]
    public static ReadOnlySpan<byte> VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME => "VK_INTEL_shader_integer_functions2"u8;

    [NativeTypeName("#define VK_INTEL_performance_query 1")]
    public const int VK_INTEL_performance_query = 1;

    [NativeTypeName("#define VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION 2")]
    public const int VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME \"VK_INTEL_performance_query\"")]
    public static ReadOnlySpan<byte> VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME => "VK_INTEL_performance_query"u8;

    [NativeTypeName("#define VK_EXT_pci_bus_info 1")]
    public const int VK_EXT_pci_bus_info = 1;

    [NativeTypeName("#define VK_EXT_PCI_BUS_INFO_SPEC_VERSION 2")]
    public const int VK_EXT_PCI_BUS_INFO_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_PCI_BUS_INFO_EXTENSION_NAME \"VK_EXT_pci_bus_info\"")]
    public static ReadOnlySpan<byte> VK_EXT_PCI_BUS_INFO_EXTENSION_NAME => "VK_EXT_pci_bus_info"u8;

    [NativeTypeName("#define VK_AMD_display_native_hdr 1")]
    public const int VK_AMD_display_native_hdr = 1;

    [NativeTypeName("#define VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION 1")]
    public const int VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME \"VK_AMD_display_native_hdr\"")]
    public static ReadOnlySpan<byte> VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME => "VK_AMD_display_native_hdr"u8;

    [NativeTypeName("#define VK_EXT_fragment_density_map 1")]
    public const int VK_EXT_fragment_density_map = 1;

    [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION 2")]
    public const int VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME \"VK_EXT_fragment_density_map\"")]
    public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME => "VK_EXT_fragment_density_map"u8;

    [NativeTypeName("#define VK_EXT_scalar_block_layout 1")]
    public const int VK_EXT_scalar_block_layout = 1;

    [NativeTypeName("#define VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION 1")]
    public const int VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME \"VK_EXT_scalar_block_layout\"")]
    public static ReadOnlySpan<byte> VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME => "VK_EXT_scalar_block_layout"u8;

    [NativeTypeName("#define VK_GOOGLE_hlsl_functionality1 1")]
    public const int VK_GOOGLE_hlsl_functionality1 = 1;

    [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION 1")]
    public const int VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME \"VK_GOOGLE_hlsl_functionality1\"")]
    public static ReadOnlySpan<byte> VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME => "VK_GOOGLE_hlsl_functionality1"u8;

    [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION")]
    public const int VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME")]
    public static ReadOnlySpan<byte> VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME => "VK_GOOGLE_hlsl_functionality1"u8;

    [NativeTypeName("#define VK_GOOGLE_decorate_string 1")]
    public const int VK_GOOGLE_decorate_string = 1;

    [NativeTypeName("#define VK_GOOGLE_DECORATE_STRING_SPEC_VERSION 1")]
    public const int VK_GOOGLE_DECORATE_STRING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME \"VK_GOOGLE_decorate_string\"")]
    public static ReadOnlySpan<byte> VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME => "VK_GOOGLE_decorate_string"u8;

    [NativeTypeName("#define VK_EXT_subgroup_size_control 1")]
    public const int VK_EXT_subgroup_size_control = 1;

    [NativeTypeName("#define VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION 2")]
    public const int VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME \"VK_EXT_subgroup_size_control\"")]
    public static ReadOnlySpan<byte> VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME => "VK_EXT_subgroup_size_control"u8;

    [NativeTypeName("#define VK_AMD_shader_core_properties2 1")]
    public const int VK_AMD_shader_core_properties2 = 1;

    [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION 1")]
    public const int VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME \"VK_AMD_shader_core_properties2\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME => "VK_AMD_shader_core_properties2"u8;

    [NativeTypeName("#define VK_AMD_device_coherent_memory 1")]
    public const int VK_AMD_device_coherent_memory = 1;

    [NativeTypeName("#define VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION 1")]
    public const int VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME \"VK_AMD_device_coherent_memory\"")]
    public static ReadOnlySpan<byte> VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME => "VK_AMD_device_coherent_memory"u8;

    [NativeTypeName("#define VK_EXT_shader_image_atomic_int64 1")]
    public const int VK_EXT_shader_image_atomic_int64 = 1;

    [NativeTypeName("#define VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME \"VK_EXT_shader_image_atomic_int64\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME => "VK_EXT_shader_image_atomic_int64"u8;

    [NativeTypeName("#define VK_EXT_memory_budget 1")]
    public const int VK_EXT_memory_budget = 1;

    [NativeTypeName("#define VK_EXT_MEMORY_BUDGET_SPEC_VERSION 1")]
    public const int VK_EXT_MEMORY_BUDGET_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_MEMORY_BUDGET_EXTENSION_NAME \"VK_EXT_memory_budget\"")]
    public static ReadOnlySpan<byte> VK_EXT_MEMORY_BUDGET_EXTENSION_NAME => "VK_EXT_memory_budget"u8;

    [NativeTypeName("#define VK_EXT_memory_priority 1")]
    public const int VK_EXT_memory_priority = 1;

    [NativeTypeName("#define VK_EXT_MEMORY_PRIORITY_SPEC_VERSION 1")]
    public const int VK_EXT_MEMORY_PRIORITY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME \"VK_EXT_memory_priority\"")]
    public static ReadOnlySpan<byte> VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME => "VK_EXT_memory_priority"u8;

    [NativeTypeName("#define VK_NV_dedicated_allocation_image_aliasing 1")]
    public const int VK_NV_dedicated_allocation_image_aliasing = 1;

    [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION 1")]
    public const int VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME \"VK_NV_dedicated_allocation_image_aliasing\"")]
    public static ReadOnlySpan<byte> VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME => "VK_NV_dedicated_allocation_image_aliasing"u8;

    [NativeTypeName("#define VK_EXT_buffer_device_address 1")]
    public const int VK_EXT_buffer_device_address = 1;

    [NativeTypeName("#define VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION 2")]
    public const int VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME \"VK_EXT_buffer_device_address\"")]
    public static ReadOnlySpan<byte> VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME => "VK_EXT_buffer_device_address"u8;

    [NativeTypeName("#define VK_EXT_tooling_info 1")]
    public const int VK_EXT_tooling_info = 1;

    [NativeTypeName("#define VK_EXT_TOOLING_INFO_SPEC_VERSION 1")]
    public const int VK_EXT_TOOLING_INFO_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_TOOLING_INFO_EXTENSION_NAME \"VK_EXT_tooling_info\"")]
    public static ReadOnlySpan<byte> VK_EXT_TOOLING_INFO_EXTENSION_NAME => "VK_EXT_tooling_info"u8;

    [NativeTypeName("#define VK_EXT_separate_stencil_usage 1")]
    public const int VK_EXT_separate_stencil_usage = 1;

    [NativeTypeName("#define VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION 1")]
    public const int VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME \"VK_EXT_separate_stencil_usage\"")]
    public static ReadOnlySpan<byte> VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME => "VK_EXT_separate_stencil_usage"u8;

    [NativeTypeName("#define VK_EXT_validation_features 1")]
    public const int VK_EXT_validation_features = 1;

    [NativeTypeName("#define VK_EXT_VALIDATION_FEATURES_SPEC_VERSION 6")]
    public const int VK_EXT_VALIDATION_FEATURES_SPEC_VERSION = 6;

    [NativeTypeName("#define VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME \"VK_EXT_validation_features\"")]
    public static ReadOnlySpan<byte> VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME => "VK_EXT_validation_features"u8;

    [NativeTypeName("#define VK_NV_cooperative_matrix 1")]
    public const int VK_NV_cooperative_matrix = 1;

    [NativeTypeName("#define VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION 1")]
    public const int VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME \"VK_NV_cooperative_matrix\"")]
    public static ReadOnlySpan<byte> VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME => "VK_NV_cooperative_matrix"u8;

    [NativeTypeName("#define VK_NV_coverage_reduction_mode 1")]
    public const int VK_NV_coverage_reduction_mode = 1;

    [NativeTypeName("#define VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION 1")]
    public const int VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME \"VK_NV_coverage_reduction_mode\"")]
    public static ReadOnlySpan<byte> VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME => "VK_NV_coverage_reduction_mode"u8;

    [NativeTypeName("#define VK_EXT_fragment_shader_interlock 1")]
    public const int VK_EXT_fragment_shader_interlock = 1;

    [NativeTypeName("#define VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION 1")]
    public const int VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME \"VK_EXT_fragment_shader_interlock\"")]
    public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME => "VK_EXT_fragment_shader_interlock"u8;

    [NativeTypeName("#define VK_EXT_ycbcr_image_arrays 1")]
    public const int VK_EXT_ycbcr_image_arrays = 1;

    [NativeTypeName("#define VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION 1")]
    public const int VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME \"VK_EXT_ycbcr_image_arrays\"")]
    public static ReadOnlySpan<byte> VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME => "VK_EXT_ycbcr_image_arrays"u8;

    [NativeTypeName("#define VK_EXT_provoking_vertex 1")]
    public const int VK_EXT_provoking_vertex = 1;

    [NativeTypeName("#define VK_EXT_PROVOKING_VERTEX_SPEC_VERSION 1")]
    public const int VK_EXT_PROVOKING_VERTEX_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME \"VK_EXT_provoking_vertex\"")]
    public static ReadOnlySpan<byte> VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME => "VK_EXT_provoking_vertex"u8;

    [NativeTypeName("#define VK_EXT_headless_surface 1")]
    public const int VK_EXT_headless_surface = 1;

    [NativeTypeName("#define VK_EXT_HEADLESS_SURFACE_SPEC_VERSION 1")]
    public const int VK_EXT_HEADLESS_SURFACE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME \"VK_EXT_headless_surface\"")]
    public static ReadOnlySpan<byte> VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME => "VK_EXT_headless_surface"u8;

    [NativeTypeName("#define VK_EXT_line_rasterization 1")]
    public const int VK_EXT_line_rasterization = 1;

    [NativeTypeName("#define VK_EXT_LINE_RASTERIZATION_SPEC_VERSION 1")]
    public const int VK_EXT_LINE_RASTERIZATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME \"VK_EXT_line_rasterization\"")]
    public static ReadOnlySpan<byte> VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME => "VK_EXT_line_rasterization"u8;

    [NativeTypeName("#define VK_EXT_shader_atomic_float 1")]
    public const int VK_EXT_shader_atomic_float = 1;

    [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME \"VK_EXT_shader_atomic_float\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME => "VK_EXT_shader_atomic_float"u8;

    [NativeTypeName("#define VK_EXT_host_query_reset 1")]
    public const int VK_EXT_host_query_reset = 1;

    [NativeTypeName("#define VK_EXT_HOST_QUERY_RESET_SPEC_VERSION 1")]
    public const int VK_EXT_HOST_QUERY_RESET_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME \"VK_EXT_host_query_reset\"")]
    public static ReadOnlySpan<byte> VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME => "VK_EXT_host_query_reset"u8;

    [NativeTypeName("#define VK_EXT_index_type_uint8 1")]
    public const int VK_EXT_index_type_uint8 = 1;

    [NativeTypeName("#define VK_EXT_INDEX_TYPE_UINT8_SPEC_VERSION 1")]
    public const int VK_EXT_INDEX_TYPE_UINT8_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME \"VK_EXT_index_type_uint8\"")]
    public static ReadOnlySpan<byte> VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME => "VK_EXT_index_type_uint8"u8;

    [NativeTypeName("#define VK_EXT_extended_dynamic_state 1")]
    public const int VK_EXT_extended_dynamic_state = 1;

    [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION 1")]
    public const int VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME \"VK_EXT_extended_dynamic_state\"")]
    public static ReadOnlySpan<byte> VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME => "VK_EXT_extended_dynamic_state"u8;

    [NativeTypeName("#define VK_EXT_host_image_copy 1")]
    public const int VK_EXT_host_image_copy = 1;

    [NativeTypeName("#define VK_EXT_HOST_IMAGE_COPY_SPEC_VERSION 1")]
    public const int VK_EXT_HOST_IMAGE_COPY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_HOST_IMAGE_COPY_EXTENSION_NAME \"VK_EXT_host_image_copy\"")]
    public static ReadOnlySpan<byte> VK_EXT_HOST_IMAGE_COPY_EXTENSION_NAME => "VK_EXT_host_image_copy"u8;

    [NativeTypeName("#define VK_EXT_map_memory_placed 1")]
    public const int VK_EXT_map_memory_placed = 1;

    [NativeTypeName("#define VK_EXT_MAP_MEMORY_PLACED_SPEC_VERSION 1")]
    public const int VK_EXT_MAP_MEMORY_PLACED_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_MAP_MEMORY_PLACED_EXTENSION_NAME \"VK_EXT_map_memory_placed\"")]
    public static ReadOnlySpan<byte> VK_EXT_MAP_MEMORY_PLACED_EXTENSION_NAME => "VK_EXT_map_memory_placed"u8;

    [NativeTypeName("#define VK_EXT_shader_atomic_float2 1")]
    public const int VK_EXT_shader_atomic_float2 = 1;

    [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_2_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_ATOMIC_FLOAT_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_2_EXTENSION_NAME \"VK_EXT_shader_atomic_float2\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_ATOMIC_FLOAT_2_EXTENSION_NAME => "VK_EXT_shader_atomic_float2"u8;

    [NativeTypeName("#define VK_EXT_surface_maintenance1 1")]
    public const int VK_EXT_surface_maintenance1 = 1;

    [NativeTypeName("#define VK_EXT_SURFACE_MAINTENANCE_1_SPEC_VERSION 1")]
    public const int VK_EXT_SURFACE_MAINTENANCE_1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SURFACE_MAINTENANCE_1_EXTENSION_NAME \"VK_EXT_surface_maintenance1\"")]
    public static ReadOnlySpan<byte> VK_EXT_SURFACE_MAINTENANCE_1_EXTENSION_NAME => "VK_EXT_surface_maintenance1"u8;

    [NativeTypeName("#define VK_EXT_swapchain_maintenance1 1")]
    public const int VK_EXT_swapchain_maintenance1 = 1;

    [NativeTypeName("#define VK_EXT_SWAPCHAIN_MAINTENANCE_1_SPEC_VERSION 1")]
    public const int VK_EXT_SWAPCHAIN_MAINTENANCE_1_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME \"VK_EXT_swapchain_maintenance1\"")]
    public static ReadOnlySpan<byte> VK_EXT_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME => "VK_EXT_swapchain_maintenance1"u8;

    [NativeTypeName("#define VK_EXT_shader_demote_to_helper_invocation 1")]
    public const int VK_EXT_shader_demote_to_helper_invocation = 1;

    [NativeTypeName("#define VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_EXTENSION_NAME \"VK_EXT_shader_demote_to_helper_invocation\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_EXTENSION_NAME => "VK_EXT_shader_demote_to_helper_invocation"u8;

    [NativeTypeName("#define VK_NV_device_generated_commands 1")]
    public const int VK_NV_device_generated_commands = 1;

    [NativeTypeName("#define VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION 3")]
    public const int VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME \"VK_NV_device_generated_commands\"")]
    public static ReadOnlySpan<byte> VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME => "VK_NV_device_generated_commands"u8;

    [NativeTypeName("#define VK_NV_inherited_viewport_scissor 1")]
    public const int VK_NV_inherited_viewport_scissor = 1;

    [NativeTypeName("#define VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION 1")]
    public const int VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME \"VK_NV_inherited_viewport_scissor\"")]
    public static ReadOnlySpan<byte> VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME => "VK_NV_inherited_viewport_scissor"u8;

    [NativeTypeName("#define VK_EXT_texel_buffer_alignment 1")]
    public const int VK_EXT_texel_buffer_alignment = 1;

    [NativeTypeName("#define VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION 1")]
    public const int VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME \"VK_EXT_texel_buffer_alignment\"")]
    public static ReadOnlySpan<byte> VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME => "VK_EXT_texel_buffer_alignment"u8;

    [NativeTypeName("#define VK_QCOM_render_pass_transform 1")]
    public const int VK_QCOM_render_pass_transform = 1;

    [NativeTypeName("#define VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION 5")]
    public const int VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION = 5;

    [NativeTypeName("#define VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME \"VK_QCOM_render_pass_transform\"")]
    public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME => "VK_QCOM_render_pass_transform"u8;

    [NativeTypeName("#define VK_EXT_depth_bias_control 1")]
    public const int VK_EXT_depth_bias_control = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_BIAS_CONTROL_SPEC_VERSION 1")]
    public const int VK_EXT_DEPTH_BIAS_CONTROL_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_BIAS_CONTROL_EXTENSION_NAME \"VK_EXT_depth_bias_control\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEPTH_BIAS_CONTROL_EXTENSION_NAME => "VK_EXT_depth_bias_control"u8;

    [NativeTypeName("#define VK_EXT_device_memory_report 1")]
    public const int VK_EXT_device_memory_report = 1;

    [NativeTypeName("#define VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION 2")]
    public const int VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME \"VK_EXT_device_memory_report\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME => "VK_EXT_device_memory_report"u8;

    [NativeTypeName("#define VK_EXT_acquire_drm_display 1")]
    public const int VK_EXT_acquire_drm_display = 1;

    [NativeTypeName("#define VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION 1")]
    public const int VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME \"VK_EXT_acquire_drm_display\"")]
    public static ReadOnlySpan<byte> VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME => "VK_EXT_acquire_drm_display"u8;

    [NativeTypeName("#define VK_EXT_robustness2 1")]
    public const int VK_EXT_robustness2 = 1;

    [NativeTypeName("#define VK_EXT_ROBUSTNESS_2_SPEC_VERSION 1")]
    public const int VK_EXT_ROBUSTNESS_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_ROBUSTNESS_2_EXTENSION_NAME \"VK_EXT_robustness2\"")]
    public static ReadOnlySpan<byte> VK_EXT_ROBUSTNESS_2_EXTENSION_NAME => "VK_EXT_robustness2"u8;

    [NativeTypeName("#define VK_EXT_custom_border_color 1")]
    public const int VK_EXT_custom_border_color = 1;

    [NativeTypeName("#define VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION 12")]
    public const int VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION = 12;

    [NativeTypeName("#define VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME \"VK_EXT_custom_border_color\"")]
    public static ReadOnlySpan<byte> VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME => "VK_EXT_custom_border_color"u8;

    [NativeTypeName("#define VK_GOOGLE_user_type 1")]
    public const int VK_GOOGLE_user_type = 1;

    [NativeTypeName("#define VK_GOOGLE_USER_TYPE_SPEC_VERSION 1")]
    public const int VK_GOOGLE_USER_TYPE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_GOOGLE_USER_TYPE_EXTENSION_NAME \"VK_GOOGLE_user_type\"")]
    public static ReadOnlySpan<byte> VK_GOOGLE_USER_TYPE_EXTENSION_NAME => "VK_GOOGLE_user_type"u8;

    [NativeTypeName("#define VK_NV_present_barrier 1")]
    public const int VK_NV_present_barrier = 1;

    [NativeTypeName("#define VK_NV_PRESENT_BARRIER_SPEC_VERSION 1")]
    public const int VK_NV_PRESENT_BARRIER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_PRESENT_BARRIER_EXTENSION_NAME \"VK_NV_present_barrier\"")]
    public static ReadOnlySpan<byte> VK_NV_PRESENT_BARRIER_EXTENSION_NAME => "VK_NV_present_barrier"u8;

    [NativeTypeName("#define VK_EXT_private_data 1")]
    public const int VK_EXT_private_data = 1;

    [NativeTypeName("#define VK_EXT_PRIVATE_DATA_SPEC_VERSION 1")]
    public const int VK_EXT_PRIVATE_DATA_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PRIVATE_DATA_EXTENSION_NAME \"VK_EXT_private_data\"")]
    public static ReadOnlySpan<byte> VK_EXT_PRIVATE_DATA_EXTENSION_NAME => "VK_EXT_private_data"u8;

    [NativeTypeName("#define VK_EXT_pipeline_creation_cache_control 1")]
    public const int VK_EXT_pipeline_creation_cache_control = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION 3")]
    public const int VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME \"VK_EXT_pipeline_creation_cache_control\"")]
    public static ReadOnlySpan<byte> VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME => "VK_EXT_pipeline_creation_cache_control"u8;

    [NativeTypeName("#define VK_NV_device_diagnostics_config 1")]
    public const int VK_NV_device_diagnostics_config = 1;

    [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION 2")]
    public const int VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME \"VK_NV_device_diagnostics_config\"")]
    public static ReadOnlySpan<byte> VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME => "VK_NV_device_diagnostics_config"u8;

    [NativeTypeName("#define VK_QCOM_render_pass_store_ops 1")]
    public const int VK_QCOM_render_pass_store_ops = 1;

    [NativeTypeName("#define VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION 2")]
    public const int VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME \"VK_QCOM_render_pass_store_ops\"")]
    public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME => "VK_QCOM_render_pass_store_ops"u8;

    [NativeTypeName("#define VK_QCOM_tile_shading 1")]
    public const int VK_QCOM_tile_shading = 1;

    [NativeTypeName("#define VK_QCOM_TILE_SHADING_SPEC_VERSION 2")]
    public const int VK_QCOM_TILE_SHADING_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_QCOM_TILE_SHADING_EXTENSION_NAME \"VK_QCOM_tile_shading\"")]
    public static ReadOnlySpan<byte> VK_QCOM_TILE_SHADING_EXTENSION_NAME => "VK_QCOM_tile_shading"u8;

    [NativeTypeName("#define VK_NV_low_latency 1")]
    public const int VK_NV_low_latency = 1;

    [NativeTypeName("#define VK_NV_LOW_LATENCY_SPEC_VERSION 1")]
    public const int VK_NV_LOW_LATENCY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_LOW_LATENCY_EXTENSION_NAME \"VK_NV_low_latency\"")]
    public static ReadOnlySpan<byte> VK_NV_LOW_LATENCY_EXTENSION_NAME => "VK_NV_low_latency"u8;

    [NativeTypeName("#define VK_EXT_descriptor_buffer 1")]
    public const int VK_EXT_descriptor_buffer = 1;

    [NativeTypeName("#define VK_EXT_DESCRIPTOR_BUFFER_SPEC_VERSION 1")]
    public const int VK_EXT_DESCRIPTOR_BUFFER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DESCRIPTOR_BUFFER_EXTENSION_NAME \"VK_EXT_descriptor_buffer\"")]
    public static ReadOnlySpan<byte> VK_EXT_DESCRIPTOR_BUFFER_EXTENSION_NAME => "VK_EXT_descriptor_buffer"u8;

    [NativeTypeName("#define VK_EXT_graphics_pipeline_library 1")]
    public const int VK_EXT_graphics_pipeline_library = 1;

    [NativeTypeName("#define VK_EXT_GRAPHICS_PIPELINE_LIBRARY_SPEC_VERSION 1")]
    public const int VK_EXT_GRAPHICS_PIPELINE_LIBRARY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_GRAPHICS_PIPELINE_LIBRARY_EXTENSION_NAME \"VK_EXT_graphics_pipeline_library\"")]
    public static ReadOnlySpan<byte> VK_EXT_GRAPHICS_PIPELINE_LIBRARY_EXTENSION_NAME => "VK_EXT_graphics_pipeline_library"u8;

    [NativeTypeName("#define VK_AMD_shader_early_and_late_fragment_tests 1")]
    public const int VK_AMD_shader_early_and_late_fragment_tests = 1;

    [NativeTypeName("#define VK_AMD_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_SPEC_VERSION 1")]
    public const int VK_AMD_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_EXTENSION_NAME \"VK_AMD_shader_early_and_late_fragment_tests\"")]
    public static ReadOnlySpan<byte> VK_AMD_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_EXTENSION_NAME => "VK_AMD_shader_early_and_late_fragment_tests"u8;

    [NativeTypeName("#define VK_NV_fragment_shading_rate_enums 1")]
    public const int VK_NV_fragment_shading_rate_enums = 1;

    [NativeTypeName("#define VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION 1")]
    public const int VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME \"VK_NV_fragment_shading_rate_enums\"")]
    public static ReadOnlySpan<byte> VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME => "VK_NV_fragment_shading_rate_enums"u8;

    [NativeTypeName("#define VK_NV_ray_tracing_motion_blur 1")]
    public const int VK_NV_ray_tracing_motion_blur = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION 1")]
    public const int VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME \"VK_NV_ray_tracing_motion_blur\"")]
    public static ReadOnlySpan<byte> VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME => "VK_NV_ray_tracing_motion_blur"u8;

    [NativeTypeName("#define VK_EXT_ycbcr_2plane_444_formats 1")]
    public const int VK_EXT_ycbcr_2plane_444_formats = 1;

    [NativeTypeName("#define VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION 1")]
    public const int VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME \"VK_EXT_ycbcr_2plane_444_formats\"")]
    public static ReadOnlySpan<byte> VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME => "VK_EXT_ycbcr_2plane_444_formats"u8;

    [NativeTypeName("#define VK_EXT_fragment_density_map2 1")]
    public const int VK_EXT_fragment_density_map2 = 1;

    [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION 1")]
    public const int VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME \"VK_EXT_fragment_density_map2\"")]
    public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME => "VK_EXT_fragment_density_map2"u8;

    [NativeTypeName("#define VK_QCOM_rotated_copy_commands 1")]
    public const int VK_QCOM_rotated_copy_commands = 1;

    [NativeTypeName("#define VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION 2")]
    public const int VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME \"VK_QCOM_rotated_copy_commands\"")]
    public static ReadOnlySpan<byte> VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME => "VK_QCOM_rotated_copy_commands"u8;

    [NativeTypeName("#define VK_EXT_image_robustness 1")]
    public const int VK_EXT_image_robustness = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION 1")]
    public const int VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME \"VK_EXT_image_robustness\"")]
    public static ReadOnlySpan<byte> VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME => "VK_EXT_image_robustness"u8;

    [NativeTypeName("#define VK_EXT_image_compression_control 1")]
    public const int VK_EXT_image_compression_control = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_COMPRESSION_CONTROL_SPEC_VERSION 1")]
    public const int VK_EXT_IMAGE_COMPRESSION_CONTROL_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_COMPRESSION_CONTROL_EXTENSION_NAME \"VK_EXT_image_compression_control\"")]
    public static ReadOnlySpan<byte> VK_EXT_IMAGE_COMPRESSION_CONTROL_EXTENSION_NAME => "VK_EXT_image_compression_control"u8;

    [NativeTypeName("#define VK_EXT_attachment_feedback_loop_layout 1")]
    public const int VK_EXT_attachment_feedback_loop_layout = 1;

    [NativeTypeName("#define VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_SPEC_VERSION 2")]
    public const int VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_EXTENSION_NAME \"VK_EXT_attachment_feedback_loop_layout\"")]
    public static ReadOnlySpan<byte> VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_EXTENSION_NAME => "VK_EXT_attachment_feedback_loop_layout"u8;

    [NativeTypeName("#define VK_EXT_4444_formats 1")]
    public const int VK_EXT_4444_formats = 1;

    [NativeTypeName("#define VK_EXT_4444_FORMATS_SPEC_VERSION 1")]
    public const int VK_EXT_4444_FORMATS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_4444_FORMATS_EXTENSION_NAME \"VK_EXT_4444_formats\"")]
    public static ReadOnlySpan<byte> VK_EXT_4444_FORMATS_EXTENSION_NAME => "VK_EXT_4444_formats"u8;

    [NativeTypeName("#define VK_EXT_device_fault 1")]
    public const int VK_EXT_device_fault = 1;

    [NativeTypeName("#define VK_EXT_DEVICE_FAULT_SPEC_VERSION 2")]
    public const int VK_EXT_DEVICE_FAULT_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_DEVICE_FAULT_EXTENSION_NAME \"VK_EXT_device_fault\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEVICE_FAULT_EXTENSION_NAME => "VK_EXT_device_fault"u8;

    [NativeTypeName("#define VK_ARM_rasterization_order_attachment_access 1")]
    public const int VK_ARM_rasterization_order_attachment_access = 1;

    [NativeTypeName("#define VK_ARM_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_SPEC_VERSION 1")]
    public const int VK_ARM_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ARM_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME \"VK_ARM_rasterization_order_attachment_access\"")]
    public static ReadOnlySpan<byte> VK_ARM_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME => "VK_ARM_rasterization_order_attachment_access"u8;

    [NativeTypeName("#define VK_EXT_rgba10x6_formats 1")]
    public const int VK_EXT_rgba10x6_formats = 1;

    [NativeTypeName("#define VK_EXT_RGBA10X6_FORMATS_SPEC_VERSION 1")]
    public const int VK_EXT_RGBA10X6_FORMATS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME \"VK_EXT_rgba10x6_formats\"")]
    public static ReadOnlySpan<byte> VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME => "VK_EXT_rgba10x6_formats"u8;

    [NativeTypeName("#define VK_VALVE_mutable_descriptor_type 1")]
    public const int VK_VALVE_mutable_descriptor_type = 1;

    [NativeTypeName("#define VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION 1")]
    public const int VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME \"VK_VALVE_mutable_descriptor_type\"")]
    public static ReadOnlySpan<byte> VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME => "VK_VALVE_mutable_descriptor_type"u8;

    [NativeTypeName("#define VK_EXT_vertex_input_dynamic_state 1")]
    public const int VK_EXT_vertex_input_dynamic_state = 1;

    [NativeTypeName("#define VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION 2")]
    public const int VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME \"VK_EXT_vertex_input_dynamic_state\"")]
    public static ReadOnlySpan<byte> VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME => "VK_EXT_vertex_input_dynamic_state"u8;

    [NativeTypeName("#define VK_EXT_physical_device_drm 1")]
    public const int VK_EXT_physical_device_drm = 1;

    [NativeTypeName("#define VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION 1")]
    public const int VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME \"VK_EXT_physical_device_drm\"")]
    public static ReadOnlySpan<byte> VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME => "VK_EXT_physical_device_drm"u8;

    [NativeTypeName("#define VK_EXT_device_address_binding_report 1")]
    public const int VK_EXT_device_address_binding_report = 1;

    [NativeTypeName("#define VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_SPEC_VERSION 1")]
    public const int VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_EXTENSION_NAME \"VK_EXT_device_address_binding_report\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_EXTENSION_NAME => "VK_EXT_device_address_binding_report"u8;

    [NativeTypeName("#define VK_EXT_depth_clip_control 1")]
    public const int VK_EXT_depth_clip_control = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_CLIP_CONTROL_SPEC_VERSION 1")]
    public const int VK_EXT_DEPTH_CLIP_CONTROL_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_CLIP_CONTROL_EXTENSION_NAME \"VK_EXT_depth_clip_control\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEPTH_CLIP_CONTROL_EXTENSION_NAME => "VK_EXT_depth_clip_control"u8;

    [NativeTypeName("#define VK_EXT_primitive_topology_list_restart 1")]
    public const int VK_EXT_primitive_topology_list_restart = 1;

    [NativeTypeName("#define VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_SPEC_VERSION 1")]
    public const int VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_EXTENSION_NAME \"VK_EXT_primitive_topology_list_restart\"")]
    public static ReadOnlySpan<byte> VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_EXTENSION_NAME => "VK_EXT_primitive_topology_list_restart"u8;

    [NativeTypeName("#define VK_EXT_present_mode_fifo_latest_ready 1")]
    public const int VK_EXT_present_mode_fifo_latest_ready = 1;

    [NativeTypeName("#define VK_EXT_PRESENT_MODE_FIFO_LATEST_READY_SPEC_VERSION 1")]
    public const int VK_EXT_PRESENT_MODE_FIFO_LATEST_READY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PRESENT_MODE_FIFO_LATEST_READY_EXTENSION_NAME \"VK_EXT_present_mode_fifo_latest_ready\"")]
    public static ReadOnlySpan<byte> VK_EXT_PRESENT_MODE_FIFO_LATEST_READY_EXTENSION_NAME => "VK_EXT_present_mode_fifo_latest_ready"u8;

    [NativeTypeName("#define VK_HUAWEI_subpass_shading 1")]
    public const int VK_HUAWEI_subpass_shading = 1;

    [NativeTypeName("#define VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION 3")]
    public const int VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME \"VK_HUAWEI_subpass_shading\"")]
    public static ReadOnlySpan<byte> VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME => "VK_HUAWEI_subpass_shading"u8;

    [NativeTypeName("#define VK_HUAWEI_invocation_mask 1")]
    public const int VK_HUAWEI_invocation_mask = 1;

    [NativeTypeName("#define VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION 1")]
    public const int VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME \"VK_HUAWEI_invocation_mask\"")]
    public static ReadOnlySpan<byte> VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME => "VK_HUAWEI_invocation_mask"u8;

    [NativeTypeName("#define VK_NV_external_memory_rdma 1")]
    public const int VK_NV_external_memory_rdma = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION 1")]
    public const int VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME \"VK_NV_external_memory_rdma\"")]
    public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME => "VK_NV_external_memory_rdma"u8;

    [NativeTypeName("#define VK_EXT_pipeline_properties 1")]
    public const int VK_EXT_pipeline_properties = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_PROPERTIES_SPEC_VERSION 1")]
    public const int VK_EXT_PIPELINE_PROPERTIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_PROPERTIES_EXTENSION_NAME \"VK_EXT_pipeline_properties\"")]
    public static ReadOnlySpan<byte> VK_EXT_PIPELINE_PROPERTIES_EXTENSION_NAME => "VK_EXT_pipeline_properties"u8;

    [NativeTypeName("#define VK_EXT_frame_boundary 1")]
    public const int VK_EXT_frame_boundary = 1;

    [NativeTypeName("#define VK_EXT_FRAME_BOUNDARY_SPEC_VERSION 1")]
    public const int VK_EXT_FRAME_BOUNDARY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_FRAME_BOUNDARY_EXTENSION_NAME \"VK_EXT_frame_boundary\"")]
    public static ReadOnlySpan<byte> VK_EXT_FRAME_BOUNDARY_EXTENSION_NAME => "VK_EXT_frame_boundary"u8;

    [NativeTypeName("#define VK_EXT_multisampled_render_to_single_sampled 1")]
    public const int VK_EXT_multisampled_render_to_single_sampled = 1;

    [NativeTypeName("#define VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_SPEC_VERSION 1")]
    public const int VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_EXTENSION_NAME \"VK_EXT_multisampled_render_to_single_sampled\"")]
    public static ReadOnlySpan<byte> VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_EXTENSION_NAME => "VK_EXT_multisampled_render_to_single_sampled"u8;

    [NativeTypeName("#define VK_EXT_extended_dynamic_state2 1")]
    public const int VK_EXT_extended_dynamic_state2 = 1;

    [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION 1")]
    public const int VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME \"VK_EXT_extended_dynamic_state2\"")]
    public static ReadOnlySpan<byte> VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME => "VK_EXT_extended_dynamic_state2"u8;

    [NativeTypeName("#define VK_EXT_color_write_enable 1")]
    public const int VK_EXT_color_write_enable = 1;

    [NativeTypeName("#define VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION 1")]
    public const int VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME \"VK_EXT_color_write_enable\"")]
    public static ReadOnlySpan<byte> VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME => "VK_EXT_color_write_enable"u8;

    [NativeTypeName("#define VK_EXT_primitives_generated_query 1")]
    public const int VK_EXT_primitives_generated_query = 1;

    [NativeTypeName("#define VK_EXT_PRIMITIVES_GENERATED_QUERY_SPEC_VERSION 1")]
    public const int VK_EXT_PRIMITIVES_GENERATED_QUERY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PRIMITIVES_GENERATED_QUERY_EXTENSION_NAME \"VK_EXT_primitives_generated_query\"")]
    public static ReadOnlySpan<byte> VK_EXT_PRIMITIVES_GENERATED_QUERY_EXTENSION_NAME => "VK_EXT_primitives_generated_query"u8;

    [NativeTypeName("#define VK_EXT_global_priority_query 1")]
    public const int VK_EXT_global_priority_query = 1;

    [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION 1")]
    public const int VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME \"VK_EXT_global_priority_query\"")]
    public static ReadOnlySpan<byte> VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME => "VK_EXT_global_priority_query"u8;

    [NativeTypeName("#define VK_MAX_GLOBAL_PRIORITY_SIZE_EXT VK_MAX_GLOBAL_PRIORITY_SIZE")]
    public const uint VK_MAX_GLOBAL_PRIORITY_SIZE_EXT = 16U;

    [NativeTypeName("#define VK_VALVE_video_encode_rgb_conversion 1")]
    public const int VK_VALVE_video_encode_rgb_conversion = 1;

    [NativeTypeName("#define VK_VALVE_VIDEO_ENCODE_RGB_CONVERSION_SPEC_VERSION 1")]
    public const int VK_VALVE_VIDEO_ENCODE_RGB_CONVERSION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_VALVE_VIDEO_ENCODE_RGB_CONVERSION_EXTENSION_NAME \"VK_VALVE_video_encode_rgb_conversion\"")]
    public static ReadOnlySpan<byte> VK_VALVE_VIDEO_ENCODE_RGB_CONVERSION_EXTENSION_NAME => "VK_VALVE_video_encode_rgb_conversion"u8;

    [NativeTypeName("#define VK_EXT_image_view_min_lod 1")]
    public const int VK_EXT_image_view_min_lod = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_VIEW_MIN_LOD_SPEC_VERSION 1")]
    public const int VK_EXT_IMAGE_VIEW_MIN_LOD_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_VIEW_MIN_LOD_EXTENSION_NAME \"VK_EXT_image_view_min_lod\"")]
    public static ReadOnlySpan<byte> VK_EXT_IMAGE_VIEW_MIN_LOD_EXTENSION_NAME => "VK_EXT_image_view_min_lod"u8;

    [NativeTypeName("#define VK_EXT_multi_draw 1")]
    public const int VK_EXT_multi_draw = 1;

    [NativeTypeName("#define VK_EXT_MULTI_DRAW_SPEC_VERSION 1")]
    public const int VK_EXT_MULTI_DRAW_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_MULTI_DRAW_EXTENSION_NAME \"VK_EXT_multi_draw\"")]
    public static ReadOnlySpan<byte> VK_EXT_MULTI_DRAW_EXTENSION_NAME => "VK_EXT_multi_draw"u8;

    [NativeTypeName("#define VK_EXT_image_2d_view_of_3d 1")]
    public const int VK_EXT_image_2d_view_of_3d = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_2D_VIEW_OF_3D_SPEC_VERSION 1")]
    public const int VK_EXT_IMAGE_2D_VIEW_OF_3D_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_2D_VIEW_OF_3D_EXTENSION_NAME \"VK_EXT_image_2d_view_of_3d\"")]
    public static ReadOnlySpan<byte> VK_EXT_IMAGE_2D_VIEW_OF_3D_EXTENSION_NAME => "VK_EXT_image_2d_view_of_3d"u8;

    [NativeTypeName("#define VK_EXT_shader_tile_image 1")]
    public const int VK_EXT_shader_tile_image = 1;

    [NativeTypeName("#define VK_EXT_SHADER_TILE_IMAGE_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_TILE_IMAGE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_TILE_IMAGE_EXTENSION_NAME \"VK_EXT_shader_tile_image\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_TILE_IMAGE_EXTENSION_NAME => "VK_EXT_shader_tile_image"u8;

    [NativeTypeName("#define VK_EXT_opacity_micromap 1")]
    public const int VK_EXT_opacity_micromap = 1;

    [NativeTypeName("#define VK_EXT_OPACITY_MICROMAP_SPEC_VERSION 2")]
    public const int VK_EXT_OPACITY_MICROMAP_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_OPACITY_MICROMAP_EXTENSION_NAME \"VK_EXT_opacity_micromap\"")]
    public static ReadOnlySpan<byte> VK_EXT_OPACITY_MICROMAP_EXTENSION_NAME => "VK_EXT_opacity_micromap"u8;

    [NativeTypeName("#define VK_EXT_load_store_op_none 1")]
    public const int VK_EXT_load_store_op_none = 1;

    [NativeTypeName("#define VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION 1")]
    public const int VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME \"VK_EXT_load_store_op_none\"")]
    public static ReadOnlySpan<byte> VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME => "VK_EXT_load_store_op_none"u8;

    [NativeTypeName("#define VK_HUAWEI_cluster_culling_shader 1")]
    public const int VK_HUAWEI_cluster_culling_shader = 1;

    [NativeTypeName("#define VK_HUAWEI_CLUSTER_CULLING_SHADER_SPEC_VERSION 3")]
    public const int VK_HUAWEI_CLUSTER_CULLING_SHADER_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_HUAWEI_CLUSTER_CULLING_SHADER_EXTENSION_NAME \"VK_HUAWEI_cluster_culling_shader\"")]
    public static ReadOnlySpan<byte> VK_HUAWEI_CLUSTER_CULLING_SHADER_EXTENSION_NAME => "VK_HUAWEI_cluster_culling_shader"u8;

    [NativeTypeName("#define VK_EXT_border_color_swizzle 1")]
    public const int VK_EXT_border_color_swizzle = 1;

    [NativeTypeName("#define VK_EXT_BORDER_COLOR_SWIZZLE_SPEC_VERSION 1")]
    public const int VK_EXT_BORDER_COLOR_SWIZZLE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME \"VK_EXT_border_color_swizzle\"")]
    public static ReadOnlySpan<byte> VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME => "VK_EXT_border_color_swizzle"u8;

    [NativeTypeName("#define VK_EXT_pageable_device_local_memory 1")]
    public const int VK_EXT_pageable_device_local_memory = 1;

    [NativeTypeName("#define VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_SPEC_VERSION 1")]
    public const int VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME \"VK_EXT_pageable_device_local_memory\"")]
    public static ReadOnlySpan<byte> VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME => "VK_EXT_pageable_device_local_memory"u8;

    [NativeTypeName("#define VK_ARM_shader_core_properties 1")]
    public const int VK_ARM_shader_core_properties = 1;

    [NativeTypeName("#define VK_ARM_SHADER_CORE_PROPERTIES_SPEC_VERSION 1")]
    public const int VK_ARM_SHADER_CORE_PROPERTIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ARM_SHADER_CORE_PROPERTIES_EXTENSION_NAME \"VK_ARM_shader_core_properties\"")]
    public static ReadOnlySpan<byte> VK_ARM_SHADER_CORE_PROPERTIES_EXTENSION_NAME => "VK_ARM_shader_core_properties"u8;

    [NativeTypeName("#define VK_ARM_scheduling_controls 1")]
    public const int VK_ARM_scheduling_controls = 1;

    [NativeTypeName("#define VK_ARM_SCHEDULING_CONTROLS_SPEC_VERSION 1")]
    public const int VK_ARM_SCHEDULING_CONTROLS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ARM_SCHEDULING_CONTROLS_EXTENSION_NAME \"VK_ARM_scheduling_controls\"")]
    public static ReadOnlySpan<byte> VK_ARM_SCHEDULING_CONTROLS_EXTENSION_NAME => "VK_ARM_scheduling_controls"u8;

    [NativeTypeName("#define VK_EXT_image_sliced_view_of_3d 1")]
    public const int VK_EXT_image_sliced_view_of_3d = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_SLICED_VIEW_OF_3D_SPEC_VERSION 1")]
    public const int VK_EXT_IMAGE_SLICED_VIEW_OF_3D_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_SLICED_VIEW_OF_3D_EXTENSION_NAME \"VK_EXT_image_sliced_view_of_3d\"")]
    public static ReadOnlySpan<byte> VK_EXT_IMAGE_SLICED_VIEW_OF_3D_EXTENSION_NAME => "VK_EXT_image_sliced_view_of_3d"u8;

    [NativeTypeName("#define VK_REMAINING_3D_SLICES_EXT (~0U)")]
    public const uint VK_REMAINING_3D_SLICES_EXT = (~0U);

    [NativeTypeName("#define VK_VALVE_descriptor_set_host_mapping 1")]
    public const int VK_VALVE_descriptor_set_host_mapping = 1;

    [NativeTypeName("#define VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_SPEC_VERSION 1")]
    public const int VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_EXTENSION_NAME \"VK_VALVE_descriptor_set_host_mapping\"")]
    public static ReadOnlySpan<byte> VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_EXTENSION_NAME => "VK_VALVE_descriptor_set_host_mapping"u8;

    [NativeTypeName("#define VK_EXT_depth_clamp_zero_one 1")]
    public const int VK_EXT_depth_clamp_zero_one = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_CLAMP_ZERO_ONE_SPEC_VERSION 1")]
    public const int VK_EXT_DEPTH_CLAMP_ZERO_ONE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_CLAMP_ZERO_ONE_EXTENSION_NAME \"VK_EXT_depth_clamp_zero_one\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEPTH_CLAMP_ZERO_ONE_EXTENSION_NAME => "VK_EXT_depth_clamp_zero_one"u8;

    [NativeTypeName("#define VK_EXT_non_seamless_cube_map 1")]
    public const int VK_EXT_non_seamless_cube_map = 1;

    [NativeTypeName("#define VK_EXT_NON_SEAMLESS_CUBE_MAP_SPEC_VERSION 1")]
    public const int VK_EXT_NON_SEAMLESS_CUBE_MAP_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_NON_SEAMLESS_CUBE_MAP_EXTENSION_NAME \"VK_EXT_non_seamless_cube_map\"")]
    public static ReadOnlySpan<byte> VK_EXT_NON_SEAMLESS_CUBE_MAP_EXTENSION_NAME => "VK_EXT_non_seamless_cube_map"u8;

    [NativeTypeName("#define VK_ARM_render_pass_striped 1")]
    public const int VK_ARM_render_pass_striped = 1;

    [NativeTypeName("#define VK_ARM_RENDER_PASS_STRIPED_SPEC_VERSION 1")]
    public const int VK_ARM_RENDER_PASS_STRIPED_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ARM_RENDER_PASS_STRIPED_EXTENSION_NAME \"VK_ARM_render_pass_striped\"")]
    public static ReadOnlySpan<byte> VK_ARM_RENDER_PASS_STRIPED_EXTENSION_NAME => "VK_ARM_render_pass_striped"u8;

    [NativeTypeName("#define VK_QCOM_fragment_density_map_offset 1")]
    public const int VK_QCOM_fragment_density_map_offset = 1;

    [NativeTypeName("#define VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_SPEC_VERSION 3")]
    public const int VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME \"VK_QCOM_fragment_density_map_offset\"")]
    public static ReadOnlySpan<byte> VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME => "VK_QCOM_fragment_density_map_offset"u8;

    [NativeTypeName("#define VK_NV_copy_memory_indirect 1")]
    public const int VK_NV_copy_memory_indirect = 1;

    [NativeTypeName("#define VK_NV_COPY_MEMORY_INDIRECT_SPEC_VERSION 1")]
    public const int VK_NV_COPY_MEMORY_INDIRECT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_COPY_MEMORY_INDIRECT_EXTENSION_NAME \"VK_NV_copy_memory_indirect\"")]
    public static ReadOnlySpan<byte> VK_NV_COPY_MEMORY_INDIRECT_EXTENSION_NAME => "VK_NV_copy_memory_indirect"u8;

    [NativeTypeName("#define VK_NV_memory_decompression 1")]
    public const int VK_NV_memory_decompression = 1;

    [NativeTypeName("#define VK_NV_MEMORY_DECOMPRESSION_SPEC_VERSION 1")]
    public const int VK_NV_MEMORY_DECOMPRESSION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_MEMORY_DECOMPRESSION_EXTENSION_NAME \"VK_NV_memory_decompression\"")]
    public static ReadOnlySpan<byte> VK_NV_MEMORY_DECOMPRESSION_EXTENSION_NAME => "VK_NV_memory_decompression"u8;

    [NativeTypeName("#define VK_NV_device_generated_commands_compute 1")]
    public const int VK_NV_device_generated_commands_compute = 1;

    [NativeTypeName("#define VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_SPEC_VERSION 2")]
    public const int VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_EXTENSION_NAME \"VK_NV_device_generated_commands_compute\"")]
    public static ReadOnlySpan<byte> VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_EXTENSION_NAME => "VK_NV_device_generated_commands_compute"u8;

    [NativeTypeName("#define VK_NV_ray_tracing_linear_swept_spheres 1")]
    public const int VK_NV_ray_tracing_linear_swept_spheres = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_LINEAR_SWEPT_SPHERES_SPEC_VERSION 1")]
    public const int VK_NV_RAY_TRACING_LINEAR_SWEPT_SPHERES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_LINEAR_SWEPT_SPHERES_EXTENSION_NAME \"VK_NV_ray_tracing_linear_swept_spheres\"")]
    public static ReadOnlySpan<byte> VK_NV_RAY_TRACING_LINEAR_SWEPT_SPHERES_EXTENSION_NAME => "VK_NV_ray_tracing_linear_swept_spheres"u8;

    [NativeTypeName("#define VK_NV_linear_color_attachment 1")]
    public const int VK_NV_linear_color_attachment = 1;

    [NativeTypeName("#define VK_NV_LINEAR_COLOR_ATTACHMENT_SPEC_VERSION 1")]
    public const int VK_NV_LINEAR_COLOR_ATTACHMENT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_LINEAR_COLOR_ATTACHMENT_EXTENSION_NAME \"VK_NV_linear_color_attachment\"")]
    public static ReadOnlySpan<byte> VK_NV_LINEAR_COLOR_ATTACHMENT_EXTENSION_NAME => "VK_NV_linear_color_attachment"u8;

    [NativeTypeName("#define VK_GOOGLE_surfaceless_query 1")]
    public const int VK_GOOGLE_surfaceless_query = 1;

    [NativeTypeName("#define VK_GOOGLE_SURFACELESS_QUERY_SPEC_VERSION 2")]
    public const int VK_GOOGLE_SURFACELESS_QUERY_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_GOOGLE_SURFACELESS_QUERY_EXTENSION_NAME \"VK_GOOGLE_surfaceless_query\"")]
    public static ReadOnlySpan<byte> VK_GOOGLE_SURFACELESS_QUERY_EXTENSION_NAME => "VK_GOOGLE_surfaceless_query"u8;

    [NativeTypeName("#define VK_EXT_image_compression_control_swapchain 1")]
    public const int VK_EXT_image_compression_control_swapchain = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_SPEC_VERSION 1")]
    public const int VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_EXTENSION_NAME \"VK_EXT_image_compression_control_swapchain\"")]
    public static ReadOnlySpan<byte> VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_EXTENSION_NAME => "VK_EXT_image_compression_control_swapchain"u8;

    [NativeTypeName("#define VK_QCOM_image_processing 1")]
    public const int VK_QCOM_image_processing = 1;

    [NativeTypeName("#define VK_QCOM_IMAGE_PROCESSING_SPEC_VERSION 1")]
    public const int VK_QCOM_IMAGE_PROCESSING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_IMAGE_PROCESSING_EXTENSION_NAME \"VK_QCOM_image_processing\"")]
    public static ReadOnlySpan<byte> VK_QCOM_IMAGE_PROCESSING_EXTENSION_NAME => "VK_QCOM_image_processing"u8;

    [NativeTypeName("#define VK_EXT_nested_command_buffer 1")]
    public const int VK_EXT_nested_command_buffer = 1;

    [NativeTypeName("#define VK_EXT_NESTED_COMMAND_BUFFER_SPEC_VERSION 1")]
    public const int VK_EXT_NESTED_COMMAND_BUFFER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_NESTED_COMMAND_BUFFER_EXTENSION_NAME \"VK_EXT_nested_command_buffer\"")]
    public static ReadOnlySpan<byte> VK_EXT_NESTED_COMMAND_BUFFER_EXTENSION_NAME => "VK_EXT_nested_command_buffer"u8;

    [NativeTypeName("#define VK_EXT_external_memory_acquire_unmodified 1")]
    public const int VK_EXT_external_memory_acquire_unmodified = 1;

    [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_SPEC_VERSION 1")]
    public const int VK_EXT_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXTENSION_NAME \"VK_EXT_external_memory_acquire_unmodified\"")]
    public static ReadOnlySpan<byte> VK_EXT_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXTENSION_NAME => "VK_EXT_external_memory_acquire_unmodified"u8;

    [NativeTypeName("#define VK_EXT_extended_dynamic_state3 1")]
    public const int VK_EXT_extended_dynamic_state3 = 1;

    [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_3_SPEC_VERSION 2")]
    public const int VK_EXT_EXTENDED_DYNAMIC_STATE_3_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_3_EXTENSION_NAME \"VK_EXT_extended_dynamic_state3\"")]
    public static ReadOnlySpan<byte> VK_EXT_EXTENDED_DYNAMIC_STATE_3_EXTENSION_NAME => "VK_EXT_extended_dynamic_state3"u8;

    [NativeTypeName("#define VK_EXT_subpass_merge_feedback 1")]
    public const int VK_EXT_subpass_merge_feedback = 1;

    [NativeTypeName("#define VK_EXT_SUBPASS_MERGE_FEEDBACK_SPEC_VERSION 2")]
    public const int VK_EXT_SUBPASS_MERGE_FEEDBACK_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_SUBPASS_MERGE_FEEDBACK_EXTENSION_NAME \"VK_EXT_subpass_merge_feedback\"")]
    public static ReadOnlySpan<byte> VK_EXT_SUBPASS_MERGE_FEEDBACK_EXTENSION_NAME => "VK_EXT_subpass_merge_feedback"u8;

    [NativeTypeName("#define VK_LUNARG_direct_driver_loading 1")]
    public const int VK_LUNARG_direct_driver_loading = 1;

    [NativeTypeName("#define VK_LUNARG_DIRECT_DRIVER_LOADING_SPEC_VERSION 1")]
    public const int VK_LUNARG_DIRECT_DRIVER_LOADING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_LUNARG_DIRECT_DRIVER_LOADING_EXTENSION_NAME \"VK_LUNARG_direct_driver_loading\"")]
    public static ReadOnlySpan<byte> VK_LUNARG_DIRECT_DRIVER_LOADING_EXTENSION_NAME => "VK_LUNARG_direct_driver_loading"u8;

    [NativeTypeName("#define VK_ARM_tensors 1")]
    public const int VK_ARM_tensors = 1;

    [NativeTypeName("#define VK_ARM_TENSORS_SPEC_VERSION 1")]
    public const int VK_ARM_TENSORS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ARM_TENSORS_EXTENSION_NAME \"VK_ARM_tensors\"")]
    public static ReadOnlySpan<byte> VK_ARM_TENSORS_EXTENSION_NAME => "VK_ARM_tensors"u8;

    [NativeTypeName("#define VK_EXT_shader_module_identifier 1")]
    public const int VK_EXT_shader_module_identifier = 1;

    [NativeTypeName("#define VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT 32U")]
    public const uint VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT = 32U;

    [NativeTypeName("#define VK_EXT_SHADER_MODULE_IDENTIFIER_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_MODULE_IDENTIFIER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_MODULE_IDENTIFIER_EXTENSION_NAME \"VK_EXT_shader_module_identifier\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_MODULE_IDENTIFIER_EXTENSION_NAME => "VK_EXT_shader_module_identifier"u8;

    [NativeTypeName("#define VK_EXT_rasterization_order_attachment_access 1")]
    public const int VK_EXT_rasterization_order_attachment_access = 1;

    [NativeTypeName("#define VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_SPEC_VERSION 1")]
    public const int VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME \"VK_EXT_rasterization_order_attachment_access\"")]
    public static ReadOnlySpan<byte> VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME => "VK_EXT_rasterization_order_attachment_access"u8;

    [NativeTypeName("#define VK_NV_optical_flow 1")]
    public const int VK_NV_optical_flow = 1;

    [NativeTypeName("#define VK_NV_OPTICAL_FLOW_SPEC_VERSION 1")]
    public const int VK_NV_OPTICAL_FLOW_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_OPTICAL_FLOW_EXTENSION_NAME \"VK_NV_optical_flow\"")]
    public static ReadOnlySpan<byte> VK_NV_OPTICAL_FLOW_EXTENSION_NAME => "VK_NV_optical_flow"u8;

    [NativeTypeName("#define VK_EXT_legacy_dithering 1")]
    public const int VK_EXT_legacy_dithering = 1;

    [NativeTypeName("#define VK_EXT_LEGACY_DITHERING_SPEC_VERSION 2")]
    public const int VK_EXT_LEGACY_DITHERING_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_LEGACY_DITHERING_EXTENSION_NAME \"VK_EXT_legacy_dithering\"")]
    public static ReadOnlySpan<byte> VK_EXT_LEGACY_DITHERING_EXTENSION_NAME => "VK_EXT_legacy_dithering"u8;

    [NativeTypeName("#define VK_EXT_pipeline_protected_access 1")]
    public const int VK_EXT_pipeline_protected_access = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_PROTECTED_ACCESS_SPEC_VERSION 1")]
    public const int VK_EXT_PIPELINE_PROTECTED_ACCESS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_PROTECTED_ACCESS_EXTENSION_NAME \"VK_EXT_pipeline_protected_access\"")]
    public static ReadOnlySpan<byte> VK_EXT_PIPELINE_PROTECTED_ACCESS_EXTENSION_NAME => "VK_EXT_pipeline_protected_access"u8;

    [NativeTypeName("#define VK_AMD_anti_lag 1")]
    public const int VK_AMD_anti_lag = 1;

    [NativeTypeName("#define VK_AMD_ANTI_LAG_SPEC_VERSION 1")]
    public const int VK_AMD_ANTI_LAG_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMD_ANTI_LAG_EXTENSION_NAME \"VK_AMD_anti_lag\"")]
    public static ReadOnlySpan<byte> VK_AMD_ANTI_LAG_EXTENSION_NAME => "VK_AMD_anti_lag"u8;

    [NativeTypeName("#define VK_EXT_shader_object 1")]
    public const int VK_EXT_shader_object = 1;

    [NativeTypeName("#define VK_EXT_SHADER_OBJECT_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_OBJECT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_OBJECT_EXTENSION_NAME \"VK_EXT_shader_object\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_OBJECT_EXTENSION_NAME => "VK_EXT_shader_object"u8;

    [NativeTypeName("#define VK_QCOM_tile_properties 1")]
    public const int VK_QCOM_tile_properties = 1;

    [NativeTypeName("#define VK_QCOM_TILE_PROPERTIES_SPEC_VERSION 1")]
    public const int VK_QCOM_TILE_PROPERTIES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_TILE_PROPERTIES_EXTENSION_NAME \"VK_QCOM_tile_properties\"")]
    public static ReadOnlySpan<byte> VK_QCOM_TILE_PROPERTIES_EXTENSION_NAME => "VK_QCOM_tile_properties"u8;

    [NativeTypeName("#define VK_SEC_amigo_profiling 1")]
    public const int VK_SEC_amigo_profiling = 1;

    [NativeTypeName("#define VK_SEC_AMIGO_PROFILING_SPEC_VERSION 1")]
    public const int VK_SEC_AMIGO_PROFILING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_SEC_AMIGO_PROFILING_EXTENSION_NAME \"VK_SEC_amigo_profiling\"")]
    public static ReadOnlySpan<byte> VK_SEC_AMIGO_PROFILING_EXTENSION_NAME => "VK_SEC_amigo_profiling"u8;

    [NativeTypeName("#define VK_QCOM_multiview_per_view_viewports 1")]
    public const int VK_QCOM_multiview_per_view_viewports = 1;

    [NativeTypeName("#define VK_QCOM_MULTIVIEW_PER_VIEW_VIEWPORTS_SPEC_VERSION 1")]
    public const int VK_QCOM_MULTIVIEW_PER_VIEW_VIEWPORTS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_MULTIVIEW_PER_VIEW_VIEWPORTS_EXTENSION_NAME \"VK_QCOM_multiview_per_view_viewports\"")]
    public static ReadOnlySpan<byte> VK_QCOM_MULTIVIEW_PER_VIEW_VIEWPORTS_EXTENSION_NAME => "VK_QCOM_multiview_per_view_viewports"u8;

    [NativeTypeName("#define VK_NV_ray_tracing_invocation_reorder 1")]
    public const int VK_NV_ray_tracing_invocation_reorder = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_INVOCATION_REORDER_SPEC_VERSION 1")]
    public const int VK_NV_RAY_TRACING_INVOCATION_REORDER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_INVOCATION_REORDER_EXTENSION_NAME \"VK_NV_ray_tracing_invocation_reorder\"")]
    public static ReadOnlySpan<byte> VK_NV_RAY_TRACING_INVOCATION_REORDER_EXTENSION_NAME => "VK_NV_ray_tracing_invocation_reorder"u8;

    [NativeTypeName("#define VK_NV_cooperative_vector 1")]
    public const int VK_NV_cooperative_vector = 1;

    [NativeTypeName("#define VK_NV_COOPERATIVE_VECTOR_SPEC_VERSION 4")]
    public const int VK_NV_COOPERATIVE_VECTOR_SPEC_VERSION = 4;

    [NativeTypeName("#define VK_NV_COOPERATIVE_VECTOR_EXTENSION_NAME \"VK_NV_cooperative_vector\"")]
    public static ReadOnlySpan<byte> VK_NV_COOPERATIVE_VECTOR_EXTENSION_NAME => "VK_NV_cooperative_vector"u8;

    [NativeTypeName("#define VK_NV_extended_sparse_address_space 1")]
    public const int VK_NV_extended_sparse_address_space = 1;

    [NativeTypeName("#define VK_NV_EXTENDED_SPARSE_ADDRESS_SPACE_SPEC_VERSION 1")]
    public const int VK_NV_EXTENDED_SPARSE_ADDRESS_SPACE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_EXTENDED_SPARSE_ADDRESS_SPACE_EXTENSION_NAME \"VK_NV_extended_sparse_address_space\"")]
    public static ReadOnlySpan<byte> VK_NV_EXTENDED_SPARSE_ADDRESS_SPACE_EXTENSION_NAME => "VK_NV_extended_sparse_address_space"u8;

    [NativeTypeName("#define VK_EXT_mutable_descriptor_type 1")]
    public const int VK_EXT_mutable_descriptor_type = 1;

    [NativeTypeName("#define VK_EXT_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION 1")]
    public const int VK_EXT_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME \"VK_EXT_mutable_descriptor_type\"")]
    public static ReadOnlySpan<byte> VK_EXT_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME => "VK_EXT_mutable_descriptor_type"u8;

    [NativeTypeName("#define VK_EXT_legacy_vertex_attributes 1")]
    public const int VK_EXT_legacy_vertex_attributes = 1;

    [NativeTypeName("#define VK_EXT_LEGACY_VERTEX_ATTRIBUTES_SPEC_VERSION 1")]
    public const int VK_EXT_LEGACY_VERTEX_ATTRIBUTES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_LEGACY_VERTEX_ATTRIBUTES_EXTENSION_NAME \"VK_EXT_legacy_vertex_attributes\"")]
    public static ReadOnlySpan<byte> VK_EXT_LEGACY_VERTEX_ATTRIBUTES_EXTENSION_NAME => "VK_EXT_legacy_vertex_attributes"u8;

    [NativeTypeName("#define VK_EXT_layer_settings 1")]
    public const int VK_EXT_layer_settings = 1;

    [NativeTypeName("#define VK_EXT_LAYER_SETTINGS_SPEC_VERSION 2")]
    public const int VK_EXT_LAYER_SETTINGS_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_EXT_LAYER_SETTINGS_EXTENSION_NAME \"VK_EXT_layer_settings\"")]
    public static ReadOnlySpan<byte> VK_EXT_LAYER_SETTINGS_EXTENSION_NAME => "VK_EXT_layer_settings"u8;

    [NativeTypeName("#define VK_ARM_shader_core_builtins 1")]
    public const int VK_ARM_shader_core_builtins = 1;

    [NativeTypeName("#define VK_ARM_SHADER_CORE_BUILTINS_SPEC_VERSION 2")]
    public const int VK_ARM_SHADER_CORE_BUILTINS_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_ARM_SHADER_CORE_BUILTINS_EXTENSION_NAME \"VK_ARM_shader_core_builtins\"")]
    public static ReadOnlySpan<byte> VK_ARM_SHADER_CORE_BUILTINS_EXTENSION_NAME => "VK_ARM_shader_core_builtins"u8;

    [NativeTypeName("#define VK_EXT_pipeline_library_group_handles 1")]
    public const int VK_EXT_pipeline_library_group_handles = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_LIBRARY_GROUP_HANDLES_SPEC_VERSION 1")]
    public const int VK_EXT_PIPELINE_LIBRARY_GROUP_HANDLES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_PIPELINE_LIBRARY_GROUP_HANDLES_EXTENSION_NAME \"VK_EXT_pipeline_library_group_handles\"")]
    public static ReadOnlySpan<byte> VK_EXT_PIPELINE_LIBRARY_GROUP_HANDLES_EXTENSION_NAME => "VK_EXT_pipeline_library_group_handles"u8;

    [NativeTypeName("#define VK_EXT_dynamic_rendering_unused_attachments 1")]
    public const int VK_EXT_dynamic_rendering_unused_attachments = 1;

    [NativeTypeName("#define VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_SPEC_VERSION 1")]
    public const int VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_EXTENSION_NAME \"VK_EXT_dynamic_rendering_unused_attachments\"")]
    public static ReadOnlySpan<byte> VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_EXTENSION_NAME => "VK_EXT_dynamic_rendering_unused_attachments"u8;

    [NativeTypeName("#define VK_NV_low_latency2 1")]
    public const int VK_NV_low_latency2 = 1;

    [NativeTypeName("#define VK_NV_LOW_LATENCY_2_SPEC_VERSION 2")]
    public const int VK_NV_LOW_LATENCY_2_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_LOW_LATENCY_2_EXTENSION_NAME \"VK_NV_low_latency2\"")]
    public static ReadOnlySpan<byte> VK_NV_LOW_LATENCY_2_EXTENSION_NAME => "VK_NV_low_latency2"u8;

    [NativeTypeName("#define VK_ARM_data_graph 1")]
    public const int VK_ARM_data_graph = 1;

    [NativeTypeName("#define VK_MAX_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_SET_NAME_SIZE_ARM 128U")]
    public const uint VK_MAX_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_SET_NAME_SIZE_ARM = 128U;

    [NativeTypeName("#define VK_ARM_DATA_GRAPH_SPEC_VERSION 1")]
    public const int VK_ARM_DATA_GRAPH_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ARM_DATA_GRAPH_EXTENSION_NAME \"VK_ARM_data_graph\"")]
    public static ReadOnlySpan<byte> VK_ARM_DATA_GRAPH_EXTENSION_NAME => "VK_ARM_data_graph"u8;

    [NativeTypeName("#define VK_QCOM_multiview_per_view_render_areas 1")]
    public const int VK_QCOM_multiview_per_view_render_areas = 1;

    [NativeTypeName("#define VK_QCOM_MULTIVIEW_PER_VIEW_RENDER_AREAS_SPEC_VERSION 1")]
    public const int VK_QCOM_MULTIVIEW_PER_VIEW_RENDER_AREAS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_MULTIVIEW_PER_VIEW_RENDER_AREAS_EXTENSION_NAME \"VK_QCOM_multiview_per_view_render_areas\"")]
    public static ReadOnlySpan<byte> VK_QCOM_MULTIVIEW_PER_VIEW_RENDER_AREAS_EXTENSION_NAME => "VK_QCOM_multiview_per_view_render_areas"u8;

    [NativeTypeName("#define VK_NV_per_stage_descriptor_set 1")]
    public const int VK_NV_per_stage_descriptor_set = 1;

    [NativeTypeName("#define VK_NV_PER_STAGE_DESCRIPTOR_SET_SPEC_VERSION 1")]
    public const int VK_NV_PER_STAGE_DESCRIPTOR_SET_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_PER_STAGE_DESCRIPTOR_SET_EXTENSION_NAME \"VK_NV_per_stage_descriptor_set\"")]
    public static ReadOnlySpan<byte> VK_NV_PER_STAGE_DESCRIPTOR_SET_EXTENSION_NAME => "VK_NV_per_stage_descriptor_set"u8;

    [NativeTypeName("#define VK_QCOM_image_processing2 1")]
    public const int VK_QCOM_image_processing2 = 1;

    [NativeTypeName("#define VK_QCOM_IMAGE_PROCESSING_2_SPEC_VERSION 1")]
    public const int VK_QCOM_IMAGE_PROCESSING_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_IMAGE_PROCESSING_2_EXTENSION_NAME \"VK_QCOM_image_processing2\"")]
    public static ReadOnlySpan<byte> VK_QCOM_IMAGE_PROCESSING_2_EXTENSION_NAME => "VK_QCOM_image_processing2"u8;

    [NativeTypeName("#define VK_QCOM_filter_cubic_weights 1")]
    public const int VK_QCOM_filter_cubic_weights = 1;

    [NativeTypeName("#define VK_QCOM_FILTER_CUBIC_WEIGHTS_SPEC_VERSION 1")]
    public const int VK_QCOM_FILTER_CUBIC_WEIGHTS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_FILTER_CUBIC_WEIGHTS_EXTENSION_NAME \"VK_QCOM_filter_cubic_weights\"")]
    public static ReadOnlySpan<byte> VK_QCOM_FILTER_CUBIC_WEIGHTS_EXTENSION_NAME => "VK_QCOM_filter_cubic_weights"u8;

    [NativeTypeName("#define VK_QCOM_ycbcr_degamma 1")]
    public const int VK_QCOM_ycbcr_degamma = 1;

    [NativeTypeName("#define VK_QCOM_YCBCR_DEGAMMA_SPEC_VERSION 1")]
    public const int VK_QCOM_YCBCR_DEGAMMA_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_YCBCR_DEGAMMA_EXTENSION_NAME \"VK_QCOM_ycbcr_degamma\"")]
    public static ReadOnlySpan<byte> VK_QCOM_YCBCR_DEGAMMA_EXTENSION_NAME => "VK_QCOM_ycbcr_degamma"u8;

    [NativeTypeName("#define VK_QCOM_filter_cubic_clamp 1")]
    public const int VK_QCOM_filter_cubic_clamp = 1;

    [NativeTypeName("#define VK_QCOM_FILTER_CUBIC_CLAMP_SPEC_VERSION 1")]
    public const int VK_QCOM_FILTER_CUBIC_CLAMP_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_FILTER_CUBIC_CLAMP_EXTENSION_NAME \"VK_QCOM_filter_cubic_clamp\"")]
    public static ReadOnlySpan<byte> VK_QCOM_FILTER_CUBIC_CLAMP_EXTENSION_NAME => "VK_QCOM_filter_cubic_clamp"u8;

    [NativeTypeName("#define VK_EXT_attachment_feedback_loop_dynamic_state 1")]
    public const int VK_EXT_attachment_feedback_loop_dynamic_state = 1;

    [NativeTypeName("#define VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_SPEC_VERSION 1")]
    public const int VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_EXTENSION_NAME \"VK_EXT_attachment_feedback_loop_dynamic_state\"")]
    public static ReadOnlySpan<byte> VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_EXTENSION_NAME => "VK_EXT_attachment_feedback_loop_dynamic_state"u8;

    [NativeTypeName("#define VK_MSFT_layered_driver 1")]
    public const int VK_MSFT_layered_driver = 1;

    [NativeTypeName("#define VK_MSFT_LAYERED_DRIVER_SPEC_VERSION 1")]
    public const int VK_MSFT_LAYERED_DRIVER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_MSFT_LAYERED_DRIVER_EXTENSION_NAME \"VK_MSFT_layered_driver\"")]
    public static ReadOnlySpan<byte> VK_MSFT_LAYERED_DRIVER_EXTENSION_NAME => "VK_MSFT_layered_driver"u8;

    [NativeTypeName("#define VK_NV_descriptor_pool_overallocation 1")]
    public const int VK_NV_descriptor_pool_overallocation = 1;

    [NativeTypeName("#define VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_SPEC_VERSION 1")]
    public const int VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_EXTENSION_NAME \"VK_NV_descriptor_pool_overallocation\"")]
    public static ReadOnlySpan<byte> VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_EXTENSION_NAME => "VK_NV_descriptor_pool_overallocation"u8;

    [NativeTypeName("#define VK_QCOM_tile_memory_heap 1")]
    public const int VK_QCOM_tile_memory_heap = 1;

    [NativeTypeName("#define VK_QCOM_TILE_MEMORY_HEAP_SPEC_VERSION 1")]
    public const int VK_QCOM_TILE_MEMORY_HEAP_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QCOM_TILE_MEMORY_HEAP_EXTENSION_NAME \"VK_QCOM_tile_memory_heap\"")]
    public static ReadOnlySpan<byte> VK_QCOM_TILE_MEMORY_HEAP_EXTENSION_NAME => "VK_QCOM_tile_memory_heap"u8;

    [NativeTypeName("#define VK_NV_display_stereo 1")]
    public const int VK_NV_display_stereo = 1;

    [NativeTypeName("#define VK_NV_DISPLAY_STEREO_SPEC_VERSION 1")]
    public const int VK_NV_DISPLAY_STEREO_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_DISPLAY_STEREO_EXTENSION_NAME \"VK_NV_display_stereo\"")]
    public static ReadOnlySpan<byte> VK_NV_DISPLAY_STEREO_EXTENSION_NAME => "VK_NV_display_stereo"u8;

    [NativeTypeName("#define VK_NV_raw_access_chains 1")]
    public const int VK_NV_raw_access_chains = 1;

    [NativeTypeName("#define VK_NV_RAW_ACCESS_CHAINS_SPEC_VERSION 1")]
    public const int VK_NV_RAW_ACCESS_CHAINS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_RAW_ACCESS_CHAINS_EXTENSION_NAME \"VK_NV_raw_access_chains\"")]
    public static ReadOnlySpan<byte> VK_NV_RAW_ACCESS_CHAINS_EXTENSION_NAME => "VK_NV_raw_access_chains"u8;

    [NativeTypeName("#define VK_NV_external_compute_queue 1")]
    public const int VK_NV_external_compute_queue = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_COMPUTE_QUEUE_SPEC_VERSION 1")]
    public const int VK_NV_EXTERNAL_COMPUTE_QUEUE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_COMPUTE_QUEUE_EXTENSION_NAME \"VK_NV_external_compute_queue\"")]
    public static ReadOnlySpan<byte> VK_NV_EXTERNAL_COMPUTE_QUEUE_EXTENSION_NAME => "VK_NV_external_compute_queue"u8;

    [NativeTypeName("#define VK_NV_command_buffer_inheritance 1")]
    public const int VK_NV_command_buffer_inheritance = 1;

    [NativeTypeName("#define VK_NV_COMMAND_BUFFER_INHERITANCE_SPEC_VERSION 1")]
    public const int VK_NV_COMMAND_BUFFER_INHERITANCE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_COMMAND_BUFFER_INHERITANCE_EXTENSION_NAME \"VK_NV_command_buffer_inheritance\"")]
    public static ReadOnlySpan<byte> VK_NV_COMMAND_BUFFER_INHERITANCE_EXTENSION_NAME => "VK_NV_command_buffer_inheritance"u8;

    [NativeTypeName("#define VK_NV_shader_atomic_float16_vector 1")]
    public const int VK_NV_shader_atomic_float16_vector = 1;

    [NativeTypeName("#define VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_SPEC_VERSION 1")]
    public const int VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_EXTENSION_NAME \"VK_NV_shader_atomic_float16_vector\"")]
    public static ReadOnlySpan<byte> VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_EXTENSION_NAME => "VK_NV_shader_atomic_float16_vector"u8;

    [NativeTypeName("#define VK_EXT_shader_replicated_composites 1")]
    public const int VK_EXT_shader_replicated_composites = 1;

    [NativeTypeName("#define VK_EXT_SHADER_REPLICATED_COMPOSITES_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_REPLICATED_COMPOSITES_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_REPLICATED_COMPOSITES_EXTENSION_NAME \"VK_EXT_shader_replicated_composites\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_REPLICATED_COMPOSITES_EXTENSION_NAME => "VK_EXT_shader_replicated_composites"u8;

    [NativeTypeName("#define VK_EXT_shader_float8 1")]
    public const int VK_EXT_shader_float8 = 1;

    [NativeTypeName("#define VK_EXT_SHADER_FLOAT8_SPEC_VERSION 1")]
    public const int VK_EXT_SHADER_FLOAT8_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_SHADER_FLOAT8_EXTENSION_NAME \"VK_EXT_shader_float8\"")]
    public static ReadOnlySpan<byte> VK_EXT_SHADER_FLOAT8_EXTENSION_NAME => "VK_EXT_shader_float8"u8;

    [NativeTypeName("#define VK_NV_ray_tracing_validation 1")]
    public const int VK_NV_ray_tracing_validation = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_VALIDATION_SPEC_VERSION 1")]
    public const int VK_NV_RAY_TRACING_VALIDATION_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_RAY_TRACING_VALIDATION_EXTENSION_NAME \"VK_NV_ray_tracing_validation\"")]
    public static ReadOnlySpan<byte> VK_NV_RAY_TRACING_VALIDATION_EXTENSION_NAME => "VK_NV_ray_tracing_validation"u8;

    [NativeTypeName("#define VK_NV_cluster_acceleration_structure 1")]
    public const int VK_NV_cluster_acceleration_structure = 1;

    [NativeTypeName("#define VK_NV_CLUSTER_ACCELERATION_STRUCTURE_SPEC_VERSION 4")]
    public const int VK_NV_CLUSTER_ACCELERATION_STRUCTURE_SPEC_VERSION = 4;

    [NativeTypeName("#define VK_NV_CLUSTER_ACCELERATION_STRUCTURE_EXTENSION_NAME \"VK_NV_cluster_acceleration_structure\"")]
    public static ReadOnlySpan<byte> VK_NV_CLUSTER_ACCELERATION_STRUCTURE_EXTENSION_NAME => "VK_NV_cluster_acceleration_structure"u8;

    [NativeTypeName("#define VK_NV_partitioned_acceleration_structure 1")]
    public const int VK_NV_partitioned_acceleration_structure = 1;

    [NativeTypeName("#define VK_NV_PARTITIONED_ACCELERATION_STRUCTURE_SPEC_VERSION 1")]
    public const int VK_NV_PARTITIONED_ACCELERATION_STRUCTURE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_PARTITIONED_ACCELERATION_STRUCTURE_EXTENSION_NAME \"VK_NV_partitioned_acceleration_structure\"")]
    public static ReadOnlySpan<byte> VK_NV_PARTITIONED_ACCELERATION_STRUCTURE_EXTENSION_NAME => "VK_NV_partitioned_acceleration_structure"u8;

    [NativeTypeName("#define VK_PARTITIONED_ACCELERATION_STRUCTURE_PARTITION_INDEX_GLOBAL_NV (~0U)")]
    public const uint VK_PARTITIONED_ACCELERATION_STRUCTURE_PARTITION_INDEX_GLOBAL_NV = (~0U);

    [NativeTypeName("#define VK_EXT_device_generated_commands 1")]
    public const int VK_EXT_device_generated_commands = 1;

    [NativeTypeName("#define VK_EXT_DEVICE_GENERATED_COMMANDS_SPEC_VERSION 1")]
    public const int VK_EXT_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME \"VK_EXT_device_generated_commands\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME => "VK_EXT_device_generated_commands"u8;

    [NativeTypeName("#define VK_MESA_image_alignment_control 1")]
    public const int VK_MESA_image_alignment_control = 1;

    [NativeTypeName("#define VK_MESA_IMAGE_ALIGNMENT_CONTROL_SPEC_VERSION 1")]
    public const int VK_MESA_IMAGE_ALIGNMENT_CONTROL_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_MESA_IMAGE_ALIGNMENT_CONTROL_EXTENSION_NAME \"VK_MESA_image_alignment_control\"")]
    public static ReadOnlySpan<byte> VK_MESA_IMAGE_ALIGNMENT_CONTROL_EXTENSION_NAME => "VK_MESA_image_alignment_control"u8;

    [NativeTypeName("#define VK_EXT_depth_clamp_control 1")]
    public const int VK_EXT_depth_clamp_control = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_CLAMP_CONTROL_SPEC_VERSION 1")]
    public const int VK_EXT_DEPTH_CLAMP_CONTROL_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_DEPTH_CLAMP_CONTROL_EXTENSION_NAME \"VK_EXT_depth_clamp_control\"")]
    public static ReadOnlySpan<byte> VK_EXT_DEPTH_CLAMP_CONTROL_EXTENSION_NAME => "VK_EXT_depth_clamp_control"u8;

    [NativeTypeName("#define VK_HUAWEI_hdr_vivid 1")]
    public const int VK_HUAWEI_hdr_vivid = 1;

    [NativeTypeName("#define VK_HUAWEI_HDR_VIVID_SPEC_VERSION 1")]
    public const int VK_HUAWEI_HDR_VIVID_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_HUAWEI_HDR_VIVID_EXTENSION_NAME \"VK_HUAWEI_hdr_vivid\"")]
    public static ReadOnlySpan<byte> VK_HUAWEI_HDR_VIVID_EXTENSION_NAME => "VK_HUAWEI_hdr_vivid"u8;

    [NativeTypeName("#define VK_NV_cooperative_matrix2 1")]
    public const int VK_NV_cooperative_matrix2 = 1;

    [NativeTypeName("#define VK_NV_COOPERATIVE_MATRIX_2_SPEC_VERSION 1")]
    public const int VK_NV_COOPERATIVE_MATRIX_2_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_COOPERATIVE_MATRIX_2_EXTENSION_NAME \"VK_NV_cooperative_matrix2\"")]
    public static ReadOnlySpan<byte> VK_NV_COOPERATIVE_MATRIX_2_EXTENSION_NAME => "VK_NV_cooperative_matrix2"u8;

    [NativeTypeName("#define VK_ARM_pipeline_opacity_micromap 1")]
    public const int VK_ARM_pipeline_opacity_micromap = 1;

    [NativeTypeName("#define VK_ARM_PIPELINE_OPACITY_MICROMAP_SPEC_VERSION 1")]
    public const int VK_ARM_PIPELINE_OPACITY_MICROMAP_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ARM_PIPELINE_OPACITY_MICROMAP_EXTENSION_NAME \"VK_ARM_pipeline_opacity_micromap\"")]
    public static ReadOnlySpan<byte> VK_ARM_PIPELINE_OPACITY_MICROMAP_EXTENSION_NAME => "VK_ARM_pipeline_opacity_micromap"u8;

    [NativeTypeName("#define VK_EXT_vertex_attribute_robustness 1")]
    public const int VK_EXT_vertex_attribute_robustness = 1;

    [NativeTypeName("#define VK_EXT_VERTEX_ATTRIBUTE_ROBUSTNESS_SPEC_VERSION 1")]
    public const int VK_EXT_VERTEX_ATTRIBUTE_ROBUSTNESS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_VERTEX_ATTRIBUTE_ROBUSTNESS_EXTENSION_NAME \"VK_EXT_vertex_attribute_robustness\"")]
    public static ReadOnlySpan<byte> VK_EXT_VERTEX_ATTRIBUTE_ROBUSTNESS_EXTENSION_NAME => "VK_EXT_vertex_attribute_robustness"u8;

    [NativeTypeName("#define VK_ARM_format_pack 1")]
    public const int VK_ARM_format_pack = 1;

    [NativeTypeName("#define VK_ARM_FORMAT_PACK_SPEC_VERSION 1")]
    public const int VK_ARM_FORMAT_PACK_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ARM_FORMAT_PACK_EXTENSION_NAME \"VK_ARM_format_pack\"")]
    public static ReadOnlySpan<byte> VK_ARM_FORMAT_PACK_EXTENSION_NAME => "VK_ARM_format_pack"u8;

    [NativeTypeName("#define VK_VALVE_fragment_density_map_layered 1")]
    public const int VK_VALVE_fragment_density_map_layered = 1;

    [NativeTypeName("#define VK_VALVE_FRAGMENT_DENSITY_MAP_LAYERED_SPEC_VERSION 1")]
    public const int VK_VALVE_FRAGMENT_DENSITY_MAP_LAYERED_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_VALVE_FRAGMENT_DENSITY_MAP_LAYERED_EXTENSION_NAME \"VK_VALVE_fragment_density_map_layered\"")]
    public static ReadOnlySpan<byte> VK_VALVE_FRAGMENT_DENSITY_MAP_LAYERED_EXTENSION_NAME => "VK_VALVE_fragment_density_map_layered"u8;

    [NativeTypeName("#define VK_NV_present_metering 1")]
    public const int VK_NV_present_metering = 1;

    [NativeTypeName("#define VK_NV_PRESENT_METERING_SPEC_VERSION 1")]
    public const int VK_NV_PRESENT_METERING_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_PRESENT_METERING_EXTENSION_NAME \"VK_NV_present_metering\"")]
    public static ReadOnlySpan<byte> VK_NV_PRESENT_METERING_EXTENSION_NAME => "VK_NV_present_metering"u8;

    [NativeTypeName("#define VK_EXT_fragment_density_map_offset 1")]
    public const int VK_EXT_fragment_density_map_offset = 1;

    [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_OFFSET_SPEC_VERSION 1")]
    public const int VK_EXT_FRAGMENT_DENSITY_MAP_OFFSET_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME \"VK_EXT_fragment_density_map_offset\"")]
    public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME => "VK_EXT_fragment_density_map_offset"u8;

    [NativeTypeName("#define VK_EXT_zero_initialize_device_memory 1")]
    public const int VK_EXT_zero_initialize_device_memory = 1;

    [NativeTypeName("#define VK_EXT_ZERO_INITIALIZE_DEVICE_MEMORY_SPEC_VERSION 1")]
    public const int VK_EXT_ZERO_INITIALIZE_DEVICE_MEMORY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_ZERO_INITIALIZE_DEVICE_MEMORY_EXTENSION_NAME \"VK_EXT_zero_initialize_device_memory\"")]
    public static ReadOnlySpan<byte> VK_EXT_ZERO_INITIALIZE_DEVICE_MEMORY_EXTENSION_NAME => "VK_EXT_zero_initialize_device_memory"u8;

    [NativeTypeName("#define VK_SEC_pipeline_cache_incremental_mode 1")]
    public const int VK_SEC_pipeline_cache_incremental_mode = 1;

    [NativeTypeName("#define VK_SEC_PIPELINE_CACHE_INCREMENTAL_MODE_SPEC_VERSION 1")]
    public const int VK_SEC_PIPELINE_CACHE_INCREMENTAL_MODE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_SEC_PIPELINE_CACHE_INCREMENTAL_MODE_EXTENSION_NAME \"VK_SEC_pipeline_cache_incremental_mode\"")]
    public static ReadOnlySpan<byte> VK_SEC_PIPELINE_CACHE_INCREMENTAL_MODE_EXTENSION_NAME => "VK_SEC_pipeline_cache_incremental_mode"u8;

    [NativeTypeName("#define VK_KHR_acceleration_structure 1")]
    public const int VK_KHR_acceleration_structure = 1;

    [NativeTypeName("#define VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION 13")]
    public const int VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION = 13;

    [NativeTypeName("#define VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME \"VK_KHR_acceleration_structure\"")]
    public static ReadOnlySpan<byte> VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME => "VK_KHR_acceleration_structure"u8;

    [NativeTypeName("#define VK_KHR_ray_tracing_pipeline 1")]
    public const int VK_KHR_ray_tracing_pipeline = 1;

    [NativeTypeName("#define VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION 1")]
    public const int VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME \"VK_KHR_ray_tracing_pipeline\"")]
    public static ReadOnlySpan<byte> VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME => "VK_KHR_ray_tracing_pipeline"u8;

    [NativeTypeName("#define VK_KHR_ray_query 1")]
    public const int VK_KHR_ray_query = 1;

    [NativeTypeName("#define VK_KHR_RAY_QUERY_SPEC_VERSION 1")]
    public const int VK_KHR_RAY_QUERY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_RAY_QUERY_EXTENSION_NAME \"VK_KHR_ray_query\"")]
    public static ReadOnlySpan<byte> VK_KHR_RAY_QUERY_EXTENSION_NAME => "VK_KHR_ray_query"u8;

    [NativeTypeName("#define VK_EXT_mesh_shader 1")]
    public const int VK_EXT_mesh_shader = 1;

    [NativeTypeName("#define VK_EXT_MESH_SHADER_SPEC_VERSION 1")]
    public const int VK_EXT_MESH_SHADER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_MESH_SHADER_EXTENSION_NAME \"VK_EXT_mesh_shader\"")]
    public static ReadOnlySpan<byte> VK_EXT_MESH_SHADER_EXTENSION_NAME => "VK_EXT_mesh_shader"u8;
}
