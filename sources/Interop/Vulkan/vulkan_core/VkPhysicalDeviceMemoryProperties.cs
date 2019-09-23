// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkPhysicalDeviceMemoryProperties
    {
        [NativeTypeName("uint32_t")]
        public uint memoryTypeCount;

        [NativeTypeName("VkMemoryType [32]")]
        public _memoryTypes_e__FixedBuffer memoryTypes;

        [NativeTypeName("uint32_t")]
        public uint memoryHeapCount;

        [NativeTypeName("VkMemoryHeap [16]")]
        public _memoryHeaps_e__FixedBuffer memoryHeaps;

        public partial struct _memoryTypes_e__FixedBuffer
        {
            internal VkMemoryType e0;
            internal VkMemoryType e1;
            internal VkMemoryType e2;
            internal VkMemoryType e3;
            internal VkMemoryType e4;
            internal VkMemoryType e5;
            internal VkMemoryType e6;
            internal VkMemoryType e7;
            internal VkMemoryType e8;
            internal VkMemoryType e9;
            internal VkMemoryType e10;
            internal VkMemoryType e11;
            internal VkMemoryType e12;
            internal VkMemoryType e13;
            internal VkMemoryType e14;
            internal VkMemoryType e15;
            internal VkMemoryType e16;
            internal VkMemoryType e17;
            internal VkMemoryType e18;
            internal VkMemoryType e19;
            internal VkMemoryType e20;
            internal VkMemoryType e21;
            internal VkMemoryType e22;
            internal VkMemoryType e23;
            internal VkMemoryType e24;
            internal VkMemoryType e25;
            internal VkMemoryType e26;
            internal VkMemoryType e27;
            internal VkMemoryType e28;
            internal VkMemoryType e29;
            internal VkMemoryType e30;
            internal VkMemoryType e31;
        }

        public partial struct _memoryHeaps_e__FixedBuffer
        {
            internal VkMemoryHeap e0;
            internal VkMemoryHeap e1;
            internal VkMemoryHeap e2;
            internal VkMemoryHeap e3;
            internal VkMemoryHeap e4;
            internal VkMemoryHeap e5;
            internal VkMemoryHeap e6;
            internal VkMemoryHeap e7;
            internal VkMemoryHeap e8;
            internal VkMemoryHeap e9;
            internal VkMemoryHeap e10;
            internal VkMemoryHeap e11;
            internal VkMemoryHeap e12;
            internal VkMemoryHeap e13;
            internal VkMemoryHeap e14;
            internal VkMemoryHeap e15;
        }
    }
}
