// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkPipelineRobustnessBufferBehaviorEXT
{
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXT = 0,
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT = 1,
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXT = 2,
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXT = 3,
    VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_MAX_ENUM_EXT = 0x7FFFFFFF,
}
