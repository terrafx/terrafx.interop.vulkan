// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_screen.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public static unsafe partial class Vulkan
{
    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetScreenBufferPropertiesQNX(VkDevice device, [NativeTypeName("const struct _screen_buffer *")] void* buffer, VkScreenBufferPropertiesQNX* pProperties);

    [NativeTypeName("#define VK_QNX_screen_surface 1")]
    public const int VK_QNX_screen_surface = 1;

    [NativeTypeName("#define VK_QNX_SCREEN_SURFACE_SPEC_VERSION 1")]
    public const int VK_QNX_SCREEN_SURFACE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QNX_SCREEN_SURFACE_EXTENSION_NAME \"VK_QNX_screen_surface\"")]
    public static ReadOnlySpan<byte> VK_QNX_SCREEN_SURFACE_EXTENSION_NAME => "VK_QNX_screen_surface"u8;

    [NativeTypeName("#define VK_QNX_external_memory_screen_buffer 1")]
    public const int VK_QNX_external_memory_screen_buffer = 1;

    [NativeTypeName("#define VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_SPEC_VERSION 1")]
    public const int VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_EXTENSION_NAME \"VK_QNX_external_memory_screen_buffer\"")]
    public static ReadOnlySpan<byte> VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_EXTENSION_NAME => "VK_QNX_external_memory_screen_buffer"u8;
}
