// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_xcb.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateXcbSurfaceKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateXcbSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkXcbSurfaceCreateInfoKHR *")] VkXcbSurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceXcbPresentationSupportKHR", ExactSpelling = true)]
        [return: NativeTypeName("VkBool32")]
        public static extern uint vkGetPhysicalDeviceXcbPresentationSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("xcb_connection_t *")] IntPtr connection, [NativeTypeName("xcb_visualid_t")] uint visual_id);
    }
}
