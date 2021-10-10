// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkVideoSessionCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("uint32_t")]
        public uint queueFamilyIndex;

        public VkVideoSessionCreateFlagsKHR flags;

        [NativeTypeName("const VkVideoProfileKHR *")]
        public VkVideoProfileKHR* pVideoProfile;

        public VkFormat pictureFormat;

        public VkExtent2D maxCodedExtent;

        public VkFormat referencePicturesFormat;

        [NativeTypeName("uint32_t")]
        public uint maxReferencePicturesSlotsCount;

        [NativeTypeName("uint32_t")]
        public uint maxReferencePicturesActiveCount;
    }
}
