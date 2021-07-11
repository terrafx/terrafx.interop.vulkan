// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkBool32")]
        public uint formatA4R4G4B4;

        [NativeTypeName("VkBool32")]
        public uint formatA4B4G4R4;
    }
}
