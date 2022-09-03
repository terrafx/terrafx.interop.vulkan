// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    public VkStructureType sType;

    public void* pNext;

    public VkBool32 shaderBufferFloat16Atomics;

    public VkBool32 shaderBufferFloat16AtomicAdd;

    public VkBool32 shaderBufferFloat16AtomicMinMax;

    public VkBool32 shaderBufferFloat32AtomicMinMax;

    public VkBool32 shaderBufferFloat64AtomicMinMax;

    public VkBool32 shaderSharedFloat16Atomics;

    public VkBool32 shaderSharedFloat16AtomicAdd;

    public VkBool32 shaderSharedFloat16AtomicMinMax;

    public VkBool32 shaderSharedFloat32AtomicMinMax;

    public VkBool32 shaderSharedFloat64AtomicMinMax;

    public VkBool32 shaderImageFloat32AtomicMinMax;

    public VkBool32 sparseImageFloat32AtomicMinMax;
}
