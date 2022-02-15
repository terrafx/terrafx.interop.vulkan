// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan
{
    public static partial class Vulkan
    {
        [NativeTypeName("#define VK_KHR_android_surface 1")]
        public const int VK_KHR_android_surface = 1;

        [NativeTypeName("#define VK_KHR_ANDROID_SURFACE_SPEC_VERSION 6")]
        public const int VK_KHR_ANDROID_SURFACE_SPEC_VERSION = 6;

        [NativeTypeName("#define VK_KHR_ANDROID_SURFACE_EXTENSION_NAME \"VK_KHR_android_surface\"")]
        public static ReadOnlySpan<byte> VK_KHR_ANDROID_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x61, 0x6E, 0x64, 0x72, 0x6F, 0x69, 0x64, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_ANDROID_external_memory_android_hardware_buffer 1")]
        public const int VK_ANDROID_external_memory_android_hardware_buffer = 1;

        [NativeTypeName("#define VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION 4")]
        public const int VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME \"VK_ANDROID_external_memory_android_hardware_buffer\"")]
        public static ReadOnlySpan<byte> VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x41, 0x4E, 0x44, 0x52, 0x4F, 0x49, 0x44, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x61, 0x6E, 0x64, 0x72, 0x6F, 0x69, 0x64, 0x5F, 0x68, 0x61, 0x72, 0x64, 0x77, 0x61, 0x72, 0x65, 0x5F, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x00 };
    }
}
