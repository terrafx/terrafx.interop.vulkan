// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct VkDeviceOrHostAddressConstAMDX
{
    [FieldOffset(0)]
    [NativeTypeName("VkDeviceAddress")]
    public ulong deviceAddress;

    [FieldOffset(0)]
    [NativeTypeName("const void *")]
    public void* hostAddress;
}
