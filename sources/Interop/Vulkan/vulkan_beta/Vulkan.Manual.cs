// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        public const uint VK_KHR_deferred_host_operations = 1;

        public const uint VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION = 2;

        // "VK_KHR_deferred_host_operations"
        public static ReadOnlySpan<sbyte> VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME => new sbyte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x64, 0x65, 0x66, 0x65, 0x72, 0x72, 0x65, 0x64, 0x5F, 0x68, 0x6F, 0x73, 0x74, 0x5F, 0x6F, 0x70, 0x65, 0x72, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x73, 0x00 };

        public const uint VK_KHR_pipeline_library = 1;

        public const uint VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION = 1;

        // "VK_KHR_pipeline_library"
        public static ReadOnlySpan<sbyte> VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME => new sbyte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x5F, 0x6C, 0x69, 0x62, 0x72, 0x61, 0x72, 0x79, 0x00 };

        public const uint VK_KHR_ray_tracing = 1;

        public const uint VK_KHR_RAY_TRACING_SPEC_VERSION = 8;

        // "VK_KHR_ray_tracing"
        public static ReadOnlySpan<sbyte> VK_KHR_RAY_TRACING_EXTENSION_NAME => new sbyte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x72, 0x61, 0x79, 0x5F, 0x74, 0x72, 0x61, 0x63, 0x69, 0x6E, 0x67, 0x00 };
    }
}
