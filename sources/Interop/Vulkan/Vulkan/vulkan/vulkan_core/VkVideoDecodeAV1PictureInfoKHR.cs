// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoDecodeAV1PictureInfoKHR
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("const StdVideoDecodeAV1PictureInfo *")]
    public StdVideoDecodeAV1PictureInfo* pStdPictureInfo;

    [NativeTypeName("int32_t[7]")]
    public _referenceNameSlotIndices_e__FixedBuffer referenceNameSlotIndices;

    [NativeTypeName("uint32_t")]
    public uint frameHeaderOffset;

    [NativeTypeName("uint32_t")]
    public uint tileCount;

    [NativeTypeName("const uint32_t *")]
    public uint* pTileOffsets;

    [NativeTypeName("const uint32_t *")]
    public uint* pTileSizes;

    [InlineArray(7)]
    public partial struct _referenceNameSlotIndices_e__FixedBuffer
    {
        public int e0;
    }
}
