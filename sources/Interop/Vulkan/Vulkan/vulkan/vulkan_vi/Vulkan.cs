// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_vi.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_NN_vi_surface 1")]
    public const int VK_NN_vi_surface = 1;

    [NativeTypeName("#define VK_NN_VI_SURFACE_SPEC_VERSION 1")]
    public const int VK_NN_VI_SURFACE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_NN_VI_SURFACE_EXTENSION_NAME \"VK_NN_vi_surface\"")]
    public static ReadOnlySpan<byte> VK_NN_VI_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x4E, 0x5F, 0x76, 0x69, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };
}
