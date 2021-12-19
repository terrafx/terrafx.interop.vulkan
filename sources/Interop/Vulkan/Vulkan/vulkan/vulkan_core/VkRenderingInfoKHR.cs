// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkRenderingInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkRenderingFlagsKHR")]
        public uint flags;

        public VkRect2D renderArea;

        [NativeTypeName("uint32_t")]
        public uint layerCount;

        [NativeTypeName("uint32_t")]
        public uint viewMask;

        [NativeTypeName("uint32_t")]
        public uint colorAttachmentCount;

        [NativeTypeName("const VkRenderingAttachmentInfoKHR *")]
        public VkRenderingAttachmentInfoKHR* pColorAttachments;

        [NativeTypeName("const VkRenderingAttachmentInfoKHR *")]
        public VkRenderingAttachmentInfoKHR* pDepthAttachment;

        [NativeTypeName("const VkRenderingAttachmentInfoKHR *")]
        public VkRenderingAttachmentInfoKHR* pStencilAttachment;
    }
}