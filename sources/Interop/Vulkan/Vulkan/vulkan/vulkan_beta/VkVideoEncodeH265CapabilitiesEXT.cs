// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH265CapabilitiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    public VkVideoEncodeH265CapabilityFlagsEXT flags;

    public VkVideoEncodeH265InputModeFlagsEXT inputModeFlags;

    public VkVideoEncodeH265OutputModeFlagsEXT outputModeFlags;

    public VkVideoEncodeH265CtbSizeFlagsEXT ctbSizes;

    public VkVideoEncodeH265TransformBlockSizeFlagsEXT transformBlockSizes;

    [NativeTypeName("uint8_t")]
    public byte maxPPictureL0ReferenceCount;

    [NativeTypeName("uint8_t")]
    public byte maxBPictureL0ReferenceCount;

    [NativeTypeName("uint8_t")]
    public byte maxL1ReferenceCount;

    [NativeTypeName("uint8_t")]
    public byte maxSubLayersCount;

    [NativeTypeName("uint8_t")]
    public byte minLog2MinLumaCodingBlockSizeMinus3;

    [NativeTypeName("uint8_t")]
    public byte maxLog2MinLumaCodingBlockSizeMinus3;

    [NativeTypeName("uint8_t")]
    public byte minLog2MinLumaTransformBlockSizeMinus2;

    [NativeTypeName("uint8_t")]
    public byte maxLog2MinLumaTransformBlockSizeMinus2;

    [NativeTypeName("uint8_t")]
    public byte minMaxTransformHierarchyDepthInter;

    [NativeTypeName("uint8_t")]
    public byte maxMaxTransformHierarchyDepthInter;

    [NativeTypeName("uint8_t")]
    public byte minMaxTransformHierarchyDepthIntra;

    [NativeTypeName("uint8_t")]
    public byte maxMaxTransformHierarchyDepthIntra;

    [NativeTypeName("uint8_t")]
    public byte maxDiffCuQpDeltaDepth;

    [NativeTypeName("uint8_t")]
    public byte minMaxNumMergeCand;

    [NativeTypeName("uint8_t")]
    public byte maxMaxNumMergeCand;
}
