// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint heapIndex, [NativeTypeName("uint32_t")] uint localDeviceIndex, [NativeTypeName("uint32_t")] uint remoteDeviceIndex, [NativeTypeName("VkPeerMemoryFeatureFlags *")] uint* pPeerMemoryFeatures);
}
