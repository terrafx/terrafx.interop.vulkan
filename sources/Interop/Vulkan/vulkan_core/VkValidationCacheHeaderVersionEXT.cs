// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkValidationCacheHeaderVersionEXT
    {
        VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT = 1,
        VK_VALIDATION_CACHE_HEADER_VERSION_BEGIN_RANGE_EXT = VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT,
        VK_VALIDATION_CACHE_HEADER_VERSION_END_RANGE_EXT = VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT,
        VK_VALIDATION_CACHE_HEADER_VERSION_RANGE_SIZE_EXT = (VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT - VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT + 1),
        VK_VALIDATION_CACHE_HEADER_VERSION_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
