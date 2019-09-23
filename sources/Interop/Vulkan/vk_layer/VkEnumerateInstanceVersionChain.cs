// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vk_layer.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkEnumerateInstanceVersionChain
    {
        public VkChainHeader header;

        [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceVersionChain *, uint32_t *)")]
        public IntPtr pfnNextLayer;

        [NativeTypeName("const struct VkEnumerateInstanceVersionChain *")]
        public VkEnumerateInstanceVersionChain* pNextLink;
    }
}
