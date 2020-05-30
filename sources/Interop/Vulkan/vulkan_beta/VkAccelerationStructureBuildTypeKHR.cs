// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkAccelerationStructureBuildTypeKHR
    {
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR = 0,
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR = 1,
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR = 2,
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_BEGIN_RANGE_KHR = VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR,
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_END_RANGE_KHR = VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR,
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_RANGE_SIZE_KHR = (VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR - VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR + 1),
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
