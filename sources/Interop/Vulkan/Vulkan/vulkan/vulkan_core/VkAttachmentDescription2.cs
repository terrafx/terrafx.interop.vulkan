// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkAttachmentDescription2
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkAttachmentDescriptionFlags flags;

    public VkFormat format;

    [NativeTypeName("VkSampleCountFlagBits")]
    public VkSampleCountFlags samples;

    public VkAttachmentLoadOp loadOp;

    public VkAttachmentStoreOp storeOp;

    public VkAttachmentLoadOp stencilLoadOp;

    public VkAttachmentStoreOp stencilStoreOp;

    public VkImageLayout initialLayout;

    public VkImageLayout finalLayout;
}
