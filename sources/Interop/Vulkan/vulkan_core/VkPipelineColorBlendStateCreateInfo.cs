// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineColorBlendStateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineColorBlendStateCreateFlags")]
        public uint flags;

        [NativeTypeName("VkBool32")]
        public uint logicOpEnable;

        public VkLogicOp logicOp;

        [NativeTypeName("uint32_t")]
        public uint attachmentCount;

        [NativeTypeName("const VkPipelineColorBlendAttachmentState *")]
        public VkPipelineColorBlendAttachmentState* pAttachments;

        [NativeTypeName("float [4]")]
        public fixed float blendConstants[4];
    }
}
