// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct VkImageBlit
    {
        public VkImageSubresourceLayers srcSubresource;

        [NativeTypeName("VkOffset3D [2]")]
        public _srcOffsets_e__FixedBuffer srcOffsets;

        public VkImageSubresourceLayers dstSubresource;

        [NativeTypeName("VkOffset3D [2]")]
        public _dstOffsets_e__FixedBuffer dstOffsets;

        public partial struct _srcOffsets_e__FixedBuffer
        {
            internal VkOffset3D e0;
            internal VkOffset3D e1;

            public ref VkOffset3D this[int index] => ref AsSpan()[index];

            public Span<VkOffset3D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }

        public partial struct _dstOffsets_e__FixedBuffer
        {
            internal VkOffset3D e0;
            internal VkOffset3D e1;

            public ref VkOffset3D this[int index] => ref AsSpan()[index];

            public Span<VkOffset3D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}
