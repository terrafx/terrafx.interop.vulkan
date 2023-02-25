// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint priorityCount;

    [NativeTypeName("VkQueueGlobalPriorityKHR[16]")]
    public _priorities_e__FixedBuffer priorities;

    public partial struct _priorities_e__FixedBuffer
    {
        public VkQueueGlobalPriorityKHR e0;
        public VkQueueGlobalPriorityKHR e1;
        public VkQueueGlobalPriorityKHR e2;
        public VkQueueGlobalPriorityKHR e3;
        public VkQueueGlobalPriorityKHR e4;
        public VkQueueGlobalPriorityKHR e5;
        public VkQueueGlobalPriorityKHR e6;
        public VkQueueGlobalPriorityKHR e7;
        public VkQueueGlobalPriorityKHR e8;
        public VkQueueGlobalPriorityKHR e9;
        public VkQueueGlobalPriorityKHR e10;
        public VkQueueGlobalPriorityKHR e11;
        public VkQueueGlobalPriorityKHR e12;
        public VkQueueGlobalPriorityKHR e13;
        public VkQueueGlobalPriorityKHR e14;
        public VkQueueGlobalPriorityKHR e15;

        [UnscopedRef]
        public ref VkQueueGlobalPriorityKHR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<VkQueueGlobalPriorityKHR> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}
