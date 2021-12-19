// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkVideoEncodeH265EmitPictureParametersEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint8_t")]
        public byte vpsId;

        [NativeTypeName("uint8_t")]
        public byte spsId;

        public VkBool32 emitVpsEnable;

        public VkBool32 emitSpsEnable;

        [NativeTypeName("uint32_t")]
        public uint ppsIdEntryCount;

        [NativeTypeName("const uint8_t *")]
        public byte* ppsIdEntries;
    }
}