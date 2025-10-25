// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkPhysicalDeviceProperties
{
    [NativeTypeName("uint32_t")]
    public uint apiVersion;

    [NativeTypeName("uint32_t")]
    public uint driverVersion;

    [NativeTypeName("uint32_t")]
    public uint vendorID;

    [NativeTypeName("uint32_t")]
    public uint deviceID;

    public VkPhysicalDeviceType deviceType;

    [NativeTypeName("char[256]")]
    public _deviceName_e__FixedBuffer deviceName;

    [NativeTypeName("uint8_t[16]")]
    public _pipelineCacheUUID_e__FixedBuffer pipelineCacheUUID;

    public VkPhysicalDeviceLimits limits;

    public VkPhysicalDeviceSparseProperties sparseProperties;

    [InlineArray(256)]
    public partial struct _deviceName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(16)]
    public partial struct _pipelineCacheUUID_e__FixedBuffer
    {
        public byte e0;
    }
}
