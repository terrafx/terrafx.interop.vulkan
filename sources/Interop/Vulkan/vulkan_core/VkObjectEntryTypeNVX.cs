// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkObjectEntryTypeNVX
    {
        VK_OBJECT_ENTRY_TYPE_DESCRIPTOR_SET_NVX = 0,
        VK_OBJECT_ENTRY_TYPE_PIPELINE_NVX = 1,
        VK_OBJECT_ENTRY_TYPE_INDEX_BUFFER_NVX = 2,
        VK_OBJECT_ENTRY_TYPE_VERTEX_BUFFER_NVX = 3,
        VK_OBJECT_ENTRY_TYPE_PUSH_CONSTANT_NVX = 4,
        VK_OBJECT_ENTRY_TYPE_BEGIN_RANGE_NVX = VK_OBJECT_ENTRY_TYPE_DESCRIPTOR_SET_NVX,
        VK_OBJECT_ENTRY_TYPE_END_RANGE_NVX = VK_OBJECT_ENTRY_TYPE_PUSH_CONSTANT_NVX,
        VK_OBJECT_ENTRY_TYPE_RANGE_SIZE_NVX = (VK_OBJECT_ENTRY_TYPE_PUSH_CONSTANT_NVX - VK_OBJECT_ENTRY_TYPE_DESCRIPTOR_SET_NVX + 1),
        VK_OBJECT_ENTRY_TYPE_MAX_ENUM_NVX = 0x7FFFFFFF,
    }
}
