// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_ggp.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_GGP_stream_descriptor_surface 1")]
    public const int VK_GGP_stream_descriptor_surface = 1;

    [NativeTypeName("#define VK_GGP_STREAM_DESCRIPTOR_SURFACE_SPEC_VERSION 1")]
    public const int VK_GGP_STREAM_DESCRIPTOR_SURFACE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME \"VK_GGP_stream_descriptor_surface\"")]
    public static ReadOnlySpan<byte> VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME => "VK_GGP_stream_descriptor_surface"u8;

    [NativeTypeName("#define VK_GGP_frame_token 1")]
    public const int VK_GGP_frame_token = 1;

    [NativeTypeName("#define VK_GGP_FRAME_TOKEN_SPEC_VERSION 1")]
    public const int VK_GGP_FRAME_TOKEN_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_GGP_FRAME_TOKEN_EXTENSION_NAME \"VK_GGP_frame_token\"")]
    public static ReadOnlySpan<byte> VK_GGP_FRAME_TOKEN_EXTENSION_NAME => "VK_GGP_frame_token"u8;
}
