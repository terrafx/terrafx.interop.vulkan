// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
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
}
