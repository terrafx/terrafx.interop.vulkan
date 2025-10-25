// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_KHR_win32_surface 1")]
    public const int VK_KHR_win32_surface = 1;

    [NativeTypeName("#define VK_KHR_WIN32_SURFACE_SPEC_VERSION 6")]
    public const int VK_KHR_WIN32_SURFACE_SPEC_VERSION = 6;

    [NativeTypeName("#define VK_KHR_WIN32_SURFACE_EXTENSION_NAME \"VK_KHR_win32_surface\"")]
    public static ReadOnlySpan<byte> VK_KHR_WIN32_SURFACE_EXTENSION_NAME => "VK_KHR_win32_surface"u8;

    [NativeTypeName("#define VK_KHR_external_memory_win32 1")]
    public const int VK_KHR_external_memory_win32 = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME \"VK_KHR_external_memory_win32\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME => "VK_KHR_external_memory_win32"u8;

    [NativeTypeName("#define VK_KHR_win32_keyed_mutex 1")]
    public const int VK_KHR_win32_keyed_mutex = 1;

    [NativeTypeName("#define VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION 1")]
    public const int VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME \"VK_KHR_win32_keyed_mutex\"")]
    public static ReadOnlySpan<byte> VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME => "VK_KHR_win32_keyed_mutex"u8;

    [NativeTypeName("#define VK_KHR_external_semaphore_win32 1")]
    public const int VK_KHR_external_semaphore_win32 = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME \"VK_KHR_external_semaphore_win32\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME => "VK_KHR_external_semaphore_win32"u8;

    [NativeTypeName("#define VK_KHR_external_fence_win32 1")]
    public const int VK_KHR_external_fence_win32 = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION 1")]
    public const int VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME \"VK_KHR_external_fence_win32\"")]
    public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME => "VK_KHR_external_fence_win32"u8;

    [NativeTypeName("#define VK_NV_external_memory_win32 1")]
    public const int VK_NV_external_memory_win32 = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION 1")]
    public const int VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME \"VK_NV_external_memory_win32\"")]
    public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME => "VK_NV_external_memory_win32"u8;

    [NativeTypeName("#define VK_NV_win32_keyed_mutex 1")]
    public const int VK_NV_win32_keyed_mutex = 1;

    [NativeTypeName("#define VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION 2")]
    public const int VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME \"VK_NV_win32_keyed_mutex\"")]
    public static ReadOnlySpan<byte> VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME => "VK_NV_win32_keyed_mutex"u8;

    [NativeTypeName("#define VK_EXT_full_screen_exclusive 1")]
    public const int VK_EXT_full_screen_exclusive = 1;

    [NativeTypeName("#define VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION 4")]
    public const int VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION = 4;

    [NativeTypeName("#define VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME \"VK_EXT_full_screen_exclusive\"")]
    public static ReadOnlySpan<byte> VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME => "VK_EXT_full_screen_exclusive"u8;

    [NativeTypeName("#define VK_NV_acquire_winrt_display 1")]
    public const int VK_NV_acquire_winrt_display = 1;

    [NativeTypeName("#define VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION 1")]
    public const int VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME \"VK_NV_acquire_winrt_display\"")]
    public static ReadOnlySpan<byte> VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME => "VK_NV_acquire_winrt_display"u8;
}
