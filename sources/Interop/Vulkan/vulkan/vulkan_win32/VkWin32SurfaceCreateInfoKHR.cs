// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkWin32SurfaceCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkWin32SurfaceCreateFlagsKHR")]
        public uint flags;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hinstance;

        [NativeTypeName("HWND")]
        public IntPtr hwnd;
    }
}
