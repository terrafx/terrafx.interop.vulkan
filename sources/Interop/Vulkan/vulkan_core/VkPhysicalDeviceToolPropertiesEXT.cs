// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceToolPropertiesEXT
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("char [256]")]
        public fixed sbyte name[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte version[256];

        [NativeTypeName("VkToolPurposeFlagsEXT")]
        public uint purposes;

        [NativeTypeName("char [256]")]
        public fixed sbyte description[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte layer[256];
    }
}
