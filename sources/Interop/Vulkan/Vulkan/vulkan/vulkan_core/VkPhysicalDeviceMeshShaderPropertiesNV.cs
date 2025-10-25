// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxDrawMeshTasksCount;

    [NativeTypeName("uint32_t")]
    public uint maxTaskWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public _maxTaskWorkGroupSize_e__FixedBuffer maxTaskWorkGroupSize;

    [NativeTypeName("uint32_t")]
    public uint maxTaskTotalMemorySize;

    [NativeTypeName("uint32_t")]
    public uint maxTaskOutputCount;

    [NativeTypeName("uint32_t")]
    public uint maxMeshWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public _maxMeshWorkGroupSize_e__FixedBuffer maxMeshWorkGroupSize;

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

    [InlineArray(3)]
    public partial struct _maxTaskWorkGroupSize_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(3)]
    public partial struct _maxMeshWorkGroupSize_e__FixedBuffer
    {
        public uint e0;
    }
}
