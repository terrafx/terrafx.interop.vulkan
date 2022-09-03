// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPipelineFragmentShadingRateStateCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkExtent2D fragmentSize;

        [NativeTypeName("VkFragmentShadingRateCombinerOpKHR[2]")]
        public _combinerOps_e__FixedBuffer combinerOps;

        public partial struct _combinerOps_e__FixedBuffer
        {
            public VkFragmentShadingRateCombinerOpKHR e0;
            public VkFragmentShadingRateCombinerOpKHR e1;

            [UnscopedRef]
            public ref VkFragmentShadingRateCombinerOpKHR this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<VkFragmentShadingRateCombinerOpKHR> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}
