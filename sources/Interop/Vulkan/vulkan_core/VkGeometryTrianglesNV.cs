// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkGeometryTrianglesNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkBuffer")]
        public ulong vertexData;

        [NativeTypeName("VkDeviceSize")]
        public ulong vertexOffset;

        [NativeTypeName("uint32_t")]
        public uint vertexCount;

        [NativeTypeName("VkDeviceSize")]
        public ulong vertexStride;

        public VkFormat vertexFormat;

        [NativeTypeName("VkBuffer")]
        public ulong indexData;

        [NativeTypeName("VkDeviceSize")]
        public ulong indexOffset;

        [NativeTypeName("uint32_t")]
        public uint indexCount;

        public VkIndexType indexType;

        [NativeTypeName("VkBuffer")]
        public ulong transformData;

        [NativeTypeName("VkDeviceSize")]
        public ulong transformOffset;
    }
}
