// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkDescriptorUpdateTemplateCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDescriptorUpdateTemplateCreateFlags")]
        public uint flags;

        [NativeTypeName("uint32_t")]
        public uint descriptorUpdateEntryCount;

        [NativeTypeName("const VkDescriptorUpdateTemplateEntry *")]
        public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;

        public VkDescriptorUpdateTemplateType templateType;

        [NativeTypeName("VkDescriptorSetLayout")]
        public ulong descriptorSetLayout;

        public VkPipelineBindPoint pipelineBindPoint;

        [NativeTypeName("VkPipelineLayout")]
        public ulong pipelineLayout;

        [NativeTypeName("uint32_t")]
        public uint set;
    }
}
