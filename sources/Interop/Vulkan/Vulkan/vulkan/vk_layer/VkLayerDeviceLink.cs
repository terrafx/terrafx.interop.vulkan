// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkLayerDeviceLink
    {
        [NativeTypeName("struct VkLayerDeviceLink_ *")]
        public VkLayerDeviceLink* pNext;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public delegate* unmanaged<VkInstance, sbyte*, delegate* unmanaged<void>> pfnNextGetInstanceProcAddr;

        [NativeTypeName("PFN_vkGetDeviceProcAddr")]
        public delegate* unmanaged<VkDevice, sbyte*, delegate* unmanaged<void>> pfnNextGetDeviceProcAddr;
    }
}
