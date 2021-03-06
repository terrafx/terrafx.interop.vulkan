// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
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

        public VkLayerFunction function;

        [NativeTypeName("union (anonymous union at C:/VulkanSDK/1.2.182.0/Include/vulkan/vk_layer.h:125:5)")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            public VkLayerInstanceLink* pLayerInfo;

            [FieldOffset(0)]
            [NativeTypeName("PFN_vkSetInstanceLoaderData")]
            public delegate* unmanaged<IntPtr, void*, VkResult> pfnSetInstanceLoaderData;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/VulkanSDK/1.2.182.0/Include/vulkan/vk_layer.h:128:9)")]
            public _layerDevice_e__Struct layerDevice;

            [FieldOffset(0)]
            [NativeTypeName("VkLoaderFeatureFlags")]
            public uint loaderFeatures;

            public unsafe partial struct _layerDevice_e__Struct
            {
                [NativeTypeName("PFN_vkLayerCreateDevice")]
                public delegate* unmanaged<IntPtr, IntPtr, VkDeviceCreateInfo*, VkAllocationCallbacks*, IntPtr*, delegate* unmanaged<IntPtr, sbyte*, delegate* unmanaged<void>>, delegate* unmanaged<IntPtr, sbyte*, delegate* unmanaged<void>>*, VkResult> pfnLayerCreateDevice;

                [NativeTypeName("PFN_vkLayerDestroyDevice")]
                public delegate* unmanaged<IntPtr, VkAllocationCallbacks*, delegate* unmanaged<IntPtr, VkAllocationCallbacks*, void>, void> pfnLayerDestroyDevice;
            }
        }
    }
}
