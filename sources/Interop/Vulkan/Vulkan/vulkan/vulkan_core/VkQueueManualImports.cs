// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkQueueManualImports
{
    public delegate* unmanaged<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> vkQueueSubmit2KHR;

    public delegate* unmanaged<VkQueue, uint*, VkCheckpointData2NV*, void> vkGetQueueCheckpointData2NV;

    public delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void> vkQueueBeginDebugUtilsLabelEXT;

    public delegate* unmanaged<VkQueue, void> vkQueueEndDebugUtilsLabelEXT;

    public delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void> vkQueueInsertDebugUtilsLabelEXT;

    public delegate* unmanaged<VkQueue, uint*, VkCheckpointDataNV*, void> vkGetQueueCheckpointDataNV;

    public delegate* unmanaged<VkQueue, VkPerformanceConfigurationINTEL, VkResult> vkQueueSetPerformanceConfigurationINTEL;
}
