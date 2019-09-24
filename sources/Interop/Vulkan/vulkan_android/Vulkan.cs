// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_android.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(libraryPath, EntryPoint = "vkCreateAndroidSurfaceKHR", CallingConvention = CallingConvention.Winapi, ExactSpelling = true)]
        public static extern VkResult vkCreateAndroidSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkAndroidSurfaceCreateInfoKHR *")] VkAndroidSurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(libraryPath, EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID", CallingConvention = CallingConvention.Winapi, ExactSpelling = true)]
        public static extern VkResult vkGetAndroidHardwareBufferPropertiesANDROID([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const struct AHardwareBuffer *")] IntPtr buffer, [NativeTypeName("VkAndroidHardwareBufferPropertiesANDROID *")] VkAndroidHardwareBufferPropertiesANDROID* pProperties);

        [DllImport(libraryPath, EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID", CallingConvention = CallingConvention.Winapi, ExactSpelling = true)]
        public static extern VkResult vkGetMemoryAndroidHardwareBufferANDROID([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryGetAndroidHardwareBufferInfoANDROID *")] VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, [NativeTypeName("struct AHardwareBuffer **")] IntPtr* pBuffer);
    }
}
