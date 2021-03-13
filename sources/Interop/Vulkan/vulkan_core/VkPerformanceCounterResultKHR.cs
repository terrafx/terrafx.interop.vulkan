// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct VkPerformanceCounterResultKHR
    {
        [FieldOffset(0)]
        [NativeTypeName("int32_t")]
        public int int32;

        [FieldOffset(0)]
        [NativeTypeName("int64_t")]
        public long int64;

        [FieldOffset(0)]
        [NativeTypeName("uint32_t")]
        public uint uint32;

        [FieldOffset(0)]
        [NativeTypeName("uint64_t")]
        public ulong uint64;

        [FieldOffset(0)]
        public float float32;

        [FieldOffset(0)]
        public double float64;
    }
}
