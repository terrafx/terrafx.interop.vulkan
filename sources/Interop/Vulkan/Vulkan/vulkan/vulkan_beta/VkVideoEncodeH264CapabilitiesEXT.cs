// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH264CapabilitiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    public VkVideoEncodeH264CapabilityFlagsEXT flags;

    public VkVideoEncodeH264InputModeFlagsEXT inputModeFlags;

    public VkVideoEncodeH264OutputModeFlagsEXT outputModeFlags;

    [NativeTypeName("uint8_t")]
    public byte maxPPictureL0ReferenceCount;

    [NativeTypeName("uint8_t")]
    public byte maxBPictureL0ReferenceCount;

    [NativeTypeName("uint8_t")]
    public byte maxL1ReferenceCount;

    public VkBool32 motionVectorsOverPicBoundariesFlag;

    [NativeTypeName("uint32_t")]
    public uint maxBytesPerPicDenom;

    [NativeTypeName("uint32_t")]
    public uint maxBitsPerMbDenom;

    [NativeTypeName("uint32_t")]
    public uint log2MaxMvLengthHorizontal;

    [NativeTypeName("uint32_t")]
    public uint log2MaxMvLengthVertical;
}
