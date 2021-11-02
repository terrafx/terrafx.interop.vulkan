// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType sType;

        public void* pNext;

        public VkBool32 storageBuffer16BitAccess;

        public VkBool32 uniformAndStorageBuffer16BitAccess;

        public VkBool32 storagePushConstant16;

        public VkBool32 storageInputOutput16;

        public VkBool32 multiview;

        public VkBool32 multiviewGeometryShader;

        public VkBool32 multiviewTessellationShader;

        public VkBool32 variablePointersStorageBuffer;

        public VkBool32 variablePointers;

        public VkBool32 protectedMemory;

        public VkBool32 samplerYcbcrConversion;

        public VkBool32 shaderDrawParameters;
    }
}
