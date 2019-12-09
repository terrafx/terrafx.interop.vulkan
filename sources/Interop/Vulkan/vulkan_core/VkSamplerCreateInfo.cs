// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkSamplerCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkSamplerCreateFlags")]
        public uint flags;

        public VkFilter magFilter;

        public VkFilter minFilter;

        public VkSamplerMipmapMode mipmapMode;

        public VkSamplerAddressMode addressModeU;

        public VkSamplerAddressMode addressModeV;

        public VkSamplerAddressMode addressModeW;

        public float mipLodBias;

        [NativeTypeName("VkBool32")]
        public uint anisotropyEnable;

        public float maxAnisotropy;

        [NativeTypeName("VkBool32")]
        public uint compareEnable;

        public VkCompareOp compareOp;

        public float minLod;

        public float maxLod;

        public VkBorderColor borderColor;

        [NativeTypeName("VkBool32")]
        public uint unnormalizedCoordinates;
    }
}
