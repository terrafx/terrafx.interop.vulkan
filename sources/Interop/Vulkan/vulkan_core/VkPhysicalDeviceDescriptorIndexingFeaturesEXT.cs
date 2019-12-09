// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("VkBool32")]
        public uint shaderInputAttachmentArrayDynamicIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderUniformTexelBufferArrayDynamicIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderStorageTexelBufferArrayDynamicIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderUniformBufferArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderSampledImageArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderStorageBufferArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderStorageImageArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderInputAttachmentArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderUniformTexelBufferArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")]
        public uint shaderStorageTexelBufferArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingUniformBufferUpdateAfterBind;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingSampledImageUpdateAfterBind;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingStorageImageUpdateAfterBind;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingStorageBufferUpdateAfterBind;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingUniformTexelBufferUpdateAfterBind;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingStorageTexelBufferUpdateAfterBind;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingUpdateUnusedWhilePending;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingPartiallyBound;

        [NativeTypeName("VkBool32")]
        public uint descriptorBindingVariableDescriptorCount;

        [NativeTypeName("VkBool32")]
        public uint runtimeDescriptorArray;
    }
}
