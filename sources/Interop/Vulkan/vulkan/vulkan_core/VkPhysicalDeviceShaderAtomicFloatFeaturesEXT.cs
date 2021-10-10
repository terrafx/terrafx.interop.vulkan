// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkBool32")]
        public uint shaderBufferFloat32Atomics;

        [NativeTypeName("VkBool32")]
        public uint shaderBufferFloat32AtomicAdd;

        [NativeTypeName("VkBool32")]
        public uint shaderBufferFloat64Atomics;

        [NativeTypeName("VkBool32")]
        public uint shaderBufferFloat64AtomicAdd;

        [NativeTypeName("VkBool32")]
        public uint shaderSharedFloat32Atomics;

        [NativeTypeName("VkBool32")]
        public uint shaderSharedFloat32AtomicAdd;

        [NativeTypeName("VkBool32")]
        public uint shaderSharedFloat64Atomics;

        [NativeTypeName("VkBool32")]
        public uint shaderSharedFloat64AtomicAdd;

        [NativeTypeName("VkBool32")]
        public uint shaderImageFloat32Atomics;

        [NativeTypeName("VkBool32")]
        public uint shaderImageFloat32AtomicAdd;

        [NativeTypeName("VkBool32")]
        public uint sparseImageFloat32Atomics;

        [NativeTypeName("VkBool32")]
        public uint sparseImageFloat32AtomicAdd;
    }
}
