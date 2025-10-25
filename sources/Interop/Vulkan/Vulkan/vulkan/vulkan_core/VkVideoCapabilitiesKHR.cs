// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoCapabilitiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    public VkVideoCapabilityFlagsKHR flags;

    [NativeTypeName("VkDeviceSize")]
    public ulong minBitstreamBufferOffsetAlignment;

    [NativeTypeName("VkDeviceSize")]
    public ulong minBitstreamBufferSizeAlignment;

    public VkExtent2D pictureAccessGranularity;

    public VkExtent2D minCodedExtent;

    public VkExtent2D maxCodedExtent;

    [NativeTypeName("uint32_t")]
    public uint maxDpbSlots;

    [NativeTypeName("uint32_t")]
    public uint maxActiveReferencePictures;

    public VkExtensionProperties stdHeaderVersion;
}
