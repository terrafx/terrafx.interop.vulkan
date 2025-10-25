// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkImportFenceWin32HandleInfoKHR
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkFence fence;

    public VkFenceImportFlags flags;

    [NativeTypeName("VkExternalFenceHandleTypeFlagBits")]
    public VkExternalFenceHandleTypeFlags handleType;

    [NativeTypeName("HANDLE")]
    public void* handle;

    [NativeTypeName("LPCWSTR")]
    public char* name;
}
