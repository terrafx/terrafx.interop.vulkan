// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

using System;

namespace TerraFX.Interop.Vulkan;

public partial struct VkIcdSurfaceWayland
{
    public VkIcdSurfaceBase @base;

    [NativeTypeName("struct wl_display *")]
    public IntPtr display;

    [NativeTypeName("struct wl_surface *")]
    public IntPtr surface;
}
