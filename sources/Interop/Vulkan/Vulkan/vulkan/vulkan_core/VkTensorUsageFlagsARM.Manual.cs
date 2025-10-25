// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[Flags]
public enum VkTensorUsageFlagsARM : ulong
{
    VK_TENSOR_USAGE_DATA_GRAPH_BIT_ARM = 0x00000020UL,
    VK_TENSOR_USAGE_IMAGE_ALIASING_BIT_ARM = 0x00000010UL,
    VK_TENSOR_USAGE_TRANSFER_DST_BIT_ARM = 0x00000008UL,
    VK_TENSOR_USAGE_TRANSFER_SRC_BIT_ARM = 0x00000004UL,
    VK_TENSOR_USAGE_SHADER_BIT_ARM = 0x00000002UL,
}
