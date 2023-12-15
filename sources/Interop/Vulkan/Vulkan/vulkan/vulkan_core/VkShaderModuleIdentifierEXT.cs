// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkShaderModuleIdentifierEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint identifierSize;

    [NativeTypeName("uint8_t[32]")]
    public _identifier_e__FixedBuffer identifier;

    [InlineArray(32)]
    public partial struct _identifier_e__FixedBuffer
    {
        public byte e0;
    }
}
