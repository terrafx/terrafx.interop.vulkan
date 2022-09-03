// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceVulkan12Features
{
    public VkStructureType sType;

    public void* pNext;

    public VkBool32 samplerMirrorClampToEdge;

    public VkBool32 drawIndirectCount;

    public VkBool32 storageBuffer8BitAccess;

    public VkBool32 uniformAndStorageBuffer8BitAccess;

    public VkBool32 storagePushConstant8;

    public VkBool32 shaderBufferInt64Atomics;

    public VkBool32 shaderSharedInt64Atomics;

    public VkBool32 shaderFloat16;

    public VkBool32 shaderInt8;

    public VkBool32 descriptorIndexing;

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

    public VkBool32 samplerFilterMinmax;

    public VkBool32 scalarBlockLayout;

    public VkBool32 imagelessFramebuffer;

    public VkBool32 uniformBufferStandardLayout;

    public VkBool32 shaderSubgroupExtendedTypes;

    public VkBool32 separateDepthStencilLayouts;

    public VkBool32 hostQueryReset;

    public VkBool32 timelineSemaphore;

    public VkBool32 bufferDeviceAddress;

    public VkBool32 bufferDeviceAddressCaptureReplay;

    public VkBool32 bufferDeviceAddressMultiDevice;

    public VkBool32 vulkanMemoryModel;

    public VkBool32 vulkanMemoryModelDeviceScope;

    public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;

    public VkBool32 shaderOutputViewportIndex;

    public VkBool32 shaderOutputLayer;

    public VkBool32 subgroupBroadcastDynamicId;
}
