// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAndroidHardwareBufferUsageANDROID
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("uint64_t")]
        public ulong androidHardwareBufferUsage;
    }
}
