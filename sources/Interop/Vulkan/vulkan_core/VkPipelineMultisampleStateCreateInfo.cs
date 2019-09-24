// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineMultisampleStateCreateFlags")]
        public uint flags;

        public VkSampleCountFlagBits rasterizationSamples;

        [NativeTypeName("VkBool32")]
        public uint sampleShadingEnable;

        public float minSampleShading;

        [NativeTypeName("const VkSampleMask *")]
        public uint* pSampleMask;

        [NativeTypeName("VkBool32")]
        public uint alphaToCoverageEnable;

        [NativeTypeName("VkBool32")]
        public uint alphaToOneEnable;
    }
}
