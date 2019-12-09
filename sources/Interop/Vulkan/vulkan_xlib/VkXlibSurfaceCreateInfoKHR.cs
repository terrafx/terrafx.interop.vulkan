// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_xlib.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkXlibSurfaceCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkXlibSurfaceCreateFlagsKHR")]
        public uint flags;

        [NativeTypeName("Display *")]
        public UIntPtr dpy;

        [NativeTypeName("Window")]
        public UIntPtr window;
    }
}
