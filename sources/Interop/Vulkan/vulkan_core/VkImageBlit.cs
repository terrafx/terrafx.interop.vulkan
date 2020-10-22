// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct VkImageBlit
    {
        public VkImageSubresourceLayers srcSubresource;

        [NativeTypeName("VkOffset3D [2]")]
        public _srcOffsets_e__FixedBuffer srcOffsets;

        public VkImageSubresourceLayers dstSubresource;

        [NativeTypeName("VkOffset3D [2]")]
        public _dstOffsets_e__FixedBuffer dstOffsets;

        public partial struct _srcOffsets_e__FixedBuffer
        {
            public VkOffset3D e0;
            public VkOffset3D e1;

            public ref VkOffset3D this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<VkOffset3D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }

        public partial struct _dstOffsets_e__FixedBuffer
        {
            public VkOffset3D e0;
            public VkOffset3D e1;

            public ref VkOffset3D this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<VkOffset3D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}
