// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAttachmentDescription2
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkAttachmentDescriptionFlags")]
        public uint flags;

        public VkFormat format;

        public VkSampleCountFlagBits samples;

        public VkAttachmentLoadOp loadOp;

        public VkAttachmentStoreOp storeOp;

        public VkAttachmentLoadOp stencilLoadOp;

        public VkAttachmentStoreOp stencilStoreOp;

        public VkImageLayout initialLayout;

        public VkImageLayout finalLayout;
    }
}