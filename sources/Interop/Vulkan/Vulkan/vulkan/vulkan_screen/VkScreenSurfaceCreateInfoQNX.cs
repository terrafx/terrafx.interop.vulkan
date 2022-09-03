// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_screen.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

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
