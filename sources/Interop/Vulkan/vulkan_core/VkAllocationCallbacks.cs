// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

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
