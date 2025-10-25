// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint shaderBufferFloat16Atomics;

    [NativeTypeName("VkBool32")]
    public uint shaderBufferFloat16AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint shaderBufferFloat16AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint shaderBufferFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint shaderBufferFloat64AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint shaderSharedFloat16Atomics;

    [NativeTypeName("VkBool32")]
    public uint shaderSharedFloat16AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint shaderSharedFloat16AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint shaderSharedFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint shaderSharedFloat64AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint shaderImageFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint sparseImageFloat32AtomicMinMax;
}
