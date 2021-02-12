// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkImageFormatProperties
    {
        public VkExtent3D maxExtent;

        [NativeTypeName("uint32_t")]
        public uint maxMipLevels;

        [NativeTypeName("uint32_t")]
        public uint maxArrayLayers;

        [NativeTypeName("VkSampleCountFlags")]
        public uint sampleCounts;

        [NativeTypeName("VkDeviceSize")]
        public ulong maxResourceSize;
    }
}
