// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
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
