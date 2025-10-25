// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPipelinePropertiesIdentifierEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint8_t[16]")]
    public _pipelineIdentifier_e__FixedBuffer pipelineIdentifier;

    [InlineArray(16)]
    public partial struct _pipelineIdentifier_e__FixedBuffer
    {
        public byte e0;
    }
}
