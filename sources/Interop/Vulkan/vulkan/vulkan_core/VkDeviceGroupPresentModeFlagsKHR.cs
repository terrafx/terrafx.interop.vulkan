// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkDeviceGroupPresentModeFlagsKHR : uint
    {
        VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR = 0x00000001,
        VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR = 0x00000002,
        VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR = 0x00000004,
        VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR = 0x00000008,
        VK_DEVICE_GROUP_PRESENT_MODE_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
