// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPipelineColorBlendStateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkPipelineColorBlendStateCreateFlags flags;

        public VkBool32 logicOpEnable;

        public VkLogicOp logicOp;

        [NativeTypeName("uint32_t")]
        public uint attachmentCount;

        [NativeTypeName("const VkPipelineColorBlendAttachmentState *")]
        public VkPipelineColorBlendAttachmentState* pAttachments;

        [NativeTypeName("float[4]")]
        public fixed float blendConstants[4];
    }
}
