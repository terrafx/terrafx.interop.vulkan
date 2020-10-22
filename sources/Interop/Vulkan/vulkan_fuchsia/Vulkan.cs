// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateImagePipeSurfaceFUCHSIA([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkImagePipeSurfaceCreateInfoFUCHSIA *")] VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [NativeTypeName("#define VK_FUCHSIA_imagepipe_surface 1")]
        public const int VK_FUCHSIA_imagepipe_surface = 1;

        [NativeTypeName("#define VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION 1")]
        public const int VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME \"VK_FUCHSIA_imagepipe_surface\"")]
        public static ReadOnlySpan<byte> VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x46, 0x55, 0x43, 0x48, 0x53, 0x49, 0x41, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x70, 0x69, 0x70, 0x65, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };
    }
}
