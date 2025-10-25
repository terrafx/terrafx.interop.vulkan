// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH264CapabilitiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkVideoEncodeH264CapabilityFlagsKHR")]
    public uint flags;

    public StdVideoH264LevelIdc maxLevelIdc;

    [NativeTypeName("uint32_t")]
    public uint maxSliceCount;

    [NativeTypeName("uint32_t")]
    public uint maxPPictureL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxBPictureL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxL1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint maxTemporalLayerCount;

    [NativeTypeName("VkBool32")]
    public uint expectDyadicTemporalLayerPattern;

    [NativeTypeName("int32_t")]
    public int minQp;

    [NativeTypeName("int32_t")]
    public int maxQp;

    [NativeTypeName("VkBool32")]
    public uint prefersGopRemainingFrames;

    [NativeTypeName("VkBool32")]
    public uint requiresGopRemainingFrames;

    [NativeTypeName("VkVideoEncodeH264StdFlagsKHR")]
    public uint stdSyntaxFlags;
}
