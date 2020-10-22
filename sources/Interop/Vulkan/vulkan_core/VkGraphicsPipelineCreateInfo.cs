// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkGraphicsPipelineCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineCreateFlags")]
        public uint flags;

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

        [NativeTypeName("VkPipelineLayout")]
        public ulong layout;

        [NativeTypeName("VkRenderPass")]
        public ulong renderPass;

        [NativeTypeName("uint32_t")]
        public uint subpass;

        [NativeTypeName("VkPipeline")]
        public ulong basePipelineHandle;

        [NativeTypeName("int32_t")]
        public int basePipelineIndex;
    }
}
