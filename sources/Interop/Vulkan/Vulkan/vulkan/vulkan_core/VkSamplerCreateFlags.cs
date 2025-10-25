// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VkSamplerCreateFlags : uint
{
    VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = 0x00000001,
    VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = 0x00000002,
    VK_SAMPLER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x00000008,
    VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT = 0x00000004,
    VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM = 0x00000010,
    VK_SAMPLER_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
