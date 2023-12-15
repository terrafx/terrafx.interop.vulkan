// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceVulkan13Features
{
    public VkStructureType sType;

    public void* pNext;

    public VkBool32 robustImageAccess;

    public VkBool32 inlineUniformBlock;

    public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;

    public VkBool32 pipelineCreationCacheControl;

    public VkBool32 privateData;

    public VkBool32 shaderDemoteToHelperInvocation;

    public VkBool32 shaderTerminateInvocation;

    public VkBool32 subgroupSizeControl;

    public VkBool32 computeFullSubgroups;

    public VkBool32 synchronization2;

    public VkBool32 textureCompressionASTC_HDR;

    public VkBool32 shaderZeroInitializeWorkgroupMemory;

    public VkBool32 dynamicRendering;

    public VkBool32 shaderIntegerDotProduct;

    public VkBool32 maintenance4;
}
