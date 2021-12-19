// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkInstanceManualImports
    {
        public delegate* unmanaged<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateImagePipeSurfaceFUCHSIA;
    }
}