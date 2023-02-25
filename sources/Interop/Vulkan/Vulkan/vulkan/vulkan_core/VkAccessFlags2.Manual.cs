// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[Flags]
public enum VkAccessFlags2 : ulong
{
    VK_ACCESS_2_NONE = 0UL,
    VK_ACCESS_2_NONE_KHR = 0UL,
    VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT = 0x00000001UL,
    VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR = 0x00000001UL,
    VK_ACCESS_2_INDEX_READ_BIT = 0x00000002UL,
    VK_ACCESS_2_INDEX_READ_BIT_KHR = 0x00000002UL,
    VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT = 0x00000004UL,
    VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR = 0x00000004UL,
    VK_ACCESS_2_UNIFORM_READ_BIT = 0x00000008UL,
    VK_ACCESS_2_UNIFORM_READ_BIT_KHR = 0x00000008UL,
    VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT = 0x00000010UL,
    VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR = 0x00000010UL,
    VK_ACCESS_2_SHADER_READ_BIT = 0x00000020UL,
    VK_ACCESS_2_SHADER_READ_BIT_KHR = 0x00000020UL,
    VK_ACCESS_2_SHADER_WRITE_BIT = 0x00000040UL,
    VK_ACCESS_2_SHADER_WRITE_BIT_KHR = 0x00000040UL,
    VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT = 0x00000080UL,
    VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR = 0x00000080UL,
    VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT = 0x00000100UL,
    VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR = 0x00000100UL,
    VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT = 0x00000200UL,
    VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR = 0x00000200UL,
    VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = 0x00000400UL,
    VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR = 0x00000400UL,
    VK_ACCESS_2_TRANSFER_READ_BIT = 0x00000800UL,
    VK_ACCESS_2_TRANSFER_READ_BIT_KHR = 0x00000800UL,
    VK_ACCESS_2_TRANSFER_WRITE_BIT = 0x00001000UL,
    VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR = 0x00001000UL,
    VK_ACCESS_2_HOST_READ_BIT = 0x00002000UL,
    VK_ACCESS_2_HOST_READ_BIT_KHR = 0x00002000UL,
    VK_ACCESS_2_HOST_WRITE_BIT = 0x00004000UL,
    VK_ACCESS_2_HOST_WRITE_BIT_KHR = 0x00004000UL,
    VK_ACCESS_2_MEMORY_READ_BIT = 0x00008000UL,
    VK_ACCESS_2_MEMORY_READ_BIT_KHR = 0x00008000UL,
    VK_ACCESS_2_MEMORY_WRITE_BIT = 0x00010000UL,
    VK_ACCESS_2_MEMORY_WRITE_BIT_KHR = 0x00010000UL,
    VK_ACCESS_2_SHADER_SAMPLED_READ_BIT = 0x100000000UL,
    VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR = 0x100000000UL,
    VK_ACCESS_2_SHADER_STORAGE_READ_BIT = 0x200000000UL,
    VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR = 0x200000000UL,
    VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT = 0x400000000UL,
    VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR = 0x400000000UL,
    VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR = 0x800000000UL,
    VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR = 0x1000000000UL,
    VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR = 0x2000000000UL,
    VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR = 0x4000000000UL,
    VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = 0x02000000UL,
    VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = 0x04000000UL,
    VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = 0x08000000UL,
    VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT = 0x00100000UL,
    VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV = 0x00020000UL,
    VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV = 0x00040000UL,
    VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000UL,
    VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV = 0x00800000UL,
    VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR = 0x00200000UL,
    VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = 0x00400000UL,
    VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV = 0x00200000UL,
    VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV = 0x00400000UL,
    VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = 0x01000000UL,
    VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = 0x00080000UL,
    VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI = 0x8000000000UL,
    VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR = 0x10000000000UL,
}
