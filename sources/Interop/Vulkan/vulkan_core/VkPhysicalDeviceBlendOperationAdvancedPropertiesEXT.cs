// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint advancedBlendMaxColorAttachments;

        [NativeTypeName("VkBool32")]
        public uint advancedBlendIndependentBlend;

        [NativeTypeName("VkBool32")]
        public uint advancedBlendNonPremultipliedSrcColor;

        [NativeTypeName("VkBool32")]
        public uint advancedBlendNonPremultipliedDstColor;

        [NativeTypeName("VkBool32")]
        public uint advancedBlendCorrelatedOverlap;

        [NativeTypeName("VkBool32")]
        public uint advancedBlendAllOperations;
    }
}
