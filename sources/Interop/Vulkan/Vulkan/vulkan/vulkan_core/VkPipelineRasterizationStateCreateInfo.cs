// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPipelineRasterizationStateCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkPipelineRasterizationStateCreateFlags flags;

    [NativeTypeName("VkBool32")]
    public uint depthClampEnable;

    [NativeTypeName("VkBool32")]
    public uint rasterizerDiscardEnable;

    public VkPolygonMode polygonMode;

    public VkCullModeFlags cullMode;

    public VkFrontFace frontFace;

    [NativeTypeName("VkBool32")]
    public uint depthBiasEnable;

    public float depthBiasConstantFactor;

    public float depthBiasClamp;

    public float depthBiasSlopeFactor;

    public float lineWidth;
}
