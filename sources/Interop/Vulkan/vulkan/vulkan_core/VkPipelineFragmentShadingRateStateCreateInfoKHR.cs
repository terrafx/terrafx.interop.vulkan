// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineFragmentShadingRateStateCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkExtent2D fragmentSize;

        [NativeTypeName("VkFragmentShadingRateCombinerOpKHR [2]")]
        public _combinerOps_e__FixedBuffer combinerOps;

        public partial struct _combinerOps_e__FixedBuffer
        {
            public VkFragmentShadingRateCombinerOpKHR e0;
            public VkFragmentShadingRateCombinerOpKHR e1;

            public ref VkFragmentShadingRateCombinerOpKHR this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<VkFragmentShadingRateCombinerOpKHR> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}
