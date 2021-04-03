// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
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
}
