// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkDeviceManualImports
    {
        public delegate* unmanaged<VkDevice, VkMemoryGetWin32HandleInfoKHR*, IntPtr*, VkResult> vkGetMemoryWin32HandleKHR;

        public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlags, IntPtr, VkMemoryWin32HandlePropertiesKHR*, VkResult> vkGetMemoryWin32HandlePropertiesKHR;

        public delegate* unmanaged<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> vkImportSemaphoreWin32HandleKHR;

        public delegate* unmanaged<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, IntPtr*, VkResult> vkGetSemaphoreWin32HandleKHR;

        public delegate* unmanaged<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> vkImportFenceWin32HandleKHR;

        public delegate* unmanaged<VkDevice, VkFenceGetWin32HandleInfoKHR*, IntPtr*, VkResult> vkGetFenceWin32HandleKHR;

        public delegate* unmanaged<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagsNV, IntPtr*, VkResult> vkGetMemoryWin32HandleNV;

        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> vkAcquireFullScreenExclusiveModeEXT;

        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> vkReleaseFullScreenExclusiveModeEXT;

        public delegate* unmanaged<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagsKHR*, VkResult> vkGetDeviceGroupSurfacePresentModes2EXT;
    }
}
