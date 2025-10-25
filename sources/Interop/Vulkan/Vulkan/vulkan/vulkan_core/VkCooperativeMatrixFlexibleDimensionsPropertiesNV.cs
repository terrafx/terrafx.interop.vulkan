// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkCooperativeMatrixFlexibleDimensionsPropertiesNV
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint MGranularity;

    [NativeTypeName("uint32_t")]
    public uint NGranularity;

    [NativeTypeName("uint32_t")]
    public uint KGranularity;

    public VkComponentTypeKHR AType;

    public VkComponentTypeKHR BType;

    public VkComponentTypeKHR CType;

    public VkComponentTypeKHR ResultType;

    [NativeTypeName("VkBool32")]
    public uint saturatingAccumulation;

    public VkScopeKHR scope;

    [NativeTypeName("uint32_t")]
    public uint workgroupInvocations;
}
