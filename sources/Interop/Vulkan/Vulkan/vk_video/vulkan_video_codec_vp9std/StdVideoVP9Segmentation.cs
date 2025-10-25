// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_vp9std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoVP9Segmentation
{
    public StdVideoVP9SegmentationFlags flags;

    [NativeTypeName("uint8_t[7]")]
    public _segmentation_tree_probs_e__FixedBuffer segmentation_tree_probs;

    [NativeTypeName("uint8_t[3]")]
    public _segmentation_pred_prob_e__FixedBuffer segmentation_pred_prob;

    [NativeTypeName("uint8_t[8]")]
    public _FeatureEnabled_e__FixedBuffer FeatureEnabled;

    [NativeTypeName("int16_t[8][4]")]
    public _FeatureData_e__FixedBuffer FeatureData;

    [InlineArray(7)]
    public partial struct _segmentation_tree_probs_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(3)]
    public partial struct _segmentation_pred_prob_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _FeatureEnabled_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8 * 4)]
    public partial struct _FeatureData_e__FixedBuffer
    {
        public short e0_0;
    }
}
