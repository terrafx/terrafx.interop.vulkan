// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint shaderGroupHandleSize;

    [NativeTypeName("uint32_t")]
    public uint maxRecursionDepth;

    [NativeTypeName("uint32_t")]
    public uint maxShaderGroupStride;

    [NativeTypeName("uint32_t")]
    public uint shaderGroupBaseAlignment;

    [NativeTypeName("uint64_t")]
    public ulong maxGeometryCount;

    [NativeTypeName("uint64_t")]
    public ulong maxInstanceCount;

    [NativeTypeName("uint64_t")]
    public ulong maxTriangleCount;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetAccelerationStructures;
}
