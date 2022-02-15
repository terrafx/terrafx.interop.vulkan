// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkDeviceManualImports
    {
        public delegate* unmanaged<VkDevice, IntPtr, VkAndroidHardwareBufferPropertiesANDROID*, VkResult> vkGetAndroidHardwareBufferPropertiesANDROID;

        public delegate* unmanaged<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, IntPtr*, VkResult> vkGetMemoryAndroidHardwareBufferANDROID;
    }
}
