// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkPhysicalDeviceLayeredApiKHR
{
    VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR = 0,
    VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR = 1,
    VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR = 2,
    VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR = 3,
    VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR = 4,
    VK_PHYSICAL_DEVICE_LAYERED_API_MAX_ENUM_KHR = 0x7FFFFFFF,
}
