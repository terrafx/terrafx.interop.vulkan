// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkPartitionedAccelerationStructureWriteInstanceDataNV
{
    public VkTransformMatrixKHR transform;

    [NativeTypeName("float[6]")]
    public _explicitAABB_e__FixedBuffer explicitAABB;

    [NativeTypeName("uint32_t")]
    public uint instanceID;

    [NativeTypeName("uint32_t")]
    public uint instanceMask;

    [NativeTypeName("uint32_t")]
    public uint instanceContributionToHitGroupIndex;

    [NativeTypeName("VkPartitionedAccelerationStructureInstanceFlagsNV")]
    public uint instanceFlags;

    [NativeTypeName("uint32_t")]
    public uint instanceIndex;

    [NativeTypeName("uint32_t")]
    public uint partitionIndex;

    [NativeTypeName("VkDeviceAddress")]
    public ulong accelerationStructure;

    [InlineArray(6)]
    public partial struct _explicitAABB_e__FixedBuffer
    {
        public float e0;
    }
}
