// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint combinedImageSamplerDescriptorSingleArray;

    [NativeTypeName("VkBool32")]
    public uint bufferlessPushDescriptors;

    [NativeTypeName("VkBool32")]
    public uint allowSamplerImageViewPostSubmitCreation;

    [NativeTypeName("VkDeviceSize")]
    public ulong descriptorBufferOffsetAlignment;

    [NativeTypeName("uint32_t")]
    public uint maxDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    public uint maxResourceDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    public uint maxSamplerDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    public uint maxEmbeddedImmutableSamplerBindings;

    [NativeTypeName("uint32_t")]
    public uint maxEmbeddedImmutableSamplers;

    [NativeTypeName("size_t")]
    public nuint bufferCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint imageCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint imageViewCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint samplerCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint accelerationStructureCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint samplerDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint combinedImageSamplerDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint sampledImageDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint storageImageDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint uniformTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint robustUniformTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint storageTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint robustStorageTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint uniformBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint robustUniformBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint storageBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint robustStorageBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint inputAttachmentDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint accelerationStructureDescriptorSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong maxSamplerDescriptorBufferRange;

    [NativeTypeName("VkDeviceSize")]
    public ulong maxResourceDescriptorBufferRange;

    [NativeTypeName("VkDeviceSize")]
    public ulong samplerDescriptorBufferAddressSpaceSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong resourceDescriptorBufferAddressSpaceSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong descriptorBufferAddressSpaceSize;
}
