// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkVendorId
    {
        VK_VENDOR_ID_VIV = 0x10001,
        VK_VENDOR_ID_VSI = 0x10002,
        VK_VENDOR_ID_KAZAN = 0x10003,
        VK_VENDOR_ID_BEGIN_RANGE = VK_VENDOR_ID_VIV,
        VK_VENDOR_ID_END_RANGE = VK_VENDOR_ID_KAZAN,
        VK_VENDOR_ID_RANGE_SIZE = (VK_VENDOR_ID_KAZAN - VK_VENDOR_ID_VIV + 1),
        VK_VENDOR_ID_MAX_ENUM = 0x7FFFFFFF,
    }
}
