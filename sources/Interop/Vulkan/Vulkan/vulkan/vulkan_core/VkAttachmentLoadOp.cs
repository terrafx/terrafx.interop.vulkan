// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkAttachmentLoadOp
{
    VK_ATTACHMENT_LOAD_OP_LOAD = 0,
    VK_ATTACHMENT_LOAD_OP_CLEAR = 1,
    VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2,
    VK_ATTACHMENT_LOAD_OP_NONE = 1000400000,
    VK_ATTACHMENT_LOAD_OP_NONE_EXT = VK_ATTACHMENT_LOAD_OP_NONE,
    VK_ATTACHMENT_LOAD_OP_NONE_KHR = VK_ATTACHMENT_LOAD_OP_NONE,
    VK_ATTACHMENT_LOAD_OP_MAX_ENUM = 0x7FFFFFFF,
}
