// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint physicalDeviceCount;

        [NativeTypeName("VkPhysicalDevice [32]")]
        public _physicalDevices_e__FixedBuffer physicalDevices;

        [NativeTypeName("VkBool32")]
        public uint subsetAllocation;

        public partial struct _physicalDevices_e__FixedBuffer
        {
            internal IntPtr e0;
            internal IntPtr e1;
            internal IntPtr e2;
            internal IntPtr e3;
            internal IntPtr e4;
            internal IntPtr e5;
            internal IntPtr e6;
            internal IntPtr e7;
            internal IntPtr e8;
            internal IntPtr e9;
            internal IntPtr e10;
            internal IntPtr e11;
            internal IntPtr e12;
            internal IntPtr e13;
            internal IntPtr e14;
            internal IntPtr e15;
            internal IntPtr e16;
            internal IntPtr e17;
            internal IntPtr e18;
            internal IntPtr e19;
            internal IntPtr e20;
            internal IntPtr e21;
            internal IntPtr e22;
            internal IntPtr e23;
            internal IntPtr e24;
            internal IntPtr e25;
            internal IntPtr e26;
            internal IntPtr e27;
            internal IntPtr e28;
            internal IntPtr e29;
            internal IntPtr e30;
            internal IntPtr e31;

            public ref IntPtr this[int index] => ref AsSpan()[index];

            public Span<IntPtr> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }
    }
}
