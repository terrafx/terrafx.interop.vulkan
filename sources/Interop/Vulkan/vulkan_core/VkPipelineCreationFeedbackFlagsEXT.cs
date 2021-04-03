// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkPipelineCreationFeedbackFlagsEXT
    {
        VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT = 0x00000001,
        VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT = 0x00000002,
        VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT = 0x00000004,
        VK_PIPELINE_CREATION_FEEDBACK_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
