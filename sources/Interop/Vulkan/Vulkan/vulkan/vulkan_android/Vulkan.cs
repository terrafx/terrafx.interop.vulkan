// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_KHR_android_surface 1")]
    public const int VK_KHR_android_surface = 1;

    [NativeTypeName("#define VK_KHR_ANDROID_SURFACE_SPEC_VERSION 6")]
    public const int VK_KHR_ANDROID_SURFACE_SPEC_VERSION = 6;

    [NativeTypeName("#define VK_KHR_ANDROID_SURFACE_EXTENSION_NAME \"VK_KHR_android_surface\"")]
    public static ReadOnlySpan<byte> VK_KHR_ANDROID_SURFACE_EXTENSION_NAME => "VK_KHR_android_surface"u8;

    [NativeTypeName("#define VK_ANDROID_external_memory_android_hardware_buffer 1")]
    public const int VK_ANDROID_external_memory_android_hardware_buffer = 1;

    [NativeTypeName("#define VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION 5")]
    public const int VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION = 5;

    [NativeTypeName("#define VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME \"VK_ANDROID_external_memory_android_hardware_buffer\"")]
    public static ReadOnlySpan<byte> VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME => "VK_ANDROID_external_memory_android_hardware_buffer"u8;

    [NativeTypeName("#define VK_ANDROID_external_format_resolve 1")]
    public const int VK_ANDROID_external_format_resolve = 1;

    [NativeTypeName("#define VK_ANDROID_EXTERNAL_FORMAT_RESOLVE_SPEC_VERSION 1")]
    public const int VK_ANDROID_EXTERNAL_FORMAT_RESOLVE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_ANDROID_EXTERNAL_FORMAT_RESOLVE_EXTENSION_NAME \"VK_ANDROID_external_format_resolve\"")]
    public static ReadOnlySpan<byte> VK_ANDROID_EXTERNAL_FORMAT_RESOLVE_EXTENSION_NAME => "VK_ANDROID_external_format_resolve"u8;
}
