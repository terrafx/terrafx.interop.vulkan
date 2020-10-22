// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkClearColorValue
    {
        [FieldOffset(0)]
        [NativeTypeName("float [4]")]
        public fixed float float32[4];

        [FieldOffset(0)]
        [NativeTypeName("int32_t [4]")]
        public fixed int int32[4];

        [FieldOffset(0)]
        [NativeTypeName("uint32_t [4]")]
        public fixed uint uint32[4];
    }
}
