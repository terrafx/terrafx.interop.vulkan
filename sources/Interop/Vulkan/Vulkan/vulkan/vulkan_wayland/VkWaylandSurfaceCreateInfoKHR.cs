// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_wayland.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkWaylandSurfaceCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkWaylandSurfaceCreateFlagsKHR")]
        public uint flags;

        [NativeTypeName("struct wl_display *")]
        public IntPtr display;

        [NativeTypeName("struct wl_surface *")]
        public IntPtr surface;
    }
}
