// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineCoverageModulationStateCreateFlagsNV")]
        public uint flags;

        public VkCoverageModulationModeNV coverageModulationMode;

        [NativeTypeName("VkBool32")]
        public uint coverageModulationTableEnable;

        [NativeTypeName("uint32_t")]
        public uint coverageModulationTableCount;

        [NativeTypeName("const float *")]
        public float* pCoverageModulationTable;
    }
}
