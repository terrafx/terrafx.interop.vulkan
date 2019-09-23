// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct VkPhysicalDeviceMemoryProperties
    {
        public partial struct _memoryTypes_e__FixedBuffer
        {
            public unsafe ref VkMemoryType this[int index] => ref AsSpan()[index];

            public Span<VkMemoryType> AsSpan() => MemoryMarshal.CreateSpan(ref e0, length: 32);
        }

        public partial struct _memoryHeaps_e__FixedBuffer
        {
            public unsafe ref VkMemoryHeap this[int index] => ref AsSpan()[index];

            public Span<VkMemoryHeap> AsSpan() => MemoryMarshal.CreateSpan(ref e0, length: 16);
        }
    }
}
