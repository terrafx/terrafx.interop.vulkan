// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_xlib.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateXlibSurfaceKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateXlibSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkXlibSurfaceCreateInfoKHR *")] VkXlibSurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceXlibPresentationSupportKHR", ExactSpelling = true)]
        [return: NativeTypeName("VkBool32")]
        public static extern uint vkGetPhysicalDeviceXlibPresentationSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("VisualID")] UIntPtr visualID);
    }
}
