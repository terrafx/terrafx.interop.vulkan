// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceOpticalFlowPropertiesNV
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    public uint supportedOutputGridSizes;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    public uint supportedHintGridSizes;

    public VkBool32 hintSupported;

    public VkBool32 costSupported;

    public VkBool32 bidirectionalFlowSupported;

    public VkBool32 globalFlowSupported;

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
