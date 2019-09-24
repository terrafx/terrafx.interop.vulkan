// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkVertexInputRate
    {
        VK_VERTEX_INPUT_RATE_VERTEX = 0,
        VK_VERTEX_INPUT_RATE_INSTANCE = 1,
        VK_VERTEX_INPUT_RATE_BEGIN_RANGE = VK_VERTEX_INPUT_RATE_VERTEX,
        VK_VERTEX_INPUT_RATE_END_RANGE = VK_VERTEX_INPUT_RATE_INSTANCE,
        VK_VERTEX_INPUT_RATE_RANGE_SIZE = (VK_VERTEX_INPUT_RATE_INSTANCE - VK_VERTEX_INPUT_RATE_VERTEX + 1),
        VK_VERTEX_INPUT_RATE_MAX_ENUM = 0x7FFFFFFF,
    }
}
