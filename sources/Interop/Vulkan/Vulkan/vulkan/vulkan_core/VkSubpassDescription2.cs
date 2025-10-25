// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkSubpassDescription2
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkSubpassDescriptionFlags flags;

    public VkPipelineBindPoint pipelineBindPoint;

    [NativeTypeName("uint32_t")]
    public uint viewMask;

    [NativeTypeName("uint32_t")]
    public uint inputAttachmentCount;

    [NativeTypeName("const VkAttachmentReference2 *")]
    public VkAttachmentReference2* pInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint colorAttachmentCount;

    [NativeTypeName("const VkAttachmentReference2 *")]
    public VkAttachmentReference2* pColorAttachments;

    [NativeTypeName("const VkAttachmentReference2 *")]
    public VkAttachmentReference2* pResolveAttachments;

    [NativeTypeName("const VkAttachmentReference2 *")]
    public VkAttachmentReference2* pDepthStencilAttachment;

    [NativeTypeName("uint32_t")]
    public uint preserveAttachmentCount;

    [NativeTypeName("const uint32_t *")]
    public uint* pPreserveAttachments;
}
