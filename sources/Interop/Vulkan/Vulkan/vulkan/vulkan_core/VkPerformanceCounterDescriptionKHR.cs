// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType sType;

        public void* pNext;

        public VkPerformanceCounterDescriptionFlagsKHR flags;

        [NativeTypeName("char [256]")]
        public fixed sbyte name[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte category[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte description[256];
    }
}
