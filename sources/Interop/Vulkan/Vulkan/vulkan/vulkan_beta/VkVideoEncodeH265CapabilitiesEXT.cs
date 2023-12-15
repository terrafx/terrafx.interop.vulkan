// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH265CapabilitiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    public VkVideoEncodeH265CapabilityFlagsEXT flags;

    public StdVideoH265LevelIdc maxLevelIdc;

    [NativeTypeName("uint32_t")]
    public uint maxSliceSegmentCount;

    public VkExtent2D maxTiles;

    public VkVideoEncodeH265CtbSizeFlagsEXT ctbSizes;

    public VkVideoEncodeH265TransformBlockSizeFlagsEXT transformBlockSizes;

    [NativeTypeName("uint32_t")]
    public uint maxPPictureL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxBPictureL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxL1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxSubLayerCount;

    [NativeTypeName("VkBool32")]
    public uint expectDyadicTemporalSubLayerPattern;

    [NativeTypeName("int32_t")]
    public int minQp;

    [NativeTypeName("int32_t")]
    public int maxQp;

    [NativeTypeName("VkBool32")]
    public uint prefersGopRemainingFrames;

    [NativeTypeName("VkBool32")]
    public uint requiresGopRemainingFrames;

    [NativeTypeName("VkVideoEncodeH265StdFlagsEXT")]
    public uint stdSyntaxFlags;
}
