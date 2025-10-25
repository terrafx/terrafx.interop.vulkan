// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint acquireCount;

    [NativeTypeName("const VkDeviceMemory *")]
    public VkDeviceMemory* pAcquireSyncs;

    [NativeTypeName("const uint64_t *")]
    public ulong* pAcquireKeys;

    [NativeTypeName("const uint32_t *")]
    public uint* pAcquireTimeoutMilliseconds;

    [NativeTypeName("uint32_t")]
    public uint releaseCount;

    [NativeTypeName("const VkDeviceMemory *")]
    public VkDeviceMemory* pReleaseSyncs;

    [NativeTypeName("const uint64_t *")]
    public ulong* pReleaseKeys;
}
