// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkFragmentShadingRateTypeNV shadingRateType;

    public VkFragmentShadingRateNV shadingRate;

    [NativeTypeName("VkFragmentShadingRateCombinerOpKHR[2]")]
    public _combinerOps_e__FixedBuffer combinerOps;

    [InlineArray(2)]
    public partial struct _combinerOps_e__FixedBuffer
    {
        public VkFragmentShadingRateCombinerOpKHR e0;
    }
}
