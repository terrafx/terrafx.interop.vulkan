// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct VkImageBlit
    {
        public partial struct _srcOffsets_e__FixedBuffer
        {
            public unsafe ref VkOffset3D this[int index] => ref AsSpan()[index];

            public Span<VkOffset3D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, length: 2);
        }

        public partial struct _dstOffsets_e__FixedBuffer
        {
            public unsafe ref VkOffset3D this[int index] => ref AsSpan()[index];

            public Span<VkOffset3D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, length: 2);
        }
    }
}
