// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkLayerDeviceInfo_
    {
        [NativeTypeName("void *")]
        public void* device_info;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public delegate* unmanaged<IntPtr, sbyte*, delegate* unmanaged<void>> pfnNextGetInstanceProcAddr;
    }
}
