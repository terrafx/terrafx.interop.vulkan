// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe struct VkXlibSurfaceCreateInfoKHR
    {
        #region Fields
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkXlibSurfaceCreateFlagsKHR")]
        public uint flags;

        [NativeTypeName("Display")]
        public IntPtr dpy;

        [NativeTypeName("Window")]
        public UIntPtr window;
        #endregion
    }
}
