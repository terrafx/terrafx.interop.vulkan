// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkGraphicsPipelineCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkPipelineCreateFlags flags;

    [NativeTypeName("uint32_t")]
    public uint stageCount;

    [NativeTypeName("const VkPipelineShaderStageCreateInfo *")]
    public VkPipelineShaderStageCreateInfo* pStages;

    [NativeTypeName("const VkPipelineVertexInputStateCreateInfo *")]
    public VkPipelineVertexInputStateCreateInfo* pVertexInputState;

    [NativeTypeName("const VkPipelineInputAssemblyStateCreateInfo *")]
    public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;

    [NativeTypeName("const VkPipelineTessellationStateCreateInfo *")]
    public VkPipelineTessellationStateCreateInfo* pTessellationState;

    [NativeTypeName("const VkPipelineViewportStateCreateInfo *")]
    public VkPipelineViewportStateCreateInfo* pViewportState;

    [NativeTypeName("const VkPipelineRasterizationStateCreateInfo *")]
    public VkPipelineRasterizationStateCreateInfo* pRasterizationState;

    [NativeTypeName("const VkPipelineMultisampleStateCreateInfo *")]
    public VkPipelineMultisampleStateCreateInfo* pMultisampleState;

    [NativeTypeName("const VkPipelineDepthStencilStateCreateInfo *")]
    public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;

    [NativeTypeName("const VkPipelineColorBlendStateCreateInfo *")]
    public VkPipelineColorBlendStateCreateInfo* pColorBlendState;

    [NativeTypeName("const VkPipelineDynamicStateCreateInfo *")]
    public VkPipelineDynamicStateCreateInfo* pDynamicState;

    public VkPipelineLayout layout;

    public VkRenderPass renderPass;

    [NativeTypeName("uint32_t")]
    public uint subpass;

    public VkPipeline basePipelineHandle;

    [NativeTypeName("int32_t")]
    public int basePipelineIndex;
}
