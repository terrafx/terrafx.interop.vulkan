// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vk_layer.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkLayerInstanceLink
    {
        [NativeTypeName("struct VkLayerInstanceLink *")]
        public VkLayerInstanceLink* pNext;

        [NativeTypeName("PFN_vkGetInstanceProcAddr")]
        public IntPtr pfnNextGetInstanceProcAddr;

        [NativeTypeName("PFN_GetPhysicalDeviceProcAddr")]
        public IntPtr pfnNextGetPhysicalDeviceProcAddr;
    }
}
