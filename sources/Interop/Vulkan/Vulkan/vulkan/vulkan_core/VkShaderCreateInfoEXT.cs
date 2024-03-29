// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkShaderCreateInfoEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("VkShaderCreateFlagsEXT")]
    public uint flags;

    [NativeTypeName("VkShaderStageFlagBits")]
    public VkShaderStageFlags stage;

    public VkShaderStageFlags nextStage;

    public VkShaderCodeTypeEXT codeType;

    [NativeTypeName("size_t")]
    public nuint codeSize;

    [NativeTypeName("const void *")]
    public void* pCode;

    [NativeTypeName("const char *")]
    public sbyte* pName;

    [NativeTypeName("uint32_t")]
    public uint setLayoutCount;

    [NativeTypeName("const VkDescriptorSetLayout *")]
    public VkDescriptorSetLayout* pSetLayouts;

    [NativeTypeName("uint32_t")]
    public uint pushConstantRangeCount;

    [NativeTypeName("const VkPushConstantRange *")]
    public VkPushConstantRange* pPushConstantRanges;

    [NativeTypeName("const VkSpecializationInfo *")]
    public VkSpecializationInfo* pSpecializationInfo;
}
