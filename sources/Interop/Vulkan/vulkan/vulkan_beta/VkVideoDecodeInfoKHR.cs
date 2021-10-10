// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkVideoDecodeInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkVideoDecodeFlagsKHR flags;

        public VkOffset2D codedOffset;

        public VkExtent2D codedExtent;

        [NativeTypeName("VkBuffer")]
        public ulong srcBuffer;

        [NativeTypeName("VkDeviceSize")]
        public ulong srcBufferOffset;

        [NativeTypeName("VkDeviceSize")]
        public ulong srcBufferRange;

        public VkVideoPictureResourceKHR dstPictureResource;

        [NativeTypeName("const VkVideoReferenceSlotKHR *")]
        public VkVideoReferenceSlotKHR* pSetupReferenceSlot;

        [NativeTypeName("uint32_t")]
        public uint referenceSlotCount;

        [NativeTypeName("const VkVideoReferenceSlotKHR *")]
        public VkVideoReferenceSlotKHR* pReferenceSlots;
    }
}
