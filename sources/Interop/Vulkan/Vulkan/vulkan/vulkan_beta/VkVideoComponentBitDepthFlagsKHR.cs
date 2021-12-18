// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    [NativeTypeName("int")]
    public enum VkVideoComponentBitDepthFlagsKHR : uint
    {
        VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR = 0,
        VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR = 0x00000001,
        VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR = 0x00000004,
        VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR = 0x00000010,
        VK_VIDEO_COMPONENT_BIT_DEPTH_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
