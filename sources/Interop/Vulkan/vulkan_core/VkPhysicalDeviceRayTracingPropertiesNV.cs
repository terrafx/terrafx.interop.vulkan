// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint shaderGroupHandleSize;

        [NativeTypeName("uint32_t")]
        public uint maxRecursionDepth;

        [NativeTypeName("uint32_t")]
        public uint maxShaderGroupStride;

        [NativeTypeName("uint32_t")]
        public uint shaderGroupBaseAlignment;

        [NativeTypeName("uint64_t")]
        public ulong maxGeometryCount;

        [NativeTypeName("uint64_t")]
        public ulong maxInstanceCount;

        [NativeTypeName("uint64_t")]
        public ulong maxTriangleCount;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetAccelerationStructures;
    }
}
