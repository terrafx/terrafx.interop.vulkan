// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeatures
{
    public VkStructureType sType;

    public void* pNext;

    public VkBool32 shaderInputAttachmentArrayDynamicIndexing;

    public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;

    public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;

    public VkBool32 shaderUniformBufferArrayNonUniformIndexing;

    public VkBool32 shaderSampledImageArrayNonUniformIndexing;

    public VkBool32 shaderStorageBufferArrayNonUniformIndexing;

    public VkBool32 shaderStorageImageArrayNonUniformIndexing;

    public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;

    public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;

    public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;

    public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;

    public VkBool32 descriptorBindingSampledImageUpdateAfterBind;

    public VkBool32 descriptorBindingStorageImageUpdateAfterBind;

    public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;

    public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;

    public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;

    public VkBool32 descriptorBindingUpdateUnusedWhilePending;

    public VkBool32 descriptorBindingPartiallyBound;

    public VkBool32 descriptorBindingVariableDescriptorCount;

    public VkBool32 runtimeDescriptorArray;
}
