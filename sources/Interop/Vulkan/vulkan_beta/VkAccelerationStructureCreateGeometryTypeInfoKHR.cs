// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAccelerationStructureCreateGeometryTypeInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkGeometryTypeKHR geometryType;

        [NativeTypeName("uint32_t")]
        public uint maxPrimitiveCount;

        public VkIndexType indexType;

        [NativeTypeName("uint32_t")]
        public uint maxVertexCount;

        public VkFormat vertexFormat;

        [NativeTypeName("VkBool32")]
        public uint allowsTransforms;
    }
}
