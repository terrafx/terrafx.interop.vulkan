// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_xcb.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

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
