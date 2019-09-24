// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkComponentTypeNV
    {
        VK_COMPONENT_TYPE_FLOAT16_NV = 0,
        VK_COMPONENT_TYPE_FLOAT32_NV = 1,
        VK_COMPONENT_TYPE_FLOAT64_NV = 2,
        VK_COMPONENT_TYPE_SINT8_NV = 3,
        VK_COMPONENT_TYPE_SINT16_NV = 4,
        VK_COMPONENT_TYPE_SINT32_NV = 5,
        VK_COMPONENT_TYPE_SINT64_NV = 6,
        VK_COMPONENT_TYPE_UINT8_NV = 7,
        VK_COMPONENT_TYPE_UINT16_NV = 8,
        VK_COMPONENT_TYPE_UINT32_NV = 9,
        VK_COMPONENT_TYPE_UINT64_NV = 10,
        VK_COMPONENT_TYPE_BEGIN_RANGE_NV = VK_COMPONENT_TYPE_FLOAT16_NV,
        VK_COMPONENT_TYPE_END_RANGE_NV = VK_COMPONENT_TYPE_UINT64_NV,
        VK_COMPONENT_TYPE_RANGE_SIZE_NV = (VK_COMPONENT_TYPE_UINT64_NV - VK_COMPONENT_TYPE_FLOAT16_NV + 1),
        VK_COMPONENT_TYPE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
