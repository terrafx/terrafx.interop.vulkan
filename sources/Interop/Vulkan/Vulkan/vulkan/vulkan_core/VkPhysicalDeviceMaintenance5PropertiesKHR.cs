// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceMaintenance5PropertiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint earlyFragmentMultisampleCoverageAfterSampleCounting;

    [NativeTypeName("VkBool32")]
    public uint earlyFragmentSampleMaskTestBeforeSampleCounting;

    [NativeTypeName("VkBool32")]
    public uint depthStencilSwizzleOneSupport;

    [NativeTypeName("VkBool32")]
    public uint polygonModePointSize;

    [NativeTypeName("VkBool32")]
    public uint nonStrictSinglePixelWideLinesUseParallelogram;

    [NativeTypeName("VkBool32")]
    public uint nonStrictWideLinesUseParallelogram;
}
