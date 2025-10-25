// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkAllocationCallbacks
{
    public void* pUserData;

    [NativeTypeName("PFN_vkAllocationFunction")]
    public delegate* unmanaged<void*, nuint, nuint, VkSystemAllocationScope, void*> pfnAllocation;

    [NativeTypeName("PFN_vkReallocationFunction")]
    public delegate* unmanaged<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> pfnReallocation;

    [NativeTypeName("PFN_vkFreeFunction")]
    public delegate* unmanaged<void*, void*, void> pfnFree;

    [NativeTypeName("PFN_vkInternalAllocationNotification")]
    public delegate* unmanaged<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalAllocation;

    [NativeTypeName("PFN_vkInternalFreeNotification")]
    public delegate* unmanaged<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalFree;
}
