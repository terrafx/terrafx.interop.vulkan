// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineDiscardRectangleStateCreateFlagsEXT")]
        public uint flags;

        public VkDiscardRectangleModeEXT discardRectangleMode;

        [NativeTypeName("uint32_t")]
        public uint discardRectangleCount;

        [NativeTypeName("const VkRect2D *")]
        public VkRect2D* pDiscardRectangles;
    }
}
