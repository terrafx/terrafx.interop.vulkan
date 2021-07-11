// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkDeviceMemoryReportEventTypeEXT
    {
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT = 0,
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT = 1,
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT = 2,
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT = 3,
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT = 4,
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
