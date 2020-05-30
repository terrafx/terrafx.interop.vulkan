// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkMemoryOverallocationBehaviorAMD
    {
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD = 0,
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD = 1,
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD = 2,
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_BEGIN_RANGE_AMD = VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD,
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_END_RANGE_AMD = VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD,
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_RANGE_SIZE_AMD = (VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD - VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD + 1),
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_MAX_ENUM_AMD = 0x7FFFFFFF,
    }
}
