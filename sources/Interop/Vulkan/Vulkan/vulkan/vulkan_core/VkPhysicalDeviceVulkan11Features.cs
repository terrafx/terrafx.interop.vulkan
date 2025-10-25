// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceVulkan11Features
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint storageBuffer16BitAccess;

    [NativeTypeName("VkBool32")]
    public uint uniformAndStorageBuffer16BitAccess;

    [NativeTypeName("VkBool32")]
    public uint storagePushConstant16;

    [NativeTypeName("VkBool32")]
    public uint storageInputOutput16;

    [NativeTypeName("VkBool32")]
    public uint multiview;

    [NativeTypeName("VkBool32")]
    public uint multiviewGeometryShader;

    [NativeTypeName("VkBool32")]
    public uint multiviewTessellationShader;

    [NativeTypeName("VkBool32")]
    public uint variablePointersStorageBuffer;

    [NativeTypeName("VkBool32")]
    public uint variablePointers;

    [NativeTypeName("VkBool32")]
    public uint protectedMemory;

    [NativeTypeName("VkBool32")]
    public uint samplerYcbcrConversion;

    [NativeTypeName("VkBool32")]
    public uint shaderDrawParameters;
}
