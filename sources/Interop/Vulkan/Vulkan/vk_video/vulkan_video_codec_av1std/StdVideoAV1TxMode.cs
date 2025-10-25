// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum StdVideoAV1TxMode
{
    STD_VIDEO_AV1_TX_MODE_ONLY_4X4 = 0,
    STD_VIDEO_AV1_TX_MODE_LARGEST = 1,
    STD_VIDEO_AV1_TX_MODE_SELECT = 2,
    STD_VIDEO_AV1_TX_MODE_INVALID = 0x7FFFFFFF,
    STD_VIDEO_AV1_TX_MODE_MAX_ENUM = 0x7FFFFFFF,
}
