// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkClusterAccelerationStructureInstantiateClusterInfoNV
{
    [NativeTypeName("uint32_t")]
    public uint clusterIdOffset;

    public uint _bitfield;

    [NativeTypeName("uint32_t : 24")]
    public uint geometryIndexOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield & 0xFFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFFFFFu) | (value & 0xFFFFFFu);
        }
    }

    [NativeTypeName("uint32_t : 8")]
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield >> 24) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
        }
    }

    [NativeTypeName("VkDeviceAddress")]
    public ulong clusterTemplateAddress;

    public VkStridedDeviceAddressNV vertexBuffer;
}
