// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkBaseInStructure
    {
        public VkStructureType sType;

        [NativeTypeName("const struct VkBaseInStructure *")]
        public VkBaseInStructure* pNext;
    }
}
