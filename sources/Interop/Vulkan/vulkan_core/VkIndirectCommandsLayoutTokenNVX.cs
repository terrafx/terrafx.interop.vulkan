// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkIndirectCommandsLayoutTokenNVX
    {
        public VkIndirectCommandsTokenTypeNVX tokenType;

        [NativeTypeName("uint32_t")]
        public uint bindingUnit;

        [NativeTypeName("uint32_t")]
        public uint dynamicCount;

        [NativeTypeName("uint32_t")]
        public uint divisor;
    }
}
