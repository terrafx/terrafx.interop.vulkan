// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkAllocationCallbacks
    {
        [NativeTypeName("void *")]
        public void* pUserData;

        [NativeTypeName("PFN_vkAllocationFunction")]
        public IntPtr pfnAllocation;

        [NativeTypeName("PFN_vkReallocationFunction")]
        public IntPtr pfnReallocation;

        [NativeTypeName("PFN_vkFreeFunction")]
        public IntPtr pfnFree;

        [NativeTypeName("PFN_vkInternalAllocationNotification")]
        public IntPtr pfnInternalAllocation;

        [NativeTypeName("PFN_vkInternalFreeNotification")]
        public IntPtr pfnInternalFree;
    }
}
