// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_win32.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate VkResult PFN_vkImportSemaphoreWin32HandleKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkImportSemaphoreWin32HandleInfoKHR *")] VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
}
