// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkBufferImageCopy
    {
        [NativeTypeName("VkDeviceSize")]
        public ulong bufferOffset;

        [NativeTypeName("uint32_t")]
        public uint bufferRowLength;

        [NativeTypeName("uint32_t")]
        public uint bufferImageHeight;

        public VkImageSubresourceLayers imageSubresource;

        public VkOffset3D imageOffset;

        public VkExtent3D imageExtent;
    }
}
