// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPerformanceCounterDescriptionFlagsKHR")]
        public uint flags;

        [NativeTypeName("char [256]")]
        public fixed sbyte name[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte category[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte description[256];
    }
}