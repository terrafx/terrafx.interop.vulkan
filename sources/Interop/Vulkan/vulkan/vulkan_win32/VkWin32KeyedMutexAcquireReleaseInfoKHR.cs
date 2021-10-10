// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint acquireCount;

        [NativeTypeName("const VkDeviceMemory *")]
        public ulong* pAcquireSyncs;

        [NativeTypeName("const uint64_t *")]
        public ulong* pAcquireKeys;

        [NativeTypeName("const uint32_t *")]
        public uint* pAcquireTimeouts;

        [NativeTypeName("uint32_t")]
        public uint releaseCount;

        [NativeTypeName("const VkDeviceMemory *")]
        public ulong* pReleaseSyncs;

        [NativeTypeName("const uint64_t *")]
        public ulong* pReleaseKeys;
    }
}
