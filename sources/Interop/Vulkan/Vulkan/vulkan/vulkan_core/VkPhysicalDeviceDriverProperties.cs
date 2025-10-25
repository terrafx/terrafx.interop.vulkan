// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceDriverProperties
{
    public VkStructureType sType;

    public void* pNext;

    public VkDriverId driverID;

    [NativeTypeName("char[256]")]
    public _driverName_e__FixedBuffer driverName;

    [NativeTypeName("char[256]")]
    public _driverInfo_e__FixedBuffer driverInfo;

    public VkConformanceVersion conformanceVersion;

    [InlineArray(256)]
    public partial struct _driverName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _driverInfo_e__FixedBuffer
    {
        public sbyte e0;
    }
}
