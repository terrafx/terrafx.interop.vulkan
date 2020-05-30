// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkAccelerationStructureTypeKHR type;

        [NativeTypeName("VkBuildAccelerationStructureFlagsKHR")]
        public uint flags;

        [NativeTypeName("VkBool32")]
        public uint update;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public ulong srcAccelerationStructure;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public ulong dstAccelerationStructure;

        [NativeTypeName("VkBool32")]
        public uint geometryArrayOfPointers;

        [NativeTypeName("uint32_t")]
        public uint geometryCount;

        [NativeTypeName("const VkAccelerationStructureGeometryKHR *const *")]
        public VkAccelerationStructureGeometryKHR** ppGeometries;

        public VkDeviceOrHostAddressKHR scratchData;
    }
}
