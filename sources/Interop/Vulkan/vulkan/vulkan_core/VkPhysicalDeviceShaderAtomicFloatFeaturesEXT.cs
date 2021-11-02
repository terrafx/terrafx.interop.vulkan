// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType;

        public void* pNext;

        public VkBool32 shaderBufferFloat32Atomics;

        public VkBool32 shaderBufferFloat32AtomicAdd;

        public VkBool32 shaderBufferFloat64Atomics;

        public VkBool32 shaderBufferFloat64AtomicAdd;

        public VkBool32 shaderSharedFloat32Atomics;

        public VkBool32 shaderSharedFloat32AtomicAdd;

        public VkBool32 shaderSharedFloat64Atomics;

        public VkBool32 shaderSharedFloat64AtomicAdd;

        public VkBool32 shaderImageFloat32Atomics;

        public VkBool32 shaderImageFloat32AtomicAdd;

        public VkBool32 sparseImageFloat32Atomics;

        public VkBool32 sparseImageFloat32AtomicAdd;
    }
}
