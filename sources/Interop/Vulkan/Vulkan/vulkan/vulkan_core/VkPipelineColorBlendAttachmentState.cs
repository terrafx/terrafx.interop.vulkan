// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkPipelineColorBlendAttachmentState
    {
        public VkBool32 blendEnable;

        public VkBlendFactor srcColorBlendFactor;

        public VkBlendFactor dstColorBlendFactor;

        public VkBlendOp colorBlendOp;

        public VkBlendFactor srcAlphaBlendFactor;

        public VkBlendFactor dstAlphaBlendFactor;

        public VkBlendOp alphaBlendOp;

        public VkColorComponentFlags colorWriteMask;
    }
}
