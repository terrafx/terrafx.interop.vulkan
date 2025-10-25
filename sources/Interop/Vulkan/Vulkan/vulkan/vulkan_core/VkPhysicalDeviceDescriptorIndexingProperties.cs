// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceDescriptorIndexingProperties
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxUpdateAfterBindDescriptorsInAllPools;

    [NativeTypeName("VkBool32")]
    public uint shaderUniformBufferArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint shaderSampledImageArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint shaderStorageBufferArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint shaderStorageImageArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint shaderInputAttachmentArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint robustBufferAccessUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint quadDivergentImplicitLod;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint maxPerStageUpdateAfterBindResources;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindInputAttachments;
}
