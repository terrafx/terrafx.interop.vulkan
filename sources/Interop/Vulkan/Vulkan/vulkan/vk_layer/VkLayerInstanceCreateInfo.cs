// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkLayerInstanceCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkLayerFunction function;

    [NativeTypeName("__AnonymousRecord_vk_layer_L104_C5")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        [FieldOffset(0)]
        public VkLayerInstanceLink* pLayerInfo;

        [FieldOffset(0)]
        [NativeTypeName("PFN_vkSetInstanceLoaderData")]
        public delegate* unmanaged<VkInstance, void*, VkResult> pfnSetInstanceLoaderData;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_vk_layer_L107_C9")]
        public _layerDevice_e__Struct layerDevice;

        [FieldOffset(0)]
        public VkLoaderFeatureFlags loaderFeatures;

        public unsafe partial struct _layerDevice_e__Struct
        {
            [NativeTypeName("PFN_vkLayerCreateDevice")]
            public delegate* unmanaged<VkInstance, VkPhysicalDevice, VkDeviceCreateInfo*, VkAllocationCallbacks*, VkDevice*, delegate* unmanaged<VkInstance, sbyte*, delegate* unmanaged<void>>, delegate* unmanaged<VkDevice, sbyte*, delegate* unmanaged<void>>*, VkResult> pfnLayerCreateDevice;

            [NativeTypeName("PFN_vkLayerDestroyDevice")]
            public delegate* unmanaged<VkDevice, VkAllocationCallbacks*, delegate* unmanaged<VkDevice, VkAllocationCallbacks*, void>, void> pfnLayerDestroyDevice;
        }
    }
}
