// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_metal.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public static unsafe partial class Vulkan
{
    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo);

    [NativeTypeName("#define VK_EXT_metal_surface 1")]
    public const int VK_EXT_metal_surface = 1;

    [NativeTypeName("#define VK_EXT_METAL_SURFACE_SPEC_VERSION 1")]
    public const int VK_EXT_METAL_SURFACE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_METAL_SURFACE_EXTENSION_NAME \"VK_EXT_metal_surface\"")]
    public static ReadOnlySpan<byte> VK_EXT_METAL_SURFACE_EXTENSION_NAME => "VK_EXT_metal_surface"u8;

    [NativeTypeName("#define VK_EXT_metal_objects 1")]
    public const int VK_EXT_metal_objects = 1;

    [NativeTypeName("#define VK_EXT_METAL_OBJECTS_SPEC_VERSION 1")]
    public const int VK_EXT_METAL_OBJECTS_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_EXT_METAL_OBJECTS_EXTENSION_NAME \"VK_EXT_metal_objects\"")]
    public static ReadOnlySpan<byte> VK_EXT_METAL_OBJECTS_EXTENSION_NAME => "VK_EXT_metal_objects"u8;
}
