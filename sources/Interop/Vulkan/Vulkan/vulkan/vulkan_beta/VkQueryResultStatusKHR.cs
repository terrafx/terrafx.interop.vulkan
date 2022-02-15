// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkQueryResultStatusKHR
    {
        VK_QUERY_RESULT_STATUS_ERROR_KHR = -1,
        VK_QUERY_RESULT_STATUS_NOT_READY_KHR = 0,
        VK_QUERY_RESULT_STATUS_COMPLETE_KHR = 1,
        VK_QUERY_RESULT_STATUS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
