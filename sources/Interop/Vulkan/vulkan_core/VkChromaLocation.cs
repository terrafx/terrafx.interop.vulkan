// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkChromaLocation
    {
        VK_CHROMA_LOCATION_COSITED_EVEN = 0,
        VK_CHROMA_LOCATION_MIDPOINT = 1,
        VK_CHROMA_LOCATION_COSITED_EVEN_KHR = VK_CHROMA_LOCATION_COSITED_EVEN,
        VK_CHROMA_LOCATION_MIDPOINT_KHR = VK_CHROMA_LOCATION_MIDPOINT,
        VK_CHROMA_LOCATION_BEGIN_RANGE = VK_CHROMA_LOCATION_COSITED_EVEN,
        VK_CHROMA_LOCATION_END_RANGE = VK_CHROMA_LOCATION_MIDPOINT,
        VK_CHROMA_LOCATION_RANGE_SIZE = (VK_CHROMA_LOCATION_MIDPOINT - VK_CHROMA_LOCATION_COSITED_EVEN + 1),
        VK_CHROMA_LOCATION_MAX_ENUM = 0x7FFFFFFF,
    }
}
