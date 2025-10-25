// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct VkTraceRaysIndirectCommand2KHR
{
    [NativeTypeName("VkDeviceAddress")]
    public ulong raygenShaderRecordAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong raygenShaderRecordSize;

    [NativeTypeName("VkDeviceAddress")]
    public ulong missShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong missShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong missShaderBindingTableStride;

    [NativeTypeName("VkDeviceAddress")]
    public ulong hitShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong hitShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong hitShaderBindingTableStride;

    [NativeTypeName("VkDeviceAddress")]
    public ulong callableShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong callableShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong callableShaderBindingTableStride;

    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("uint32_t")]
    public uint depth;
}
