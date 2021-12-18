// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_ggp.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, [NativeTypeName("const VkStreamDescriptorSurfaceCreateInfoGGP *")] VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);

        [NativeTypeName("#define VK_GGP_stream_descriptor_surface 1")]
        public const int VK_GGP_stream_descriptor_surface = 1;

        [NativeTypeName("#define VK_GGP_STREAM_DESCRIPTOR_SURFACE_SPEC_VERSION 1")]
        public const int VK_GGP_STREAM_DESCRIPTOR_SURFACE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME \"VK_GGP_stream_descriptor_surface\"")]
        public static ReadOnlySpan<byte> VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x47, 0x47, 0x50, 0x5F, 0x73, 0x74, 0x72, 0x65, 0x61, 0x6D, 0x5F, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x6F, 0x72, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define VK_GGP_frame_token 1")]
        public const int VK_GGP_frame_token = 1;

        [NativeTypeName("#define VK_GGP_FRAME_TOKEN_SPEC_VERSION 1")]
        public const int VK_GGP_FRAME_TOKEN_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GGP_FRAME_TOKEN_EXTENSION_NAME \"VK_GGP_frame_token\"")]
        public static ReadOnlySpan<byte> VK_GGP_FRAME_TOKEN_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x47, 0x47, 0x50, 0x5F, 0x66, 0x72, 0x61, 0x6D, 0x65, 0x5F, 0x74, 0x6F, 0x6B, 0x65, 0x6E, 0x00 };
    }
}
