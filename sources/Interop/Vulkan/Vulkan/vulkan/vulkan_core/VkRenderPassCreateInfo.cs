// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkRenderPassCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkRenderPassCreateFlags flags;

    [NativeTypeName("uint32_t")]
    public uint attachmentCount;

    [NativeTypeName("const VkAttachmentDescription *")]
    public VkAttachmentDescription* pAttachments;

    [NativeTypeName("uint32_t")]
    public uint subpassCount;

    [NativeTypeName("const VkSubpassDescription *")]
    public VkSubpassDescription* pSubpasses;

    [NativeTypeName("uint32_t")]
    public uint dependencyCount;

    [NativeTypeName("const VkSubpassDependency *")]
    public VkSubpassDependency* pDependencies;
}
