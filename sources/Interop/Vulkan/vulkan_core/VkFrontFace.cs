// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkFrontFace
    {
        VK_FRONT_FACE_COUNTER_CLOCKWISE = 0,
        VK_FRONT_FACE_CLOCKWISE = 1,
        VK_FRONT_FACE_BEGIN_RANGE = VK_FRONT_FACE_COUNTER_CLOCKWISE,
        VK_FRONT_FACE_END_RANGE = VK_FRONT_FACE_CLOCKWISE,
        VK_FRONT_FACE_RANGE_SIZE = (VK_FRONT_FACE_CLOCKWISE - VK_FRONT_FACE_COUNTER_CLOCKWISE + 1),
        VK_FRONT_FACE_MAX_ENUM = 0x7FFFFFFF,
    }
}
