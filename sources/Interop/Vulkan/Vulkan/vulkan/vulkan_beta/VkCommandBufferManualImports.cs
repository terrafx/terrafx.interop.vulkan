// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkCommandBufferManualImports
{
    public delegate* unmanaged<VkCommandBuffer, VkPipeline, ulong, ulong, void> vkCmdInitializeGraphScratchMemoryAMDX;

    public delegate* unmanaged<VkCommandBuffer, ulong, ulong, VkDispatchGraphCountInfoAMDX*, void> vkCmdDispatchGraphAMDX;

    public delegate* unmanaged<VkCommandBuffer, ulong, ulong, VkDispatchGraphCountInfoAMDX*, void> vkCmdDispatchGraphIndirectAMDX;

    public delegate* unmanaged<VkCommandBuffer, ulong, ulong, ulong, void> vkCmdDispatchGraphIndirectCountAMDX;

    public delegate* unmanaged<VkCommandBuffer, VkCudaLaunchInfoNV*, void> vkCmdCudaLaunchKernelNV;
}
