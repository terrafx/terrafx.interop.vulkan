// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vk_layer.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VkLayerInstanceCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkLayerFunction")]
        public VkLayerFunction function;

        [NativeTypeName("union (anonymous union at vulkan/vk_layer.h:118:5)")]
        public _u__AnonymousRecord u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u__AnonymousRecord
        {
            [FieldOffset(0)]
            [NativeTypeName("VkLayerInstanceLink *")]
            public VkLayerInstanceLink* pLayerInfo;

            [FieldOffset(0)]
            [NativeTypeName("PFN_vkSetInstanceLoaderData")]
            public IntPtr pfnSetInstanceLoaderData;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at vulkan/vk_layer.h:121:9)")]
            public _layerDevice__AnonymousRecord layerDevice;

            public partial struct _layerDevice__AnonymousRecord
            {
                [NativeTypeName("PFN_vkLayerCreateDevice")]
                public IntPtr pfnLayerCreateDevice;

                [NativeTypeName("PFN_vkLayerDestroyDevice")]
                public IntPtr pfnLayerDestroyDevice;
            }
        }
    }
}
