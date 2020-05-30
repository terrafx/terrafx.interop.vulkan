// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("VkDeviceAddress")]
    public unsafe delegate ulong PFN_vkGetAccelerationStructureDeviceAddressKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkAccelerationStructureDeviceAddressInfoKHR *")] VkAccelerationStructureDeviceAddressInfoKHR* pInfo);
}
