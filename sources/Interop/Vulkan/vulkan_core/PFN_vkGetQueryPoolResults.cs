// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate VkResult PFN_vkGetQueryPoolResults([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint firstQuery, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("size_t")] UIntPtr dataSize, [NativeTypeName("void *")] void* pData, [NativeTypeName("VkDeviceSize")] ulong stride, [NativeTypeName("VkQueryResultFlags")] uint flags);
}
