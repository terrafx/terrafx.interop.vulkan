// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
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
        public VkLayerFunction_ function;

        [NativeTypeName("union (anonymous union at C:/VulkanSDK/1.2.135.0/Include/vulkan/vk_layer.h:118:5)")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("VkLayerInstanceLink *")]
            public VkLayerInstanceLink* pLayerInfo;

            [FieldOffset(0)]
            [NativeTypeName("PFN_vkSetInstanceLoaderData")]
            public IntPtr pfnSetInstanceLoaderData;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/VulkanSDK/1.2.135.0/Include/vulkan/vk_layer.h:121:9)")]
            public _layerDevice_e__Struct layerDevice;

            public partial struct _layerDevice_e__Struct
            {
                [NativeTypeName("PFN_vkLayerCreateDevice")]
                public IntPtr pfnLayerCreateDevice;

                [NativeTypeName("PFN_vkLayerDestroyDevice")]
                public IntPtr pfnLayerDestroyDevice;
            }
        }
    }
}
