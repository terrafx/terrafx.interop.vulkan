// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH264MemMgmtControlOp
    {
        std_video_h264_mem_mgmt_control_op_end = 0,
        std_video_h264_mem_mgmt_control_op_unmark_short_term = 1,
        std_video_h264_mem_mgmt_control_op_unmark_long_term = 2,
        std_video_h264_mem_mgmt_control_op_mark_long_term = 3,
        std_video_h264_mem_mgmt_control_op_set_max_long_term_index = 4,
        std_video_h264_mem_mgmt_control_op_unmark_all = 5,
        std_video_h264_mem_mgmt_control_op_mark_current_as_long_term = 6,
        std_video_h264_mem_mgmt_control_op_invalid = 0x7FFFFFFF,
    }
}
