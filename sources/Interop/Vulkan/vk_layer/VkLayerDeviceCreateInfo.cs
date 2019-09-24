// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vk_layer.h in the Vulkan-Headers repository for tag v1.1.123
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
        public VkLayerFunction function;

        [NativeTypeName("union (anonymous union at vulkan/vk_layer.h:138:5)")]
        public _u__AnonymousRecord u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u__AnonymousRecord
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
