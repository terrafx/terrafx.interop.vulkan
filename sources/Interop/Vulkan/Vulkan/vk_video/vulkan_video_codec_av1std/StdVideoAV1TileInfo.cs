// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_av1std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct StdVideoAV1TileInfo
{
    public StdVideoAV1TileInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte TileCols;

    [NativeTypeName("uint8_t")]
    public byte TileRows;

    [NativeTypeName("uint16_t")]
    public ushort context_update_tile_id;

    [NativeTypeName("uint8_t")]
    public byte tile_size_bytes_minus_1;

    [NativeTypeName("uint8_t[7]")]
    public _reserved1_e__FixedBuffer reserved1;

    [NativeTypeName("const uint16_t *")]
    public ushort* pMiColStarts;

    [NativeTypeName("const uint16_t *")]
    public ushort* pMiRowStarts;

    [NativeTypeName("const uint16_t *")]
    public ushort* pWidthInSbsMinus1;

    [NativeTypeName("const uint16_t *")]
    public ushort* pHeightInSbsMinus1;

    [InlineArray(7)]
    public partial struct _reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
