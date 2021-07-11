// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineMultisampleStateCreateFlags")]
        public uint flags;

        [NativeTypeName("VkSampleCountFlagBits")]
        public VkSampleCountFlags rasterizationSamples;

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
