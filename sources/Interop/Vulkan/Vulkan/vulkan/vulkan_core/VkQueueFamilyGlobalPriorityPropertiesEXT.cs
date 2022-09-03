// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkQueueFamilyGlobalPriorityPropertiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint priorityCount;

    [NativeTypeName("VkQueueGlobalPriorityKHR[16]")]
    public _priorities_e__FixedBuffer priorities;

    public partial struct _priorities_e__FixedBuffer
    {
        public VkQueueGlobalPriorityEXT e0;
        public VkQueueGlobalPriorityEXT e1;
        public VkQueueGlobalPriorityEXT e2;
        public VkQueueGlobalPriorityEXT e3;
        public VkQueueGlobalPriorityEXT e4;
        public VkQueueGlobalPriorityEXT e5;
        public VkQueueGlobalPriorityEXT e6;
        public VkQueueGlobalPriorityEXT e7;
        public VkQueueGlobalPriorityEXT e8;
        public VkQueueGlobalPriorityEXT e9;
        public VkQueueGlobalPriorityEXT e10;
        public VkQueueGlobalPriorityEXT e11;
        public VkQueueGlobalPriorityEXT e12;
        public VkQueueGlobalPriorityEXT e13;
        public VkQueueGlobalPriorityEXT e14;
        public VkQueueGlobalPriorityEXT e15;

        [UnscopedRef]
        public ref VkQueueGlobalPriorityEXT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<VkQueueGlobalPriorityEXT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}
