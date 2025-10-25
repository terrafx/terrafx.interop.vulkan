// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceOpticalFlowPropertiesNV
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    public uint supportedOutputGridSizes;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    public uint supportedHintGridSizes;

    [NativeTypeName("VkBool32")]
    public uint hintSupported;

    [NativeTypeName("VkBool32")]
    public uint costSupported;

    [NativeTypeName("VkBool32")]
    public uint bidirectionalFlowSupported;

    [NativeTypeName("VkBool32")]
    public uint globalFlowSupported;

    [NativeTypeName("uint32_t")]
    public uint minWidth;

    [NativeTypeName("uint32_t")]
    public uint minHeight;

    [NativeTypeName("uint32_t")]
    public uint maxWidth;

    [NativeTypeName("uint32_t")]
    public uint maxHeight;

    [NativeTypeName("uint32_t")]
    public uint maxNumRegionsOfInterest;
}
