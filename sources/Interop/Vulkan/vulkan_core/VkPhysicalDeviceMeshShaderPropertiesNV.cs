// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint maxDrawMeshTasksCount;

        [NativeTypeName("uint32_t")]
        public uint maxTaskWorkGroupInvocations;

        [NativeTypeName("uint32_t [3]")]
        public fixed uint maxTaskWorkGroupSize[3];

        [NativeTypeName("uint32_t")]
        public uint maxTaskTotalMemorySize;

        [NativeTypeName("uint32_t")]
        public uint maxTaskOutputCount;

        [NativeTypeName("uint32_t")]
        public uint maxMeshWorkGroupInvocations;

        [NativeTypeName("uint32_t [3]")]
        public fixed uint maxMeshWorkGroupSize[3];

        [NativeTypeName("uint32_t")]
        public uint maxMeshTotalMemorySize;

        [NativeTypeName("uint32_t")]
        public uint maxMeshOutputVertices;

        [NativeTypeName("uint32_t")]
        public uint maxMeshOutputPrimitives;

        [NativeTypeName("uint32_t")]
        public uint maxMeshMultiviewViewCount;

        [NativeTypeName("uint32_t")]
        public uint meshOutputPerVertexGranularity;

        [NativeTypeName("uint32_t")]
        public uint meshOutputPerPrimitiveGranularity;
    }
}
