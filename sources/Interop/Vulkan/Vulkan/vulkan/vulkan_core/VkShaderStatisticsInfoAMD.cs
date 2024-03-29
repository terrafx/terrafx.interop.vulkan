// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VkShaderStatisticsInfoAMD
{
    public VkShaderStageFlags shaderStageMask;

    public VkShaderResourceUsageAMD resourceUsage;

    [NativeTypeName("uint32_t")]
    public uint numPhysicalVgprs;

    [NativeTypeName("uint32_t")]
    public uint numPhysicalSgprs;

    [NativeTypeName("uint32_t")]
    public uint numAvailableVgprs;

    [NativeTypeName("uint32_t")]
    public uint numAvailableSgprs;

    [NativeTypeName("uint32_t[3]")]
    public _computeWorkGroupSize_e__FixedBuffer computeWorkGroupSize;

    [InlineArray(3)]
    public partial struct _computeWorkGroupSize_e__FixedBuffer
    {
        public uint e0;
    }
}
