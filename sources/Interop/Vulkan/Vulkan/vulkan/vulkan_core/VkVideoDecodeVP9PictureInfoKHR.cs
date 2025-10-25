// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoDecodeVP9PictureInfoKHR
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("const StdVideoDecodeVP9PictureInfo *")]
    public StdVideoDecodeVP9PictureInfo* pStdPictureInfo;

    [NativeTypeName("int32_t[3]")]
    public _referenceNameSlotIndices_e__FixedBuffer referenceNameSlotIndices;

    [NativeTypeName("uint32_t")]
    public uint uncompressedHeaderOffset;

    [NativeTypeName("uint32_t")]
    public uint compressedHeaderOffset;

    [NativeTypeName("uint32_t")]
    public uint tilesOffset;

    [InlineArray(3)]
    public partial struct _referenceNameSlotIndices_e__FixedBuffer
    {
        public int e0;
    }
}
