// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VkLayerDeviceCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkLayerFunction")]
        public VkLayerFunction_ function;

        [NativeTypeName("union (anonymous union at C:/VulkanSDK/1.2.135.0/Include/vulkan/vk_layer.h:138:5)")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("VkLayerDeviceLink *")]
            public VkLayerDeviceLink* pLayerInfo;

            [FieldOffset(0)]
            [NativeTypeName("PFN_vkSetDeviceLoaderData")]
            public IntPtr pfnSetDeviceLoaderData;
        }
    }
}
