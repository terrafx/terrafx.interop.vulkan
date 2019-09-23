// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkQueryType
    {
        VK_QUERY_TYPE_OCCLUSION = 0,
        VK_QUERY_TYPE_PIPELINE_STATISTICS = 1,
        VK_QUERY_TYPE_TIMESTAMP = 2,
        VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = 1000028004,
        VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = 1000165000,
        VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL = 1000210000,
        VK_QUERY_TYPE_BEGIN_RANGE = VK_QUERY_TYPE_OCCLUSION,
        VK_QUERY_TYPE_END_RANGE = VK_QUERY_TYPE_TIMESTAMP,
        VK_QUERY_TYPE_RANGE_SIZE = (VK_QUERY_TYPE_TIMESTAMP - VK_QUERY_TYPE_OCCLUSION + 1),
        VK_QUERY_TYPE_MAX_ENUM = 0x7FFFFFFF,
    }
}
