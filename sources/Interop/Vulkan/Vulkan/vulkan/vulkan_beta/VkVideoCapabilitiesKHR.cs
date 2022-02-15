// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoCapabilitiesKHR
    {
        public VkStructureType sType;

        public void* pNext;

        public VkVideoCapabilityFlagsKHR capabilityFlags;

        [NativeTypeName("VkDeviceSize")]
        public ulong minBitstreamBufferOffsetAlignment;

        [NativeTypeName("VkDeviceSize")]
        public ulong minBitstreamBufferSizeAlignment;

        public VkExtent2D videoPictureExtentGranularity;

        public VkExtent2D minExtent;

        public VkExtent2D maxExtent;

        [NativeTypeName("uint32_t")]
        public uint maxReferencePicturesSlotsCount;

        [NativeTypeName("uint32_t")]
        public uint maxReferencePicturesActiveCount;
    }
}
