// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceManualImports
{
    public delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkExecutionGraphPipelineCreateInfoAMDX*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateExecutionGraphPipelinesAMDX;

    public delegate* unmanaged<VkDevice, VkPipeline, VkExecutionGraphPipelineScratchSizeAMDX*, VkResult> vkGetExecutionGraphPipelineScratchSizeAMDX;

    public delegate* unmanaged<VkDevice, VkPipeline, VkPipelineShaderStageNodeCreateInfoAMDX*, uint*, VkResult> vkGetExecutionGraphPipelineNodeIndexAMDX;

    public delegate* unmanaged<VkDevice, VkCudaModuleCreateInfoNV*, VkAllocationCallbacks*, VkCudaModuleNV*, VkResult> vkCreateCudaModuleNV;

    public delegate* unmanaged<VkDevice, VkCudaModuleNV, nuint*, void*, VkResult> vkGetCudaModuleCacheNV;

    public delegate* unmanaged<VkDevice, VkCudaFunctionCreateInfoNV*, VkAllocationCallbacks*, VkCudaFunctionNV*, VkResult> vkCreateCudaFunctionNV;

    public delegate* unmanaged<VkDevice, VkCudaModuleNV, VkAllocationCallbacks*, void> vkDestroyCudaModuleNV;

    public delegate* unmanaged<VkDevice, VkCudaFunctionNV, VkAllocationCallbacks*, void> vkDestroyCudaFunctionNV;
}
