// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkOpticalFlowGridSizeFlagsNV : uint
{
    VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV = 0,
    VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV = 0x00000001,
    VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV = 0x00000002,
    VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV = 0x00000004,
    VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV = 0x00000008,
    VK_OPTICAL_FLOW_GRID_SIZE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
}
