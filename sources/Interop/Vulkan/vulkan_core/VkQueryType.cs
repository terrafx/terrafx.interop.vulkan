// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkQueryType
    {
        VK_QUERY_TYPE_OCCLUSION = 0,
        VK_QUERY_TYPE_PIPELINE_STATISTICS = 1,
        VK_QUERY_TYPE_TIMESTAMP = 2,
        VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = 1000028004,
        VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR = 1000116000,
        VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR = 1000165000,
        VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR = 1000150000,
        VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL = 1000210000,
        VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR,
        VK_QUERY_TYPE_MAX_ENUM = 0x7FFFFFFF,
    }
}
