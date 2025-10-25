// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct8BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct8BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct8BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct4x8BitPackedUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct4x8BitPackedSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct4x8BitPackedMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct16BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct16BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct16BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct32BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct32BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct32BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct64BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct64BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProduct64BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating8BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating16BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating32BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating64BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
