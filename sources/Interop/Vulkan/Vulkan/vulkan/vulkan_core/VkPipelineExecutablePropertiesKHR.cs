// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPipelineExecutablePropertiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    public VkShaderStageFlags stages;

    [NativeTypeName("char[256]")]
    public _name_e__FixedBuffer name;

    [NativeTypeName("char[256]")]
    public _description_e__FixedBuffer description;

    [NativeTypeName("uint32_t")]
    public uint subgroupSize;

    [InlineArray(256)]
    public partial struct _name_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _description_e__FixedBuffer
    {
        public sbyte e0;
    }
}
