// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceVulkan13Features
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint robustImageAccess;

    [NativeTypeName("VkBool32")]
    public uint inlineUniformBlock;

    [NativeTypeName("VkBool32")]
    public uint descriptorBindingInlineUniformBlockUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint pipelineCreationCacheControl;

    [NativeTypeName("VkBool32")]
    public uint privateData;

    [NativeTypeName("VkBool32")]
    public uint shaderDemoteToHelperInvocation;

    [NativeTypeName("VkBool32")]
    public uint shaderTerminateInvocation;

    [NativeTypeName("VkBool32")]
    public uint subgroupSizeControl;

    [NativeTypeName("VkBool32")]
    public uint computeFullSubgroups;

    [NativeTypeName("VkBool32")]
    public uint synchronization2;

    [NativeTypeName("VkBool32")]
    public uint textureCompressionASTC_HDR;

    [NativeTypeName("VkBool32")]
    public uint shaderZeroInitializeWorkgroupMemory;

    [NativeTypeName("VkBool32")]
    public uint dynamicRendering;

    [NativeTypeName("VkBool32")]
    public uint shaderIntegerDotProduct;

    [NativeTypeName("VkBool32")]
    public uint maintenance4;
}
