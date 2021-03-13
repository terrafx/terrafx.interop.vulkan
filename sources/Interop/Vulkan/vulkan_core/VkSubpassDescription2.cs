// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSubpassDescription2
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
}
