// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceDriverProperties
    {
        public VkStructureType sType;

        public void* pNext;

        public VkDriverId driverID;

        [NativeTypeName("char [256]")]
        public fixed sbyte driverName[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte driverInfo[256];

        public VkConformanceVersion conformanceVersion;
    }
}
