// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
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
}
