// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_win32.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateWin32SurfaceKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateWin32SurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkWin32SurfaceCreateInfoKHR *")] VkWin32SurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceWin32PresentationSupportKHR", ExactSpelling = true)]
        [return: NativeTypeName("VkBool32")]
        public static extern uint vkGetPhysicalDeviceWin32PresentationSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetMemoryWin32HandleKHR", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryWin32HandleKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryGetWin32HandleInfoKHR *")] VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryWin32HandlePropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, [NativeTypeName("HANDLE")] IntPtr handle, [NativeTypeName("VkMemoryWin32HandlePropertiesKHR *")] VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkImportSemaphoreWin32HandleKHR", ExactSpelling = true)]
        public static extern VkResult vkImportSemaphoreWin32HandleKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportSemaphoreWin32HandleInfoKHR *")] VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetSemaphoreWin32HandleKHR", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreWin32HandleKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkSemaphoreGetWin32HandleInfoKHR *")] VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkImportFenceWin32HandleKHR", ExactSpelling = true)]
        public static extern VkResult vkImportFenceWin32HandleKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportFenceWin32HandleInfoKHR *")] VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetFenceWin32HandleKHR", ExactSpelling = true)]
        public static extern VkResult vkGetFenceWin32HandleKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkFenceGetWin32HandleInfoKHR *")] VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetMemoryWin32HandleNV", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryWin32HandleNV([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkDeviceMemory")] ulong memory, [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")] uint handleType, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("uint32_t *")] uint* pPresentModeCount, [NativeTypeName("VkPresentModeKHR *")] VkPresentModeKHR* pPresentModes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkAcquireFullScreenExclusiveModeEXT", ExactSpelling = true)]
        public static extern VkResult vkAcquireFullScreenExclusiveModeEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkReleaseFullScreenExclusiveModeEXT", ExactSpelling = true)]
        public static extern VkResult vkReleaseFullScreenExclusiveModeEXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkSwapchainKHR")] ulong swapchain);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceGroupSurfacePresentModes2EXT([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("VkDeviceGroupPresentModeFlagsKHR *")] uint* pModes);
    }
}
