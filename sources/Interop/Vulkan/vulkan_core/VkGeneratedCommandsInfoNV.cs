// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkPipelineBindPoint pipelineBindPoint;

        [NativeTypeName("VkPipeline")]
        public ulong pipeline;

        [NativeTypeName("VkIndirectCommandsLayoutNV")]
        public ulong indirectCommandsLayout;

        [NativeTypeName("uint32_t")]
        public uint streamCount;

        [NativeTypeName("const VkIndirectCommandsStreamNV *")]
        public VkIndirectCommandsStreamNV* pStreams;

        [NativeTypeName("uint32_t")]
        public uint sequencesCount;

        [NativeTypeName("VkBuffer")]
        public ulong preprocessBuffer;

        [NativeTypeName("VkDeviceSize")]
        public ulong preprocessOffset;

        [NativeTypeName("VkDeviceSize")]
        public ulong preprocessSize;

        [NativeTypeName("VkBuffer")]
        public ulong sequencesCountBuffer;

        [NativeTypeName("VkDeviceSize")]
        public ulong sequencesCountOffset;

        [NativeTypeName("VkBuffer")]
        public ulong sequencesIndexBuffer;

        [NativeTypeName("VkDeviceSize")]
        public ulong sequencesIndexOffset;
    }
}
