// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define vulkan_video_codec_h265std_encode 1")]
    public const int vulkan_video_codec_h265std_encode = 1;

    [NativeTypeName("#define STD_VIDEO_ENCODE_H265_LUMA_LIST_SIZE 15")]
    public const int STD_VIDEO_ENCODE_H265_LUMA_LIST_SIZE = 15;

    [NativeTypeName("#define STD_VIDEO_ENCODE_H265_CHROMA_LIST_SIZE 15")]
    public const int STD_VIDEO_ENCODE_H265_CHROMA_LIST_SIZE = 15;

    [NativeTypeName("#define STD_VIDEO_ENCODE_H265_CHROMA_LISTS_NUM 2")]
    public const int STD_VIDEO_ENCODE_H265_CHROMA_LISTS_NUM = 2;
}
