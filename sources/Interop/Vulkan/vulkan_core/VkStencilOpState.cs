// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkStencilOpState
    {
        public VkStencilOp failOp;

        public VkStencilOp passOp;

        public VkStencilOp depthFailOp;

        public VkCompareOp compareOp;

        [NativeTypeName("uint32_t")]
        public uint compareMask;

        [NativeTypeName("uint32_t")]
        public uint writeMask;

        [NativeTypeName("uint32_t")]
        public uint reference;
    }
}
