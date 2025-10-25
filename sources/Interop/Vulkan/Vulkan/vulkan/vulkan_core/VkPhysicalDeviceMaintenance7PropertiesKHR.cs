// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceMaintenance7PropertiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint robustFragmentShadingRateAttachmentAccess;

    [NativeTypeName("VkBool32")]
    public uint separateDepthStencilAttachmentAccess;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetTotalUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetTotalStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetTotalBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
}
