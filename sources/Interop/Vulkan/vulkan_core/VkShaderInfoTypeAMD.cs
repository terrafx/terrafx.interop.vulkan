// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkShaderInfoTypeAMD
    {
        VK_SHADER_INFO_TYPE_STATISTICS_AMD = 0,
        VK_SHADER_INFO_TYPE_BINARY_AMD = 1,
        VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD = 2,
        VK_SHADER_INFO_TYPE_BEGIN_RANGE_AMD = VK_SHADER_INFO_TYPE_STATISTICS_AMD,
        VK_SHADER_INFO_TYPE_END_RANGE_AMD = VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD,
        VK_SHADER_INFO_TYPE_RANGE_SIZE_AMD = (VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD - VK_SHADER_INFO_TYPE_STATISTICS_AMD + 1),
        VK_SHADER_INFO_TYPE_MAX_ENUM_AMD = 0x7FFFFFFF,
    }
}
