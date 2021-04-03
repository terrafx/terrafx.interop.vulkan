// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkDeviceSize")]
        public ulong storageTexelBufferOffsetAlignmentBytes;

        [NativeTypeName("VkBool32")]
        public uint storageTexelBufferOffsetSingleTexelAlignment;

        [NativeTypeName("VkDeviceSize")]
        public ulong uniformTexelBufferOffsetAlignmentBytes;

        [NativeTypeName("VkBool32")]
        public uint uniformTexelBufferOffsetSingleTexelAlignment;
    }
}
