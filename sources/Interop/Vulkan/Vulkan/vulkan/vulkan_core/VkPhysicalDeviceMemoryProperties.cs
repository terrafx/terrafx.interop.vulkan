// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkPhysicalDeviceMemoryProperties
{
    [NativeTypeName("uint32_t")]
    public uint memoryTypeCount;

    [NativeTypeName("VkMemoryType[32]")]
    public _memoryTypes_e__FixedBuffer memoryTypes;

    [NativeTypeName("uint32_t")]
    public uint memoryHeapCount;

    [NativeTypeName("VkMemoryHeap[16]")]
    public _memoryHeaps_e__FixedBuffer memoryHeaps;

    [InlineArray(32)]
    public partial struct _memoryTypes_e__FixedBuffer
    {
        public VkMemoryType e0;
    }

    [InlineArray(16)]
    public partial struct _memoryHeaps_e__FixedBuffer
    {
        public VkMemoryHeap e0;
    }
}
