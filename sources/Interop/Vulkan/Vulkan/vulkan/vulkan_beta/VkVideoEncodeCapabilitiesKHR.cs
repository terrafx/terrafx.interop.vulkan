// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeCapabilitiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    public VkVideoEncodeCapabilityFlagsKHR flags;

    public VkVideoEncodeRateControlModeFlagsKHR rateControlModes;

    [NativeTypeName("uint32_t")]
    public uint maxRateControlLayers;

    [NativeTypeName("uint64_t")]
    public ulong maxBitrate;

    [NativeTypeName("uint32_t")]
    public uint maxQualityLevels;

    public VkExtent2D encodeInputPictureGranularity;

    [NativeTypeName("VkVideoEncodeFeedbackFlagsKHR")]
    public uint supportedEncodeFeedbackFlags;
}
