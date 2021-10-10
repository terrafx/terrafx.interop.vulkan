// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkImageViewAddressPropertiesNVX
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkDeviceAddress")]
        public ulong deviceAddress;

        [NativeTypeName("VkDeviceSize")]
        public ulong size;
    }
}
