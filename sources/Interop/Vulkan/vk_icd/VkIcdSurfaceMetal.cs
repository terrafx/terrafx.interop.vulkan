// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vk_icd.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkIcdSurfaceMetal
    {
        public VkIcdSurfaceBase @base;

        [NativeTypeName("const CAMetalLayer *")]
        public IntPtr pView;
    }
}
