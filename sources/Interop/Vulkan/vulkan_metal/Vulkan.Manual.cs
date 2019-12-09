// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_metal.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        public const int VK_EXT_metal_surface = 1;

        public const int VK_EXT_METAL_SURFACE_SPEC_VERSION = 1;

        // VK_EXT_metal_surface
        public static ReadOnlySpan<sbyte> VK_EXT_METAL_SURFACE_EXTENSION_NAME => new sbyte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x6D, 0x65, 0x74, 0x61, 0x6C, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };
    }
}
