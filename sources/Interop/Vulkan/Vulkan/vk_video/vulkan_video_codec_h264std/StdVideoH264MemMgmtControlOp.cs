// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum StdVideoH264MemMgmtControlOp
{
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END = 0,
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM = 1,
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM = 2,
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM = 3,
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX = 4,
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL = 5,
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM = 6,
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_INVALID = 0x7FFFFFFF,
    STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MAX_ENUM = 0x7FFFFFFF,
}
