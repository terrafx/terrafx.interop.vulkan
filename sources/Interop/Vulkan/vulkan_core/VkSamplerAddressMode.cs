// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkSamplerAddressMode
    {
        VK_SAMPLER_ADDRESS_MODE_REPEAT = 0,
        VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT = 1,
        VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE = 2,
        VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER = 3,
        VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE = 4,
        VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE_KHR = VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE,
        VK_SAMPLER_ADDRESS_MODE_BEGIN_RANGE = VK_SAMPLER_ADDRESS_MODE_REPEAT,
        VK_SAMPLER_ADDRESS_MODE_END_RANGE = VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER,
        VK_SAMPLER_ADDRESS_MODE_RANGE_SIZE = (VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER - VK_SAMPLER_ADDRESS_MODE_REPEAT + 1),
        VK_SAMPLER_ADDRESS_MODE_MAX_ENUM = 0x7FFFFFFF,
    }
}
