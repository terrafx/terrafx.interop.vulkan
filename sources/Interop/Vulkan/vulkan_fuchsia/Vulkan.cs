// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_fuchsia.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(libraryPath, EntryPoint = "vkCreateImagePipeSurfaceFUCHSIA", CallingConvention = CallingConvention.Cdecl)]
        public static extern VkResult vkCreateImagePipeSurfaceFUCHSIA([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkImagePipeSurfaceCreateInfoFUCHSIA *")] VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);
    }
}
