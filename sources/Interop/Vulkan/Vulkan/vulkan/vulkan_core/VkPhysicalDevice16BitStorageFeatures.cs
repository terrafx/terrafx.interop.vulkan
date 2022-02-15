// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType sType;

        public void* pNext;

        public VkBool32 storageBuffer16BitAccess;

        public VkBool32 uniformAndStorageBuffer16BitAccess;

        public VkBool32 storagePushConstant16;

        public VkBool32 storageInputOutput16;
    }
}
