// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkDeviceFaultVendorInfoEXT
{
    [NativeTypeName("char[256]")]
    public _description_e__FixedBuffer description;

    [NativeTypeName("uint64_t")]
    public ulong vendorFaultCode;

    [NativeTypeName("uint64_t")]
    public ulong vendorFaultData;

    [InlineArray(256)]
    public partial struct _description_e__FixedBuffer
    {
        public sbyte e0;
    }
}
