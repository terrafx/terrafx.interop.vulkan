// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkLayerDeviceInfo
{
    public void* device_info;

    [NativeTypeName("PFN_vkGetInstanceProcAddr")]
    public delegate* unmanaged<VkInstance, sbyte*, delegate* unmanaged<void>> pfnNextGetInstanceProcAddr;
}
