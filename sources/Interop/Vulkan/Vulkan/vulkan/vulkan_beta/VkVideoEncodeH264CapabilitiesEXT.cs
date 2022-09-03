// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH264CapabilitiesEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkVideoEncodeH264CapabilityFlagsEXT flags;

    public VkVideoEncodeH264InputModeFlagsEXT inputModeFlags;

    public VkVideoEncodeH264OutputModeFlagsEXT outputModeFlags;

    public VkExtent2D minPictureSizeInMbs;

    public VkExtent2D maxPictureSizeInMbs;

    public VkExtent2D inputImageDataAlignment;

    [NativeTypeName("uint8_t")]
    public byte maxNumL0ReferenceForP;

    [NativeTypeName("uint8_t")]
    public byte maxNumL0ReferenceForB;

    [NativeTypeName("uint8_t")]
    public byte maxNumL1Reference;

    [NativeTypeName("uint8_t")]
    public byte qualityLevelCount;

    public VkExtensionProperties stdExtensionVersion;
}
