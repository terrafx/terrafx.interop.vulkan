// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkAccelerationStructureTypeKHR type;

    public VkBuildAccelerationStructureFlagsKHR flags;

    public VkBuildAccelerationStructureModeKHR mode;

    public VkAccelerationStructureKHR srcAccelerationStructure;

    public VkAccelerationStructureKHR dstAccelerationStructure;

    [NativeTypeName("uint32_t")]
    public uint geometryCount;

    [NativeTypeName("const VkAccelerationStructureGeometryKHR *")]
    public VkAccelerationStructureGeometryKHR* pGeometries;

    [NativeTypeName("const VkAccelerationStructureGeometryKHR *const *")]
    public VkAccelerationStructureGeometryKHR** ppGeometries;

    public VkDeviceOrHostAddressKHR scratchData;
}
