// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkPointClippingBehavior
    {
        VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES = 0,
        VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY = 1,
        VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES_KHR = VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES,
        VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY_KHR = VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY,
        VK_POINT_CLIPPING_BEHAVIOR_MAX_ENUM = 0x7FFFFFFF,
    }
}
