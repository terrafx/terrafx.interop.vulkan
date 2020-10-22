// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkSparseImageFormatProperties
    {
        [NativeTypeName("VkImageAspectFlags")]
        public uint aspectMask;

        public VkExtent3D imageGranularity;

        [NativeTypeName("VkSparseImageFormatFlags")]
        public uint flags;
    }
}
