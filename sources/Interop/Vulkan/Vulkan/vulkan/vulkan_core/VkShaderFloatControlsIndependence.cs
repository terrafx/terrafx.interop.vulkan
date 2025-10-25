// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkShaderFloatControlsIndependence
{
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY = 0,
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL = 1,
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE = 2,
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY,
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL,
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE,
    VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_MAX_ENUM = 0x7FFFFFFF,
}
