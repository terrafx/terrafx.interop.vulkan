// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType sType;

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
