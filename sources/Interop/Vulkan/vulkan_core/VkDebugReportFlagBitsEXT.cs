// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkDebugReportFlagBitsEXT
    {
        VK_DEBUG_REPORT_INFORMATION_BIT_EXT = 0x00000001,
        VK_DEBUG_REPORT_WARNING_BIT_EXT = 0x00000002,
        VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT = 0x00000004,
        VK_DEBUG_REPORT_ERROR_BIT_EXT = 0x00000008,
        VK_DEBUG_REPORT_DEBUG_BIT_EXT = 0x00000010,
        VK_DEBUG_REPORT_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
