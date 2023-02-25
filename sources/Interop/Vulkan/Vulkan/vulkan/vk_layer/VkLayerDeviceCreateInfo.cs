// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkLayerDeviceCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkLayerFunction function;

    [NativeTypeName("union (anonymous union at C:/VulkanSDK/1.3.239.0/Include/vulkan/vk_layer.h:146:5)")]
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
