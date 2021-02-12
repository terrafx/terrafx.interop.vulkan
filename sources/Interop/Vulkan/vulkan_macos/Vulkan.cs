// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_macos.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateMacOSSurfaceMVK([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkMacOSSurfaceCreateInfoMVK *")] VkMacOSSurfaceCreateInfoMVK* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [NativeTypeName("#define VK_MVK_macos_surface 1")]
        public const int VK_MVK_macos_surface = 1;

        [NativeTypeName("#define VK_MVK_MACOS_SURFACE_SPEC_VERSION 3")]
        public const int VK_MVK_MACOS_SURFACE_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_MVK_MACOS_SURFACE_EXTENSION_NAME \"VK_MVK_macos_surface\"")]
        public static ReadOnlySpan<byte> VK_MVK_MACOS_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4D, 0x56, 0x4B, 0x5F, 0x6D, 0x61, 0x63, 0x6F, 0x73, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };
    }
}
