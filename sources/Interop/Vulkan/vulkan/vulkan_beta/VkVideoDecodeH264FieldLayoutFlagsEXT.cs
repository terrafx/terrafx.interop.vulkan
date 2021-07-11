// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum VkVideoDecodeH264FieldLayoutFlagsEXT : uint
    {
        VK_VIDEO_DECODE_H264_PROGRESSIVE_PICTURES_ONLY_EXT = 0,
        VK_VIDEO_DECODE_H264_FIELD_LAYOUT_LINE_INTERLACED_PLANE_BIT_EXT = 0x00000001,
        VK_VIDEO_DECODE_H264_FIELD_LAYOUT_SEPARATE_INTERLACED_PLANE_BIT_EXT = 0x00000002,
        VK_VIDEO_DECODE_H264_FIELD_LAYOUT_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
