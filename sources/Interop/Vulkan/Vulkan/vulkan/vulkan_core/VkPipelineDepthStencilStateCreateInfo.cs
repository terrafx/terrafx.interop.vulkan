// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkPipelineDepthStencilStateCreateFlags flags;

        public VkBool32 depthTestEnable;

        public VkBool32 depthWriteEnable;

        public VkCompareOp depthCompareOp;

        public VkBool32 depthBoundsTestEnable;

        public VkBool32 stencilTestEnable;

        public VkStencilOpState front;

        public VkStencilOpState back;

        public float minDepthBounds;

        public float maxDepthBounds;
    }
}
