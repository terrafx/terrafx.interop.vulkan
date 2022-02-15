// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoEncodeH264RateControlLayerInfoEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint8_t")]
        public byte temporalLayerId;

        public VkBool32 useInitialRcQp;

        public VkVideoEncodeH264QpEXT initialRcQp;

        public VkBool32 useMinQp;

        public VkVideoEncodeH264QpEXT minQp;

        public VkBool32 useMaxQp;

        public VkVideoEncodeH264QpEXT maxQp;

        public VkBool32 useMaxFrameSize;

        public VkVideoEncodeH264FrameSizeEXT maxFrameSize;
    }
}
