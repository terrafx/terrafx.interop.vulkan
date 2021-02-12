// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_xcb.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateXcbSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkXcbSurfaceCreateInfoKHR *")] VkXcbSurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("VkBool32")]
        public static extern uint vkGetPhysicalDeviceXcbPresentationSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("xcb_connection_t *")] IntPtr connection, [NativeTypeName("xcb_visualid_t")] uint visual_id);

        [NativeTypeName("#define VK_KHR_xcb_surface 1")]
        public const int VK_KHR_xcb_surface = 1;

        [NativeTypeName("#define VK_KHR_XCB_SURFACE_SPEC_VERSION 6")]
        public const int VK_KHR_XCB_SURFACE_SPEC_VERSION = 6;

        [NativeTypeName("#define VK_KHR_XCB_SURFACE_EXTENSION_NAME \"VK_KHR_xcb_surface\"")]
        public static ReadOnlySpan<byte> VK_KHR_XCB_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x78, 0x63, 0x62, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };
    }
}
