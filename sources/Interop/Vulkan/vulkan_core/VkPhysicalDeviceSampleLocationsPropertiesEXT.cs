// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("VkSampleCountFlags")]
        public uint sampleLocationSampleCounts;

        public VkExtent2D maxSampleLocationGridSize;

        [NativeTypeName("float [2]")]
        public fixed float sampleLocationCoordinateRange[2];

        [NativeTypeName("uint32_t")]
        public uint sampleLocationSubPixelBits;

        [NativeTypeName("VkBool32")]
        public uint variableSampleLocations;
    }
}
