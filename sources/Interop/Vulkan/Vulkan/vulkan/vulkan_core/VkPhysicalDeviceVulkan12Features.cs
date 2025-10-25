// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceVulkan12Features
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint samplerMirrorClampToEdge;

    [NativeTypeName("VkBool32")]
    public uint drawIndirectCount;

    [NativeTypeName("VkBool32")]
    public uint storageBuffer8BitAccess;

    [NativeTypeName("VkBool32")]
    public uint uniformAndStorageBuffer8BitAccess;

    [NativeTypeName("VkBool32")]
    public uint storagePushConstant8;

    [NativeTypeName("VkBool32")]
    public uint shaderBufferInt64Atomics;

    [NativeTypeName("VkBool32")]
    public uint shaderSharedInt64Atomics;

    [NativeTypeName("VkBool32")]
    public uint shaderFloat16;

    [NativeTypeName("VkBool32")]
    public uint shaderInt8;

    [NativeTypeName("VkBool32")]
    public uint descriptorIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderInputAttachmentArrayDynamicIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderUniformTexelBufferArrayDynamicIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderStorageTexelBufferArrayDynamicIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderUniformBufferArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderSampledImageArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderStorageBufferArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderStorageImageArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderInputAttachmentArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderUniformTexelBufferArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint shaderStorageTexelBufferArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingUniformBufferUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingSampledImageUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingStorageImageUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingStorageBufferUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingUniformTexelBufferUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingStorageTexelBufferUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingUpdateUnusedWhilePending;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingPartiallyBound;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingVariableDescriptorCount;

    [NativeTypeName("VkBool32")]
    public uint runtimeDescriptorArray;

    [NativeTypeName("VkBool32")]
    public uint samplerFilterMinmax;

    [NativeTypeName("VkBool32")]
    public uint scalarBlockLayout;

    [NativeTypeName("VkBool32")]
    public uint imagelessFramebuffer;

    [NativeTypeName("VkBool32")]
    public uint uniformBufferStandardLayout;

    [NativeTypeName("VkBool32")]
    public uint shaderSubgroupExtendedTypes;

    [NativeTypeName("VkBool32")]
    public uint separateDepthStencilLayouts;

    [NativeTypeName("VkBool32")]
    public uint hostQueryReset;

    [NativeTypeName("VkBool32")]
    public uint timelineSemaphore;

    [NativeTypeName("VkBool32")]
    public uint bufferDeviceAddress;

    [NativeTypeName("VkBool32")]
    public uint bufferDeviceAddressCaptureReplay;

    [NativeTypeName("VkBool32")]
    public uint bufferDeviceAddressMultiDevice;

    [NativeTypeName("VkBool32")]
    public uint vulkanMemoryModel;

    [NativeTypeName("VkBool32")]
    public uint vulkanMemoryModelDeviceScope;

    [NativeTypeName("VkBool32")]
    public uint vulkanMemoryModelAvailabilityVisibilityChains;

    [NativeTypeName("VkBool32")]
    public uint shaderOutputViewportIndex;

    [NativeTypeName("VkBool32")]
    public uint shaderOutputLayer;

    [NativeTypeName("VkBool32")]
    public uint subgroupBroadcastDynamicId;
}
