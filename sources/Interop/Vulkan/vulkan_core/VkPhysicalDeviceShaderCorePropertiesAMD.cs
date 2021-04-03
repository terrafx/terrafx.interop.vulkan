// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint shaderEngineCount;

        [NativeTypeName("uint32_t")]
        public uint shaderArraysPerEngineCount;

        [NativeTypeName("uint32_t")]
        public uint computeUnitsPerShaderArray;

        [NativeTypeName("uint32_t")]
        public uint simdPerComputeUnit;

        [NativeTypeName("uint32_t")]
        public uint wavefrontsPerSimd;

        [NativeTypeName("uint32_t")]
        public uint wavefrontSize;

        [NativeTypeName("uint32_t")]
        public uint sgprsPerSimd;

        [NativeTypeName("uint32_t")]
        public uint minSgprAllocation;

        [NativeTypeName("uint32_t")]
        public uint maxSgprAllocation;

        [NativeTypeName("uint32_t")]
        public uint sgprAllocationGranularity;

        [NativeTypeName("uint32_t")]
        public uint vgprsPerSimd;

        [NativeTypeName("uint32_t")]
        public uint minVgprAllocation;

        [NativeTypeName("uint32_t")]
        public uint maxVgprAllocation;

        [NativeTypeName("uint32_t")]
        public uint vgprAllocationGranularity;
    }
}
