// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkIndirectCommandsLayoutTokenNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkIndirectCommandsTokenTypeNV tokenType;

        [NativeTypeName("uint32_t")]
        public uint stream;

        [NativeTypeName("uint32_t")]
        public uint offset;

        [NativeTypeName("uint32_t")]
        public uint vertexBindingUnit;

        [NativeTypeName("VkBool32")]
        public uint vertexDynamicStride;

        [NativeTypeName("VkPipelineLayout")]
        public ulong pushconstantPipelineLayout;

        public VkShaderStageFlags pushconstantShaderStageFlags;

        [NativeTypeName("uint32_t")]
        public uint pushconstantOffset;

        [NativeTypeName("uint32_t")]
        public uint pushconstantSize;

        public VkIndirectStateFlagsNV indirectStateFlags;

        [NativeTypeName("uint32_t")]
        public uint indexTypeCount;

        [NativeTypeName("const VkIndexType *")]
        public VkIndexType* pIndexTypes;

        [NativeTypeName("const uint32_t *")]
        public uint* pIndexTypeValues;
    }
}
