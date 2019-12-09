// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkCmdProcessCommandsInfoNVX
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkObjectTableNVX")]
        public ulong objectTable;

        [NativeTypeName("VkIndirectCommandsLayoutNVX")]
        public ulong indirectCommandsLayout;

        [NativeTypeName("uint32_t")]
        public uint indirectCommandsTokenCount;

        [NativeTypeName("const VkIndirectCommandsTokenNVX *")]
        public VkIndirectCommandsTokenNVX* pIndirectCommandsTokens;

        [NativeTypeName("uint32_t")]
        public uint maxSequencesCount;

        [NativeTypeName("VkCommandBuffer")]
        public IntPtr targetCommandBuffer;

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
