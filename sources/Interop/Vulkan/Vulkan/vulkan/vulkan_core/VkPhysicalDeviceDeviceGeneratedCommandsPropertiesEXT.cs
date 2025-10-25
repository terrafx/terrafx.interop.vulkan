// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectPipelineCount;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectShaderObjectCount;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectSequenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectCommandsTokenCount;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectCommandsTokenOffset;

    [NativeTypeName("uint32_t")]
    public uint maxIndirectCommandsIndirectStride;

    [NativeTypeName("VkIndirectCommandsInputModeFlagsEXT")]
    public uint supportedIndirectCommandsInputModes;

    public VkShaderStageFlags supportedIndirectCommandsShaderStages;

    public VkShaderStageFlags supportedIndirectCommandsShaderStagesPipelineBinding;

    public VkShaderStageFlags supportedIndirectCommandsShaderStagesShaderBinding;

    [NativeTypeName("VkBool32")]
    public uint deviceGeneratedCommandsTransformFeedback;

    [NativeTypeName("VkBool32")]
    public uint deviceGeneratedCommandsMultiDrawIndirectCount;
}
