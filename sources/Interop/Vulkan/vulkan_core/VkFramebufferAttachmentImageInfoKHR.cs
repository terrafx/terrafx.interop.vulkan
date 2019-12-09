// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkFramebufferAttachmentImageInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkImageCreateFlags")]
        public uint flags;

        [NativeTypeName("VkImageUsageFlags")]
        public uint usage;

        [NativeTypeName("uint32_t")]
        public uint width;

        [NativeTypeName("uint32_t")]
        public uint height;

        [NativeTypeName("uint32_t")]
        public uint layerCount;

        [NativeTypeName("uint32_t")]
        public uint viewFormatCount;

        [NativeTypeName("const VkFormat *")]
        public VkFormat* pViewFormats;
    }
}
