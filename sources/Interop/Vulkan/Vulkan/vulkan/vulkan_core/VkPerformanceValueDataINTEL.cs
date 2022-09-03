// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct VkPerformanceValueDataINTEL
{
    [FieldOffset(0)]
    [NativeTypeName("uint32_t")]
    public uint value32;

    [FieldOffset(0)]
    [NativeTypeName("uint64_t")]
    public ulong value64;

    [FieldOffset(0)]
    public float valueFloat;

    [FieldOffset(0)]
    public VkBool32 valueBool;

    [FieldOffset(0)]
    [NativeTypeName("const char *")]
    public sbyte* valueString;
}
