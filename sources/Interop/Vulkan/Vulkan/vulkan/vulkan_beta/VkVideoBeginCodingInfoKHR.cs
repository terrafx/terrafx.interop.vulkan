// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoBeginCodingInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkVideoBeginCodingFlagsKHR")]
        public uint flags;

        public VkVideoCodingQualityPresetFlagsKHR codecQualityPreset;

        public VkVideoSessionKHR videoSession;

        public VkVideoSessionParametersKHR videoSessionParameters;

        [NativeTypeName("uint32_t")]
        public uint referenceSlotCount;

        [NativeTypeName("const VkVideoReferenceSlotKHR *")]
        public VkVideoReferenceSlotKHR* pReferenceSlots;
    }
}
