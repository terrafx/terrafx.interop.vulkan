// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSubpassDescription
    {
        [NativeTypeName("VkSubpassDescriptionFlags")]
        public uint flags;

        public VkPipelineBindPoint pipelineBindPoint;

        [NativeTypeName("uint32_t")]
        public uint inputAttachmentCount;

        [NativeTypeName("const VkAttachmentReference *")]
        public VkAttachmentReference* pInputAttachments;

        [NativeTypeName("uint32_t")]
        public uint colorAttachmentCount;

        [NativeTypeName("const VkAttachmentReference *")]
        public VkAttachmentReference* pColorAttachments;

        [NativeTypeName("const VkAttachmentReference *")]
        public VkAttachmentReference* pResolveAttachments;

        [NativeTypeName("const VkAttachmentReference *")]
        public VkAttachmentReference* pDepthStencilAttachment;

        [NativeTypeName("uint32_t")]
        public uint preserveAttachmentCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pPreserveAttachments;
    }
}
