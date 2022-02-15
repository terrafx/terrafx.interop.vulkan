// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    [NativeTypeName("int")]
    public enum VkVideoCodingQualityPresetFlagsKHR : uint
    {
        VK_VIDEO_CODING_QUALITY_PRESET_NORMAL_BIT_KHR = 0x00000001,
        VK_VIDEO_CODING_QUALITY_PRESET_POWER_BIT_KHR = 0x00000002,
        VK_VIDEO_CODING_QUALITY_PRESET_QUALITY_BIT_KHR = 0x00000004,
        VK_VIDEO_CODING_QUALITY_PRESET_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
