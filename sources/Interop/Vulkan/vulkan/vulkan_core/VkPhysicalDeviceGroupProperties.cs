// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint physicalDeviceCount;

        [NativeTypeName("VkPhysicalDevice [32]")]
        public _physicalDevices_e__FixedBuffer physicalDevices;

        [NativeTypeName("VkBool32")]
        public uint subsetAllocation;

        public partial struct _physicalDevices_e__FixedBuffer
        {
            public IntPtr e0;
            public IntPtr e1;
            public IntPtr e2;
            public IntPtr e3;
            public IntPtr e4;
            public IntPtr e5;
            public IntPtr e6;
            public IntPtr e7;
            public IntPtr e8;
            public IntPtr e9;
            public IntPtr e10;
            public IntPtr e11;
            public IntPtr e12;
            public IntPtr e13;
            public IntPtr e14;
            public IntPtr e15;
            public IntPtr e16;
            public IntPtr e17;
            public IntPtr e18;
            public IntPtr e19;
            public IntPtr e20;
            public IntPtr e21;
            public IntPtr e22;
            public IntPtr e23;
            public IntPtr e24;
            public IntPtr e25;
            public IntPtr e26;
            public IntPtr e27;
            public IntPtr e28;
            public IntPtr e29;
            public IntPtr e30;
            public IntPtr e31;

            public ref IntPtr this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<IntPtr> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }
    }
}
