// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkPipelineExecutableInternalRepresentationKHR
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("char [256]")]
        public fixed sbyte name[256];

        [NativeTypeName("char [256]")]
        public fixed sbyte description[256];

        [NativeTypeName("VkBool32")]
        public uint isText;

        [NativeTypeName("size_t")]
        public UIntPtr dataSize;

        [NativeTypeName("void *")]
        public void* pData;
    }
}
