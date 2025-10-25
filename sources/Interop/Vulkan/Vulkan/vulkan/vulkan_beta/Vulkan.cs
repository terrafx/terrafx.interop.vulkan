// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define VK_KHR_portability_subset 1")]
    public const int VK_KHR_portability_subset = 1;

    [NativeTypeName("#define VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION 1")]
    public const int VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME \"VK_KHR_portability_subset\"")]
    public static ReadOnlySpan<byte> VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME => "VK_KHR_portability_subset"u8;

    [NativeTypeName("#define VK_AMDX_shader_enqueue 1")]
    public const int VK_AMDX_shader_enqueue = 1;

    [NativeTypeName("#define VK_AMDX_SHADER_ENQUEUE_SPEC_VERSION 2")]
    public const int VK_AMDX_SHADER_ENQUEUE_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME \"VK_AMDX_shader_enqueue\"")]
    public static ReadOnlySpan<byte> VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME => "VK_AMDX_shader_enqueue"u8;

    [NativeTypeName("#define VK_SHADER_INDEX_UNUSED_AMDX (~0U)")]
    public const uint VK_SHADER_INDEX_UNUSED_AMDX = (~0U);

    [NativeTypeName("#define VK_NV_cuda_kernel_launch 1")]
    public const int VK_NV_cuda_kernel_launch = 1;

    [NativeTypeName("#define VK_NV_CUDA_KERNEL_LAUNCH_SPEC_VERSION 2")]
    public const int VK_NV_CUDA_KERNEL_LAUNCH_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_CUDA_KERNEL_LAUNCH_EXTENSION_NAME \"VK_NV_cuda_kernel_launch\"")]
    public static ReadOnlySpan<byte> VK_NV_CUDA_KERNEL_LAUNCH_EXTENSION_NAME => "VK_NV_cuda_kernel_launch"u8;

    [NativeTypeName("#define VK_NV_displacement_micromap 1")]
    public const int VK_NV_displacement_micromap = 1;

    [NativeTypeName("#define VK_NV_DISPLACEMENT_MICROMAP_SPEC_VERSION 2")]
    public const int VK_NV_DISPLACEMENT_MICROMAP_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME \"VK_NV_displacement_micromap\"")]
    public static ReadOnlySpan<byte> VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME => "VK_NV_displacement_micromap"u8;

    [NativeTypeName("#define VK_AMDX_dense_geometry_format 1")]
    public const int VK_AMDX_dense_geometry_format = 1;

    [NativeTypeName("#define VK_AMDX_DENSE_GEOMETRY_FORMAT_SPEC_VERSION 1")]
    public const int VK_AMDX_DENSE_GEOMETRY_FORMAT_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMDX_DENSE_GEOMETRY_FORMAT_EXTENSION_NAME \"VK_AMDX_dense_geometry_format\"")]
    public static ReadOnlySpan<byte> VK_AMDX_DENSE_GEOMETRY_FORMAT_EXTENSION_NAME => "VK_AMDX_dense_geometry_format"u8;

    [NativeTypeName("#define VK_COMPRESSED_TRIANGLE_FORMAT_DGF1_BYTE_ALIGNMENT_AMDX 128U")]
    public const uint VK_COMPRESSED_TRIANGLE_FORMAT_DGF1_BYTE_ALIGNMENT_AMDX = 128U;

    [NativeTypeName("#define VK_COMPRESSED_TRIANGLE_FORMAT_DGF1_BYTE_STRIDE_AMDX 128U")]
    public const uint VK_COMPRESSED_TRIANGLE_FORMAT_DGF1_BYTE_STRIDE_AMDX = 128U;
}
