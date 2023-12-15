// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPipelineMultisampleStateCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkPipelineMultisampleStateCreateFlags flags;

    [NativeTypeName("VkSampleCountFlagBits")]
    public VkSampleCountFlags rasterizationSamples;

    public VkBool32 sampleShadingEnable;

    public float minSampleShading;

    [NativeTypeName("const VkSampleMask *")]
    public uint* pSampleMask;

    public VkBool32 alphaToCoverageEnable;

    public VkBool32 alphaToOneEnable;
}
