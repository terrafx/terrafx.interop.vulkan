// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct StdVideoH264ScalingLists
    {
        [NativeTypeName("uint8_t")]
        public byte scaling_list_present_mask;

        [NativeTypeName("uint8_t")]
        public byte use_default_scaling_matrix_mask;

        [NativeTypeName("uint8_t [6][16]")]
        public fixed byte ScalingList4x4[6 * 16];

        [NativeTypeName("uint8_t [2][64]")]
        public fixed byte ScalingList8x8[2 * 64];
    }
}
