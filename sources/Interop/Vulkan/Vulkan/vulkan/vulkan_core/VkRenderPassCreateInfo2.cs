// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkRenderPassCreateInfo2
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkRenderPassCreateFlags flags;

        [NativeTypeName("uint32_t")]
        public uint attachmentCount;

        [NativeTypeName("const VkAttachmentDescription2 *")]
        public VkAttachmentDescription2* pAttachments;

        [NativeTypeName("uint32_t")]
        public uint subpassCount;

        [NativeTypeName("const VkSubpassDescription2 *")]
        public VkSubpassDescription2* pSubpasses;

        [NativeTypeName("uint32_t")]
        public uint dependencyCount;

        [NativeTypeName("const VkSubpassDependency2 *")]
        public VkSubpassDependency2* pDependencies;

        [NativeTypeName("uint32_t")]
        public uint correlatedViewMaskCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pCorrelatedViewMasks;
    }
}
