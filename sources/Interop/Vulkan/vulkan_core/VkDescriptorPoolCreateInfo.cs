// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDescriptorPoolCreateFlags")]
        public uint flags;

        [NativeTypeName("uint32_t")]
        public uint maxSets;

        [NativeTypeName("uint32_t")]
        public uint poolSizeCount;

        [NativeTypeName("const VkDescriptorPoolSize *")]
        public VkDescriptorPoolSize* pPoolSizes;
    }
}
