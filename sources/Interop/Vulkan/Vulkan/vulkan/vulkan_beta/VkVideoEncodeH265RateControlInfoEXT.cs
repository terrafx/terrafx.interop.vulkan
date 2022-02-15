// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoEncodeH265RateControlInfoEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint gopFrameCount;

        [NativeTypeName("uint32_t")]
        public uint idrPeriod;

        [NativeTypeName("uint32_t")]
        public uint consecutiveBFrameCount;

        [NativeTypeName("VkVideoEncodeH265RateControlStructureFlagBitsEXT")]
        public VkVideoEncodeH265RateControlStructureFlagsEXT rateControlStructure;

        [NativeTypeName("uint8_t")]
        public byte subLayerCount;
    }
}