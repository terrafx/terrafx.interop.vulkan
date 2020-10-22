// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkIndirectCommandsLayoutCreateInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkIndirectCommandsLayoutUsageFlagsNV")]
        public uint flags;

        public VkPipelineBindPoint pipelineBindPoint;

        [NativeTypeName("uint32_t")]
        public uint tokenCount;

        [NativeTypeName("const VkIndirectCommandsLayoutTokenNV *")]
        public VkIndirectCommandsLayoutTokenNV* pTokens;

        [NativeTypeName("uint32_t")]
        public uint streamCount;

        [NativeTypeName("const uint32_t *")]
        public uint* pStreamStrides;
    }
}
