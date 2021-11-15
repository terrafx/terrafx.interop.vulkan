// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineRasterizationStateCreateFlags")]
        public uint flags;

        public VkBool32 depthClampEnable;

        public VkBool32 rasterizerDiscardEnable;

        public VkPolygonMode polygonMode;

        public VkCullModeFlags cullMode;

        public VkFrontFace frontFace;

        public VkBool32 depthBiasEnable;

        public float depthBiasConstantFactor;

        public float depthBiasClamp;

        public float depthBiasSlopeFactor;

        public float lineWidth;
    }
}
