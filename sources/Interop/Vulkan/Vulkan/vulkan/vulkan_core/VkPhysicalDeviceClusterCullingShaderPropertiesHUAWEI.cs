// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t[3]")]
    public _maxWorkGroupCount_e__FixedBuffer maxWorkGroupCount;

    [NativeTypeName("uint32_t[3]")]
    public _maxWorkGroupSize_e__FixedBuffer maxWorkGroupSize;

    [NativeTypeName("uint32_t")]
    public uint maxOutputClusterCount;

    [NativeTypeName("VkDeviceSize")]
    public ulong indirectBufferOffsetAlignment;

    [InlineArray(3)]
    public partial struct _maxWorkGroupCount_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(3)]
    public partial struct _maxWorkGroupSize_e__FixedBuffer
    {
        public uint e0;
    }
}
