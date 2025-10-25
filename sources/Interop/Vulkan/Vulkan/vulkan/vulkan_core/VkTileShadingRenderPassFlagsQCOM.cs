// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkTileShadingRenderPassFlagsQCOM : uint
{
    VK_TILE_SHADING_RENDER_PASS_ENABLE_BIT_QCOM = 0x00000001,
    VK_TILE_SHADING_RENDER_PASS_PER_TILE_EXECUTION_BIT_QCOM = 0x00000002,
    VK_TILE_SHADING_RENDER_PASS_FLAG_BITS_MAX_ENUM_QCOM = 0x7FFFFFFF,
}
