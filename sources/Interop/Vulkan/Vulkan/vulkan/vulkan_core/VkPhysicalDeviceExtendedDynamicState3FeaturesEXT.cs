// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3TessellationDomainOrigin;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3DepthClampEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3PolygonMode;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3RasterizationSamples;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3SampleMask;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3AlphaToCoverageEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3AlphaToOneEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3LogicOpEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ColorBlendEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ColorBlendEquation;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ColorWriteMask;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3RasterizationStream;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ConservativeRasterizationMode;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ExtraPrimitiveOverestimationSize;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3DepthClipEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3SampleLocationsEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ColorBlendAdvanced;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ProvokingVertexMode;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3LineRasterizationMode;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3LineStippleEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3DepthClipNegativeOneToOne;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ViewportWScalingEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ViewportSwizzle;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3CoverageToColorEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3CoverageToColorLocation;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3CoverageModulationMode;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3CoverageModulationTableEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3CoverageModulationTable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3CoverageReductionMode;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3RepresentativeFragmentTestEnable;

    [NativeTypeName("VkBool32")]
    public uint extendedDynamicState3ShadingRateImageEnable;
}
