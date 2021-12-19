// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_xlib.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkXlibSurfaceCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkXlibSurfaceCreateFlagsKHR")]
        public uint flags;

        public IntPtr dpy;

        [NativeTypeName("Window")]
        public nuint window;
    }
}
