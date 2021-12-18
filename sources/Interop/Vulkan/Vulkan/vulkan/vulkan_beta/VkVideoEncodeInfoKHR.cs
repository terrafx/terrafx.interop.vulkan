// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoEncodeInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkVideoEncodeFlagsKHR flags;

        [NativeTypeName("uint32_t")]
        public uint qualityLevel;

        public VkExtent2D codedExtent;

        public VkBuffer dstBitstreamBuffer;

        [NativeTypeName("VkDeviceSize")]
        public ulong dstBitstreamBufferOffset;

        [NativeTypeName("VkDeviceSize")]
        public ulong dstBitstreamBufferMaxRange;

        public VkVideoPictureResourceKHR srcPictureResource;

        [NativeTypeName("const VkVideoReferenceSlotKHR *")]
        public VkVideoReferenceSlotKHR* pSetupReferenceSlot;

        [NativeTypeName("uint32_t")]
        public uint referenceSlotCount;

        [NativeTypeName("const VkVideoReferenceSlotKHR *")]
        public VkVideoReferenceSlotKHR* pReferenceSlots;
    }
}
