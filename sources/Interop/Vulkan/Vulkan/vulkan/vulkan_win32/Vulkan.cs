// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateWin32SurfaceKHR(VkInstance instance, [NativeTypeName("const VkWin32SurfaceCreateInfoKHR *")] VkWin32SurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryWin32HandleKHR(VkDevice device, [NativeTypeName("const VkMemoryGetWin32HandleInfoKHR *")] VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, [NativeTypeName("VkExternalMemoryHandleTypeFlagBits")] VkExternalMemoryHandleTypeFlags handleType, [NativeTypeName("HANDLE")] IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, [NativeTypeName("const VkImportSemaphoreWin32HandleInfoKHR *")] VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, [NativeTypeName("const VkSemaphoreGetWin32HandleInfoKHR *")] VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkImportFenceWin32HandleKHR(VkDevice device, [NativeTypeName("const VkImportFenceWin32HandleInfoKHR *")] VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetFenceWin32HandleKHR(VkDevice device, [NativeTypeName("const VkFenceGetWin32HandleInfoKHR *")] VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [NativeTypeName("uint32_t *")] uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, [NativeTypeName("const VkPhysicalDeviceSurfaceInfo2KHR *")] VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes);

        [NativeTypeName("#define VK_KHR_win32_surface 1")]
        public const int VK_KHR_win32_surface = 1;

        [NativeTypeName("#define VK_KHR_WIN32_SURFACE_SPEC_VERSION 6")]
        public const int VK_KHR_WIN32_SURFACE_SPEC_VERSION = 6;

        [NativeTypeName("#define VK_KHR_WIN32_SURFACE_EXTENSION_NAME \"VK_KHR_win32_surface\"")]
        public static ReadOnlySpan<byte> VK_KHR_WIN32_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_external_memory_win32 1")]
        public const int VK_KHR_external_memory_win32 = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME \"VK_KHR_external_memory_win32\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_win32_keyed_mutex 1")]
        public const int VK_KHR_win32_keyed_mutex = 1;

        [NativeTypeName("#define VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION 1")]
        public const int VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME \"VK_KHR_win32_keyed_mutex\"")]
        public static ReadOnlySpan<byte> VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x5F, 0x6B, 0x65, 0x79, 0x65, 0x64, 0x5F, 0x6D, 0x75, 0x74, 0x65, 0x78, 0x00 };

        [NativeTypeName("#define VK_KHR_external_semaphore_win32 1")]
        public const int VK_KHR_external_semaphore_win32 = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME \"VK_KHR_external_semaphore_win32\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x70, 0x68, 0x6F, 0x72, 0x65, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define VK_KHR_external_fence_win32 1")]
        public const int VK_KHR_external_fence_win32 = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME \"VK_KHR_external_fence_win32\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x66, 0x65, 0x6E, 0x63, 0x65, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define VK_NV_external_memory_win32 1")]
        public const int VK_NV_external_memory_win32 = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION 1")]
        public const int VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME \"VK_NV_external_memory_win32\"")]
        public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define VK_NV_win32_keyed_mutex 1")]
        public const int VK_NV_win32_keyed_mutex = 1;

        [NativeTypeName("#define VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION 2")]
        public const int VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME \"VK_NV_win32_keyed_mutex\"")]
        public static ReadOnlySpan<byte> VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x5F, 0x6B, 0x65, 0x79, 0x65, 0x64, 0x5F, 0x6D, 0x75, 0x74, 0x65, 0x78, 0x00 };

        [NativeTypeName("#define VK_EXT_full_screen_exclusive 1")]
        public const int VK_EXT_full_screen_exclusive = 1;

        [NativeTypeName("#define VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION 4")]
        public const int VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME \"VK_EXT_full_screen_exclusive\"")]
        public static ReadOnlySpan<byte> VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x66, 0x75, 0x6C, 0x6C, 0x5F, 0x73, 0x63, 0x72, 0x65, 0x65, 0x6E, 0x5F, 0x65, 0x78, 0x63, 0x6C, 0x75, 0x73, 0x69, 0x76, 0x65, 0x00 };
    }
}