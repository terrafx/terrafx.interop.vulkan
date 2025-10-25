// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceTensorPropertiesARM
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxTensorDimensionCount;

    [NativeTypeName("uint64_t")]
    public ulong maxTensorElements;

    [NativeTypeName("uint64_t")]
    public ulong maxPerDimensionTensorElements;

    [NativeTypeName("int64_t")]
    public long maxTensorStride;

    [NativeTypeName("uint64_t")]
    public ulong maxTensorSize;

    [NativeTypeName("uint32_t")]
    public uint maxTensorShaderAccessArrayLength;

    [NativeTypeName("uint32_t")]
    public uint maxTensorShaderAccessSize;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetStorageTensors;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorSetStorageTensors;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindStorageTensors;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindStorageTensors;

    [NativeTypeName("VkBool32")]
    public uint shaderStorageTensorArrayNonUniformIndexingNative;

    public VkShaderStageFlags shaderTensorSupportedStages;
}
