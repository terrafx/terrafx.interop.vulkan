// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct VkDecompressMemoryRegionNV
{
    [NativeTypeName("VkDeviceAddress")]
    public ulong srcAddress;

    [NativeTypeName("VkDeviceAddress")]
    public ulong dstAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong compressedSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong decompressedSize;

    [NativeTypeName("VkMemoryDecompressionMethodFlagsNV")]
    public ulong decompressionMethod;
}