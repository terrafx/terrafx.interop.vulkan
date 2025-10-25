// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkPartitionedAccelerationStructureWritePartitionTranslationDataNV
{
    [NativeTypeName("uint32_t")]
    public uint partitionIndex;

    [NativeTypeName("float[3]")]
    public _partitionTranslation_e__FixedBuffer partitionTranslation;

    [InlineArray(3)]
    public partial struct _partitionTranslation_e__FixedBuffer
    {
        public float e0;
    }
}
