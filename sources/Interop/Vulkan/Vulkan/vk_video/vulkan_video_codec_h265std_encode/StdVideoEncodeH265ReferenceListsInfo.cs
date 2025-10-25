// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct StdVideoEncodeH265ReferenceListsInfo
{
    public StdVideoEncodeH265ReferenceListsInfoFlags flags;

    [NativeTypeName("uint8_t")]
    public byte num_ref_idx_l0_active_minus1;

    [NativeTypeName("uint8_t")]
    public byte num_ref_idx_l1_active_minus1;

    [NativeTypeName("uint8_t[15]")]
    public _RefPicList0_e__FixedBuffer RefPicList0;

    [NativeTypeName("uint8_t[15]")]
    public _RefPicList1_e__FixedBuffer RefPicList1;

    [NativeTypeName("uint8_t[15]")]
    public _list_entry_l0_e__FixedBuffer list_entry_l0;

    [NativeTypeName("uint8_t[15]")]
    public _list_entry_l1_e__FixedBuffer list_entry_l1;

    [InlineArray(15)]
    public partial struct _RefPicList0_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(15)]
    public partial struct _RefPicList1_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(15)]
    public partial struct _list_entry_l0_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(15)]
    public partial struct _list_entry_l1_e__FixedBuffer
    {
        public byte e0;
    }
}
