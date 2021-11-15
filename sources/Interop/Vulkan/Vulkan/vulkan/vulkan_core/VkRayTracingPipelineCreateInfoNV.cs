// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkRayTracingPipelineCreateInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkPipelineCreateFlags flags;

        [NativeTypeName("uint32_t")]
        public uint stageCount;

        [NativeTypeName("const VkPipelineShaderStageCreateInfo *")]
        public VkPipelineShaderStageCreateInfo* pStages;

        [NativeTypeName("uint32_t")]
        public uint groupCount;

        [NativeTypeName("const VkRayTracingShaderGroupCreateInfoNV *")]
        public VkRayTracingShaderGroupCreateInfoNV* pGroups;

        [NativeTypeName("uint32_t")]
        public uint maxRecursionDepth;

        public VkPipelineLayout layout;

        public VkPipeline basePipelineHandle;

        [NativeTypeName("int32_t")]
        public int basePipelineIndex;
    }
}
