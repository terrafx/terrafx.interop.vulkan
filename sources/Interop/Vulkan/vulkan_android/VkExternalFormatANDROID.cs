// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_android.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkExternalFormatANDROID
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("uint64_t")]
        public ulong externalFormat;
    }
}
