// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV
{
    [NativeTypeName("uint32_t")]
    public uint clusterID;

    [NativeTypeName("VkClusterAccelerationStructureClusterFlagsNV")]
    public uint clusterFlags;

    public uint _bitfield;

    [NativeTypeName("uint32_t : 9")]
    public uint triangleCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield & 0x1FFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1FFu) | (value & 0x1FFu);
        }
    }

    [NativeTypeName("uint32_t : 9")]
    public uint vertexCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 9) & 0x1FFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1FFu << 9)) | ((value & 0x1FFu) << 9);
        }
    }

    [NativeTypeName("uint32_t : 6")]
    public uint positionTruncateBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 18) & 0x3Fu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x3Fu << 18)) | ((value & 0x3Fu) << 18);
        }
    }

    [NativeTypeName("uint32_t : 4")]
    public uint indexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 24) & 0xFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFu << 24)) | ((value & 0xFu) << 24);
        }
    }

    [NativeTypeName("uint32_t : 4")]
    public uint opacityMicromapIndexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 28) & 0xFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFu << 28)) | ((value & 0xFu) << 28);
        }
    }

    public VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV baseGeometryIndexAndGeometryFlags;

    [NativeTypeName("uint16_t")]
    public ushort indexBufferStride;

    [NativeTypeName("uint16_t")]
    public ushort vertexBufferStride;

    [NativeTypeName("uint16_t")]
    public ushort geometryIndexAndFlagsBufferStride;

    [NativeTypeName("uint16_t")]
    public ushort opacityMicromapIndexBufferStride;

    [NativeTypeName("VkDeviceAddress")]
    public ulong indexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    public ulong vertexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    public ulong geometryIndexAndFlagsBuffer;

    [NativeTypeName("VkDeviceAddress")]
    public ulong opacityMicromapArray;

    [NativeTypeName("VkDeviceAddress")]
    public ulong opacityMicromapIndexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    public ulong instantiationBoundingBoxLimit;
}
