// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkPhysicalDeviceMemoryProperties
    {
        [NativeTypeName("uint32_t")]
        public uint memoryTypeCount;

        [NativeTypeName("VkMemoryType[32]")]
        public _memoryTypes_e__FixedBuffer memoryTypes;

        [NativeTypeName("uint32_t")]
        public uint memoryHeapCount;

        [NativeTypeName("VkMemoryHeap[16]")]
        public _memoryHeaps_e__FixedBuffer memoryHeaps;

        public partial struct _memoryTypes_e__FixedBuffer
        {
            public VkMemoryType e0;
            public VkMemoryType e1;
            public VkMemoryType e2;
            public VkMemoryType e3;
            public VkMemoryType e4;
            public VkMemoryType e5;
            public VkMemoryType e6;
            public VkMemoryType e7;
            public VkMemoryType e8;
            public VkMemoryType e9;
            public VkMemoryType e10;
            public VkMemoryType e11;
            public VkMemoryType e12;
            public VkMemoryType e13;
            public VkMemoryType e14;
            public VkMemoryType e15;
            public VkMemoryType e16;
            public VkMemoryType e17;
            public VkMemoryType e18;
            public VkMemoryType e19;
            public VkMemoryType e20;
            public VkMemoryType e21;
            public VkMemoryType e22;
            public VkMemoryType e23;
            public VkMemoryType e24;
            public VkMemoryType e25;
            public VkMemoryType e26;
            public VkMemoryType e27;
            public VkMemoryType e28;
            public VkMemoryType e29;
            public VkMemoryType e30;
            public VkMemoryType e31;

            public ref VkMemoryType this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<VkMemoryType> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }

        public partial struct _memoryHeaps_e__FixedBuffer
        {
            public VkMemoryHeap e0;
            public VkMemoryHeap e1;
            public VkMemoryHeap e2;
            public VkMemoryHeap e3;
            public VkMemoryHeap e4;
            public VkMemoryHeap e5;
            public VkMemoryHeap e6;
            public VkMemoryHeap e7;
            public VkMemoryHeap e8;
            public VkMemoryHeap e9;
            public VkMemoryHeap e10;
            public VkMemoryHeap e11;
            public VkMemoryHeap e12;
            public VkMemoryHeap e13;
            public VkMemoryHeap e14;
            public VkMemoryHeap e15;

            public ref VkMemoryHeap this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<VkMemoryHeap> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
