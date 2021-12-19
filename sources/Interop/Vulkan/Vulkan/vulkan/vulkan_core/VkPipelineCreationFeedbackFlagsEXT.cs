// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    [NativeTypeName("int")]
    [Flags]
    public enum VkPipelineCreationFeedbackFlagsEXT : uint
    {
        VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT = 0x00000001,
        VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT = 0x00000002,
        VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT = 0x00000004,
        VK_PIPELINE_CREATION_FEEDBACK_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
