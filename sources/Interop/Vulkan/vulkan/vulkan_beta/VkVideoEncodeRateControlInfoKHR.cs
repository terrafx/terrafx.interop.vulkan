// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkVideoEncodeRateControlInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkVideoEncodeRateControlFlagsKHR flags;

        [NativeTypeName("VkVideoEncodeRateControlModeFlagBitsKHR")]
        public VkVideoEncodeRateControlModeFlagsKHR rateControlMode;

        [NativeTypeName("uint32_t")]
        public uint averageBitrate;

        [NativeTypeName("uint16_t")]
        public ushort peakToAverageBitrateRatio;

        [NativeTypeName("uint16_t")]
        public ushort frameRateNumerator;

        [NativeTypeName("uint16_t")]
        public ushort frameRateDenominator;

        [NativeTypeName("uint32_t")]
        public uint virtualBufferSizeInMs;
    }
}
