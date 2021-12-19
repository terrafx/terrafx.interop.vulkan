// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_xcb.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    public static partial class Vulkan
    {
        [NativeTypeName("#define VK_KHR_xcb_surface 1")]
        public const int VK_KHR_xcb_surface = 1;

        [NativeTypeName("#define VK_KHR_XCB_SURFACE_SPEC_VERSION 6")]
        public const int VK_KHR_XCB_SURFACE_SPEC_VERSION = 6;

        [NativeTypeName("#define VK_KHR_XCB_SURFACE_EXTENSION_NAME \"VK_KHR_xcb_surface\"")]
        public static ReadOnlySpan<byte> VK_KHR_XCB_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x78, 0x63, 0x62, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };
    }
}
