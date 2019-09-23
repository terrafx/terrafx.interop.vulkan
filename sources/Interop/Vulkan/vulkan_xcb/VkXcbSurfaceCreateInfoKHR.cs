// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_xcb.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkXcbSurfaceCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkXcbSurfaceCreateFlagsKHR")]
        public uint flags;

        [NativeTypeName("xcb_connection_t *")]
        public IntPtr connection;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }
}
