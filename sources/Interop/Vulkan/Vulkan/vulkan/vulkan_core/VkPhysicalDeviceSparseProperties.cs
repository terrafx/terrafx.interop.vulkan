// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkPhysicalDeviceSparseProperties
    {
        public VkBool32 residencyStandard2DBlockShape;

        public VkBool32 residencyStandard2DMultisampleBlockShape;

        public VkBool32 residencyStandard3DBlockShape;

        public VkBool32 residencyAlignedMipSize;

        public VkBool32 residencyNonResidentStrict;
    }
}
