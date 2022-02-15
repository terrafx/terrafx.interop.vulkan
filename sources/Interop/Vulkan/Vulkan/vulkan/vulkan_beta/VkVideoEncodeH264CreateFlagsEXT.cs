// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    [NativeTypeName("int")]
    public enum VkVideoEncodeH264CreateFlagsEXT : uint
    {
        VK_VIDEO_ENCODE_H264_CREATE_DEFAULT_EXT = 0,
        VK_VIDEO_ENCODE_H264_CREATE_RESERVED_0_BIT_EXT = 0x00000001,
        VK_VIDEO_ENCODE_H264_CREATE_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
