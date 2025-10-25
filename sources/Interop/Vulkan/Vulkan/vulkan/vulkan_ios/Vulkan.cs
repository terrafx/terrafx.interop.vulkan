// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_ios.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_MVK_ios_surface 1")]
    public const int VK_MVK_ios_surface = 1;

    [NativeTypeName("#define VK_MVK_IOS_SURFACE_SPEC_VERSION 3")]
    public const int VK_MVK_IOS_SURFACE_SPEC_VERSION = 3;

    [NativeTypeName("#define VK_MVK_IOS_SURFACE_EXTENSION_NAME \"VK_MVK_ios_surface\"")]
    public static ReadOnlySpan<byte> VK_MVK_IOS_SURFACE_EXTENSION_NAME => "VK_MVK_ios_surface"u8;
}
