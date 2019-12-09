// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkDrawIndexedIndirectCommand
    {
        [NativeTypeName("uint32_t")]
        public uint indexCount;

        [NativeTypeName("uint32_t")]
        public uint instanceCount;

        [NativeTypeName("uint32_t")]
        public uint firstIndex;

        [NativeTypeName("int32_t")]
        public int vertexOffset;

        [NativeTypeName("uint32_t")]
        public uint firstInstance;
    }
}
