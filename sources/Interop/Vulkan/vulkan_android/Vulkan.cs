// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateAndroidSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkAndroidSurfaceCreateInfoKHR *")] VkAndroidSurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetAndroidHardwareBufferPropertiesANDROID([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const struct AHardwareBuffer *")] IntPtr buffer, [NativeTypeName("VkAndroidHardwareBufferPropertiesANDROID *")] VkAndroidHardwareBufferPropertiesANDROID* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetMemoryAndroidHardwareBufferANDROID([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkMemoryGetAndroidHardwareBufferInfoANDROID *")] VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, [NativeTypeName("struct AHardwareBuffer **")] IntPtr* pBuffer);

        [NativeTypeName("#define VK_KHR_android_surface 1")]
        public const int VK_KHR_android_surface = 1;

        [NativeTypeName("#define VK_KHR_ANDROID_SURFACE_SPEC_VERSION 6")]
        public const int VK_KHR_ANDROID_SURFACE_SPEC_VERSION = 6;

        [NativeTypeName("#define VK_KHR_ANDROID_SURFACE_EXTENSION_NAME \"VK_KHR_android_surface\"")]
        public static ReadOnlySpan<byte> VK_KHR_ANDROID_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x61, 0x6E, 0x64, 0x72, 0x6F, 0x69, 0x64, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_ANDROID_external_memory_android_hardware_buffer 1")]
        public const int VK_ANDROID_external_memory_android_hardware_buffer = 1;

        [NativeTypeName("#define VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION 3")]
        public const int VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME \"VK_ANDROID_external_memory_android_hardware_buffer\"")]
        public static ReadOnlySpan<byte> VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4E, 0x44, 0x52, 0x4F, 0x49, 0x44, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x61, 0x6E, 0x64, 0x72, 0x6F, 0x69, 0x64, 0x5F, 0x68, 0x61, 0x72, 0x64, 0x77, 0x61, 0x72, 0x65, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x00 };
    }
}
