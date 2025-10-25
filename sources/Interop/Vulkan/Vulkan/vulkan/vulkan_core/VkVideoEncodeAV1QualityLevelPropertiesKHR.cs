// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeAV1QualityLevelPropertiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkVideoEncodeAV1RateControlFlagsKHR")]
    public uint preferredRateControlFlags;

    [NativeTypeName("uint32_t")]
    public uint preferredGopFrameCount;

    [NativeTypeName("uint32_t")]
    public uint preferredKeyFramePeriod;

    [NativeTypeName("uint32_t")]
    public uint preferredConsecutiveBipredictiveFrameCount;

    [NativeTypeName("uint32_t")]
    public uint preferredTemporalLayerCount;

    public VkVideoEncodeAV1QIndexKHR preferredConstantQIndex;

    [NativeTypeName("uint32_t")]
    public uint preferredMaxSingleReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint preferredSingleReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint preferredMaxUnidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint preferredMaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint preferredUnidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint preferredMaxBidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint preferredMaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint preferredMaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint preferredBidirectionalCompoundReferenceNameMask;
}
