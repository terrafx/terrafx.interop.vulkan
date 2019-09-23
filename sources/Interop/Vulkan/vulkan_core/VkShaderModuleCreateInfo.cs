// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkShaderModuleCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkShaderModuleCreateFlags")]
        public uint flags;

        [NativeTypeName("size_t")]
        public UIntPtr codeSize;

        [NativeTypeName("const uint32_t *")]
        public uint* pCode;
    }
}
