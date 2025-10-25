// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkCuLaunchInfoNVX
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkCuFunctionNVX function;

    [NativeTypeName("uint32_t")]
    public uint gridDimX;

    [NativeTypeName("uint32_t")]
    public uint gridDimY;

    [NativeTypeName("uint32_t")]
    public uint gridDimZ;

    [NativeTypeName("uint32_t")]
    public uint blockDimX;

    [NativeTypeName("uint32_t")]
    public uint blockDimY;

    [NativeTypeName("uint32_t")]
    public uint blockDimZ;

    [NativeTypeName("uint32_t")]
    public uint sharedMemBytes;

    [NativeTypeName("size_t")]
    public nuint paramCount;

    [NativeTypeName("const void *const *")]
    public void** pParams;

    [NativeTypeName("size_t")]
    public nuint extraCount;

    [NativeTypeName("const void *const *")]
    public void** pExtras;
}
