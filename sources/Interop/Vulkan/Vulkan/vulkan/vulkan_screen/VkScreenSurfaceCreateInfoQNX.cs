// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_screen.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkScreenSurfaceCreateInfoQNX
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkScreenSurfaceCreateFlagsQNX")]
        public uint flags;

        [NativeTypeName("struct _screen_context *")]
        public IntPtr context;

        [NativeTypeName("struct _screen_window *")]
        public IntPtr window;
    }
}
