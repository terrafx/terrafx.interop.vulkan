// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkCoarseSampleOrderTypeNV
    {
        VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV = 0,
        VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV = 1,
        VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV = 2,
        VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV = 3,
        VK_COARSE_SAMPLE_ORDER_TYPE_BEGIN_RANGE_NV = VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV,
        VK_COARSE_SAMPLE_ORDER_TYPE_END_RANGE_NV = VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV,
        VK_COARSE_SAMPLE_ORDER_TYPE_RANGE_SIZE_NV = (VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV - VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV + 1),
        VK_COARSE_SAMPLE_ORDER_TYPE_MAX_ENUM_NV = 0x7FFFFFFF,
    }
}
