// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceCooperativeMatrix2FeaturesNV
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint cooperativeMatrixWorkgroupScope;

    [NativeTypeName("VkBool32")]
    public uint cooperativeMatrixFlexibleDimensions;

    [NativeTypeName("VkBool32")]
    public uint cooperativeMatrixReductions;

    [NativeTypeName("VkBool32")]
    public uint cooperativeMatrixConversions;

    [NativeTypeName("VkBool32")]
    public uint cooperativeMatrixPerElementOperations;

    [NativeTypeName("VkBool32")]
    public uint cooperativeMatrixTensorAddressing;

    [NativeTypeName("VkBool32")]
    public uint cooperativeMatrixBlockLoads;
}
