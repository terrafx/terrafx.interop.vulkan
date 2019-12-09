// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public partial struct VkDescriptorUpdateTemplateEntry
    {
        [NativeTypeName("uint32_t")]
        public uint dstBinding;

        [NativeTypeName("uint32_t")]
        public uint dstArrayElement;

        [NativeTypeName("uint32_t")]
        public uint descriptorCount;

        public VkDescriptorType descriptorType;

        [NativeTypeName("size_t")]
        public UIntPtr offset;

        [NativeTypeName("size_t")]
        public UIntPtr stride;
    }
}
