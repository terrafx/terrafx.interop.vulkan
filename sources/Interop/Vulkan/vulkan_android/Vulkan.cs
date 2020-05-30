// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", EntryPoint = "vkCreateAndroidSurfaceKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateAndroidSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkAndroidSurfaceCreateInfoKHR *")] VkAndroidSurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport("vulkan", EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID", ExactSpelling = true)]
        public static extern VkResult vkGetAndroidHardwareBufferPropertiesANDROID([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const struct AHardwareBuffer *")] IntPtr buffer, [NativeTypeName("VkAndroidHardwareBufferPropertiesANDROID *")] VkAndroidHardwareBufferPropertiesANDROID* pProperties);

        [DllImport("vulkan", EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryAndroidHardwareBufferANDROID([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryGetAndroidHardwareBufferInfoANDROID *")] VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, [NativeTypeName("struct AHardwareBuffer **")] IntPtr* pBuffer);
    }
}
