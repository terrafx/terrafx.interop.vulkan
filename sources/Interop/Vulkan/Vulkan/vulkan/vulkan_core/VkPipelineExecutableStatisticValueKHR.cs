// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public partial struct VkPipelineExecutableStatisticValueKHR
{
    [FieldOffset(0)]
    [NativeTypeName("VkBool32")]
    public uint b32;

    [FieldOffset(0)]
    [NativeTypeName("int64_t")]
    public long i64;

    [FieldOffset(0)]
    [NativeTypeName("uint64_t")]
    public ulong u64;

    [FieldOffset(0)]
    public double f64;
}
