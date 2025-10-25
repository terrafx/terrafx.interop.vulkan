// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceFloatControlsProperties
{
    public VkStructureType sType;

    public void* pNext;

    public VkShaderFloatControlsIndependence denormBehaviorIndependence;

    public VkShaderFloatControlsIndependence roundingModeIndependence;

    [NativeTypeName("VkBool32")]
    public uint shaderSignedZeroInfNanPreserveFloat16;

    [NativeTypeName("VkBool32")]
    public uint shaderSignedZeroInfNanPreserveFloat32;

    [NativeTypeName("VkBool32")]
    public uint shaderSignedZeroInfNanPreserveFloat64;

    [NativeTypeName("VkBool32")]
    public uint shaderDenormPreserveFloat16;

    [NativeTypeName("VkBool32")]
    public uint shaderDenormPreserveFloat32;

    [NativeTypeName("VkBool32")]
    public uint shaderDenormPreserveFloat64;

    [NativeTypeName("VkBool32")]
    public uint shaderDenormFlushToZeroFloat16;

    [NativeTypeName("VkBool32")]
    public uint shaderDenormFlushToZeroFloat32;

    [NativeTypeName("VkBool32")]
    public uint shaderDenormFlushToZeroFloat64;

    [NativeTypeName("VkBool32")]
    public uint shaderRoundingModeRTEFloat16;

    [NativeTypeName("VkBool32")]
    public uint shaderRoundingModeRTEFloat32;

    [NativeTypeName("VkBool32")]
    public uint shaderRoundingModeRTEFloat64;

    [NativeTypeName("VkBool32")]
    public uint shaderRoundingModeRTZFloat16;

    [NativeTypeName("VkBool32")]
    public uint shaderRoundingModeRTZFloat32;

    [NativeTypeName("VkBool32")]
    public uint shaderRoundingModeRTZFloat64;
}
