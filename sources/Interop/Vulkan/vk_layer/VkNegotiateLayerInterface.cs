// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkNegotiateLayerInterface
    {
        public VkNegotiateLayerStructType sType;

        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint loaderLayerInterfaceVersion;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public delegate* unmanaged<IntPtr, sbyte*, delegate* unmanaged<void>> pfnGetInstanceProcAddr;

        [NativeTypeName("PFN_vkGetDeviceProcAddr")]
        public delegate* unmanaged<IntPtr, sbyte*, delegate* unmanaged<void>> pfnGetDeviceProcAddr;

        [NativeTypeName("PFN_GetPhysicalDeviceProcAddr")]
        public delegate* unmanaged<IntPtr, sbyte*, delegate* unmanaged<void>> pfnGetPhysicalDeviceProcAddr;
    }
}
