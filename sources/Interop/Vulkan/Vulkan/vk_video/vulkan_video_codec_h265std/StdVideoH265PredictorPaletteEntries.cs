// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoH265PredictorPaletteEntries
{
    [NativeTypeName("uint16_t[3][128]")]
    public _PredictorPaletteEntries_e__FixedBuffer PredictorPaletteEntries;

    [InlineArray(3 * 128)]
    public partial struct _PredictorPaletteEntries_e__FixedBuffer
    {
        public ushort e0_0;
    }
}
