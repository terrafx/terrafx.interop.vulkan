// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkPipelineCacheHeaderVersion
    {
        VK_PIPELINE_CACHE_HEADER_VERSION_ONE = 1,
        VK_PIPELINE_CACHE_HEADER_VERSION_BEGIN_RANGE = VK_PIPELINE_CACHE_HEADER_VERSION_ONE,
        VK_PIPELINE_CACHE_HEADER_VERSION_END_RANGE = VK_PIPELINE_CACHE_HEADER_VERSION_ONE,
        VK_PIPELINE_CACHE_HEADER_VERSION_RANGE_SIZE = (VK_PIPELINE_CACHE_HEADER_VERSION_ONE - VK_PIPELINE_CACHE_HEADER_VERSION_ONE + 1),
        VK_PIPELINE_CACHE_HEADER_VERSION_MAX_ENUM = 0x7FFFFFFF,
    }
}
