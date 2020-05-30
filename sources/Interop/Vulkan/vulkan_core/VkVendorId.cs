// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkVendorId
    {
        VK_VENDOR_ID_VIV = 0x10001,
        VK_VENDOR_ID_VSI = 0x10002,
        VK_VENDOR_ID_KAZAN = 0x10003,
        VK_VENDOR_ID_CODEPLAY = 0x10004,
        VK_VENDOR_ID_BEGIN_RANGE = VK_VENDOR_ID_VIV,
        VK_VENDOR_ID_END_RANGE = VK_VENDOR_ID_CODEPLAY,
        VK_VENDOR_ID_RANGE_SIZE = (VK_VENDOR_ID_CODEPLAY - VK_VENDOR_ID_VIV + 1),
        VK_VENDOR_ID_MAX_ENUM = 0x7FFFFFFF,
    }
}
