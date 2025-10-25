// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkLayerDeviceCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkLayerFunction function;

    [NativeTypeName("__AnonymousRecord_vk_layer_L125_C5")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        [FieldOffset(0)]
        public VkLayerDeviceLink* pLayerInfo;

        [FieldOffset(0)]
        [NativeTypeName("PFN_vkSetDeviceLoaderData")]
        public delegate* unmanaged<VkDevice, void*, VkResult> pfnSetDeviceLoaderData;
    }
}
