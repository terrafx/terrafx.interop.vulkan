// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSubpassDescription2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkSubpassDescriptionFlags")]
        public uint flags;

        public VkPipelineBindPoint pipelineBindPoint;

        [NativeTypeName("uint32_t")]
        public uint viewMask;

        [NativeTypeName("uint32_t")]
        public uint inputAttachmentCount;

        [NativeTypeName("const VkAttachmentReference2KHR *")]
        public VkAttachmentReference2KHR* pInputAttachments;

        [NativeTypeName("uint32_t")]
        public uint colorAttachmentCount;

        [NativeTypeName("const VkAttachmentReference2KHR *")]
        public VkAttachmentReference2KHR* pColorAttachments;

        [NativeTypeName("const VkAttachmentReference2KHR *")]
        public VkAttachmentReference2KHR* pResolveAttachments;

        [NativeTypeName("const VkAttachmentReference2KHR *")]
        public VkAttachmentReference2KHR* pDepthStencilAttachment;

        [NativeTypeName("uint32_t")]
        public uint preserveAttachmentCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pPreserveAttachments;
    }
}
