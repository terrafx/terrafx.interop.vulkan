// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkStencilFaceFlagBits
    {
        VK_STENCIL_FACE_FRONT_BIT = 0x00000001,
        VK_STENCIL_FACE_BACK_BIT = 0x00000002,
        VK_STENCIL_FACE_FRONT_AND_BACK = 0x00000003,
        VK_STENCIL_FRONT_AND_BACK = VK_STENCIL_FACE_FRONT_AND_BACK,
        VK_STENCIL_FACE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
