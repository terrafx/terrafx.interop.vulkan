// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vk_layer.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("PFN_vkVoidFunction")]
    public unsafe delegate IntPtr PFN_GetPhysicalDeviceProcAddr([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const char *")] sbyte* pName);
}
