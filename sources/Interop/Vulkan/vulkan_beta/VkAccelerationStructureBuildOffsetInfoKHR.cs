// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkAccelerationStructureBuildOffsetInfoKHR
    {
        [NativeTypeName("uint32_t")]
        public uint primitiveCount;

        [NativeTypeName("uint32_t")]
        public uint primitiveOffset;

        [NativeTypeName("uint32_t")]
        public uint firstVertex;

        [NativeTypeName("uint32_t")]
        public uint transformOffset;
    }
}
