// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_xlib_xrandr.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkAcquireXlibDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("Display *")] IntPtr dpy, [NativeTypeName("VkDisplayKHR")] ulong display);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetRandROutputDisplayEXT([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("Display *")] IntPtr dpy, [NativeTypeName("RROutput")] nuint rrOutput, [NativeTypeName("VkDisplayKHR *")] ulong* pDisplay);

        [NativeTypeName("#define VK_EXT_acquire_xlib_display 1")]
        public const int VK_EXT_acquire_xlib_display = 1;

        [NativeTypeName("#define VK_EXT_ACQUIRE_XLIB_DISPLAY_SPEC_VERSION 1")]
        public const int VK_EXT_ACQUIRE_XLIB_DISPLAY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME \"VK_EXT_acquire_xlib_display\"")]
        public static ReadOnlySpan<byte> VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x61, 0x63, 0x71, 0x75, 0x69, 0x72, 0x65, 0x5F, 0x78, 0x6C, 0x69, 0x62, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };
    }
}
