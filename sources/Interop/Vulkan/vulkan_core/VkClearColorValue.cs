// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

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
