// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkImageResolve
    {
        public VkImageSubresourceLayers srcSubresource;

        public VkOffset3D srcOffset;

        public VkImageSubresourceLayers dstSubresource;

        public VkOffset3D dstOffset;

        public VkExtent3D extent;
    }
}
