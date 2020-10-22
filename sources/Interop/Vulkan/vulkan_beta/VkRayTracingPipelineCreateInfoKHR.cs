// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkRayTracingPipelineCreateInfoKHR
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

        [NativeTypeName("uint32_t")]
        public uint groupCount;

        [NativeTypeName("const VkRayTracingShaderGroupCreateInfoKHR *")]
        public VkRayTracingShaderGroupCreateInfoKHR* pGroups;

        [NativeTypeName("uint32_t")]
        public uint maxRecursionDepth;

        public VkPipelineLibraryCreateInfoKHR libraries;

        [NativeTypeName("const VkRayTracingPipelineInterfaceCreateInfoKHR *")]
        public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;

        [NativeTypeName("VkPipelineLayout")]
        public ulong layout;

        [NativeTypeName("VkPipeline")]
        public ulong basePipelineHandle;

        [NativeTypeName("int32_t")]
        public int basePipelineIndex;
    }
}
