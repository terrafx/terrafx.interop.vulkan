// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkNegotiateLayerInterface
    {
        public VkNegotiateLayerStructType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint loaderLayerInterfaceVersion;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public IntPtr pfnGetInstanceProcAddr;

        [NativeTypeName("PFN_vkGetDeviceProcAddr")]
        public IntPtr pfnGetDeviceProcAddr;

        [NativeTypeName("PFN_GetPhysicalDeviceProcAddr")]
        public IntPtr pfnGetPhysicalDeviceProcAddr;
    }
}
