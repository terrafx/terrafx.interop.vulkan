// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAndroidHardwareBufferFormatPropertiesANDROID
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        public VkFormat format;

        [NativeTypeName("uint64_t")]
        public ulong externalFormat;

        [NativeTypeName("VkFormatFeatureFlags")]
        public uint formatFeatures;

        public VkComponentMapping samplerYcbcrConversionComponents;

        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;

        public VkSamplerYcbcrRange suggestedYcbcrRange;

        public VkChromaLocation suggestedXChromaOffset;

        public VkChromaLocation suggestedYChromaOffset;
    }
}
