// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkCoarseSampleOrderCustomNV
    {
        public VkShadingRatePaletteEntryNV shadingRate;

        [NativeTypeName("uint32_t")]
        public uint sampleCount;

        [NativeTypeName("uint32_t")]
        public uint sampleLocationCount;

        [NativeTypeName("const VkCoarseSampleLocationNV *")]
        public VkCoarseSampleLocationNV* pSampleLocations;
    }
}
