// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAccelerationStructureCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDeviceSize")]
        public ulong compactedSize;

        public VkAccelerationStructureTypeKHR type;

        [NativeTypeName("VkBuildAccelerationStructureFlagsKHR")]
        public uint flags;

        [NativeTypeName("uint32_t")]
        public uint maxGeometryCount;

        [NativeTypeName("const VkAccelerationStructureCreateGeometryTypeInfoKHR *")]
        public VkAccelerationStructureCreateGeometryTypeInfoKHR* pGeometryInfos;

        [NativeTypeName("VkDeviceAddress")]
        public ulong deviceAddress;
    }
}
