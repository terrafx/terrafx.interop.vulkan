// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_xlib_xrandr.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkAcquireXlibDisplayEXT", ExactSpelling = true)]
        public static extern VkResult vkAcquireXlibDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("VkDisplayKHR")] ulong display);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetRandROutputDisplayEXT", ExactSpelling = true)]
        public static extern VkResult vkGetRandROutputDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("RROutput")] uint rrOutput, [NativeTypeName("VkDisplayKHR *")] ulong* pDisplay);
    }
}
