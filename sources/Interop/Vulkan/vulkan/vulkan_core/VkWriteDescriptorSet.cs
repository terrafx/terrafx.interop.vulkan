// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkWriteDescriptorSet
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDescriptorSet")]
        public ulong dstSet;

        [NativeTypeName("uint32_t")]
        public uint dstBinding;

        [NativeTypeName("uint32_t")]
        public uint dstArrayElement;

        [NativeTypeName("uint32_t")]
        public uint descriptorCount;

        public VkDescriptorType descriptorType;

        [NativeTypeName("const VkDescriptorImageInfo *")]
        public VkDescriptorImageInfo* pImageInfo;

        [NativeTypeName("const VkDescriptorBufferInfo *")]
        public VkDescriptorBufferInfo* pBufferInfo;

        [NativeTypeName("const VkBufferView *")]
        public ulong* pTexelBufferView;
    }
}
