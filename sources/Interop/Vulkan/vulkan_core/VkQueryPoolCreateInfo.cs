// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkQueryPoolCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkQueryPoolCreateFlags")]
        public uint flags;

        public VkQueryType queryType;

        [NativeTypeName("uint32_t")]
        public uint queryCount;

        [NativeTypeName("VkQueryPipelineStatisticFlags")]
        public uint pipelineStatistics;
    }
}
