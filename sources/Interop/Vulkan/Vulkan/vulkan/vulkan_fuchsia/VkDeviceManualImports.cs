// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceManualImports
{
    public delegate* unmanaged<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, uint*, VkResult> vkGetMemoryZirconHandleFUCHSIA;

    public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlags, uint, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult> vkGetMemoryZirconHandlePropertiesFUCHSIA;

    public delegate* unmanaged<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult> vkImportSemaphoreZirconHandleFUCHSIA;

    public delegate* unmanaged<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, uint*, VkResult> vkGetSemaphoreZirconHandleFUCHSIA;

    public delegate* unmanaged<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult> vkCreateBufferCollectionFUCHSIA;

    public delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult> vkSetBufferCollectionImageConstraintsFUCHSIA;

    public delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult> vkSetBufferCollectionBufferConstraintsFUCHSIA;

    public delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void> vkDestroyBufferCollectionFUCHSIA;

    public delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult> vkGetBufferCollectionPropertiesFUCHSIA;
}
