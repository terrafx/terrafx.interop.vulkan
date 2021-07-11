// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum VkVideoChromaSubsamplingFlagsKHR : uint
    {
        VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_BIT_KHR = 0,
        VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR = 0x00000001,
        VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR = 0x00000002,
        VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR = 0x00000004,
        VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR = 0x00000008,
        VK_VIDEO_CHROMA_SUBSAMPLING_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
