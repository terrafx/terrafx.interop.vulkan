// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkPhysicalDeviceDataGraphOperationSupportARM
{
    public VkPhysicalDeviceDataGraphOperationTypeARM operationType;

    [NativeTypeName("char[128]")]
    public _name_e__FixedBuffer name;

    [NativeTypeName("uint32_t")]
    public uint version;

    [InlineArray(128)]
    public partial struct _name_e__FixedBuffer
    {
        public sbyte e0;
    }
}
