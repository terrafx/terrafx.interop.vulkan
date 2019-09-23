// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(libraryPath, EntryPoint = "vkCreateInstance", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateInstance([NativeTypeName("const VkInstanceCreateInfo *")] VkInstanceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkInstance *")] IntPtr* pInstance);

        [DllImport(libraryPath, EntryPoint = "vkDestroyInstance", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyInstance([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkEnumeratePhysicalDevices", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumeratePhysicalDevices([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceCount, [NativeTypeName("VkPhysicalDevice *")] IntPtr* pPhysicalDevices);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceFeatures", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures *")] VkPhysicalDeviceFeatures* pFeatures);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceFormatProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties *")] VkFormatProperties* pFormatProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, [NativeTypeName("VkImageUsageFlags")] uint usage, [NativeTypeName("VkImageCreateFlags")] uint flags, [NativeTypeName("VkImageFormatProperties *")] VkImageFormatProperties* pImageFormatProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties *")] VkPhysicalDeviceProperties* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties *")] VkQueueFamilyProperties* pQueueFamilyProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceMemoryProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties *")] VkPhysicalDeviceMemoryProperties* pMemoryProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetInstanceProcAddr", CallingConvention = CallingConvention.Winapi)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern IntPtr vkGetInstanceProcAddr([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport(libraryPath, EntryPoint = "vkGetDeviceProcAddr", CallingConvention = CallingConvention.Winapi)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern IntPtr vkGetDeviceProcAddr([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport(libraryPath, EntryPoint = "vkCreateDevice", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDevice([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkDeviceCreateInfo *")] VkDeviceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDevice *")] IntPtr* pDevice);

        [DllImport(libraryPath, EntryPoint = "vkDestroyDevice", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDevice([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkEnumerateInstanceExtensionProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateInstanceExtensionProperties([NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkExtensionProperties *")] VkExtensionProperties* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkEnumerateDeviceExtensionProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateDeviceExtensionProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkExtensionProperties *")] VkExtensionProperties* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkEnumerateInstanceLayerProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateInstanceLayerProperties([NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkEnumerateDeviceLayerProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateDeviceLayerProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetDeviceQueue", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("uint32_t")] uint queueIndex, [NativeTypeName("VkQueue *")] IntPtr* pQueue);

        [DllImport(libraryPath, EntryPoint = "vkQueueSubmit", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueueSubmit([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t")] uint submitCount, [NativeTypeName("const VkSubmitInfo *")] VkSubmitInfo* pSubmits, [NativeTypeName("VkFence")] ulong fence);

        [DllImport(libraryPath, EntryPoint = "vkQueueWaitIdle", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueueWaitIdle([NativeTypeName("VkQueue")] IntPtr queue);

        [DllImport(libraryPath, EntryPoint = "vkDeviceWaitIdle", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkDeviceWaitIdle([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport(libraryPath, EntryPoint = "vkAllocateMemory", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAllocateMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryAllocateInfo *")] VkMemoryAllocateInfo* pAllocateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDeviceMemory *")] ulong* pMemory);

        [DllImport(libraryPath, EntryPoint = "vkFreeMemory", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkMapMemory", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkMapMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("VkMemoryMapFlags")] uint flags, [NativeTypeName("void **")] void** ppData);

        [DllImport(libraryPath, EntryPoint = "vkUnmapMemory", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUnmapMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory);

        [DllImport(libraryPath, EntryPoint = "vkFlushMappedMemoryRanges", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkFlushMappedMemoryRanges([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

        [DllImport(libraryPath, EntryPoint = "vkInvalidateMappedMemoryRanges", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkInvalidateMappedMemoryRanges([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

        [DllImport(libraryPath, EntryPoint = "vkGetDeviceMemoryCommitment", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceMemoryCommitment([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize *")] ulong* pCommittedMemoryInBytes);

        [DllImport(libraryPath, EntryPoint = "vkBindBufferMemory", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindBufferMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

        [DllImport(libraryPath, EntryPoint = "vkBindImageMemory", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindImageMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

        [DllImport(libraryPath, EntryPoint = "vkGetBufferMemoryRequirements", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkMemoryRequirements *")] VkMemoryRequirements* pMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkGetImageMemoryRequirements", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkMemoryRequirements *")] VkMemoryRequirements* pMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkGetImageSparseMemoryRequirements", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements *")] VkSparseImageMemoryRequirements* pSparseMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, [NativeTypeName("VkImageUsageFlags")] uint usage, VkImageTiling tiling, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties *")] VkSparseImageFormatProperties* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkQueueBindSparse", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueueBindSparse([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindSparseInfo *")] VkBindSparseInfo* pBindInfo, [NativeTypeName("VkFence")] ulong fence);

        [DllImport(libraryPath, EntryPoint = "vkCreateFence", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateFence([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceCreateInfo *")] VkFenceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport(libraryPath, EntryPoint = "vkDestroyFence", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFence([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFence")] ulong fence, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkResetFences", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetFences([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] ulong* pFences);

        [DllImport(libraryPath, EntryPoint = "vkGetFenceStatus", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetFenceStatus([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFence")] ulong fence);

        [DllImport(libraryPath, EntryPoint = "vkWaitForFences", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkWaitForFences([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] ulong* pFences, [NativeTypeName("VkBool32")] uint waitAll, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport(libraryPath, EntryPoint = "vkCreateSemaphore", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreCreateInfo *")] VkSemaphoreCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSemaphore *")] ulong* pSemaphore);

        [DllImport(libraryPath, EntryPoint = "vkDestroySemaphore", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateEvent", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkEventCreateInfo *")] VkEventCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkEvent *")] ulong* pEvent);

        [DllImport(libraryPath, EntryPoint = "vkDestroyEvent", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkGetEventStatus", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetEventStatus([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport(libraryPath, EntryPoint = "vkSetEvent", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkSetEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport(libraryPath, EntryPoint = "vkResetEvent", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport(libraryPath, EntryPoint = "vkCreateQueryPool", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkQueryPoolCreateInfo *")] VkQueryPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkQueryPool *")] ulong* pQueryPool);

        [DllImport(libraryPath, EntryPoint = "vkDestroyQueryPool", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkGetQueryPoolResults", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetQueryPoolResults([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("size_t")] UIntPtr dataSize, [NativeTypeName("void *")] void* pData, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);

        [DllImport(libraryPath, EntryPoint = "vkCreateBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateBuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferCreateInfo *")] VkBufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkBuffer *")] ulong* pBuffer);

        [DllImport(libraryPath, EntryPoint = "vkDestroyBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateBufferView", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateBufferView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferViewCreateInfo *")] VkBufferViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkBufferView *")] ulong* pView);

        [DllImport(libraryPath, EntryPoint = "vkDestroyBufferView", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBufferView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBufferView")] ulong bufferView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateImage", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateImage([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageCreateInfo *")] VkImageCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkImage *")] ulong* pImage);

        [DllImport(libraryPath, EntryPoint = "vkDestroyImage", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImage([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkGetImageSubresourceLayout", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSubresourceLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("const VkImageSubresource *")] VkImageSubresource* pSubresource, [NativeTypeName("VkSubresourceLayout *")] VkSubresourceLayout* pLayout);

        [DllImport(libraryPath, EntryPoint = "vkCreateImageView", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateImageView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageViewCreateInfo *")] VkImageViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkImageView *")] ulong* pView);

        [DllImport(libraryPath, EntryPoint = "vkDestroyImageView", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImageView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImageView")] ulong imageView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateShaderModule", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateShaderModule([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkShaderModuleCreateInfo *")] VkShaderModuleCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkShaderModule *")] ulong* pShaderModule);

        [DllImport(libraryPath, EntryPoint = "vkDestroyShaderModule", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyShaderModule([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkShaderModule")] ulong shaderModule, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreatePipelineCache", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreatePipelineCache([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineCacheCreateInfo *")] VkPipelineCacheCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipelineCache *")] ulong* pPipelineCache);

        [DllImport(libraryPath, EntryPoint = "vkDestroyPipelineCache", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineCache([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkGetPipelineCacheData", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPipelineCacheData([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("size_t *")] UIntPtr* pDataSize, [NativeTypeName("void *")] void* pData);

        [DllImport(libraryPath, EntryPoint = "vkMergePipelineCaches", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkMergePipelineCaches([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkPipelineCache *")] ulong* pSrcCaches);

        [DllImport(libraryPath, EntryPoint = "vkCreateGraphicsPipelines", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateGraphicsPipelines([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkGraphicsPipelineCreateInfo *")] VkGraphicsPipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport(libraryPath, EntryPoint = "vkCreateComputePipelines", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateComputePipelines([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkComputePipelineCreateInfo *")] VkComputePipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport(libraryPath, EntryPoint = "vkDestroyPipeline", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipeline([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreatePipelineLayout", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreatePipelineLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineLayoutCreateInfo *")] VkPipelineLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipelineLayout *")] ulong* pPipelineLayout);

        [DllImport(libraryPath, EntryPoint = "vkDestroyPipelineLayout", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineLayout")] ulong pipelineLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateSampler", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSampler([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerCreateInfo *")] VkSamplerCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSampler *")] ulong* pSampler);

        [DllImport(libraryPath, EntryPoint = "vkDestroySampler", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySampler([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSampler")] ulong sampler, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateDescriptorSetLayout", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDescriptorSetLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorSetLayout *")] ulong* pSetLayout);

        [DllImport(libraryPath, EntryPoint = "vkDestroyDescriptorSetLayout", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorSetLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSetLayout")] ulong descriptorSetLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateDescriptorPool", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorPoolCreateInfo *")] VkDescriptorPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorPool *")] ulong* pDescriptorPool);

        [DllImport(libraryPath, EntryPoint = "vkDestroyDescriptorPool", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkResetDescriptorPool", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("VkDescriptorPoolResetFlags")] uint flags);

        [DllImport(libraryPath, EntryPoint = "vkAllocateDescriptorSets", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAllocateDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetAllocateInfo *")] VkDescriptorSetAllocateInfo* pAllocateInfo, [NativeTypeName("VkDescriptorSet *")] ulong* pDescriptorSets);

        [DllImport(libraryPath, EntryPoint = "vkFreeDescriptorSets", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkFreeDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] ulong* pDescriptorSets);

        [DllImport(libraryPath, EntryPoint = "vkUpdateDescriptorSets", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites, [NativeTypeName("uint32_t")] uint descriptorCopyCount, [NativeTypeName("const VkCopyDescriptorSet *")] VkCopyDescriptorSet* pDescriptorCopies);

        [DllImport(libraryPath, EntryPoint = "vkCreateFramebuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateFramebuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFramebufferCreateInfo *")] VkFramebufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFramebuffer *")] ulong* pFramebuffer);

        [DllImport(libraryPath, EntryPoint = "vkDestroyFramebuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFramebuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFramebuffer")] ulong framebuffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateRenderPass", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateRenderPass([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo *")] VkRenderPassCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport(libraryPath, EntryPoint = "vkDestroyRenderPass", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyRenderPass([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkRenderPass")] ulong renderPass, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkGetRenderAreaGranularity", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetRenderAreaGranularity([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkRenderPass")] ulong renderPass, [NativeTypeName("VkExtent2D *")] VkExtent2D* pGranularity);

        [DllImport(libraryPath, EntryPoint = "vkCreateCommandPool", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCommandPoolCreateInfo *")] VkCommandPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkCommandPool *")] ulong* pCommandPool);

        [DllImport(libraryPath, EntryPoint = "vkDestroyCommandPool", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkResetCommandPool", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolResetFlags")] uint flags);

        [DllImport(libraryPath, EntryPoint = "vkAllocateCommandBuffers", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAllocateCommandBuffers([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCommandBufferAllocateInfo *")] VkCommandBufferAllocateInfo* pAllocateInfo, [NativeTypeName("VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport(libraryPath, EntryPoint = "vkFreeCommandBuffers", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeCommandBuffers([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport(libraryPath, EntryPoint = "vkBeginCommandBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBeginCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCommandBufferBeginInfo *")] VkCommandBufferBeginInfo* pBeginInfo);

        [DllImport(libraryPath, EntryPoint = "vkEndCommandBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEndCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(libraryPath, EntryPoint = "vkResetCommandBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkResetCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkCommandBufferResetFlags")] uint flags);

        [DllImport(libraryPath, EntryPoint = "vkCmdBindPipeline", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindPipeline([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipeline")] ulong pipeline);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetViewport", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewport([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewport *")] VkViewport* pViewports);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetScissor", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetScissor([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstScissor, [NativeTypeName("uint32_t")] uint scissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pScissors);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetLineWidth", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetLineWidth([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float lineWidth);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetDepthBias", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBias([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetBlendConstants", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetBlendConstants([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const float [4]")] float blendConstants);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetDepthBounds", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBounds([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float minDepthBounds, float maxDepthBounds);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetStencilCompareMask", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilCompareMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint compareMask);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetStencilWriteMask", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilWriteMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint writeMask);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetStencilReference", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilReference([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint reference);

        [DllImport(libraryPath, EntryPoint = "vkCmdBindDescriptorSets", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindDescriptorSets([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint firstSet, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] ulong* pDescriptorSets, [NativeTypeName("uint32_t")] uint dynamicOffsetCount, [NativeTypeName("const uint32_t *")] uint* pDynamicOffsets);

        [DllImport(libraryPath, EntryPoint = "vkCmdBindIndexBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindIndexBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkIndexType indexType);

        [DllImport(libraryPath, EntryPoint = "vkCmdBindVertexBuffers", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindVertexBuffers([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets);

        [DllImport(libraryPath, EntryPoint = "vkCmdDraw", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDraw([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint vertexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstVertex, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawIndexed", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexed([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint indexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstIndex, [NativeTypeName("int32_t")] int vertexOffset, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawIndirect", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawIndexedIndirect", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(libraryPath, EntryPoint = "vkCmdDispatch", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatch([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport(libraryPath, EntryPoint = "vkCmdDispatchIndirect", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset);

        [DllImport(libraryPath, EntryPoint = "vkCmdCopyBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong srcBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferCopy *")] VkBufferCopy* pRegions);

        [DllImport(libraryPath, EntryPoint = "vkCmdCopyImage", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageCopy *")] VkImageCopy* pRegions);

        [DllImport(libraryPath, EntryPoint = "vkCmdBlitImage", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBlitImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageBlit *")] VkImageBlit* pRegions, VkFilter filter);

        [DllImport(libraryPath, EntryPoint = "vkCmdCopyBufferToImage", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBufferToImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong srcBuffer, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

        [DllImport(libraryPath, EntryPoint = "vkCmdCopyImageToBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImageToBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

        [DllImport(libraryPath, EntryPoint = "vkCmdUpdateBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdUpdateBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong dataSize, [NativeTypeName("const void *")] void* pData);

        [DllImport(libraryPath, EntryPoint = "vkCmdFillBuffer", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdFillBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("uint32_t")] uint data);

        [DllImport(libraryPath, EntryPoint = "vkCmdClearColorImage", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearColorImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong image, VkImageLayout imageLayout, [NativeTypeName("const VkClearColorValue *")] VkClearColorValue* pColor, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

        [DllImport(libraryPath, EntryPoint = "vkCmdClearDepthStencilImage", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearDepthStencilImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong image, VkImageLayout imageLayout, [NativeTypeName("const VkClearDepthStencilValue *")] VkClearDepthStencilValue* pDepthStencil, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

        [DllImport(libraryPath, EntryPoint = "vkCmdClearAttachments", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearAttachments([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint attachmentCount, [NativeTypeName("const VkClearAttachment *")] VkClearAttachment* pAttachments, [NativeTypeName("uint32_t")] uint rectCount, [NativeTypeName("const VkClearRect *")] VkClearRect* pRects);

        [DllImport(libraryPath, EntryPoint = "vkCmdResolveImage", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResolveImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageResolve *")] VkImageResolve* pRegions);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetEvent", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetEvent([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("VkPipelineStageFlags")] uint stageMask);

        [DllImport(libraryPath, EntryPoint = "vkCmdResetEvent", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetEvent([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("VkPipelineStageFlags")] uint stageMask);

        [DllImport(libraryPath, EntryPoint = "vkCmdWaitEvents", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWaitEvents([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint eventCount, [NativeTypeName("const VkEvent *")] ulong* pEvents, [NativeTypeName("VkPipelineStageFlags")] uint srcStageMask, [NativeTypeName("VkPipelineStageFlags")] uint dstStageMask, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

        [DllImport(libraryPath, EntryPoint = "vkCmdPipelineBarrier", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPipelineBarrier([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkPipelineStageFlags")] uint srcStageMask, [NativeTypeName("VkPipelineStageFlags")] uint dstStageMask, [NativeTypeName("VkDependencyFlags")] uint dependencyFlags, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

        [DllImport(libraryPath, EntryPoint = "vkCmdBeginQuery", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags);

        [DllImport(libraryPath, EntryPoint = "vkCmdEndQuery", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport(libraryPath, EntryPoint = "vkCmdResetQueryPool", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetQueryPool([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport(libraryPath, EntryPoint = "vkCmdWriteTimestamp", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteTimestamp([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport(libraryPath, EntryPoint = "vkCmdCopyQueryPoolResults", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyQueryPoolResults([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);

        [DllImport(libraryPath, EntryPoint = "vkCmdPushConstants", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushConstants([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("VkShaderStageFlags")] uint stageFlags, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint size, [NativeTypeName("const void *")] void* pValues);

        [DllImport(libraryPath, EntryPoint = "vkCmdBeginRenderPass", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginRenderPass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);

        [DllImport(libraryPath, EntryPoint = "vkCmdNextSubpass", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdNextSubpass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkSubpassContents contents);

        [DllImport(libraryPath, EntryPoint = "vkCmdEndRenderPass", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndRenderPass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(libraryPath, EntryPoint = "vkCmdExecuteCommands", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdExecuteCommands([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport(libraryPath, EntryPoint = "vkEnumerateInstanceVersion", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumerateInstanceVersion([NativeTypeName("uint32_t *")] uint* pApiVersion);

        [DllImport(libraryPath, EntryPoint = "vkBindBufferMemory2", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindBufferMemory2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport(libraryPath, EntryPoint = "vkBindImageMemory2", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindImageMemory2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport(libraryPath, EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupPeerMemoryFeatures([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetDeviceMask", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDeviceMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport(libraryPath, EntryPoint = "vkCmdDispatchBase", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchBase([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport(libraryPath, EntryPoint = "vkEnumeratePhysicalDeviceGroups", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroups([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, [NativeTypeName("VkPhysicalDeviceGroupProperties *")] VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetImageMemoryRequirements2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkGetBufferMemoryRequirements2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkGetImageSparseMemoryRequirements2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements2 *")] VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceFeatures2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures2 *")] VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceProperties2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties2 *")] VkPhysicalDeviceProperties2* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceFormatProperties2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties2 *")] VkFormatProperties2* pFormatProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, [NativeTypeName("VkImageFormatProperties2 *")] VkImageFormatProperties2* pImageFormatProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties2 *")] VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceMemoryProperties2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties2 *")] VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties2 *")] VkSparseImageFormatProperties2* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkTrimCommandPool", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkTrimCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport(libraryPath, EntryPoint = "vkGetDeviceQueue2", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceQueueInfo2 *")] VkDeviceQueueInfo2* pQueueInfo, [NativeTypeName("VkQueue *")] IntPtr* pQueue);

        [DllImport(libraryPath, EntryPoint = "vkCreateSamplerYcbcrConversion", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSamplerYcbcrConversion([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSamplerYcbcrConversion *")] ulong* pYcbcrConversion);

        [DllImport(libraryPath, EntryPoint = "vkDestroySamplerYcbcrConversion", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySamplerYcbcrConversion([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSamplerYcbcrConversion")] ulong ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateDescriptorUpdateTemplate", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDescriptorUpdateTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorUpdateTemplate *")] ulong* pDescriptorUpdateTemplate);

        [DllImport(libraryPath, EntryPoint = "vkDestroyDescriptorUpdateTemplate", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorUpdateTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkUpdateDescriptorSetWithTemplate", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSetWithTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSet")] ulong descriptorSet, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalBufferProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [NativeTypeName("VkExternalBufferProperties *")] VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalFenceProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [NativeTypeName("VkExternalFenceProperties *")] VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalSemaphoreProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [NativeTypeName("VkExternalSemaphoreProperties *")] VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetDescriptorSetLayoutSupport", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDescriptorSetLayoutSupport([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("VkDescriptorSetLayoutSupport *")] VkDescriptorSetLayoutSupport* pSupport);

        [DllImport(libraryPath, EntryPoint = "vkDestroySurfaceKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkBool32 *")] uint* pSupported);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkSurfaceCapabilitiesKHR *")] VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormatsKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, [NativeTypeName("VkSurfaceFormatKHR *")] VkSurfaceFormatKHR* pSurfaceFormats);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfacePresentModesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pPresentModeCount, [NativeTypeName("VkPresentModeKHR *")] VkPresentModeKHR* pPresentModes);

        [DllImport(libraryPath, EntryPoint = "vkCreateSwapchainKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSwapchainKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSwapchainKHR *")] ulong* pSwapchain);

        [DllImport(libraryPath, EntryPoint = "vkDestroySwapchainKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySwapchainKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkGetSwapchainImagesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSwapchainImagesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint32_t *")] uint* pSwapchainImageCount, [NativeTypeName("VkImage *")] ulong* pSwapchainImages);

        [DllImport(libraryPath, EntryPoint = "vkAcquireNextImageKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAcquireNextImageKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint64_t")] ulong timeout, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("VkFence")] ulong fence, [NativeTypeName("uint32_t *")] uint* pImageIndex);

        [DllImport(libraryPath, EntryPoint = "vkQueuePresentKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueuePresentKHR([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkPresentInfoKHR *")] VkPresentInfoKHR* pPresentInfo);

        [DllImport(libraryPath, EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDeviceGroupPresentCapabilitiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceGroupPresentCapabilitiesKHR *")] VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        [DllImport(libraryPath, EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDeviceGroupSurfacePresentModesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkDeviceGroupPresentModeFlagsKHR *")] uint* pModes);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDevicePresentRectanglesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pRectCount, [NativeTypeName("VkRect2D *")] VkRect2D* pRects);

        [DllImport(libraryPath, EntryPoint = "vkAcquireNextImage2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAcquireNextImage2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAcquireNextImageInfoKHR *")] VkAcquireNextImageInfoKHR* pAcquireInfo, [NativeTypeName("uint32_t *")] uint* pImageIndex);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPropertiesKHR *")] VkDisplayPropertiesKHR* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPlanePropertiesKHR *")] VkDisplayPlanePropertiesKHR* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayPlaneSupportedDisplaysKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("uint32_t *")] uint* pDisplayCount, [NativeTypeName("VkDisplayKHR *")] ulong* pDisplays);

        [DllImport(libraryPath, EntryPoint = "vkGetDisplayModePropertiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayModePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayModePropertiesKHR *")] VkDisplayModePropertiesKHR* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkCreateDisplayModeKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDisplayModeKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayModeCreateInfoKHR *")] VkDisplayModeCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDisplayModeKHR *")] ulong* pMode);

        [DllImport(libraryPath, EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayPlaneCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayModeKHR")] ulong mode, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("VkDisplayPlaneCapabilitiesKHR *")] VkDisplayPlaneCapabilitiesKHR* pCapabilities);

        [DllImport(libraryPath, EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDisplayPlaneSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDisplaySurfaceCreateInfoKHR *")] VkDisplaySurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(libraryPath, EntryPoint = "vkCreateSharedSwapchainsKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSharedSwapchainsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSwapchainKHR *")] ulong* pSwapchains);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceFeatures2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures2 *")] VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties2 *")] VkPhysicalDeviceProperties2* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties2 *")] VkFormatProperties2* pFormatProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, [NativeTypeName("VkImageFormatProperties2 *")] VkImageFormatProperties2* pImageFormatProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties2 *")] VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties2 *")] VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties2 *")] VkSparseImageFormatProperties2* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetDeviceMaskKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDeviceMaskKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport(libraryPath, EntryPoint = "vkCmdDispatchBaseKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchBaseKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport(libraryPath, EntryPoint = "vkTrimCommandPoolKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkTrimCommandPoolKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport(libraryPath, EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroupsKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, [NativeTypeName("VkPhysicalDeviceGroupProperties *")] VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalBufferPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [NativeTypeName("VkExternalBufferProperties *")] VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetMemoryFdKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryGetFdInfoKHR *")] VkMemoryGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport(libraryPath, EntryPoint = "vkGetMemoryFdPropertiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryFdPropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, [NativeTypeName("VkMemoryFdPropertiesKHR *")] VkMemoryFdPropertiesKHR* pMemoryFdProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [NativeTypeName("VkExternalSemaphoreProperties *")] VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport(libraryPath, EntryPoint = "vkImportSemaphoreFdKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkImportSemaphoreFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportSemaphoreFdInfoKHR *")] VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        [DllImport(libraryPath, EntryPoint = "vkGetSemaphoreFdKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSemaphoreFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreGetFdInfoKHR *")] VkSemaphoreGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport(libraryPath, EntryPoint = "vkCmdPushDescriptorSetKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites);

        [DllImport(libraryPath, EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("const void *")] void* pData);

        [DllImport(libraryPath, EntryPoint = "vkCreateDescriptorUpdateTemplateKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorUpdateTemplate *")] ulong* pDescriptorUpdateTemplate);

        [DllImport(libraryPath, EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSetWithTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSet")] ulong descriptorSet, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport(libraryPath, EntryPoint = "vkCreateRenderPass2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateRenderPass2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo2KHR *")] VkRenderPassCreateInfo2KHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport(libraryPath, EntryPoint = "vkCmdBeginRenderPass2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginRenderPass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, [NativeTypeName("const VkSubpassBeginInfoKHR *")] VkSubpassBeginInfoKHR* pSubpassBeginInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdNextSubpass2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdNextSubpass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassBeginInfoKHR *")] VkSubpassBeginInfoKHR* pSubpassBeginInfo, [NativeTypeName("const VkSubpassEndInfoKHR *")] VkSubpassEndInfoKHR* pSubpassEndInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdEndRenderPass2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndRenderPass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassEndInfoKHR *")] VkSubpassEndInfoKHR* pSubpassEndInfo);

        [DllImport(libraryPath, EntryPoint = "vkGetSwapchainStatusKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSwapchainStatusKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalFencePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [NativeTypeName("VkExternalFenceProperties *")] VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport(libraryPath, EntryPoint = "vkImportFenceFdKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkImportFenceFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportFenceFdInfoKHR *")] VkImportFenceFdInfoKHR* pImportFenceFdInfo);

        [DllImport(libraryPath, EntryPoint = "vkGetFenceFdKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetFenceFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceGetFdInfoKHR *")] VkFenceGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("VkSurfaceCapabilities2KHR *")] VkSurfaceCapabilities2KHR* pSurfaceCapabilities);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormats2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, [NativeTypeName("VkSurfaceFormat2KHR *")] VkSurfaceFormat2KHR* pSurfaceFormats);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceDisplayProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayProperties2KHR *")] VkDisplayProperties2KHR* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPlaneProperties2KHR *")] VkDisplayPlaneProperties2KHR* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetDisplayModeProperties2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayModeProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayModeProperties2KHR *")] VkDisplayModeProperties2KHR* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetDisplayPlaneCapabilities2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetDisplayPlaneCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkDisplayPlaneInfo2KHR *")] VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, [NativeTypeName("VkDisplayPlaneCapabilities2KHR *")] VkDisplayPlaneCapabilities2KHR* pCapabilities);

        [DllImport(libraryPath, EntryPoint = "vkGetImageMemoryRequirements2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkGetBufferMemoryRequirements2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements2 *")] VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkCreateSamplerYcbcrConversionKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateSamplerYcbcrConversionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSamplerYcbcrConversion *")] ulong* pYcbcrConversion);

        [DllImport(libraryPath, EntryPoint = "vkDestroySamplerYcbcrConversionKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySamplerYcbcrConversionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSamplerYcbcrConversion")] ulong ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkBindBufferMemory2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindBufferMemory2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport(libraryPath, EntryPoint = "vkBindImageMemory2KHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindImageMemory2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport(libraryPath, EntryPoint = "vkGetDescriptorSetLayoutSupportKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDescriptorSetLayoutSupportKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("VkDescriptorSetLayoutSupport *")] VkDescriptorSetLayoutSupport* pSupport);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawIndirectCountKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectCountKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawIndexedIndirectCountKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirectCountKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(libraryPath, EntryPoint = "vkGetPipelineExecutablePropertiesKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPipelineExecutablePropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineInfoKHR *")] VkPipelineInfoKHR* pPipelineInfo, [NativeTypeName("uint32_t *")] uint* pExecutableCount, [NativeTypeName("VkPipelineExecutablePropertiesKHR *")] VkPipelineExecutablePropertiesKHR* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPipelineExecutableStatisticsKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPipelineExecutableStatisticsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pStatisticCount, [NativeTypeName("VkPipelineExecutableStatisticKHR *")] VkPipelineExecutableStatisticKHR* pStatistics);

        [DllImport(libraryPath, EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPipelineExecutableInternalRepresentationsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pInternalRepresentationCount, [NativeTypeName("VkPipelineExecutableInternalRepresentationKHR *")] VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        [DllImport(libraryPath, EntryPoint = "vkCreateDebugReportCallbackEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDebugReportCallbackEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDebugReportCallbackCreateInfoEXT *")] VkDebugReportCallbackCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDebugReportCallbackEXT *")] ulong* pCallback);

        [DllImport(libraryPath, EntryPoint = "vkDestroyDebugReportCallbackEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDebugReportCallbackEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugReportCallbackEXT")] ulong callback, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkDebugReportMessageEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDebugReportMessageEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugReportFlagsEXT")] uint flags, VkDebugReportObjectTypeEXT objectType, [NativeTypeName("uint64_t")] ulong @object, [NativeTypeName("size_t")] UIntPtr location, [NativeTypeName("int32_t")] int messageCode, [NativeTypeName("const char *")] sbyte* pLayerPrefix, [NativeTypeName("const char *")] sbyte* pMessage);

        [DllImport(libraryPath, EntryPoint = "vkDebugMarkerSetObjectTagEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkDebugMarkerSetObjectTagEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugMarkerObjectTagInfoEXT *")] VkDebugMarkerObjectTagInfoEXT* pTagInfo);

        [DllImport(libraryPath, EntryPoint = "vkDebugMarkerSetObjectNameEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkDebugMarkerSetObjectNameEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugMarkerObjectNameInfoEXT *")] VkDebugMarkerObjectNameInfoEXT* pNameInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdDebugMarkerBeginEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerBeginEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdDebugMarkerEndEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerEndEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(libraryPath, EntryPoint = "vkCmdDebugMarkerInsertEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerInsertEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindTransformFeedbackBuffersEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets, [NativeTypeName("const VkDeviceSize *")] ulong* pSizes);

        [DllImport(libraryPath, EntryPoint = "vkCmdBeginTransformFeedbackEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] ulong* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport(libraryPath, EntryPoint = "vkCmdEndTransformFeedbackEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] ulong* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport(libraryPath, EntryPoint = "vkCmdBeginQueryIndexedEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginQueryIndexedEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags, [NativeTypeName("uint32_t")] uint index);

        [DllImport(libraryPath, EntryPoint = "vkCmdEndQueryIndexedEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndQueryIndexedEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("uint32_t")] uint index);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawIndirectByteCountEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectByteCountEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstInstance, [NativeTypeName("VkBuffer")] ulong counterBuffer, [NativeTypeName("VkDeviceSize")] ulong counterBufferOffset, [NativeTypeName("uint32_t")] uint counterOffset, [NativeTypeName("uint32_t")] uint vertexStride);

        [DllImport(libraryPath, EntryPoint = "vkGetImageViewHandleNVX", CallingConvention = CallingConvention.Winapi)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint vkGetImageViewHandleNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageViewHandleInfoNVX *")] VkImageViewHandleInfoNVX* pInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawIndirectCountAMD", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectCountAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawIndexedIndirectCountAMD", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(libraryPath, EntryPoint = "vkGetShaderInfoAMD", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetShaderInfoAMD([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, [NativeTypeName("size_t *")] UIntPtr* pInfoSize, [NativeTypeName("void *")] void* pInfo);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, [NativeTypeName("VkImageUsageFlags")] uint usage, [NativeTypeName("VkImageCreateFlags")] uint flags, [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")] uint externalHandleType, [NativeTypeName("VkExternalImageFormatPropertiesNV *")] VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

        [DllImport(libraryPath, EntryPoint = "vkCmdBeginConditionalRenderingEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkConditionalRenderingBeginInfoEXT *")] VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

        [DllImport(libraryPath, EntryPoint = "vkCmdEndConditionalRenderingEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(libraryPath, EntryPoint = "vkCmdProcessCommandsNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdProcessCommandsNVX([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCmdProcessCommandsInfoNVX *")] VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdReserveSpaceForCommandsNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdReserveSpaceForCommandsNVX([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCmdReserveSpaceForCommandsInfoNVX *")] VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo);

        [DllImport(libraryPath, EntryPoint = "vkCreateIndirectCommandsLayoutNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateIndirectCommandsLayoutNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkIndirectCommandsLayoutCreateInfoNVX *")] VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkIndirectCommandsLayoutNVX *")] ulong* pIndirectCommandsLayout);

        [DllImport(libraryPath, EntryPoint = "vkDestroyIndirectCommandsLayoutNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyIndirectCommandsLayoutNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkIndirectCommandsLayoutNVX")] ulong indirectCommandsLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkCreateObjectTableNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateObjectTableNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkObjectTableCreateInfoNVX *")] VkObjectTableCreateInfoNVX* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkObjectTableNVX *")] ulong* pObjectTable);

        [DllImport(libraryPath, EntryPoint = "vkDestroyObjectTableNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyObjectTableNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkObjectTableNVX")] ulong objectTable, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkRegisterObjectsNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkRegisterObjectsNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkObjectTableNVX")] ulong objectTable, [NativeTypeName("uint32_t")] uint objectCount, [NativeTypeName("const VkObjectTableEntryNVX *const *")] VkObjectTableEntryNVX** ppObjectTableEntries, [NativeTypeName("const uint32_t *")] uint* pObjectIndices);

        [DllImport(libraryPath, EntryPoint = "vkUnregisterObjectsNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkUnregisterObjectsNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkObjectTableNVX")] ulong objectTable, [NativeTypeName("uint32_t")] uint objectCount, [NativeTypeName("const VkObjectEntryTypeNVX *")] VkObjectEntryTypeNVX* pObjectEntryTypes, [NativeTypeName("const uint32_t *")] uint* pObjectIndices);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDeviceGeneratedCommandsFeaturesNVX *")] VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, [NativeTypeName("VkDeviceGeneratedCommandsLimitsNVX *")] VkDeviceGeneratedCommandsLimitsNVX* pLimits);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetViewportWScalingNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewportWScalingNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewportWScalingNV *")] VkViewportWScalingNV* pViewportWScalings);

        [DllImport(libraryPath, EntryPoint = "vkReleaseDisplayEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkReleaseDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkSurfaceCapabilities2EXT *")] VkSurfaceCapabilities2EXT* pSurfaceCapabilities);

        [DllImport(libraryPath, EntryPoint = "vkDisplayPowerControlEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkDisplayPowerControlEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayPowerInfoEXT *")] VkDisplayPowerInfoEXT* pDisplayPowerInfo);

        [DllImport(libraryPath, EntryPoint = "vkRegisterDeviceEventEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkRegisterDeviceEventEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceEventInfoEXT *")] VkDeviceEventInfoEXT* pDeviceEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport(libraryPath, EntryPoint = "vkRegisterDisplayEventEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkRegisterDisplayEventEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayEventInfoEXT *")] VkDisplayEventInfoEXT* pDisplayEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport(libraryPath, EntryPoint = "vkGetSwapchainCounterEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetSwapchainCounterEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, VkSurfaceCounterFlagBitsEXT counter, [NativeTypeName("uint64_t *")] ulong* pCounterValue);

        [DllImport(libraryPath, EntryPoint = "vkGetRefreshCycleDurationGOOGLE", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetRefreshCycleDurationGOOGLE([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("VkRefreshCycleDurationGOOGLE *")] VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPastPresentationTimingGOOGLE", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPastPresentationTimingGOOGLE([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint32_t *")] uint* pPresentationTimingCount, [NativeTypeName("VkPastPresentationTimingGOOGLE *")] VkPastPresentationTimingGOOGLE* pPresentationTimings);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetDiscardRectangleEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDiscardRectangleEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstDiscardRectangle, [NativeTypeName("uint32_t")] uint discardRectangleCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pDiscardRectangles);

        [DllImport(libraryPath, EntryPoint = "vkSetHdrMetadataEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSetHdrMetadataEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainKHR *")] ulong* pSwapchains, [NativeTypeName("const VkHdrMetadataEXT *")] VkHdrMetadataEXT* pMetadata);

        [DllImport(libraryPath, EntryPoint = "vkSetDebugUtilsObjectNameEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkSetDebugUtilsObjectNameEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")] VkDebugUtilsObjectNameInfoEXT* pNameInfo);

        [DllImport(libraryPath, EntryPoint = "vkSetDebugUtilsObjectTagEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkSetDebugUtilsObjectTagEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugUtilsObjectTagInfoEXT *")] VkDebugUtilsObjectTagInfoEXT* pTagInfo);

        [DllImport(libraryPath, EntryPoint = "vkQueueBeginDebugUtilsLabelEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueBeginDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport(libraryPath, EntryPoint = "vkQueueEndDebugUtilsLabelEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueEndDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue);

        [DllImport(libraryPath, EntryPoint = "vkQueueInsertDebugUtilsLabelEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueInsertDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdBeginDebugUtilsLabelEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdEndDebugUtilsLabelEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(libraryPath, EntryPoint = "vkCmdInsertDebugUtilsLabelEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdInsertDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport(libraryPath, EntryPoint = "vkCreateDebugUtilsMessengerEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDebugUtilsMessengerCreateInfoEXT *")] VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDebugUtilsMessengerEXT *")] ulong* pMessenger);

        [DllImport(libraryPath, EntryPoint = "vkDestroyDebugUtilsMessengerEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugUtilsMessengerEXT")] ulong messenger, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkSubmitDebugUtilsMessageEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSubmitDebugUtilsMessageEXT([NativeTypeName("VkInstance")] IntPtr instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")] uint messageTypes, [NativeTypeName("const VkDebugUtilsMessengerCallbackDataEXT *")] VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetSampleLocationsEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetSampleLocationsEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSampleLocationsInfoEXT *")] VkSampleLocationsInfoEXT* pSampleLocationsInfo);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMultisamplePropertiesEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkSampleCountFlagBits samples, [NativeTypeName("VkMultisamplePropertiesEXT *")] VkMultisamplePropertiesEXT* pMultisampleProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetImageDrmFormatModifierPropertiesEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkImageDrmFormatModifierPropertiesEXT *")] VkImageDrmFormatModifierPropertiesEXT* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkCreateValidationCacheEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateValidationCacheEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkValidationCacheCreateInfoEXT *")] VkValidationCacheCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkValidationCacheEXT *")] ulong* pValidationCache);

        [DllImport(libraryPath, EntryPoint = "vkDestroyValidationCacheEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyValidationCacheEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong validationCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkMergeValidationCachesEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkMergeValidationCachesEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkValidationCacheEXT *")] ulong* pSrcCaches);

        [DllImport(libraryPath, EntryPoint = "vkGetValidationCacheDataEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetValidationCacheDataEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong validationCache, [NativeTypeName("size_t *")] UIntPtr* pDataSize, [NativeTypeName("void *")] void* pData);

        [DllImport(libraryPath, EntryPoint = "vkCmdBindShadingRateImageNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindShadingRateImageNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImageView")] ulong imageView, VkImageLayout imageLayout);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetViewportShadingRatePaletteNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewportShadingRatePaletteNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkShadingRatePaletteNV *")] VkShadingRatePaletteNV* pShadingRatePalettes);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetCoarseSampleOrderNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetCoarseSampleOrderNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, [NativeTypeName("uint32_t")] uint customSampleOrderCount, [NativeTypeName("const VkCoarseSampleOrderCustomNV *")] VkCoarseSampleOrderCustomNV* pCustomSampleOrders);

        [DllImport(libraryPath, EntryPoint = "vkCreateAccelerationStructureNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateAccelerationStructureNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureCreateInfoNV *")] VkAccelerationStructureCreateInfoNV* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkAccelerationStructureNV *")] ulong* pAccelerationStructure);

        [DllImport(libraryPath, EntryPoint = "vkDestroyAccelerationStructureNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyAccelerationStructureNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureNV")] ulong accelerationStructure, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(libraryPath, EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetAccelerationStructureMemoryRequirementsNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureMemoryRequirementsInfoNV *")] VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, [NativeTypeName("VkMemoryRequirements2KHR *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(libraryPath, EntryPoint = "vkBindAccelerationStructureMemoryNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkBindAccelerationStructureMemoryNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindAccelerationStructureMemoryInfoNV *")] VkBindAccelerationStructureMemoryInfoNV* pBindInfos);

        [DllImport(libraryPath, EntryPoint = "vkCmdBuildAccelerationStructureNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBuildAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkAccelerationStructureInfoNV *")] VkAccelerationStructureInfoNV* pInfo, [NativeTypeName("VkBuffer")] ulong instanceData, [NativeTypeName("VkDeviceSize")] ulong instanceOffset, [NativeTypeName("VkBool32")] uint update, [NativeTypeName("VkAccelerationStructureNV")] ulong dst, [NativeTypeName("VkAccelerationStructureNV")] ulong src, [NativeTypeName("VkBuffer")] ulong scratch, [NativeTypeName("VkDeviceSize")] ulong scratchOffset);

        [DllImport(libraryPath, EntryPoint = "vkCmdCopyAccelerationStructureNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkAccelerationStructureNV")] ulong dst, [NativeTypeName("VkAccelerationStructureNV")] ulong src, VkCopyAccelerationStructureModeNV mode);

        [DllImport(libraryPath, EntryPoint = "vkCmdTraceRaysNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdTraceRaysNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong raygenShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong raygenShaderBindingOffset, [NativeTypeName("VkBuffer")] ulong missShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingStride, [NativeTypeName("VkBuffer")] ulong hitShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingStride, [NativeTypeName("VkBuffer")] ulong callableShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingStride, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth);

        [DllImport(libraryPath, EntryPoint = "vkCreateRayTracingPipelinesNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateRayTracingPipelinesNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkRayTracingPipelineCreateInfoNV *")] VkRayTracingPipelineCreateInfoNV* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport(libraryPath, EntryPoint = "vkGetRayTracingShaderGroupHandlesNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] UIntPtr dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport(libraryPath, EntryPoint = "vkGetAccelerationStructureHandleNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetAccelerationStructureHandleNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureNV")] ulong accelerationStructure, [NativeTypeName("size_t")] UIntPtr dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport(libraryPath, EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureNV *")] ulong* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery);

        [DllImport(libraryPath, EntryPoint = "vkCompileDeferredNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCompileDeferredNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint shader);

        [DllImport(libraryPath, EntryPoint = "vkGetMemoryHostPointerPropertiesEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetMemoryHostPointerPropertiesEXT([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, [NativeTypeName("const void *")] void* pHostPointer, [NativeTypeName("VkMemoryHostPointerPropertiesEXT *")] VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

        [DllImport(libraryPath, EntryPoint = "vkCmdWriteBufferMarkerAMD", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteBufferMarkerAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("uint32_t")] uint marker);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pTimeDomainCount, [NativeTypeName("VkTimeDomainEXT *")] VkTimeDomainEXT* pTimeDomains);

        [DllImport(libraryPath, EntryPoint = "vkGetCalibratedTimestampsEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetCalibratedTimestampsEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint timestampCount, [NativeTypeName("const VkCalibratedTimestampInfoEXT *")] VkCalibratedTimestampInfoEXT* pTimestampInfos, [NativeTypeName("uint64_t *")] ulong* pTimestamps, [NativeTypeName("uint64_t *")] ulong* pMaxDeviation);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawMeshTasksNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawMeshTasksNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint taskCount, [NativeTypeName("uint32_t")] uint firstTask);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawMeshTasksIndirectNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawMeshTasksIndirectNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(libraryPath, EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawMeshTasksIndirectCountNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetExclusiveScissorNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetExclusiveScissorNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstExclusiveScissor, [NativeTypeName("uint32_t")] uint exclusiveScissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pExclusiveScissors);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetCheckpointNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetCheckpointNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const void *")] void* pCheckpointMarker);

        [DllImport(libraryPath, EntryPoint = "vkGetQueueCheckpointDataNV", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetQueueCheckpointDataNV([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t *")] uint* pCheckpointDataCount, [NativeTypeName("VkCheckpointDataNV *")] VkCheckpointDataNV* pCheckpointData);

        [DllImport(libraryPath, EntryPoint = "vkInitializePerformanceApiINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkInitializePerformanceApiINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkInitializePerformanceApiInfoINTEL *")] VkInitializePerformanceApiInfoINTEL* pInitializeInfo);

        [DllImport(libraryPath, EntryPoint = "vkUninitializePerformanceApiINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUninitializePerformanceApiINTEL([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetPerformanceMarkerINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCmdSetPerformanceMarkerINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceMarkerInfoINTEL *")] VkPerformanceMarkerInfoINTEL* pMarkerInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceStreamMarkerInfoINTEL *")] VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetPerformanceOverrideINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCmdSetPerformanceOverrideINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceOverrideInfoINTEL *")] VkPerformanceOverrideInfoINTEL* pOverrideInfo);

        [DllImport(libraryPath, EntryPoint = "vkAcquirePerformanceConfigurationINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkAcquirePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPerformanceConfigurationAcquireInfoINTEL *")] VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [NativeTypeName("VkPerformanceConfigurationINTEL *")] ulong* pConfiguration);

        [DllImport(libraryPath, EntryPoint = "vkReleasePerformanceConfigurationINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkReleasePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPerformanceConfigurationINTEL")] ulong configuration);

        [DllImport(libraryPath, EntryPoint = "vkQueueSetPerformanceConfigurationINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkQueueSetPerformanceConfigurationINTEL([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("VkPerformanceConfigurationINTEL")] ulong configuration);

        [DllImport(libraryPath, EntryPoint = "vkGetPerformanceParameterINTEL", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPerformanceParameterINTEL([NativeTypeName("VkDevice")] IntPtr device, VkPerformanceParameterTypeINTEL parameter, [NativeTypeName("VkPerformanceValueINTEL *")] VkPerformanceValueINTEL* pValue);

        [DllImport(libraryPath, EntryPoint = "vkSetLocalDimmingAMD", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSetLocalDimmingAMD([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapChain, [NativeTypeName("VkBool32")] uint localDimmingEnable);

        [DllImport(libraryPath, EntryPoint = "vkGetBufferDeviceAddressEXT", CallingConvention = CallingConvention.Winapi)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddressEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfoEXT *")] VkBufferDeviceAddressInfoEXT* pInfo);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkCooperativeMatrixPropertiesNV *")] VkCooperativeMatrixPropertiesNV* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pCombinationCount, [NativeTypeName("VkFramebufferMixedSamplesCombinationNV *")] VkFramebufferMixedSamplesCombinationNV* pCombinations);

        [DllImport(libraryPath, EntryPoint = "vkCreateHeadlessSurfaceEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern VkResult vkCreateHeadlessSurfaceEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkHeadlessSurfaceCreateInfoEXT *")] VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(libraryPath, EntryPoint = "vkCmdSetLineStippleEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetLineStippleEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint lineStippleFactor, [NativeTypeName("uint16_t")] ushort lineStipplePattern);

        [DllImport(libraryPath, EntryPoint = "vkResetQueryPoolEXT", CallingConvention = CallingConvention.Winapi)]
        public static extern void vkResetQueryPoolEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);
    }
}
