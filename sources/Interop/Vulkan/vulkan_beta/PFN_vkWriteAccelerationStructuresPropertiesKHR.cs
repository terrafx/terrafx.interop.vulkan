// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate VkResult PFN_vkWriteAccelerationStructuresPropertiesKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("uint32_t")] uint accelerationStructureCount, [NativeTypeName("const VkAccelerationStructureKHR *")] ulong* pAccelerationStructures, VkQueryType queryType, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("void *")] void* pData, [NativeTypeName("size_t")] nuint stride);
}
