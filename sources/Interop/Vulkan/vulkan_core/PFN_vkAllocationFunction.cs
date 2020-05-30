// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("void *")]
    public unsafe delegate void* PFN_vkAllocationFunction([NativeTypeName("void *")] void* pUserData, [NativeTypeName("size_t")] nuint size, [NativeTypeName("size_t")] nuint alignment, VkSystemAllocationScope allocationScope);
}
