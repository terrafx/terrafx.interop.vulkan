// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceGroupProperties
    {
        public unsafe partial struct _physicalDevices_e__FixedBuffer
        {
            public unsafe ref IntPtr this[int index] => ref AsSpan()[index];

            public Span<IntPtr> AsSpan() => MemoryMarshal.CreateSpan(ref e0, length: 32);
        }
    }
}
