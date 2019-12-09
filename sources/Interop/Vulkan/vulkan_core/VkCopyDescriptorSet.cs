// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkCopyDescriptorSet
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDescriptorSet")]
        public ulong srcSet;

        [NativeTypeName("uint32_t")]
        public uint srcBinding;

        [NativeTypeName("uint32_t")]
        public uint srcArrayElement;

        [NativeTypeName("VkDescriptorSet")]
        public ulong dstSet;

        [NativeTypeName("uint32_t")]
        public uint dstBinding;

        [NativeTypeName("uint32_t")]
        public uint dstArrayElement;

        [NativeTypeName("uint32_t")]
        public uint descriptorCount;
    }
}
