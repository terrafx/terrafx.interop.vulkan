// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkImageBlit2
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkImageSubresourceLayers srcSubresource;

    [NativeTypeName("VkOffset3D[2]")]
    public _srcOffsets_e__FixedBuffer srcOffsets;

    public VkImageSubresourceLayers dstSubresource;

    [NativeTypeName("VkOffset3D[2]")]
    public _dstOffsets_e__FixedBuffer dstOffsets;

    public partial struct _srcOffsets_e__FixedBuffer
    {
        public VkOffset3D e0;
        public VkOffset3D e1;

        [UnscopedRef]
        public ref VkOffset3D this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<VkOffset3D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }

    public partial struct _dstOffsets_e__FixedBuffer
    {
        public VkOffset3D e0;
        public VkOffset3D e1;

        [UnscopedRef]
        public ref VkOffset3D this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<VkOffset3D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}
