// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceShaderEnqueuePropertiesAMDX
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxExecutionGraphDepth;

    [NativeTypeName("uint32_t")]
    public uint maxExecutionGraphShaderOutputNodes;

    [NativeTypeName("uint32_t")]
    public uint maxExecutionGraphShaderPayloadSize;

    [NativeTypeName("uint32_t")]
    public uint maxExecutionGraphShaderPayloadCount;

    [NativeTypeName("uint32_t")]
    public uint executionGraphDispatchAddressAlignment;

    [NativeTypeName("uint32_t[3]")]
    public _maxExecutionGraphWorkgroupCount_e__FixedBuffer maxExecutionGraphWorkgroupCount;

    [NativeTypeName("uint32_t")]
    public uint maxExecutionGraphWorkgroups;

    [InlineArray(3)]
    public partial struct _maxExecutionGraphWorkgroupCount_e__FixedBuffer
    {
        public uint e0;
    }
}
