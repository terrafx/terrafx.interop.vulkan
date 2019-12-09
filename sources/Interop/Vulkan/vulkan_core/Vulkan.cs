// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateInstance", ExactSpelling = true)]
        public static extern VkResult vkCreateInstance([NativeTypeName("const VkInstanceCreateInfo *")] VkInstanceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkInstance *")] IntPtr* pInstance);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyInstance", ExactSpelling = true)]
        public static extern void vkDestroyInstance([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEnumeratePhysicalDevices", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDevices([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceCount, [NativeTypeName("VkPhysicalDevice *")] IntPtr* pPhysicalDevices);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceFeatures", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures *")] VkPhysicalDeviceFeatures* pFeatures);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceFormatProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties *")] VkFormatProperties* pFormatProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, [NativeTypeName("VkImageUsageFlags")] uint usage, [NativeTypeName("VkImageCreateFlags")] uint flags, [NativeTypeName("VkImageFormatProperties *")] VkImageFormatProperties* pImageFormatProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties *")] VkPhysicalDeviceProperties* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties *")] VkQueueFamilyProperties* pQueueFamilyProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceMemoryProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties *")] VkPhysicalDeviceMemoryProperties* pMemoryProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetInstanceProcAddr", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern IntPtr vkGetInstanceProcAddr([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceProcAddr", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern IntPtr vkGetDeviceProcAddr([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDevice", ExactSpelling = true)]
        public static extern VkResult vkCreateDevice([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkDeviceCreateInfo *")] VkDeviceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDevice *")] IntPtr* pDevice);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyDevice", ExactSpelling = true)]
        public static extern void vkDestroyDevice([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEnumerateInstanceExtensionProperties", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceExtensionProperties([NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkExtensionProperties *")] VkExtensionProperties* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEnumerateDeviceExtensionProperties", ExactSpelling = true)]
        public static extern VkResult vkEnumerateDeviceExtensionProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkExtensionProperties *")] VkExtensionProperties* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEnumerateInstanceLayerProperties", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceLayerProperties([NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEnumerateDeviceLayerProperties", ExactSpelling = true)]
        public static extern VkResult vkEnumerateDeviceLayerProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkLayerProperties *")] VkLayerProperties* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceQueue", ExactSpelling = true)]
        public static extern void vkGetDeviceQueue([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("uint32_t")] uint queueIndex, [NativeTypeName("VkQueue *")] IntPtr* pQueue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkQueueSubmit", ExactSpelling = true)]
        public static extern VkResult vkQueueSubmit([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t")] uint submitCount, [NativeTypeName("const VkSubmitInfo *")] VkSubmitInfo* pSubmits, [NativeTypeName("VkFence")] ulong fence);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkQueueWaitIdle", ExactSpelling = true)]
        public static extern VkResult vkQueueWaitIdle([NativeTypeName("VkQueue")] IntPtr queue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDeviceWaitIdle", ExactSpelling = true)]
        public static extern VkResult vkDeviceWaitIdle([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkAllocateMemory", ExactSpelling = true)]
        public static extern VkResult vkAllocateMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryAllocateInfo *")] VkMemoryAllocateInfo* pAllocateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDeviceMemory *")] ulong* pMemory);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkFreeMemory", ExactSpelling = true)]
        public static extern void vkFreeMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkMapMemory", ExactSpelling = true)]
        public static extern VkResult vkMapMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("VkMemoryMapFlags")] uint flags, [NativeTypeName("void **")] void** ppData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkUnmapMemory", ExactSpelling = true)]
        public static extern void vkUnmapMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkFlushMappedMemoryRanges", ExactSpelling = true)]
        public static extern VkResult vkFlushMappedMemoryRanges([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkInvalidateMappedMemoryRanges", ExactSpelling = true)]
        public static extern VkResult vkInvalidateMappedMemoryRanges([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint memoryRangeCount, [NativeTypeName("const VkMappedMemoryRange *")] VkMappedMemoryRange* pMemoryRanges);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceMemoryCommitment", ExactSpelling = true)]
        public static extern void vkGetDeviceMemoryCommitment([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize *")] ulong* pCommittedMemoryInBytes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkBindBufferMemory", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkBindImageMemory", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkDeviceSize")] ulong memoryOffset);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetBufferMemoryRequirements", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkMemoryRequirements *")] VkMemoryRequirements* pMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageMemoryRequirements", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkMemoryRequirements *")] VkMemoryRequirements* pMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageSparseMemoryRequirements", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements *")] VkSparseImageMemoryRequirements* pSparseMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, [NativeTypeName("VkImageUsageFlags")] uint usage, VkImageTiling tiling, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties *")] VkSparseImageFormatProperties* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkQueueBindSparse", ExactSpelling = true)]
        public static extern VkResult vkQueueBindSparse([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindSparseInfo *")] VkBindSparseInfo* pBindInfo, [NativeTypeName("VkFence")] ulong fence);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateFence", ExactSpelling = true)]
        public static extern VkResult vkCreateFence([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceCreateInfo *")] VkFenceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyFence", ExactSpelling = true)]
        public static extern void vkDestroyFence([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFence")] ulong fence, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkResetFences", ExactSpelling = true)]
        public static extern VkResult vkResetFences([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] ulong* pFences);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetFenceStatus", ExactSpelling = true)]
        public static extern VkResult vkGetFenceStatus([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFence")] ulong fence);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkWaitForFences", ExactSpelling = true)]
        public static extern VkResult vkWaitForFences([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint fenceCount, [NativeTypeName("const VkFence *")] ulong* pFences, [NativeTypeName("VkBool32")] uint waitAll, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateSemaphore", ExactSpelling = true)]
        public static extern VkResult vkCreateSemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreCreateInfo *")] VkSemaphoreCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSemaphore *")] ulong* pSemaphore);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroySemaphore", ExactSpelling = true)]
        public static extern void vkDestroySemaphore([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateEvent", ExactSpelling = true)]
        public static extern VkResult vkCreateEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkEventCreateInfo *")] VkEventCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkEvent *")] ulong* pEvent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyEvent", ExactSpelling = true)]
        public static extern void vkDestroyEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetEventStatus", ExactSpelling = true)]
        public static extern VkResult vkGetEventStatus([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkSetEvent", ExactSpelling = true)]
        public static extern VkResult vkSetEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkResetEvent", ExactSpelling = true)]
        public static extern VkResult vkResetEvent([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkEvent")] ulong @event);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateQueryPool", ExactSpelling = true)]
        public static extern VkResult vkCreateQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkQueryPoolCreateInfo *")] VkQueryPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkQueryPool *")] ulong* pQueryPool);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyQueryPool", ExactSpelling = true)]
        public static extern void vkDestroyQueryPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetQueryPoolResults", ExactSpelling = true)]
        public static extern VkResult vkGetQueryPoolResults([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("size_t")] UIntPtr dataSize, [NativeTypeName("void *")] void* pData, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateBuffer", ExactSpelling = true)]
        public static extern VkResult vkCreateBuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferCreateInfo *")] VkBufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkBuffer *")] ulong* pBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyBuffer", ExactSpelling = true)]
        public static extern void vkDestroyBuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateBufferView", ExactSpelling = true)]
        public static extern VkResult vkCreateBufferView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferViewCreateInfo *")] VkBufferViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkBufferView *")] ulong* pView);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyBufferView", ExactSpelling = true)]
        public static extern void vkDestroyBufferView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkBufferView")] ulong bufferView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateImage", ExactSpelling = true)]
        public static extern VkResult vkCreateImage([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageCreateInfo *")] VkImageCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkImage *")] ulong* pImage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyImage", ExactSpelling = true)]
        public static extern void vkDestroyImage([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageSubresourceLayout", ExactSpelling = true)]
        public static extern void vkGetImageSubresourceLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("const VkImageSubresource *")] VkImageSubresource* pSubresource, [NativeTypeName("VkSubresourceLayout *")] VkSubresourceLayout* pLayout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateImageView", ExactSpelling = true)]
        public static extern VkResult vkCreateImageView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageViewCreateInfo *")] VkImageViewCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkImageView *")] ulong* pView);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyImageView", ExactSpelling = true)]
        public static extern void vkDestroyImageView([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImageView")] ulong imageView, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateShaderModule", ExactSpelling = true)]
        public static extern VkResult vkCreateShaderModule([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkShaderModuleCreateInfo *")] VkShaderModuleCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkShaderModule *")] ulong* pShaderModule);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyShaderModule", ExactSpelling = true)]
        public static extern void vkDestroyShaderModule([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkShaderModule")] ulong shaderModule, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreatePipelineCache", ExactSpelling = true)]
        public static extern VkResult vkCreatePipelineCache([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineCacheCreateInfo *")] VkPipelineCacheCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipelineCache *")] ulong* pPipelineCache);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyPipelineCache", ExactSpelling = true)]
        public static extern void vkDestroyPipelineCache([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPipelineCacheData", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineCacheData([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("size_t *")] UIntPtr* pDataSize, [NativeTypeName("void *")] void* pData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkMergePipelineCaches", ExactSpelling = true)]
        public static extern VkResult vkMergePipelineCaches([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkPipelineCache *")] ulong* pSrcCaches);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateGraphicsPipelines", ExactSpelling = true)]
        public static extern VkResult vkCreateGraphicsPipelines([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkGraphicsPipelineCreateInfo *")] VkGraphicsPipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateComputePipelines", ExactSpelling = true)]
        public static extern VkResult vkCreateComputePipelines([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkComputePipelineCreateInfo *")] VkComputePipelineCreateInfo* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyPipeline", ExactSpelling = true)]
        public static extern void vkDestroyPipeline([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreatePipelineLayout", ExactSpelling = true)]
        public static extern VkResult vkCreatePipelineLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineLayoutCreateInfo *")] VkPipelineLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipelineLayout *")] ulong* pPipelineLayout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyPipelineLayout", ExactSpelling = true)]
        public static extern void vkDestroyPipelineLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineLayout")] ulong pipelineLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateSampler", ExactSpelling = true)]
        public static extern VkResult vkCreateSampler([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerCreateInfo *")] VkSamplerCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSampler *")] ulong* pSampler);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroySampler", ExactSpelling = true)]
        public static extern void vkDestroySampler([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSampler")] ulong sampler, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDescriptorSetLayout", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorSetLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorSetLayout *")] ulong* pSetLayout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyDescriptorSetLayout", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorSetLayout([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSetLayout")] ulong descriptorSetLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDescriptorPool", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorPoolCreateInfo *")] VkDescriptorPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorPool *")] ulong* pDescriptorPool);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyDescriptorPool", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkResetDescriptorPool", ExactSpelling = true)]
        public static extern VkResult vkResetDescriptorPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("VkDescriptorPoolResetFlags")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkAllocateDescriptorSets", ExactSpelling = true)]
        public static extern VkResult vkAllocateDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetAllocateInfo *")] VkDescriptorSetAllocateInfo* pAllocateInfo, [NativeTypeName("VkDescriptorSet *")] ulong* pDescriptorSets);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkFreeDescriptorSets", ExactSpelling = true)]
        public static extern VkResult vkFreeDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorPool")] ulong descriptorPool, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] ulong* pDescriptorSets);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkUpdateDescriptorSets", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSets([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites, [NativeTypeName("uint32_t")] uint descriptorCopyCount, [NativeTypeName("const VkCopyDescriptorSet *")] VkCopyDescriptorSet* pDescriptorCopies);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateFramebuffer", ExactSpelling = true)]
        public static extern VkResult vkCreateFramebuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFramebufferCreateInfo *")] VkFramebufferCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFramebuffer *")] ulong* pFramebuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyFramebuffer", ExactSpelling = true)]
        public static extern void vkDestroyFramebuffer([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkFramebuffer")] ulong framebuffer, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateRenderPass", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo *")] VkRenderPassCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyRenderPass", ExactSpelling = true)]
        public static extern void vkDestroyRenderPass([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkRenderPass")] ulong renderPass, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetRenderAreaGranularity", ExactSpelling = true)]
        public static extern void vkGetRenderAreaGranularity([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkRenderPass")] ulong renderPass, [NativeTypeName("VkExtent2D *")] VkExtent2D* pGranularity);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateCommandPool", ExactSpelling = true)]
        public static extern VkResult vkCreateCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCommandPoolCreateInfo *")] VkCommandPoolCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkCommandPool *")] ulong* pCommandPool);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyCommandPool", ExactSpelling = true)]
        public static extern void vkDestroyCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkResetCommandPool", ExactSpelling = true)]
        public static extern VkResult vkResetCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolResetFlags")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkAllocateCommandBuffers", ExactSpelling = true)]
        public static extern VkResult vkAllocateCommandBuffers([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkCommandBufferAllocateInfo *")] VkCommandBufferAllocateInfo* pAllocateInfo, [NativeTypeName("VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkFreeCommandBuffers", ExactSpelling = true)]
        public static extern void vkFreeCommandBuffers([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkBeginCommandBuffer", ExactSpelling = true)]
        public static extern VkResult vkBeginCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCommandBufferBeginInfo *")] VkCommandBufferBeginInfo* pBeginInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEndCommandBuffer", ExactSpelling = true)]
        public static extern VkResult vkEndCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkResetCommandBuffer", ExactSpelling = true)]
        public static extern VkResult vkResetCommandBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkCommandBufferResetFlags")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBindPipeline", ExactSpelling = true)]
        public static extern void vkCmdBindPipeline([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipeline")] ulong pipeline);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetViewport", ExactSpelling = true)]
        public static extern void vkCmdSetViewport([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewport *")] VkViewport* pViewports);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetScissor", ExactSpelling = true)]
        public static extern void vkCmdSetScissor([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstScissor, [NativeTypeName("uint32_t")] uint scissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pScissors);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetLineWidth", ExactSpelling = true)]
        public static extern void vkCmdSetLineWidth([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float lineWidth);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetDepthBias", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBias([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetBlendConstants", ExactSpelling = true)]
        public static extern void vkCmdSetBlendConstants([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const float [4]")] float* blendConstants);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetDepthBounds", ExactSpelling = true)]
        public static extern void vkCmdSetDepthBounds([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, float minDepthBounds, float maxDepthBounds);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetStencilCompareMask", ExactSpelling = true)]
        public static extern void vkCmdSetStencilCompareMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint compareMask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetStencilWriteMask", ExactSpelling = true)]
        public static extern void vkCmdSetStencilWriteMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint writeMask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetStencilReference", ExactSpelling = true)]
        public static extern void vkCmdSetStencilReference([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkStencilFaceFlags")] uint faceMask, [NativeTypeName("uint32_t")] uint reference);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBindDescriptorSets", ExactSpelling = true)]
        public static extern void vkCmdBindDescriptorSets([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint firstSet, [NativeTypeName("uint32_t")] uint descriptorSetCount, [NativeTypeName("const VkDescriptorSet *")] ulong* pDescriptorSets, [NativeTypeName("uint32_t")] uint dynamicOffsetCount, [NativeTypeName("const uint32_t *")] uint* pDynamicOffsets);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBindIndexBuffer", ExactSpelling = true)]
        public static extern void vkCmdBindIndexBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, VkIndexType indexType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBindVertexBuffers", ExactSpelling = true)]
        public static extern void vkCmdBindVertexBuffers([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDraw", ExactSpelling = true)]
        public static extern void vkCmdDraw([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint vertexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstVertex, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawIndexed", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexed([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint indexCount, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstIndex, [NativeTypeName("int32_t")] int vertexOffset, [NativeTypeName("uint32_t")] uint firstInstance);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawIndirect", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawIndexedIndirect", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDispatch", ExactSpelling = true)]
        public static extern void vkCmdDispatch([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDispatchIndirect", ExactSpelling = true)]
        public static extern void vkCmdDispatchIndirect([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdCopyBuffer", ExactSpelling = true)]
        public static extern void vkCmdCopyBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong srcBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferCopy *")] VkBufferCopy* pRegions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdCopyImage", ExactSpelling = true)]
        public static extern void vkCmdCopyImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageCopy *")] VkImageCopy* pRegions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBlitImage", ExactSpelling = true)]
        public static extern void vkCmdBlitImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageBlit *")] VkImageBlit* pRegions, VkFilter filter);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdCopyBufferToImage", ExactSpelling = true)]
        public static extern void vkCmdCopyBufferToImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong srcBuffer, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdCopyImageToBuffer", ExactSpelling = true)]
        public static extern void vkCmdCopyImageToBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkBufferImageCopy *")] VkBufferImageCopy* pRegions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdUpdateBuffer", ExactSpelling = true)]
        public static extern void vkCmdUpdateBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong dataSize, [NativeTypeName("const void *")] void* pData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdFillBuffer", ExactSpelling = true)]
        public static extern void vkCmdFillBuffer([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong size, [NativeTypeName("uint32_t")] uint data);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdClearColorImage", ExactSpelling = true)]
        public static extern void vkCmdClearColorImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong image, VkImageLayout imageLayout, [NativeTypeName("const VkClearColorValue *")] VkClearColorValue* pColor, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdClearDepthStencilImage", ExactSpelling = true)]
        public static extern void vkCmdClearDepthStencilImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong image, VkImageLayout imageLayout, [NativeTypeName("const VkClearDepthStencilValue *")] VkClearDepthStencilValue* pDepthStencil, [NativeTypeName("uint32_t")] uint rangeCount, [NativeTypeName("const VkImageSubresourceRange *")] VkImageSubresourceRange* pRanges);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdClearAttachments", ExactSpelling = true)]
        public static extern void vkCmdClearAttachments([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint attachmentCount, [NativeTypeName("const VkClearAttachment *")] VkClearAttachment* pAttachments, [NativeTypeName("uint32_t")] uint rectCount, [NativeTypeName("const VkClearRect *")] VkClearRect* pRects);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdResolveImage", ExactSpelling = true)]
        public static extern void vkCmdResolveImage([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImage")] ulong srcImage, VkImageLayout srcImageLayout, [NativeTypeName("VkImage")] ulong dstImage, VkImageLayout dstImageLayout, [NativeTypeName("uint32_t")] uint regionCount, [NativeTypeName("const VkImageResolve *")] VkImageResolve* pRegions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetEvent", ExactSpelling = true)]
        public static extern void vkCmdSetEvent([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("VkPipelineStageFlags")] uint stageMask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdResetEvent", ExactSpelling = true)]
        public static extern void vkCmdResetEvent([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkEvent")] ulong @event, [NativeTypeName("VkPipelineStageFlags")] uint stageMask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdWaitEvents", ExactSpelling = true)]
        public static extern void vkCmdWaitEvents([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint eventCount, [NativeTypeName("const VkEvent *")] ulong* pEvents, [NativeTypeName("VkPipelineStageFlags")] uint srcStageMask, [NativeTypeName("VkPipelineStageFlags")] uint dstStageMask, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdPipelineBarrier", ExactSpelling = true)]
        public static extern void vkCmdPipelineBarrier([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkPipelineStageFlags")] uint srcStageMask, [NativeTypeName("VkPipelineStageFlags")] uint dstStageMask, [NativeTypeName("VkDependencyFlags")] uint dependencyFlags, [NativeTypeName("uint32_t")] uint memoryBarrierCount, [NativeTypeName("const VkMemoryBarrier *")] VkMemoryBarrier* pMemoryBarriers, [NativeTypeName("uint32_t")] uint bufferMemoryBarrierCount, [NativeTypeName("const VkBufferMemoryBarrier *")] VkBufferMemoryBarrier* pBufferMemoryBarriers, [NativeTypeName("uint32_t")] uint imageMemoryBarrierCount, [NativeTypeName("const VkImageMemoryBarrier *")] VkImageMemoryBarrier* pImageMemoryBarriers);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBeginQuery", ExactSpelling = true)]
        public static extern void vkCmdBeginQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdEndQuery", ExactSpelling = true)]
        public static extern void vkCmdEndQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdResetQueryPool", ExactSpelling = true)]
        public static extern void vkCmdResetQueryPool([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdWriteTimestamp", ExactSpelling = true)]
        public static extern void vkCmdWriteTimestamp([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdCopyQueryPoolResults", ExactSpelling = true)]
        public static extern void vkCmdCopyQueryPoolResults([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdPushConstants", ExactSpelling = true)]
        public static extern void vkCmdPushConstants([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("VkShaderStageFlags")] uint stageFlags, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint size, [NativeTypeName("const void *")] void* pValues);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBeginRenderPass", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdNextSubpass", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkSubpassContents contents);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdEndRenderPass", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdExecuteCommands", ExactSpelling = true)]
        public static extern void vkCmdExecuteCommands([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint commandBufferCount, [NativeTypeName("const VkCommandBuffer *")] IntPtr* pCommandBuffers);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEnumerateInstanceVersion", ExactSpelling = true)]
        public static extern VkResult vkEnumerateInstanceVersion([NativeTypeName("uint32_t *")] uint* pApiVersion);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkBindBufferMemory2", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkBindImageMemory2", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures", ExactSpelling = true)]
        public static extern void vkGetDeviceGroupPeerMemoryFeatures([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetDeviceMask", ExactSpelling = true)]
        public static extern void vkCmdSetDeviceMask([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDispatchBase", ExactSpelling = true)]
        public static extern void vkCmdDispatchBase([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEnumeratePhysicalDeviceGroups", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroups([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, [NativeTypeName("VkPhysicalDeviceGroupProperties *")] VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageMemoryRequirements2", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetBufferMemoryRequirements2", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageSparseMemoryRequirements2", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements2 *")] VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceFeatures2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures2 *")] VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties2 *")] VkPhysicalDeviceProperties2* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceFormatProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties2 *")] VkFormatProperties2* pFormatProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, [NativeTypeName("VkImageFormatProperties2 *")] VkImageFormatProperties2* pImageFormatProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties2 *")] VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceMemoryProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties2 *")] VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties2 *")] VkSparseImageFormatProperties2* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkTrimCommandPool", ExactSpelling = true)]
        public static extern void vkTrimCommandPool([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceQueue2", ExactSpelling = true)]
        public static extern void vkGetDeviceQueue2([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceQueueInfo2 *")] VkDeviceQueueInfo2* pQueueInfo, [NativeTypeName("VkQueue *")] IntPtr* pQueue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateSamplerYcbcrConversion", ExactSpelling = true)]
        public static extern VkResult vkCreateSamplerYcbcrConversion([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSamplerYcbcrConversion *")] ulong* pYcbcrConversion);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroySamplerYcbcrConversion", ExactSpelling = true)]
        public static extern void vkDestroySamplerYcbcrConversion([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSamplerYcbcrConversion")] ulong ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDescriptorUpdateTemplate", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorUpdateTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorUpdateTemplate *")] ulong* pDescriptorUpdateTemplate);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyDescriptorUpdateTemplate", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorUpdateTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkUpdateDescriptorSetWithTemplate", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSetWithTemplate([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSet")] ulong descriptorSet, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalBufferProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [NativeTypeName("VkExternalBufferProperties *")] VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalFenceProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [NativeTypeName("VkExternalFenceProperties *")] VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalSemaphoreProperties([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [NativeTypeName("VkExternalSemaphoreProperties *")] VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDescriptorSetLayoutSupport", ExactSpelling = true)]
        public static extern void vkGetDescriptorSetLayoutSupport([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("VkDescriptorSetLayoutSupport *")] VkDescriptorSetLayoutSupport* pSupport);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroySurfaceKHR", ExactSpelling = true)]
        public static extern void vkDestroySurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkBool32 *")] uint* pSupported);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkSurfaceCapabilitiesKHR *")] VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormatsKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, [NativeTypeName("VkSurfaceFormatKHR *")] VkSurfaceFormatKHR* pSurfaceFormats);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfacePresentModesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pPresentModeCount, [NativeTypeName("VkPresentModeKHR *")] VkPresentModeKHR* pPresentModes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateSwapchainKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateSwapchainKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSwapchainKHR *")] ulong* pSwapchain);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroySwapchainKHR", ExactSpelling = true)]
        public static extern void vkDestroySwapchainKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetSwapchainImagesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainImagesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint32_t *")] uint* pSwapchainImageCount, [NativeTypeName("VkImage *")] ulong* pSwapchainImages);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkAcquireNextImageKHR", ExactSpelling = true)]
        public static extern VkResult vkAcquireNextImageKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint64_t")] ulong timeout, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("VkFence")] ulong fence, [NativeTypeName("uint32_t *")] uint* pImageIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkQueuePresentKHR", ExactSpelling = true)]
        public static extern VkResult vkQueuePresentKHR([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkPresentInfoKHR *")] VkPresentInfoKHR* pPresentInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceGroupPresentCapabilitiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceGroupPresentCapabilitiesKHR *")] VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceGroupSurfacePresentModesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkDeviceGroupPresentModeFlagsKHR *")] uint* pModes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDevicePresentRectanglesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("uint32_t *")] uint* pRectCount, [NativeTypeName("VkRect2D *")] VkRect2D* pRects);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkAcquireNextImage2KHR", ExactSpelling = true)]
        public static extern VkResult vkAcquireNextImage2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAcquireNextImageInfoKHR *")] VkAcquireNextImageInfoKHR* pAcquireInfo, [NativeTypeName("uint32_t *")] uint* pImageIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPropertiesKHR *")] VkDisplayPropertiesKHR* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPlanePropertiesKHR *")] VkDisplayPlanePropertiesKHR* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneSupportedDisplaysKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("uint32_t *")] uint* pDisplayCount, [NativeTypeName("VkDisplayKHR *")] ulong* pDisplays);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDisplayModePropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayModePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayModePropertiesKHR *")] VkDisplayModePropertiesKHR* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDisplayModeKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateDisplayModeKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayModeCreateInfoKHR *")] VkDisplayModeCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDisplayModeKHR *")] ulong* pMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayModeKHR")] ulong mode, [NativeTypeName("uint32_t")] uint planeIndex, [NativeTypeName("VkDisplayPlaneCapabilitiesKHR *")] VkDisplayPlaneCapabilitiesKHR* pCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateDisplayPlaneSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDisplaySurfaceCreateInfoKHR *")] VkDisplaySurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateSharedSwapchainsKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateSharedSwapchainsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainCreateInfoKHR *")] VkSwapchainCreateInfoKHR* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSwapchainKHR *")] ulong* pSwapchains);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceFeatures2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFeatures2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceFeatures2 *")] VkPhysicalDeviceFeatures2* pFeatures);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceProperties2 *")] VkPhysicalDeviceProperties2* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, [NativeTypeName("VkFormatProperties2 *")] VkFormatProperties2* pFormatProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceImageFormatInfo2 *")] VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, [NativeTypeName("VkImageFormatProperties2 *")] VkImageFormatProperties2* pImageFormatProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pQueueFamilyPropertyCount, [NativeTypeName("VkQueueFamilyProperties2 *")] VkQueueFamilyProperties2* pQueueFamilyProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkPhysicalDeviceMemoryProperties2 *")] VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSparseImageFormatInfo2 *")] VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkSparseImageFormatProperties2 *")] VkSparseImageFormatProperties2* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR", ExactSpelling = true)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetDeviceMaskKHR", ExactSpelling = true)]
        public static extern void vkCmdSetDeviceMaskKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint deviceMask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDispatchBaseKHR", ExactSpelling = true)]
        public static extern void vkCmdDispatchBaseKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint baseGroupX, [NativeTypeName("uint32_t")] uint baseGroupY, [NativeTypeName("uint32_t")] uint baseGroupZ, [NativeTypeName("uint32_t")] uint groupCountX, [NativeTypeName("uint32_t")] uint groupCountY, [NativeTypeName("uint32_t")] uint groupCountZ);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkTrimCommandPoolKHR", ExactSpelling = true)]
        public static extern void vkTrimCommandPoolKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkCommandPool")] ulong commandPool, [NativeTypeName("VkCommandPoolTrimFlags")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR", ExactSpelling = true)]
        public static extern VkResult vkEnumeratePhysicalDeviceGroupsKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("uint32_t *")] uint* pPhysicalDeviceGroupCount, [NativeTypeName("VkPhysicalDeviceGroupProperties *")] VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalBufferPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalBufferInfo *")] VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [NativeTypeName("VkExternalBufferProperties *")] VkExternalBufferProperties* pExternalBufferProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetMemoryFdKHR", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryGetFdInfoKHR *")] VkMemoryGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetMemoryFdPropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryFdPropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, [NativeTypeName("VkMemoryFdPropertiesKHR *")] VkMemoryFdPropertiesKHR* pMemoryFdProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalSemaphoreInfo *")] VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [NativeTypeName("VkExternalSemaphoreProperties *")] VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkImportSemaphoreFdKHR", ExactSpelling = true)]
        public static extern VkResult vkImportSemaphoreFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportSemaphoreFdInfoKHR *")] VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetSemaphoreFdKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreGetFdInfoKHR *")] VkSemaphoreGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdPushDescriptorSetKHR", ExactSpelling = true)]
        public static extern void vkCmdPushDescriptorSetKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("uint32_t")] uint descriptorWriteCount, [NativeTypeName("const VkWriteDescriptorSet *")] VkWriteDescriptorSet* pDescriptorWrites);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR", ExactSpelling = true)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("VkPipelineLayout")] ulong layout, [NativeTypeName("uint32_t")] uint set, [NativeTypeName("const void *")] void* pData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDescriptorUpdateTemplateKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")] VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDescriptorUpdateTemplate *")] ulong* pDescriptorUpdateTemplate);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR", ExactSpelling = true)]
        public static extern void vkDestroyDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR", ExactSpelling = true)]
        public static extern void vkUpdateDescriptorSetWithTemplateKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDescriptorSet")] ulong descriptorSet, [NativeTypeName("VkDescriptorUpdateTemplate")] ulong descriptorUpdateTemplate, [NativeTypeName("const void *")] void* pData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateRenderPass2KHR", ExactSpelling = true)]
        public static extern VkResult vkCreateRenderPass2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkRenderPassCreateInfo2KHR *")] VkRenderPassCreateInfo2KHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkRenderPass *")] ulong* pRenderPass);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBeginRenderPass2KHR", ExactSpelling = true)]
        public static extern void vkCmdBeginRenderPass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkRenderPassBeginInfo *")] VkRenderPassBeginInfo* pRenderPassBegin, [NativeTypeName("const VkSubpassBeginInfoKHR *")] VkSubpassBeginInfoKHR* pSubpassBeginInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdNextSubpass2KHR", ExactSpelling = true)]
        public static extern void vkCmdNextSubpass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassBeginInfoKHR *")] VkSubpassBeginInfoKHR* pSubpassBeginInfo, [NativeTypeName("const VkSubpassEndInfoKHR *")] VkSubpassEndInfoKHR* pSubpassEndInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdEndRenderPass2KHR", ExactSpelling = true)]
        public static extern void vkCmdEndRenderPass2KHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSubpassEndInfoKHR *")] VkSubpassEndInfoKHR* pSubpassEndInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetSwapchainStatusKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainStatusKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceExternalFencePropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceExternalFenceInfo *")] VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [NativeTypeName("VkExternalFenceProperties *")] VkExternalFenceProperties* pExternalFenceProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkImportFenceFdKHR", ExactSpelling = true)]
        public static extern VkResult vkImportFenceFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportFenceFdInfoKHR *")] VkImportFenceFdInfoKHR* pImportFenceFdInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetFenceFdKHR", ExactSpelling = true)]
        public static extern VkResult vkGetFenceFdKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceGetFdInfoKHR *")] VkFenceGetFdInfoKHR* pGetFdInfo, [NativeTypeName("int *")] int* pFd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("VkSurfaceCapabilities2KHR *")] VkSurfaceCapabilities2KHR* pSurfaceCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceFormats2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("uint32_t *")] uint* pSurfaceFormatCount, [NativeTypeName("VkSurfaceFormat2KHR *")] VkSurfaceFormat2KHR* pSurfaceFormats);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayProperties2KHR *")] VkDisplayProperties2KHR* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayPlaneProperties2KHR *")] VkDisplayPlaneProperties2KHR* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDisplayModeProperties2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayModeProperties2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkDisplayModeProperties2KHR *")] VkDisplayModeProperties2KHR* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDisplayPlaneCapabilities2KHR", ExactSpelling = true)]
        public static extern VkResult vkGetDisplayPlaneCapabilities2KHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkDisplayPlaneInfo2KHR *")] VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, [NativeTypeName("VkDisplayPlaneCapabilities2KHR *")] VkDisplayPlaneCapabilities2KHR* pCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageMemoryRequirements2KHR", ExactSpelling = true)]
        public static extern void vkGetImageMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")] VkImageMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetBufferMemoryRequirements2KHR", ExactSpelling = true)]
        public static extern void vkGetBufferMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")] VkBufferMemoryRequirementsInfo2* pInfo, [NativeTypeName("VkMemoryRequirements2 *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", ExactSpelling = true)]
        public static extern void vkGetImageSparseMemoryRequirements2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")] VkImageSparseMemoryRequirementsInfo2* pInfo, [NativeTypeName("uint32_t *")] uint* pSparseMemoryRequirementCount, [NativeTypeName("VkSparseImageMemoryRequirements2 *")] VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateSamplerYcbcrConversionKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateSamplerYcbcrConversionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")] VkSamplerYcbcrConversionCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSamplerYcbcrConversion *")] ulong* pYcbcrConversion);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroySamplerYcbcrConversionKHR", ExactSpelling = true)]
        public static extern void vkDestroySamplerYcbcrConversionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSamplerYcbcrConversion")] ulong ycbcrConversion, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkBindBufferMemory2KHR", ExactSpelling = true)]
        public static extern VkResult vkBindBufferMemory2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindBufferMemoryInfo *")] VkBindBufferMemoryInfo* pBindInfos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkBindImageMemory2KHR", ExactSpelling = true)]
        public static extern VkResult vkBindImageMemory2KHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindImageMemoryInfo *")] VkBindImageMemoryInfo* pBindInfos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDescriptorSetLayoutSupportKHR", ExactSpelling = true)]
        public static extern void vkGetDescriptorSetLayoutSupportKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")] VkDescriptorSetLayoutCreateInfo* pCreateInfo, [NativeTypeName("VkDescriptorSetLayoutSupport *")] VkDescriptorSetLayoutSupport* pSupport);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawIndirectCountKHR", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCountKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawIndexedIndirectCountKHR", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCountKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetSemaphoreCounterValueKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreCounterValueKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSemaphore")] ulong semaphore, [NativeTypeName("uint64_t *")] ulong* pValue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkWaitSemaphoresKHR", ExactSpelling = true)]
        public static extern VkResult vkWaitSemaphoresKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreWaitInfoKHR *")] VkSemaphoreWaitInfoKHR* pWaitInfo, [NativeTypeName("uint64_t")] ulong timeout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkSignalSemaphoreKHR", ExactSpelling = true)]
        public static extern VkResult vkSignalSemaphoreKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreSignalInfoKHR *")] VkSemaphoreSignalInfoKHR* pSignalInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPipelineExecutablePropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutablePropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineInfoKHR *")] VkPipelineInfoKHR* pPipelineInfo, [NativeTypeName("uint32_t *")] uint* pExecutableCount, [NativeTypeName("VkPipelineExecutablePropertiesKHR *")] VkPipelineExecutablePropertiesKHR* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPipelineExecutableStatisticsKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutableStatisticsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pStatisticCount, [NativeTypeName("VkPipelineExecutableStatisticKHR *")] VkPipelineExecutableStatisticKHR* pStatistics);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR", ExactSpelling = true)]
        public static extern VkResult vkGetPipelineExecutableInternalRepresentationsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPipelineExecutableInfoKHR *")] VkPipelineExecutableInfoKHR* pExecutableInfo, [NativeTypeName("uint32_t *")] uint* pInternalRepresentationCount, [NativeTypeName("VkPipelineExecutableInternalRepresentationKHR *")] VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDebugReportCallbackEXT", ExactSpelling = true)]
        public static extern VkResult vkCreateDebugReportCallbackEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDebugReportCallbackCreateInfoEXT *")] VkDebugReportCallbackCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDebugReportCallbackEXT *")] ulong* pCallback);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyDebugReportCallbackEXT", ExactSpelling = true)]
        public static extern void vkDestroyDebugReportCallbackEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugReportCallbackEXT")] ulong callback, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDebugReportMessageEXT", ExactSpelling = true)]
        public static extern void vkDebugReportMessageEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugReportFlagsEXT")] uint flags, VkDebugReportObjectTypeEXT objectType, [NativeTypeName("uint64_t")] ulong @object, [NativeTypeName("size_t")] UIntPtr location, [NativeTypeName("int32_t")] int messageCode, [NativeTypeName("const char *")] sbyte* pLayerPrefix, [NativeTypeName("const char *")] sbyte* pMessage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDebugMarkerSetObjectTagEXT", ExactSpelling = true)]
        public static extern VkResult vkDebugMarkerSetObjectTagEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugMarkerObjectTagInfoEXT *")] VkDebugMarkerObjectTagInfoEXT* pTagInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDebugMarkerSetObjectNameEXT", ExactSpelling = true)]
        public static extern VkResult vkDebugMarkerSetObjectNameEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugMarkerObjectNameInfoEXT *")] VkDebugMarkerObjectNameInfoEXT* pNameInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDebugMarkerBeginEXT", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerBeginEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDebugMarkerEndEXT", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerEndEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDebugMarkerInsertEXT", ExactSpelling = true)]
        public static extern void vkCmdDebugMarkerInsertEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugMarkerMarkerInfoEXT *")] VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", ExactSpelling = true)]
        public static extern void vkCmdBindTransformFeedbackBuffersEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstBinding, [NativeTypeName("uint32_t")] uint bindingCount, [NativeTypeName("const VkBuffer *")] ulong* pBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pOffsets, [NativeTypeName("const VkDeviceSize *")] ulong* pSizes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBeginTransformFeedbackEXT", ExactSpelling = true)]
        public static extern void vkCmdBeginTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] ulong* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdEndTransformFeedbackEXT", ExactSpelling = true)]
        public static extern void vkCmdEndTransformFeedbackEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstCounterBuffer, [NativeTypeName("uint32_t")] uint counterBufferCount, [NativeTypeName("const VkBuffer *")] ulong* pCounterBuffers, [NativeTypeName("const VkDeviceSize *")] ulong* pCounterBufferOffsets);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBeginQueryIndexedEXT", ExactSpelling = true)]
        public static extern void vkCmdBeginQueryIndexedEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags, [NativeTypeName("uint32_t")] uint index);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdEndQueryIndexedEXT", ExactSpelling = true)]
        public static extern void vkCmdEndQueryIndexedEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("uint32_t")] uint index);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawIndirectByteCountEXT", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectByteCountEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint instanceCount, [NativeTypeName("uint32_t")] uint firstInstance, [NativeTypeName("VkBuffer")] ulong counterBuffer, [NativeTypeName("VkDeviceSize")] ulong counterBufferOffset, [NativeTypeName("uint32_t")] uint counterOffset, [NativeTypeName("uint32_t")] uint vertexStride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageViewHandleNVX", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint vkGetImageViewHandleNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImageViewHandleInfoNVX *")] VkImageViewHandleInfoNVX* pInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawIndirectCountAMD", ExactSpelling = true)]
        public static extern void vkCmdDrawIndirectCountAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawIndexedIndirectCountAMD", ExactSpelling = true)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetShaderInfoAMD", ExactSpelling = true)]
        public static extern VkResult vkGetShaderInfoAMD([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, [NativeTypeName("size_t *")] UIntPtr* pInfoSize, [NativeTypeName("void *")] void* pInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, [NativeTypeName("VkImageUsageFlags")] uint usage, [NativeTypeName("VkImageCreateFlags")] uint flags, [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")] uint externalHandleType, [NativeTypeName("VkExternalImageFormatPropertiesNV *")] VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBeginConditionalRenderingEXT", ExactSpelling = true)]
        public static extern void vkCmdBeginConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkConditionalRenderingBeginInfoEXT *")] VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdEndConditionalRenderingEXT", ExactSpelling = true)]
        public static extern void vkCmdEndConditionalRenderingEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdProcessCommandsNVX", ExactSpelling = true)]
        public static extern void vkCmdProcessCommandsNVX([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCmdProcessCommandsInfoNVX *")] VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdReserveSpaceForCommandsNVX", ExactSpelling = true)]
        public static extern void vkCmdReserveSpaceForCommandsNVX([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkCmdReserveSpaceForCommandsInfoNVX *")] VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateIndirectCommandsLayoutNVX", ExactSpelling = true)]
        public static extern VkResult vkCreateIndirectCommandsLayoutNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkIndirectCommandsLayoutCreateInfoNVX *")] VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkIndirectCommandsLayoutNVX *")] ulong* pIndirectCommandsLayout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyIndirectCommandsLayoutNVX", ExactSpelling = true)]
        public static extern void vkDestroyIndirectCommandsLayoutNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkIndirectCommandsLayoutNVX")] ulong indirectCommandsLayout, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateObjectTableNVX", ExactSpelling = true)]
        public static extern VkResult vkCreateObjectTableNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkObjectTableCreateInfoNVX *")] VkObjectTableCreateInfoNVX* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkObjectTableNVX *")] ulong* pObjectTable);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyObjectTableNVX", ExactSpelling = true)]
        public static extern void vkDestroyObjectTableNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkObjectTableNVX")] ulong objectTable, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkRegisterObjectsNVX", ExactSpelling = true)]
        public static extern VkResult vkRegisterObjectsNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkObjectTableNVX")] ulong objectTable, [NativeTypeName("uint32_t")] uint objectCount, [NativeTypeName("const VkObjectTableEntryNVX *const *")] VkObjectTableEntryNVX** ppObjectTableEntries, [NativeTypeName("const uint32_t *")] uint* pObjectIndices);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkUnregisterObjectsNVX", ExactSpelling = true)]
        public static extern VkResult vkUnregisterObjectsNVX([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkObjectTableNVX")] ulong objectTable, [NativeTypeName("uint32_t")] uint objectCount, [NativeTypeName("const VkObjectEntryTypeNVX *")] VkObjectEntryTypeNVX* pObjectEntryTypes, [NativeTypeName("const uint32_t *")] uint* pObjectIndices);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDeviceGeneratedCommandsFeaturesNVX *")] VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, [NativeTypeName("VkDeviceGeneratedCommandsLimitsNVX *")] VkDeviceGeneratedCommandsLimitsNVX* pLimits);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetViewportWScalingNV", ExactSpelling = true)]
        public static extern void vkCmdSetViewportWScalingNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkViewportWScalingNV *")] VkViewportWScalingNV* pViewportWScalings);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkReleaseDisplayEXT", ExactSpelling = true)]
        public static extern VkResult vkReleaseDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkDisplayKHR")] ulong display);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("VkSurfaceKHR")] ulong surface, [NativeTypeName("VkSurfaceCapabilities2EXT *")] VkSurfaceCapabilities2EXT* pSurfaceCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDisplayPowerControlEXT", ExactSpelling = true)]
        public static extern VkResult vkDisplayPowerControlEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayPowerInfoEXT *")] VkDisplayPowerInfoEXT* pDisplayPowerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkRegisterDeviceEventEXT", ExactSpelling = true)]
        public static extern VkResult vkRegisterDeviceEventEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDeviceEventInfoEXT *")] VkDeviceEventInfoEXT* pDeviceEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkRegisterDisplayEventEXT", ExactSpelling = true)]
        public static extern VkResult vkRegisterDisplayEventEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDisplayKHR")] ulong display, [NativeTypeName("const VkDisplayEventInfoEXT *")] VkDisplayEventInfoEXT* pDisplayEventInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkFence *")] ulong* pFence);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetSwapchainCounterEXT", ExactSpelling = true)]
        public static extern VkResult vkGetSwapchainCounterEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, VkSurfaceCounterFlagBitsEXT counter, [NativeTypeName("uint64_t *")] ulong* pCounterValue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetRefreshCycleDurationGOOGLE", ExactSpelling = true)]
        public static extern VkResult vkGetRefreshCycleDurationGOOGLE([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("VkRefreshCycleDurationGOOGLE *")] VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPastPresentationTimingGOOGLE", ExactSpelling = true)]
        public static extern VkResult vkGetPastPresentationTimingGOOGLE([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain, [NativeTypeName("uint32_t *")] uint* pPresentationTimingCount, [NativeTypeName("VkPastPresentationTimingGOOGLE *")] VkPastPresentationTimingGOOGLE* pPresentationTimings);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetDiscardRectangleEXT", ExactSpelling = true)]
        public static extern void vkCmdSetDiscardRectangleEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstDiscardRectangle, [NativeTypeName("uint32_t")] uint discardRectangleCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pDiscardRectangles);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkSetHdrMetadataEXT", ExactSpelling = true)]
        public static extern void vkSetHdrMetadataEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint swapchainCount, [NativeTypeName("const VkSwapchainKHR *")] ulong* pSwapchains, [NativeTypeName("const VkHdrMetadataEXT *")] VkHdrMetadataEXT* pMetadata);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkSetDebugUtilsObjectNameEXT", ExactSpelling = true)]
        public static extern VkResult vkSetDebugUtilsObjectNameEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")] VkDebugUtilsObjectNameInfoEXT* pNameInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkSetDebugUtilsObjectTagEXT", ExactSpelling = true)]
        public static extern VkResult vkSetDebugUtilsObjectTagEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkDebugUtilsObjectTagInfoEXT *")] VkDebugUtilsObjectTagInfoEXT* pTagInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkQueueBeginDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkQueueBeginDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkQueueEndDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkQueueEndDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkQueueInsertDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkQueueInsertDebugUtilsLabelEXT([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBeginDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkCmdBeginDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdEndDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkCmdEndDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdInsertDebugUtilsLabelEXT", ExactSpelling = true)]
        public static extern void vkCmdInsertDebugUtilsLabelEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkDebugUtilsLabelEXT *")] VkDebugUtilsLabelEXT* pLabelInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateDebugUtilsMessengerEXT", ExactSpelling = true)]
        public static extern VkResult vkCreateDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkDebugUtilsMessengerCreateInfoEXT *")] VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkDebugUtilsMessengerEXT *")] ulong* pMessenger);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyDebugUtilsMessengerEXT", ExactSpelling = true)]
        public static extern void vkDestroyDebugUtilsMessengerEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("VkDebugUtilsMessengerEXT")] ulong messenger, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkSubmitDebugUtilsMessageEXT", ExactSpelling = true)]
        public static extern void vkSubmitDebugUtilsMessageEXT([NativeTypeName("VkInstance")] IntPtr instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")] uint messageTypes, [NativeTypeName("const VkDebugUtilsMessengerCallbackDataEXT *")] VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetSampleLocationsEXT", ExactSpelling = true)]
        public static extern void vkCmdSetSampleLocationsEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkSampleLocationsInfoEXT *")] VkSampleLocationsInfoEXT* pSampleLocationsInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT", ExactSpelling = true)]
        public static extern void vkGetPhysicalDeviceMultisamplePropertiesEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, VkSampleCountFlagBits samples, [NativeTypeName("VkMultisamplePropertiesEXT *")] VkMultisamplePropertiesEXT* pMultisampleProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT", ExactSpelling = true)]
        public static extern VkResult vkGetImageDrmFormatModifierPropertiesEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkImage")] ulong image, [NativeTypeName("VkImageDrmFormatModifierPropertiesEXT *")] VkImageDrmFormatModifierPropertiesEXT* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateValidationCacheEXT", ExactSpelling = true)]
        public static extern VkResult vkCreateValidationCacheEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkValidationCacheCreateInfoEXT *")] VkValidationCacheCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkValidationCacheEXT *")] ulong* pValidationCache);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyValidationCacheEXT", ExactSpelling = true)]
        public static extern void vkDestroyValidationCacheEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong validationCache, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkMergeValidationCachesEXT", ExactSpelling = true)]
        public static extern VkResult vkMergeValidationCachesEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong dstCache, [NativeTypeName("uint32_t")] uint srcCacheCount, [NativeTypeName("const VkValidationCacheEXT *")] ulong* pSrcCaches);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetValidationCacheDataEXT", ExactSpelling = true)]
        public static extern VkResult vkGetValidationCacheDataEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkValidationCacheEXT")] ulong validationCache, [NativeTypeName("size_t *")] UIntPtr* pDataSize, [NativeTypeName("void *")] void* pData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBindShadingRateImageNV", ExactSpelling = true)]
        public static extern void vkCmdBindShadingRateImageNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkImageView")] ulong imageView, VkImageLayout imageLayout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetViewportShadingRatePaletteNV", ExactSpelling = true)]
        public static extern void vkCmdSetViewportShadingRatePaletteNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstViewport, [NativeTypeName("uint32_t")] uint viewportCount, [NativeTypeName("const VkShadingRatePaletteNV *")] VkShadingRatePaletteNV* pShadingRatePalettes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetCoarseSampleOrderNV", ExactSpelling = true)]
        public static extern void vkCmdSetCoarseSampleOrderNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, [NativeTypeName("uint32_t")] uint customSampleOrderCount, [NativeTypeName("const VkCoarseSampleOrderCustomNV *")] VkCoarseSampleOrderCustomNV* pCustomSampleOrders);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateAccelerationStructureNV", ExactSpelling = true)]
        public static extern VkResult vkCreateAccelerationStructureNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureCreateInfoNV *")] VkAccelerationStructureCreateInfoNV* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkAccelerationStructureNV *")] ulong* pAccelerationStructure);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkDestroyAccelerationStructureNV", ExactSpelling = true)]
        public static extern void vkDestroyAccelerationStructureNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureNV")] ulong accelerationStructure, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV", ExactSpelling = true)]
        public static extern void vkGetAccelerationStructureMemoryRequirementsNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureMemoryRequirementsInfoNV *")] VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, [NativeTypeName("VkMemoryRequirements2KHR *")] VkMemoryRequirements2* pMemoryRequirements);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkBindAccelerationStructureMemoryNV", ExactSpelling = true)]
        public static extern VkResult vkBindAccelerationStructureMemoryNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint bindInfoCount, [NativeTypeName("const VkBindAccelerationStructureMemoryInfoNV *")] VkBindAccelerationStructureMemoryInfoNV* pBindInfos);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdBuildAccelerationStructureNV", ExactSpelling = true)]
        public static extern void vkCmdBuildAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkAccelerationStructureInfoNV *")] VkAccelerationStructureInfoNV* pInfo, [NativeTypeName("VkBuffer")] ulong instanceData, [NativeTypeName("VkDeviceSize")] ulong instanceOffset, [NativeTypeName("VkBool32")] uint update, [NativeTypeName("VkAccelerationStructureNV")] ulong dst, [NativeTypeName("VkAccelerationStructureNV")] ulong src, [NativeTypeName("VkBuffer")] ulong scratch, [NativeTypeName("VkDeviceSize")] ulong scratchOffset);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdCopyAccelerationStructureNV", ExactSpelling = true)]
        public static extern void vkCmdCopyAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkAccelerationStructureNV")] ulong dst, [NativeTypeName("VkAccelerationStructureNV")] ulong src, VkCopyAccelerationStructureModeNV mode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdTraceRaysNV", ExactSpelling = true)]
        public static extern void vkCmdTraceRaysNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong raygenShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong raygenShaderBindingOffset, [NativeTypeName("VkBuffer")] ulong missShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong missShaderBindingStride, [NativeTypeName("VkBuffer")] ulong hitShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong hitShaderBindingStride, [NativeTypeName("VkBuffer")] ulong callableShaderBindingTableBuffer, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingOffset, [NativeTypeName("VkDeviceSize")] ulong callableShaderBindingStride, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateRayTracingPipelinesNV", ExactSpelling = true)]
        public static extern VkResult vkCreateRayTracingPipelinesNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipelineCache")] ulong pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkRayTracingPipelineCreateInfoNV *")] VkRayTracingPipelineCreateInfoNV* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkPipeline *")] ulong* pPipelines);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetRayTracingShaderGroupHandlesNV", ExactSpelling = true)]
        public static extern VkResult vkGetRayTracingShaderGroupHandlesNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint firstGroup, [NativeTypeName("uint32_t")] uint groupCount, [NativeTypeName("size_t")] UIntPtr dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetAccelerationStructureHandleNV", ExactSpelling = true)]
        public static extern VkResult vkGetAccelerationStructureHandleNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkAccelerationStructureNV")] ulong accelerationStructure, [NativeTypeName("size_t")] UIntPtr dataSize, [NativeTypeName("void *")] void* pData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV", ExactSpelling = true)]
        public static extern void vkCmdWriteAccelerationStructuresPropertiesNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureNV *")] ulong* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCompileDeferredNV", ExactSpelling = true)]
        public static extern VkResult vkCompileDeferredNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPipeline")] ulong pipeline, [NativeTypeName("uint32_t")] uint shader);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetMemoryHostPointerPropertiesEXT", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryHostPointerPropertiesEXT([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, [NativeTypeName("const void *")] void* pHostPointer, [NativeTypeName("VkMemoryHostPointerPropertiesEXT *")] VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdWriteBufferMarkerAMD", ExactSpelling = true)]
        public static extern void vkCmdWriteBufferMarkerAMD([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, [NativeTypeName("VkBuffer")] ulong dstBuffer, [NativeTypeName("VkDeviceSize")] ulong dstOffset, [NativeTypeName("uint32_t")] uint marker);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pTimeDomainCount, [NativeTypeName("VkTimeDomainEXT *")] VkTimeDomainEXT* pTimeDomains);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetCalibratedTimestampsEXT", ExactSpelling = true)]
        public static extern VkResult vkGetCalibratedTimestampsEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint timestampCount, [NativeTypeName("const VkCalibratedTimestampInfoEXT *")] VkCalibratedTimestampInfoEXT* pTimestampInfos, [NativeTypeName("uint64_t *")] ulong* pTimestamps, [NativeTypeName("uint64_t *")] ulong* pMaxDeviation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawMeshTasksNV", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint taskCount, [NativeTypeName("uint32_t")] uint firstTask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawMeshTasksIndirectNV", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksIndirectNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("uint32_t")] uint drawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV", ExactSpelling = true)]
        public static extern void vkCmdDrawMeshTasksIndirectCountNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkBuffer")] ulong buffer, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkBuffer")] ulong countBuffer, [NativeTypeName("VkDeviceSize")] ulong countBufferOffset, [NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("uint32_t")] uint stride);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetExclusiveScissorNV", ExactSpelling = true)]
        public static extern void vkCmdSetExclusiveScissorNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint firstExclusiveScissor, [NativeTypeName("uint32_t")] uint exclusiveScissorCount, [NativeTypeName("const VkRect2D *")] VkRect2D* pExclusiveScissors);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetCheckpointNV", ExactSpelling = true)]
        public static extern void vkCmdSetCheckpointNV([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const void *")] void* pCheckpointMarker);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetQueueCheckpointDataNV", ExactSpelling = true)]
        public static extern void vkGetQueueCheckpointDataNV([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("uint32_t *")] uint* pCheckpointDataCount, [NativeTypeName("VkCheckpointDataNV *")] VkCheckpointDataNV* pCheckpointData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkInitializePerformanceApiINTEL", ExactSpelling = true)]
        public static extern VkResult vkInitializePerformanceApiINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkInitializePerformanceApiInfoINTEL *")] VkInitializePerformanceApiInfoINTEL* pInitializeInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkUninitializePerformanceApiINTEL", ExactSpelling = true)]
        public static extern void vkUninitializePerformanceApiINTEL([NativeTypeName("VkDevice")] IntPtr device);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetPerformanceMarkerINTEL", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceMarkerINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceMarkerInfoINTEL *")] VkPerformanceMarkerInfoINTEL* pMarkerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceStreamMarkerInfoINTEL *")] VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetPerformanceOverrideINTEL", ExactSpelling = true)]
        public static extern VkResult vkCmdSetPerformanceOverrideINTEL([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkPerformanceOverrideInfoINTEL *")] VkPerformanceOverrideInfoINTEL* pOverrideInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkAcquirePerformanceConfigurationINTEL", ExactSpelling = true)]
        public static extern VkResult vkAcquirePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPerformanceConfigurationAcquireInfoINTEL *")] VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [NativeTypeName("VkPerformanceConfigurationINTEL *")] ulong* pConfiguration);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkReleasePerformanceConfigurationINTEL", ExactSpelling = true)]
        public static extern VkResult vkReleasePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkPerformanceConfigurationINTEL")] ulong configuration);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkQueueSetPerformanceConfigurationINTEL", ExactSpelling = true)]
        public static extern VkResult vkQueueSetPerformanceConfigurationINTEL([NativeTypeName("VkQueue")] IntPtr queue, [NativeTypeName("VkPerformanceConfigurationINTEL")] ulong configuration);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPerformanceParameterINTEL", ExactSpelling = true)]
        public static extern VkResult vkGetPerformanceParameterINTEL([NativeTypeName("VkDevice")] IntPtr device, VkPerformanceParameterTypeINTEL parameter, [NativeTypeName("VkPerformanceValueINTEL *")] VkPerformanceValueINTEL* pValue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkSetLocalDimmingAMD", ExactSpelling = true)]
        public static extern void vkSetLocalDimmingAMD([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapChain, [NativeTypeName("VkBool32")] uint localDimmingEnable);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetBufferDeviceAddressEXT", ExactSpelling = true)]
        [return: NativeTypeName("VkDeviceAddress")]
        public static extern ulong vkGetBufferDeviceAddressEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkBufferDeviceAddressInfoEXT *")] VkBufferDeviceAddressInfoEXT* pInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkCooperativeMatrixPropertiesNV *")] VkCooperativeMatrixPropertiesNV* pProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t *")] uint* pCombinationCount, [NativeTypeName("VkFramebufferMixedSamplesCombinationNV *")] VkFramebufferMixedSamplesCombinationNV* pCombinations);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateHeadlessSurfaceEXT", ExactSpelling = true)]
        public static extern VkResult vkCreateHeadlessSurfaceEXT([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkHeadlessSurfaceCreateInfoEXT *")] VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCmdSetLineStippleEXT", ExactSpelling = true)]
        public static extern void vkCmdSetLineStippleEXT([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("uint32_t")] uint lineStippleFactor, [NativeTypeName("uint16_t")] ushort lineStipplePattern);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkResetQueryPoolEXT", ExactSpelling = true)]
        public static extern void vkResetQueryPoolEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount);
    }
}
