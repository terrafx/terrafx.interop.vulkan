// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceFaultInfoEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("char[256]")]
    public _description_e__FixedBuffer description;

    public VkDeviceFaultAddressInfoEXT* pAddressInfos;

    public VkDeviceFaultVendorInfoEXT* pVendorInfos;

    public void* pVendorBinaryData;

    [InlineArray(256)]
    public partial struct _description_e__FixedBuffer
    {
        public sbyte e0;
    }
}
