// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_FUCHSIA_imagepipe_surface 1")]
    public const int VK_FUCHSIA_imagepipe_surface = 1;

    [NativeTypeName("#define VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION 1")]
    public const int VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME \"VK_FUCHSIA_imagepipe_surface\"")]
    public static ReadOnlySpan<byte> VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME => "VK_FUCHSIA_imagepipe_surface"u8;

    [NativeTypeName("#define VK_FUCHSIA_external_memory 1")]
    public const int VK_FUCHSIA_external_memory = 1;

    [NativeTypeName("#define VK_FUCHSIA_EXTERNAL_MEMORY_SPEC_VERSION 1")]
    public const int VK_FUCHSIA_EXTERNAL_MEMORY_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_FUCHSIA_external_memory\"")]
    public static ReadOnlySpan<byte> VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME => "VK_FUCHSIA_external_memory"u8;

    [NativeTypeName("#define VK_FUCHSIA_external_semaphore 1")]
    public const int VK_FUCHSIA_external_semaphore = 1;

    [NativeTypeName("#define VK_FUCHSIA_EXTERNAL_SEMAPHORE_SPEC_VERSION 1")]
    public const int VK_FUCHSIA_EXTERNAL_SEMAPHORE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME \"VK_FUCHSIA_external_semaphore\"")]
    public static ReadOnlySpan<byte> VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME => "VK_FUCHSIA_external_semaphore"u8;

    [NativeTypeName("#define VK_FUCHSIA_buffer_collection 1")]
    public const int VK_FUCHSIA_buffer_collection = 1;

    [NativeTypeName("#define VK_FUCHSIA_BUFFER_COLLECTION_SPEC_VERSION 2")]
    public const int VK_FUCHSIA_BUFFER_COLLECTION_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_FUCHSIA_BUFFER_COLLECTION_EXTENSION_NAME \"VK_FUCHSIA_buffer_collection\"")]
    public static ReadOnlySpan<byte> VK_FUCHSIA_BUFFER_COLLECTION_EXTENSION_NAME => "VK_FUCHSIA_buffer_collection"u8;
}
