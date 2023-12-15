// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPerformanceCounterKHR
{
    public VkStructureType sType;

    public void* pNext;

    public VkPerformanceCounterUnitKHR unit;

    public VkPerformanceCounterScopeKHR scope;

    public VkPerformanceCounterStorageKHR storage;

    [NativeTypeName("uint8_t[16]")]
    public _uuid_e__FixedBuffer uuid;

    [InlineArray(16)]
    public partial struct _uuid_e__FixedBuffer
    {
        public byte e0;
    }
}
