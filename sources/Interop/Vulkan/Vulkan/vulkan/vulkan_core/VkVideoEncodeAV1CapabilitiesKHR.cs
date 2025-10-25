// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeAV1CapabilitiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkVideoEncodeAV1CapabilityFlagsKHR")]
    public uint flags;

    public StdVideoAV1Level maxLevel;

    public VkExtent2D codedPictureAlignment;

    public VkExtent2D maxTiles;

    public VkExtent2D minTileSize;

    public VkExtent2D maxTileSize;

    [NativeTypeName("VkVideoEncodeAV1SuperblockSizeFlagsKHR")]
    public uint superblockSizes;

    [NativeTypeName("uint32_t")]
    public uint maxSingleReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint singleReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint maxUnidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint unidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint maxBidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxBidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxBidirectionalCompoundGroup2ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint bidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint maxTemporalLayerCount;

    [NativeTypeName("uint32_t")]
    public uint maxSpatialLayerCount;

    [NativeTypeName("uint32_t")]
    public uint maxOperatingPoints;

    [NativeTypeName("uint32_t")]
    public uint minQIndex;

    [NativeTypeName("uint32_t")]
    public uint maxQIndex;

    [NativeTypeName("VkBool32")]
    public uint prefersGopRemainingFrames;

    [NativeTypeName("VkBool32")]
    public uint requiresGopRemainingFrames;

    [NativeTypeName("VkVideoEncodeAV1StdFlagsKHR")]
    public uint stdSyntaxFlags;
}
