// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkVideoEncodeAV1PredictionModeKHR
{
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR = 0,
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR = 1,
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHR = 2,
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHR = 3,
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_MAX_ENUM_KHR = 0x7FFFFFFF,
}
