// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkAccelerationStructureTrianglesDisplacementMicromapNV
{
    public VkStructureType sType;

    public void* pNext;

    public VkFormat displacementBiasAndScaleFormat;

    public VkFormat displacementVectorFormat;

    public VkDeviceOrHostAddressConstKHR displacementBiasAndScaleBuffer;

    [NativeTypeName("VkDeviceSize")]
    public ulong displacementBiasAndScaleStride;

    public VkDeviceOrHostAddressConstKHR displacementVectorBuffer;

    [NativeTypeName("VkDeviceSize")]
    public ulong displacementVectorStride;

    public VkDeviceOrHostAddressConstKHR displacedMicromapPrimitiveFlags;

    [NativeTypeName("VkDeviceSize")]
    public ulong displacedMicromapPrimitiveFlagsStride;

    public VkIndexType indexType;

    public VkDeviceOrHostAddressConstKHR indexBuffer;

    [NativeTypeName("VkDeviceSize")]
    public ulong indexStride;

    [NativeTypeName("uint32_t")]
    public uint baseTriangle;

    [NativeTypeName("uint32_t")]
    public uint usageCountsCount;

    [NativeTypeName("const VkMicromapUsageEXT *")]
    public VkMicromapUsageEXT* pUsageCounts;

    [NativeTypeName("const VkMicromapUsageEXT *const *")]
    public VkMicromapUsageEXT** ppUsageCounts;

    public VkMicromapEXT micromap;
}
