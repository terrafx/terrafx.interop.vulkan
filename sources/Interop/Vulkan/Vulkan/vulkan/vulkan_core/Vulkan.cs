// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan
{
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
        public static extern VkResult vkMapMemory(VkDevice device, VkDeviceMemory memory, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("VkMemoryMapFlags")] uint flags, void** ppData);

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
        public static extern VkResult vkWaitForFences(VkDevice device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] VkFence* pFences, VkBool32 waitAll, [NativeTypeName("uint64_t")] ulong timeout);

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
        public static extern VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, [NativeTypeName("VkDescriptorPoolResetFlags")] uint flags);

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
        public static extern void vkCmdSetBlendConstants(VkCommandBuffer commandBuffer, [NativeTypeName("const float [4]")] float* blendConstants);

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
        public static extern void vkTrimCommandPool(VkDevice device, VkCommandPool commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

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
        public static extern void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported);

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
        public static extern void vkGetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHR(VkDevice device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDeviceMaskKHR(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDispatchBaseKHR(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkTrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroupsKHR(VkInstance instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryFdKHR(VkDevice device, [NativeTypeName("const VkMemoryGetFdInfoKHR *")] VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, [NativeTypeName("VkExternalMemoryHandleTypeFlagBits")] VkExternalMemoryHandleTypeFlags handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkImportSemaphoreFdKHR(VkDevice device, [NativeTypeName("const VkImportSemaphoreFdInfoKHR *")] VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreFdKHR(VkDevice device, [NativeTypeName("const VkSemaphoreGetFdInfoKHR *")] VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorUpdateTemplateKHR(VkDevice device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass2KHR(VkDevice device, [NativeTypeName("const VkRenderPassCreateInfo2 *")] VkRenderPassCreateInfo2* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkSubpassBeginInfo *")] VkSubpassBeginInfo* pSubpassBeginInfo, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkSubpassEndInfo *")] VkSubpassEndInfo* pSubpassEndInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkImportFenceFdKHR(VkDevice device, [NativeTypeName("const VkImportFenceFdInfoKHR *")] VkImportFenceFdInfoKHR* pImportFenceFdInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetFenceFdKHR(VkDevice device, [NativeTypeName("const VkFenceGetFdInfoKHR *")] VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("uint32_t *")] uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkQueryPoolPerformanceCreateInfoKHR *")] VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, [NativeTypeName("uint32_t *")] uint* pNumPasses);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquireProfilingLockKHR(VkDevice device, [NativeTypeName("const VkAcquireProfilingLockInfoKHR *")] VkAcquireProfilingLockInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkReleaseProfilingLockKHR(VkDevice device);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayProperties2KHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkDisplayPlaneInfo2KHR *")] VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements2KHR(VkDevice device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements2KHR(VkDevice device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements2KHR(VkDevice device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateSamplerYcbcrConversionKHR(VkDevice device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory2KHR(VkDevice device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory2KHR(VkDevice device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDescriptorSetLayoutSupportKHR(VkDevice device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkBuffer countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkBuffer countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreCounterValueKHR(VkDevice device, VkSemaphore semaphore, [NativeTypeName("uint64_t *")] ulong* pValue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkWaitSemaphoresKHR(VkDevice device, [NativeTypeName("const VkSemaphoreWaitInfo *")] VkSemaphoreWaitInfo* pWaitInfo, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSignalSemaphoreKHR(VkDevice device, [NativeTypeName("const VkSemaphoreSignalInfo *")] VkSemaphoreSignalInfo* pSignalInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkExtent2D *")] VkExtent2D* pFragmentSize, [NativeTypeName("const VkFragmentShadingRateCombinerOpKHR [2]")] VkFragmentShadingRateCombinerOpKHR* combinerOps);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkWaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, [NativeTypeName("uint64_t")] ulong presentId, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddressKHR(VkDevice device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetBufferOpaqueCaptureAddressKHR(VkDevice device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong vkGetDeviceMemoryOpaqueCaptureAddressKHR(VkDevice device, [NativeTypeName("const VkDeviceMemoryOpaqueCaptureAddressInfo *")] VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDeferredOperationKHR(VkDevice device, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint vkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, [NativeTypeName("const VkPipelineInfoKHR *")] VkPipelineInfoKHR* pPipelineInfo, [NativeTypeName("uint32_t *")] uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_NONE_KHR = 0UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR = 0x00000001UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR = 0x00000002UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR = 0x00000004UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR = 0x00000008UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR = 0x00000010UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR = 0x00000020UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR = 0x00000040UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR = 0x00000080UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR = 0x00000100UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR = 0x00000200UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR = 0x00000400UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR = 0x00000800UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR = 0x00001000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR = 0x00001000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR = 0x00002000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_HOST_BIT_KHR = 0x00004000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR = 0x00008000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR = 0x00010000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_COPY_BIT_KHR = 0x100000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR = 0x200000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_BLIT_BIT_KHR = 0x400000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR = 0x800000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR = 0x1000000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR = 0x2000000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR = 0x4000000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT = 0x01000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 0x00040000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV = 0x00020000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV = 0x00400000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 0x02000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR = 0x00200000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV = 0x00200000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV = 0x02000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 0x00800000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV = 0x00080000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV = 0x00100000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI = 0x8000000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI = 0x10000000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_NONE_KHR = 0UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR = 0x00000001UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_INDEX_READ_BIT_KHR = 0x00000002UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR = 0x00000004UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_UNIFORM_READ_BIT_KHR = 0x00000008UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR = 0x00000010UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_READ_BIT_KHR = 0x00000020UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_WRITE_BIT_KHR = 0x00000040UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR = 0x00000080UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR = 0x00000100UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR = 0x00000200UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR = 0x00000400UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_TRANSFER_READ_BIT_KHR = 0x00000800UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR = 0x00001000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_HOST_READ_BIT_KHR = 0x00002000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_HOST_WRITE_BIT_KHR = 0x00004000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_MEMORY_READ_BIT_KHR = 0x00008000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_MEMORY_WRITE_BIT_KHR = 0x00010000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR = 0x100000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR = 0x200000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR = 0x400000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = 0x02000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = 0x04000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = 0x08000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT = 0x00100000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV = 0x00020000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV = 0x00040000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV = 0x00800000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR = 0x00200000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = 0x00400000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV = 0x00200000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV = 0x00400000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = 0x01000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = 0x00080000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI = 0x8000000000UL;

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, [NativeTypeName("const VkDependencyInfoKHR *")] VkDependencyInfoKHR* pDependencyInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdResetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, [NativeTypeName("VkPipelineStageFlags2KHR")] ulong stageMask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWaitEvents2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint eventCount, [NativeTypeName("const VkEvent *")] VkEvent* pEvents, [NativeTypeName("const VkDependencyInfoKHR *")] VkDependencyInfoKHR* pDependencyInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPipelineBarrier2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkDependencyInfoKHR *")] VkDependencyInfoKHR* pDependencyInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteTimestamp2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("VkPipelineStageFlags2KHR")] ulong stage, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkQueueSubmit2KHR(VkQueue queue, [NativeTypeName("uint32_t")] uint submitCount, [NativeTypeName("const VkSubmitInfo2KHR *")] VkSubmitInfo2KHR* pSubmits, VkFence fence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, [NativeTypeName("VkPipelineStageFlags2KHR")] ulong stage, VkBuffer dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("uint32_t")] uint marker);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetQueueCheckpointData2NV(VkQueue queue, [NativeTypeName("uint32_t *")] uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyBuffer2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyBufferInfo2KHR *")] VkCopyBufferInfo2KHR* pCopyBufferInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyImage2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyImageInfo2KHR *")] VkCopyImageInfo2KHR* pCopyImageInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyBufferToImageInfo2KHR *")] VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyImageToBufferInfo2KHR *")] VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBlitImage2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkBlitImageInfo2KHR *")] VkBlitImageInfo2KHR* pBlitImageInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdResolveImage2KHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkResolveImageInfo2KHR *")] VkResolveImageInfo2KHR* pResolveImageInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, [NativeTypeName("const VkDebugReportCallbackCreateInfoEXT *")] VkDebugReportCallbackCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, [NativeTypeName("uint64_t")] ulong @object, [NativeTypeName("size_t")] nuint location, [NativeTypeName("int32_t")] int messageCode, [NativeTypeName("const char *")] sbyte* pLayerPrefix, [NativeTypeName("const char *")] sbyte* pMessage);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, [NativeTypeName("const VkDebugMarkerObjectTagInfoEXT *")] VkDebugMarkerObjectTagInfoEXT* pTagInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, [NativeTypeName("const VkDebugMarkerObjectNameInfoEXT *")] VkDebugMarkerObjectNameInfoEXT* pNameInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] VkBuffer* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets, [NativeTypeName("const VkDeviceSize *")] ulong* pSizes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] VkBuffer* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] VkBuffer* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint query, VkQueryControlFlags flags, [NativeTypeName("uint32_t")] uint index);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("uint32_t")] uint index);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstInstance, VkBuffer counterBuffer, [NativeTypeName("VkDeviceSize")] ulong counterBufferOffset, [NativeTypeName("uint32_t")] uint counterOffset, [NativeTypeName("uint32_t")] uint vertexStride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateCuModuleNVX(VkDevice device, [NativeTypeName("const VkCuModuleCreateInfoNVX *")] VkCuModuleCreateInfoNVX* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateCuFunctionNVX(VkDevice device, [NativeTypeName("const VkCuFunctionCreateInfoNVX *")] VkCuFunctionCreateInfoNVX* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCuLaunchInfoNVX *")] VkCuLaunchInfoNVX* pLaunchInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint vkGetImageViewHandleNVX(VkDevice device, [NativeTypeName("const VkImageViewHandleInfoNVX *")] VkImageViewHandleInfoNVX* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkBuffer countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkBuffer countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, [NativeTypeName("VkShaderStageFlagBits")] VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, [NativeTypeName("size_t *")] nuint* pInfoSize, void* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, [NativeTypeName("const VkConditionalRenderingBeginInfoEXT *")] VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewportWScalingNV *")] VkViewportWScalingNV* pViewportWScalings);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, [NativeTypeName("const VkDisplayPowerInfoEXT *")] VkDisplayPowerInfoEXT* pDisplayPowerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkRegisterDeviceEventEXT(VkDevice device, [NativeTypeName("const VkDeviceEventInfoEXT *")] VkDeviceEventInfoEXT* pDeviceEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkFence* pFence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, [NativeTypeName("const VkDisplayEventInfoEXT *")] VkDisplayEventInfoEXT* pDisplayEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkFence* pFence);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, [NativeTypeName("VkSurfaceCounterFlagBitsEXT")] VkSurfaceCounterFlagsEXT counter, [NativeTypeName("uint64_t *")] ulong* pCounterValue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, [NativeTypeName("uint32_t *")] uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstDiscardRectangle, [NativeTypeName("uint32_t")] uint discardRectangleCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pDiscardRectangles);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkSetHdrMetadataEXT(VkDevice device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainKHR *")] VkSwapchainKHR* pSwapchains, [NativeTypeName("const VkHdrMetadataEXT *")] VkHdrMetadataEXT* pMetadata);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")] VkDebugUtilsObjectNameInfoEXT* pNameInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, [NativeTypeName("const VkDebugUtilsObjectTagInfoEXT *")] VkDebugUtilsObjectTagInfoEXT* pTagInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkQueueEndDebugUtilsLabelEXT(VkQueue queue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, [NativeTypeName("const VkDebugUtilsMessengerCreateInfoEXT *")] VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkSubmitDebugUtilsMessageEXT(VkInstance instance, [NativeTypeName("VkDebugUtilsMessageSeverityFlagBitsEXT")] VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, [NativeTypeName("const VkDebugUtilsMessengerCallbackDataEXT *")] VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, [NativeTypeName("const VkSampleLocationsInfoEXT *")] VkSampleLocationsInfoEXT* pSampleLocationsInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, [NativeTypeName("VkSampleCountFlagBits")] VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateValidationCacheEXT(VkDevice device, [NativeTypeName("const VkValidationCacheCreateInfoEXT *")] VkValidationCacheCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkValidationCacheEXT *")] VkValidationCacheEXT* pSrcCaches);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, [NativeTypeName("size_t *")] nuint* pDataSize, void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkShadingRatePaletteNV *")] VkShadingRatePaletteNV* pShadingRatePalettes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, [NativeTypeName("uint32_t")] uint customSampleOrderCount, [NativeTypeName("const VkCoarseSampleOrderCustomNV *")] VkCoarseSampleOrderCustomNV* pCustomSampleOrders);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateAccelerationStructureNV(VkDevice device, [NativeTypeName("const VkAccelerationStructureCreateInfoNV *")] VkAccelerationStructureCreateInfoNV* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, [NativeTypeName("const VkAccelerationStructureMemoryRequirementsInfoNV *")] VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, [NativeTypeName("VkMemoryRequirements2KHR *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindAccelerationStructureMemoryInfoNV *")] VkBindAccelerationStructureMemoryInfoNV* pBindInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, [NativeTypeName("const VkAccelerationStructureInfoNV *")] VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, [NativeTypeName("VkDeviceSize")] ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, [NativeTypeName("VkDeviceSize")] ulong scratchOffset);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingStride, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkRayTracingPipelineCreateInfoNV *")] VkRayTracingPipelineCreateInfoNV* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] nuint dataSize, void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesNV(VkDevice device, VkPipeline pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] nuint dataSize, void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, [NativeTypeName("size_t")] nuint dataSize, void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureNV *")] VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint firstQuery);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, [NativeTypeName("uint32_t")] uint shader);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, [NativeTypeName("VkExternalMemoryHandleTypeFlagBits")] VkExternalMemoryHandleTypeFlags handleType, [NativeTypeName("const void *")] void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, [NativeTypeName("VkPipelineStageFlagBits")] VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("uint32_t")] uint marker);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetCalibratedTimestampsEXT(VkDevice device, [NativeTypeName("uint32_t")] uint timestampCount, [NativeTypeName("const VkCalibratedTimestampInfoEXT *")] VkCalibratedTimestampInfoEXT* pTimestampInfos, [NativeTypeName("uint64_t *")] ulong* pTimestamps, [NativeTypeName("uint64_t *")] ulong* pMaxDeviation);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint taskCount, [NativeTypeName("uint32_t")] uint firstTask);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkBuffer countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstExclusiveScissor, [NativeTypeName("uint32_t")] uint exclusiveScissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pExclusiveScissors);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, [NativeTypeName("const void *")] void* pCheckpointMarker);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetQueueCheckpointDataNV(VkQueue queue, [NativeTypeName("uint32_t *")] uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkInitializePerformanceApiINTEL(VkDevice device, [NativeTypeName("const VkInitializePerformanceApiInfoINTEL *")] VkInitializePerformanceApiInfoINTEL* pInitializeInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkUninitializePerformanceApiINTEL(VkDevice device);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, [NativeTypeName("const VkPerformanceMarkerInfoINTEL *")] VkPerformanceMarkerInfoINTEL* pMarkerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, [NativeTypeName("const VkPerformanceStreamMarkerInfoINTEL *")] VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, [NativeTypeName("const VkPerformanceOverrideInfoINTEL *")] VkPerformanceOverrideInfoINTEL* pOverrideInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, [NativeTypeName("const VkPerformanceConfigurationAcquireInfoINTEL *")] VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddressEXT(VkDevice device, [NativeTypeName("const VkBufferDeviceAddressInfo *")] VkBufferDeviceAddressInfo* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t *")] uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, [NativeTypeName("const VkHeadlessSurfaceCreateInfoEXT *")] VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint lineStippleFactor, [NativeTypeName("uint16_t")] ushort lineStipplePattern);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkResetQueryPoolEXT(VkDevice device, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetCullModeEXT(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetFrontFaceEXT(VkCommandBuffer commandBuffer, VkFrontFace frontFace);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetPrimitiveTopologyEXT(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetViewportWithCountEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewport *")] VkViewport* pViewports);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetScissorWithCountEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint scissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pScissors);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] VkBuffer* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets, [NativeTypeName("const VkDeviceSize *")] ulong* pSizes, [NativeTypeName("const VkDeviceSize *")] ulong* pStrides);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthWriteEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthCompareOpEXT(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBoundsTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetStencilTestEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetStencilOpEXT(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, [NativeTypeName("const VkGeneratedCommandsMemoryRequirementsInfoNV *")] VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, [NativeTypeName("const VkGeneratedCommandsInfoNV *")] VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, [NativeTypeName("const VkGeneratedCommandsInfoNV *")] VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, [NativeTypeName("uint32_t")] uint groupIndex);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, [NativeTypeName("const VkIndirectCommandsLayoutCreateInfoNV *")] VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, [NativeTypeName("int32_t")] int drmFd, VkDisplayKHR display);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDrmDisplayEXT(VkPhysicalDevice physicalDevice, [NativeTypeName("int32_t")] int drmFd, [NativeTypeName("uint32_t")] uint connectorId, VkDisplayKHR* display);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreatePrivateDataSlotEXT(VkDevice device, [NativeTypeName("const VkPrivateDataSlotCreateInfoEXT *")] VkPrivateDataSlotCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPrivateDataSlotEXT* pPrivateDataSlot);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkSetPrivateDataEXT(VkDevice device, VkObjectType objectType, [NativeTypeName("uint64_t")] ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, [NativeTypeName("uint64_t")] ulong data);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetPrivateDataEXT(VkDevice device, VkObjectType objectType, [NativeTypeName("uint64_t")] ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, [NativeTypeName("uint64_t *")] ulong* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, [NativeTypeName("const VkFragmentShadingRateCombinerOpKHR [2]")] VkFragmentShadingRateCombinerOpKHR* combinerOps);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t")] uint deviceRelativeId, VkDisplayKHR* pDisplay);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint vertexBindingDescriptionCount, [NativeTypeName("const VkVertexInputBindingDescription2EXT *")] VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, [NativeTypeName("uint32_t")] uint vertexAttributeDescriptionCount, [NativeTypeName("const VkVertexInputAttributeDescription2EXT *")] VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryRemoteAddressNV(VkDevice device, [NativeTypeName("const VkMemoryGetRemoteAddressInfoNV *")] VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, [NativeTypeName("VkRemoteAddressNV *")] void** pAddress);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint patchControlPoints);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetRasterizerDiscardEnableEXT(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBiasEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetPrimitiveRestartEnableEXT(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint attachmentCount, [NativeTypeName("const VkBool32 *")] VkBool32* pColorWriteEnables);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("const VkMultiDrawInfoEXT *")] VkMultiDrawInfoEXT* pVertexInfo, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstInstance, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("const VkMultiDrawIndexedInfoEXT *")] VkMultiDrawIndexedInfoEXT* pIndexInfo, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstInstance, [NativeTypeName("uint32_t")] uint stride, [NativeTypeName("const int32_t *")] int* pVertexOffset);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateAccelerationStructureKHR(VkDevice device, [NativeTypeName("const VkAccelerationStructureCreateInfoKHR *")] VkAccelerationStructureCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint infoCount, [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")] VkAccelerationStructureBuildGeometryInfoKHR* pInfos, [NativeTypeName("const VkAccelerationStructureBuildRangeInfoKHR *const *")] VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint infoCount, [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")] VkAccelerationStructureBuildGeometryInfoKHR* pInfos, [NativeTypeName("const VkDeviceAddress *")] ulong* pIndirectDeviceAddresses, [NativeTypeName("const uint32_t *")] uint* pIndirectStrides, [NativeTypeName("const uint32_t *const *")] uint** ppMaxPrimitiveCounts);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, [NativeTypeName("uint32_t")] uint infoCount, [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")] VkAccelerationStructureBuildGeometryInfoKHR* pInfos, [NativeTypeName("const VkAccelerationStructureBuildRangeInfoKHR *const *")] VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, [NativeTypeName("const VkCopyAccelerationStructureInfoKHR *")] VkCopyAccelerationStructureInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, [NativeTypeName("const VkCopyAccelerationStructureToMemoryInfoKHR *")] VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, [NativeTypeName("const VkCopyMemoryToAccelerationStructureInfoKHR *")] VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureKHR *")] VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("size_t")] nuint dataSize, void* pData, [NativeTypeName("size_t")] nuint stride);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyAccelerationStructureInfoKHR *")] VkCopyAccelerationStructureInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyAccelerationStructureToMemoryInfoKHR *")] VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkCopyMemoryToAccelerationStructureInfoKHR *")] VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, [NativeTypeName("const VkAccelerationStructureDeviceAddressInfoKHR *")] VkAccelerationStructureDeviceAddressInfoKHR* pInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureKHR *")] VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, [NativeTypeName("uint32_t")] uint firstQuery);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, [NativeTypeName("const VkAccelerationStructureVersionInfoKHR *")] VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")] VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, [NativeTypeName("const uint32_t *")] uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")] VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")] VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")] VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")] VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkRayTracingPipelineCreateInfoKHR *")] VkRayTracingPipelineCreateInfoKHR* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] nuint dataSize, void* pData);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")] VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")] VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")] VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, [NativeTypeName("const VkStridedDeviceAddressRegionKHR *")] VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, [NativeTypeName("VkDeviceAddress")] ulong indirectDeviceAddress);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceSize")]
        public static extern ulong vkGetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, [NativeTypeName("uint32_t")] uint group, VkShaderGroupShaderKHR groupShader);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, [NativeTypeName("uint32_t")] uint pipelineStackSize);

        [NativeTypeName("#define VK_VERSION_1_0 1")]
        public const int VK_VERSION_1_0 = 1;

        [NativeTypeName("#define VK_USE_64_BIT_PTR_DEFINES 1")]
        public const int VK_USE_64_BIT_PTR_DEFINES = 1;

        [NativeTypeName("#define VK_API_VERSION_1_0 VK_MAKE_API_VERSION(0, 1, 0, 0)")]
        public const uint VK_API_VERSION_1_0 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(0)) << 12) | ((uint)(0)));

        [NativeTypeName("#define VK_HEADER_VERSION 189")]
        public const int VK_HEADER_VERSION = 189;

        [NativeTypeName("#define VK_HEADER_VERSION_COMPLETE VK_MAKE_API_VERSION(0, 1, 2, VK_HEADER_VERSION)")]
        public const uint VK_HEADER_VERSION_COMPLETE = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(2)) << 12) | ((uint)(189)));

        [NativeTypeName("#define VK_UUID_SIZE 16U")]
        public const uint VK_UUID_SIZE = 16U;

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

        [NativeTypeName("#define VK_MAX_MEMORY_HEAPS 16U")]
        public const uint VK_MAX_MEMORY_HEAPS = 16U;

        [NativeTypeName("#define VK_MAX_PHYSICAL_DEVICE_NAME_SIZE 256U")]
        public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256U;

        [NativeTypeName("#define VK_MAX_EXTENSION_NAME_SIZE 256U")]
        public const uint VK_MAX_EXTENSION_NAME_SIZE = 256U;

        [NativeTypeName("#define VK_MAX_DESCRIPTION_SIZE 256U")]
        public const uint VK_MAX_DESCRIPTION_SIZE = 256U;

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
        public const uint VK_MAX_DEVICE_GROUP_SIZE_KHR = 32U;

        [NativeTypeName("#define VK_KHR_external_memory_capabilities 1")]
        public const int VK_KHR_external_memory_capabilities = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_memory_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x63, 0x61, 0x70, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_LUID_SIZE_KHR VK_LUID_SIZE")]
        public const uint VK_LUID_SIZE_KHR = 8U;

        [NativeTypeName("#define VK_KHR_external_memory 1")]
        public const int VK_KHR_external_memory = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_KHR_external_memory\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_QUEUE_FAMILY_EXTERNAL_KHR VK_QUEUE_FAMILY_EXTERNAL")]
        public const uint VK_QUEUE_FAMILY_EXTERNAL_KHR = (~1U);

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

        [NativeTypeName("#define VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION 2")]
        public const int VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION = 2;

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
        public const uint VK_MAX_DRIVER_NAME_SIZE_KHR = 256U;

        [NativeTypeName("#define VK_MAX_DRIVER_INFO_SIZE_KHR VK_MAX_DRIVER_INFO_SIZE")]
        public const uint VK_MAX_DRIVER_INFO_SIZE_KHR = 256U;

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

        [NativeTypeName("#define VK_KHR_shader_terminate_invocation 1")]
        public const int VK_KHR_shader_terminate_invocation = 1;

        [NativeTypeName("#define VK_KHR_SHADER_TERMINATE_INVOCATION_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_TERMINATE_INVOCATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_TERMINATE_INVOCATION_EXTENSION_NAME \"VK_KHR_shader_terminate_invocation\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_TERMINATE_INVOCATION_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x74, 0x65, 0x72, 0x6D, 0x69, 0x6E, 0x61, 0x74, 0x65, 0x5F, 0x69, 0x6E, 0x76, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define VK_KHR_fragment_shading_rate 1")]
        public const int VK_KHR_fragment_shading_rate = 1;

        [NativeTypeName("#define VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION 1")]
        public const int VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME \"VK_KHR_fragment_shading_rate\"")]
        public static ReadOnlySpan<byte> VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x69, 0x6E, 0x67, 0x5F, 0x72, 0x61, 0x74, 0x65, 0x00 };

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

        [NativeTypeName("#define VK_KHR_present_wait 1")]
        public const int VK_KHR_present_wait = 1;

        [NativeTypeName("#define VK_KHR_PRESENT_WAIT_SPEC_VERSION 1")]
        public const int VK_KHR_PRESENT_WAIT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PRESENT_WAIT_EXTENSION_NAME \"VK_KHR_present_wait\"")]
        public static ReadOnlySpan<byte> VK_KHR_PRESENT_WAIT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x72, 0x65, 0x73, 0x65, 0x6E, 0x74, 0x5F, 0x77, 0x61, 0x69, 0x74, 0x00 };

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

        [NativeTypeName("#define VK_KHR_deferred_host_operations 1")]
        public const int VK_KHR_deferred_host_operations = 1;

        [NativeTypeName("#define VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION 4")]
        public const int VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME \"VK_KHR_deferred_host_operations\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x65, 0x66, 0x65, 0x72, 0x72, 0x65, 0x64, 0x5F, 0x68, 0x6F, 0x73, 0x74, 0x5F, 0x6F, 0x70, 0x65, 0x72, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_pipeline_executable_properties 1")]
        public const int VK_KHR_pipeline_executable_properties = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION 1")]
        public const int VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME \"VK_KHR_pipeline_executable_properties\"")]
        public static ReadOnlySpan<byte> VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x65, 0x78, 0x65, 0x63, 0x75, 0x74, 0x61, 0x62, 0x6C, 0x65, 0x5F, 0x70, 0x72, 0x6F, 0x70, 0x65, 0x72, 0x74, 0x69, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define VK_KHR_pipeline_library 1")]
        public const int VK_KHR_pipeline_library = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION 1")]
        public const int VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME \"VK_KHR_pipeline_library\"")]
        public static ReadOnlySpan<byte> VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x6C, 0x69, 0x62, 0x72, 0x61, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_KHR_shader_non_semantic_info 1")]
        public const int VK_KHR_shader_non_semantic_info = 1;

        [NativeTypeName("#define VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME \"VK_KHR_shader_non_semantic_info\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x6E, 0x6F, 0x6E, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x6E, 0x74, 0x69, 0x63, 0x5F, 0x69, 0x6E, 0x66, 0x6F, 0x00 };

        [NativeTypeName("#define VK_KHR_present_id 1")]
        public const int VK_KHR_present_id = 1;

        [NativeTypeName("#define VK_KHR_PRESENT_ID_SPEC_VERSION 1")]
        public const int VK_KHR_PRESENT_ID_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PRESENT_ID_EXTENSION_NAME \"VK_KHR_present_id\"")]
        public static ReadOnlySpan<byte> VK_KHR_PRESENT_ID_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x72, 0x65, 0x73, 0x65, 0x6E, 0x74, 0x5F, 0x69, 0x64, 0x00 };

        [NativeTypeName("#define VK_KHR_synchronization2 1")]
        public const int VK_KHR_synchronization2 = 1;

        [NativeTypeName("#define VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION 1")]
        public const int VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME \"VK_KHR_synchronization2\"")]
        public static ReadOnlySpan<byte> VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x79, 0x6E, 0x63, 0x68, 0x72, 0x6F, 0x6E, 0x69, 0x7A, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_shader_subgroup_uniform_control_flow 1")]
        public const int VK_KHR_shader_subgroup_uniform_control_flow = 1;

        [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME \"VK_KHR_shader_subgroup_uniform_control_flow\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x73, 0x75, 0x62, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x75, 0x6E, 0x69, 0x66, 0x6F, 0x72, 0x6D, 0x5F, 0x63, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x5F, 0x66, 0x6C, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define VK_KHR_zero_initialize_workgroup_memory 1")]
        public const int VK_KHR_zero_initialize_workgroup_memory = 1;

        [NativeTypeName("#define VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION 1")]
        public const int VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME \"VK_KHR_zero_initialize_workgroup_memory\"")]
        public static ReadOnlySpan<byte> VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x7A, 0x65, 0x72, 0x6F, 0x5F, 0x69, 0x6E, 0x69, 0x74, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x5F, 0x77, 0x6F, 0x72, 0x6B, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_KHR_workgroup_memory_explicit_layout 1")]
        public const int VK_KHR_workgroup_memory_explicit_layout = 1;

        [NativeTypeName("#define VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION 1")]
        public const int VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME \"VK_KHR_workgroup_memory_explicit_layout\"")]
        public static ReadOnlySpan<byte> VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x77, 0x6F, 0x72, 0x6B, 0x67, 0x72, 0x6F, 0x75, 0x70, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x65, 0x78, 0x70, 0x6C, 0x69, 0x63, 0x69, 0x74, 0x5F, 0x6C, 0x61, 0x79, 0x6F, 0x75, 0x74, 0x00 };

        [NativeTypeName("#define VK_KHR_copy_commands2 1")]
        public const int VK_KHR_copy_commands2 = 1;

        [NativeTypeName("#define VK_KHR_COPY_COMMANDS_2_SPEC_VERSION 1")]
        public const int VK_KHR_COPY_COMMANDS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME \"VK_KHR_copy_commands2\"")]
        public static ReadOnlySpan<byte> VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x63, 0x6F, 0x70, 0x79, 0x5F, 0x63, 0x6F, 0x6D, 0x6D, 0x61, 0x6E, 0x64, 0x73, 0x32, 0x00 };

        [NativeTypeName("#define VK_EXT_debug_report 1")]
        public const int VK_EXT_debug_report = 1;

        [NativeTypeName("#define VK_EXT_DEBUG_REPORT_SPEC_VERSION 10")]
        public const int VK_EXT_DEBUG_REPORT_SPEC_VERSION = 10;

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

        [NativeTypeName("#define VK_NVX_binary_import 1")]
        public const int VK_NVX_binary_import = 1;

        [NativeTypeName("#define VK_NVX_BINARY_IMPORT_SPEC_VERSION 1")]
        public const int VK_NVX_BINARY_IMPORT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NVX_BINARY_IMPORT_EXTENSION_NAME \"VK_NVX_binary_import\"")]
        public static ReadOnlySpan<byte> VK_NVX_BINARY_IMPORT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x58, 0x5F, 0x62, 0x69, 0x6E, 0x61, 0x72, 0x79, 0x5F, 0x69, 0x6D, 0x70, 0x6F, 0x72, 0x74, 0x00 };

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

        [NativeTypeName("#define VK_QUEUE_FAMILY_FOREIGN_EXT (~2U)")]
        public const uint VK_QUEUE_FAMILY_FOREIGN_EXT = (~2U);

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

        [NativeTypeName("#define VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION 2")]
        public const int VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION = 2;

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

        [NativeTypeName("#define VK_EXT_shader_image_atomic_int64 1")]
        public const int VK_EXT_shader_image_atomic_int64 = 1;

        [NativeTypeName("#define VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME \"VK_EXT_shader_image_atomic_int64\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x61, 0x74, 0x6F, 0x6D, 0x69, 0x63, 0x5F, 0x69, 0x6E, 0x74, 0x36, 0x34, 0x00 };

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

        [NativeTypeName("#define VK_EXT_VALIDATION_FEATURES_SPEC_VERSION 5")]
        public const int VK_EXT_VALIDATION_FEATURES_SPEC_VERSION = 5;

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

        [NativeTypeName("#define VK_EXT_provoking_vertex 1")]
        public const int VK_EXT_provoking_vertex = 1;

        [NativeTypeName("#define VK_EXT_PROVOKING_VERTEX_SPEC_VERSION 1")]
        public const int VK_EXT_PROVOKING_VERTEX_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME \"VK_EXT_provoking_vertex\"")]
        public static ReadOnlySpan<byte> VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x70, 0x72, 0x6F, 0x76, 0x6F, 0x6B, 0x69, 0x6E, 0x67, 0x5F, 0x76, 0x65, 0x72, 0x74, 0x65, 0x78, 0x00 };

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

        [NativeTypeName("#define VK_EXT_shader_atomic_float2 1")]
        public const int VK_EXT_shader_atomic_float2 = 1;

        [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_2_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_ATOMIC_FLOAT_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_2_EXTENSION_NAME \"VK_EXT_shader_atomic_float2\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_ATOMIC_FLOAT_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x5F, 0x61, 0x74, 0x6F, 0x6D, 0x69, 0x63, 0x5F, 0x66, 0x6C, 0x6F, 0x61, 0x74, 0x32, 0x00 };

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

        [NativeTypeName("#define VK_NV_inherited_viewport_scissor 1")]
        public const int VK_NV_inherited_viewport_scissor = 1;

        [NativeTypeName("#define VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION 1")]
        public const int VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME \"VK_NV_inherited_viewport_scissor\"")]
        public static ReadOnlySpan<byte> VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x69, 0x6E, 0x68, 0x65, 0x72, 0x69, 0x74, 0x65, 0x64, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x70, 0x6F, 0x72, 0x74, 0x5F, 0x73, 0x63, 0x69, 0x73, 0x73, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_texel_buffer_alignment 1")]
        public const int VK_EXT_texel_buffer_alignment = 1;

        [NativeTypeName("#define VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION 1")]
        public const int VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME \"VK_EXT_texel_buffer_alignment\"")]
        public static ReadOnlySpan<byte> VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x74, 0x65, 0x78, 0x65, 0x6C, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x5F, 0x61, 0x6C, 0x69, 0x67, 0x6E, 0x6D, 0x65, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define VK_QCOM_render_pass_transform 1")]
        public const int VK_QCOM_render_pass_transform = 1;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION 2")]
        public const int VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME \"VK_QCOM_render_pass_transform\"")]
        public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x51, 0x43, 0x4F, 0x4D, 0x5F, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x5F, 0x70, 0x61, 0x73, 0x73, 0x5F, 0x74, 0x72, 0x61, 0x6E, 0x73, 0x66, 0x6F, 0x72, 0x6D, 0x00 };

        [NativeTypeName("#define VK_EXT_device_memory_report 1")]
        public const int VK_EXT_device_memory_report = 1;

        [NativeTypeName("#define VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION 2")]
        public const int VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME \"VK_EXT_device_memory_report\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x72, 0x65, 0x70, 0x6F, 0x72, 0x74, 0x00 };

        [NativeTypeName("#define VK_EXT_acquire_drm_display 1")]
        public const int VK_EXT_acquire_drm_display = 1;

        [NativeTypeName("#define VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION 1")]
        public const int VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME \"VK_EXT_acquire_drm_display\"")]
        public static ReadOnlySpan<byte> VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x61, 0x63, 0x71, 0x75, 0x69, 0x72, 0x65, 0x5F, 0x64, 0x72, 0x6D, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };

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

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION 2")]
        public const int VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME \"VK_QCOM_render_pass_store_ops\"")]
        public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x51, 0x43, 0x4F, 0x4D, 0x5F, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x5F, 0x70, 0x61, 0x73, 0x73, 0x5F, 0x73, 0x74, 0x6F, 0x72, 0x65, 0x5F, 0x6F, 0x70, 0x73, 0x00 };

        [NativeTypeName("#define VK_NV_fragment_shading_rate_enums 1")]
        public const int VK_NV_fragment_shading_rate_enums = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION 1")]
        public const int VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME \"VK_NV_fragment_shading_rate_enums\"")]
        public static ReadOnlySpan<byte> VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x69, 0x6E, 0x67, 0x5F, 0x72, 0x61, 0x74, 0x65, 0x5F, 0x65, 0x6E, 0x75, 0x6D, 0x73, 0x00 };

        [NativeTypeName("#define VK_NV_ray_tracing_motion_blur 1")]
        public const int VK_NV_ray_tracing_motion_blur = 1;

        [NativeTypeName("#define VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION 1")]
        public const int VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME \"VK_NV_ray_tracing_motion_blur\"")]
        public static ReadOnlySpan<byte> VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x72, 0x61, 0x79, 0x5F, 0x74, 0x72, 0x61, 0x63, 0x69, 0x6E, 0x67, 0x5F, 0x6D, 0x6F, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x62, 0x6C, 0x75, 0x72, 0x00 };

        [NativeTypeName("#define VK_EXT_ycbcr_2plane_444_formats 1")]
        public const int VK_EXT_ycbcr_2plane_444_formats = 1;

        [NativeTypeName("#define VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION 1")]
        public const int VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME \"VK_EXT_ycbcr_2plane_444_formats\"")]
        public static ReadOnlySpan<byte> VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x79, 0x63, 0x62, 0x63, 0x72, 0x5F, 0x32, 0x70, 0x6C, 0x61, 0x6E, 0x65, 0x5F, 0x34, 0x34, 0x34, 0x5F, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x73, 0x00 };

        [NativeTypeName("#define VK_EXT_fragment_density_map2 1")]
        public const int VK_EXT_fragment_density_map2 = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION 1")]
        public const int VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME \"VK_EXT_fragment_density_map2\"")]
        public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x66, 0x72, 0x61, 0x67, 0x6D, 0x65, 0x6E, 0x74, 0x5F, 0x64, 0x65, 0x6E, 0x73, 0x69, 0x74, 0x79, 0x5F, 0x6D, 0x61, 0x70, 0x32, 0x00 };

        [NativeTypeName("#define VK_QCOM_rotated_copy_commands 1")]
        public const int VK_QCOM_rotated_copy_commands = 1;

        [NativeTypeName("#define VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION 1")]
        public const int VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME \"VK_QCOM_rotated_copy_commands\"")]
        public static ReadOnlySpan<byte> VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x51, 0x43, 0x4F, 0x4D, 0x5F, 0x72, 0x6F, 0x74, 0x61, 0x74, 0x65, 0x64, 0x5F, 0x63, 0x6F, 0x70, 0x79, 0x5F, 0x63, 0x6F, 0x6D, 0x6D, 0x61, 0x6E, 0x64, 0x73, 0x00 };

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

        [NativeTypeName("#define VK_NV_acquire_winrt_display 1")]
        public const int VK_NV_acquire_winrt_display = 1;

        [NativeTypeName("#define VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION 1")]
        public const int VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME \"VK_NV_acquire_winrt_display\"")]
        public static ReadOnlySpan<byte> VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x61, 0x63, 0x71, 0x75, 0x69, 0x72, 0x65, 0x5F, 0x77, 0x69, 0x6E, 0x72, 0x74, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };

        [NativeTypeName("#define VK_VALVE_mutable_descriptor_type 1")]
        public const int VK_VALVE_mutable_descriptor_type = 1;

        [NativeTypeName("#define VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION 1")]
        public const int VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME \"VK_VALVE_mutable_descriptor_type\"")]
        public static ReadOnlySpan<byte> VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x56, 0x41, 0x4C, 0x56, 0x45, 0x5F, 0x6D, 0x75, 0x74, 0x61, 0x62, 0x6C, 0x65, 0x5F, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x6F, 0x72, 0x5F, 0x74, 0x79, 0x70, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_vertex_input_dynamic_state 1")]
        public const int VK_EXT_vertex_input_dynamic_state = 1;

        [NativeTypeName("#define VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION 2")]
        public const int VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME \"VK_EXT_vertex_input_dynamic_state\"")]
        public static ReadOnlySpan<byte> VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x76, 0x65, 0x72, 0x74, 0x65, 0x78, 0x5F, 0x69, 0x6E, 0x70, 0x75, 0x74, 0x5F, 0x64, 0x79, 0x6E, 0x61, 0x6D, 0x69, 0x63, 0x5F, 0x73, 0x74, 0x61, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_physical_device_drm 1")]
        public const int VK_EXT_physical_device_drm = 1;

        [NativeTypeName("#define VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION 1")]
        public const int VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME \"VK_EXT_physical_device_drm\"")]
        public static ReadOnlySpan<byte> VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x70, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x5F, 0x64, 0x72, 0x6D, 0x00 };

        [NativeTypeName("#define VK_HUAWEI_subpass_shading 1")]
        public const int VK_HUAWEI_subpass_shading = 1;

        [NativeTypeName("#define VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION 2")]
        public const int VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME \"VK_HUAWEI_subpass_shading\"")]
        public static ReadOnlySpan<byte> VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x48, 0x55, 0x41, 0x57, 0x45, 0x49, 0x5F, 0x73, 0x75, 0x62, 0x70, 0x61, 0x73, 0x73, 0x5F, 0x73, 0x68, 0x61, 0x64, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define VK_HUAWEI_invocation_mask 1")]
        public const int VK_HUAWEI_invocation_mask = 1;

        [NativeTypeName("#define VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION 1")]
        public const int VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME \"VK_HUAWEI_invocation_mask\"")]
        public static ReadOnlySpan<byte> VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x48, 0x55, 0x41, 0x57, 0x45, 0x49, 0x5F, 0x69, 0x6E, 0x76, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x6D, 0x61, 0x73, 0x6B, 0x00 };

        [NativeTypeName("#define VK_NV_external_memory_rdma 1")]
        public const int VK_NV_external_memory_rdma = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION 1")]
        public const int VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME \"VK_NV_external_memory_rdma\"")]
        public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x72, 0x64, 0x6D, 0x61, 0x00 };

        [NativeTypeName("#define VK_EXT_extended_dynamic_state2 1")]
        public const int VK_EXT_extended_dynamic_state2 = 1;

        [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION 1")]
        public const int VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME \"VK_EXT_extended_dynamic_state2\"")]
        public static ReadOnlySpan<byte> VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x6E, 0x64, 0x65, 0x64, 0x5F, 0x64, 0x79, 0x6E, 0x61, 0x6D, 0x69, 0x63, 0x5F, 0x73, 0x74, 0x61, 0x74, 0x65, 0x32, 0x00 };

        [NativeTypeName("#define VK_EXT_color_write_enable 1")]
        public const int VK_EXT_color_write_enable = 1;

        [NativeTypeName("#define VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION 1")]
        public const int VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME \"VK_EXT_color_write_enable\"")]
        public static ReadOnlySpan<byte> VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x5F, 0x77, 0x72, 0x69, 0x74, 0x65, 0x5F, 0x65, 0x6E, 0x61, 0x62, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_global_priority_query 1")]
        public const int VK_EXT_global_priority_query = 1;

        [NativeTypeName("#define VK_MAX_GLOBAL_PRIORITY_SIZE_EXT 16U")]
        public const uint VK_MAX_GLOBAL_PRIORITY_SIZE_EXT = 16U;

        [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION 1")]
        public const int VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME \"VK_EXT_global_priority_query\"")]
        public static ReadOnlySpan<byte> VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x67, 0x6C, 0x6F, 0x62, 0x61, 0x6C, 0x5F, 0x70, 0x72, 0x69, 0x6F, 0x72, 0x69, 0x74, 0x79, 0x5F, 0x71, 0x75, 0x65, 0x72, 0x79, 0x00 };

        [NativeTypeName("#define VK_EXT_multi_draw 1")]
        public const int VK_EXT_multi_draw = 1;

        [NativeTypeName("#define VK_EXT_MULTI_DRAW_SPEC_VERSION 1")]
        public const int VK_EXT_MULTI_DRAW_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_MULTI_DRAW_EXTENSION_NAME \"VK_EXT_multi_draw\"")]
        public static ReadOnlySpan<byte> VK_EXT_MULTI_DRAW_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x6D, 0x75, 0x6C, 0x74, 0x69, 0x5F, 0x64, 0x72, 0x61, 0x77, 0x00 };

        [NativeTypeName("#define VK_EXT_load_store_op_none 1")]
        public const int VK_EXT_load_store_op_none = 1;

        [NativeTypeName("#define VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION 1")]
        public const int VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME \"VK_EXT_load_store_op_none\"")]
        public static ReadOnlySpan<byte> VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x6C, 0x6F, 0x61, 0x64, 0x5F, 0x73, 0x74, 0x6F, 0x72, 0x65, 0x5F, 0x6F, 0x70, 0x5F, 0x6E, 0x6F, 0x6E, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_acceleration_structure 1")]
        public const int VK_KHR_acceleration_structure = 1;

        [NativeTypeName("#define VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION 12")]
        public const int VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION = 12;

        [NativeTypeName("#define VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME \"VK_KHR_acceleration_structure\"")]
        public static ReadOnlySpan<byte> VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x61, 0x63, 0x63, 0x65, 0x6C, 0x65, 0x72, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x5F, 0x73, 0x74, 0x72, 0x75, 0x63, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_ray_tracing_pipeline 1")]
        public const int VK_KHR_ray_tracing_pipeline = 1;

        [NativeTypeName("#define VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION 1")]
        public const int VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME \"VK_KHR_ray_tracing_pipeline\"")]
        public static ReadOnlySpan<byte> VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x72, 0x61, 0x79, 0x5F, 0x74, 0x72, 0x61, 0x63, 0x69, 0x6E, 0x67, 0x5F, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_ray_query 1")]
        public const int VK_KHR_ray_query = 1;

        [NativeTypeName("#define VK_KHR_RAY_QUERY_SPEC_VERSION 1")]
        public const int VK_KHR_RAY_QUERY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_RAY_QUERY_EXTENSION_NAME \"VK_KHR_ray_query\"")]
        public static ReadOnlySpan<byte> VK_KHR_RAY_QUERY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x72, 0x61, 0x79, 0x5F, 0x71, 0x75, 0x65, 0x72, 0x79, 0x00 };
    }
}
