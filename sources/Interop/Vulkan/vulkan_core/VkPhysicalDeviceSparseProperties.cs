// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkPhysicalDeviceSparseProperties
    {
        [NativeTypeName("VkBool32")]
        public uint residencyStandard2DBlockShape;

        [NativeTypeName("VkBool32")]
        public uint residencyStandard2DMultisampleBlockShape;

        [NativeTypeName("VkBool32")]
        public uint residencyStandard3DBlockShape;

        [NativeTypeName("VkBool32")]
        public uint residencyAlignedMipSize;

        [NativeTypeName("VkBool32")]
        public uint residencyNonResidentStrict;
    }
}
