// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vk_layer.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkEnumerateInstanceExtensionPropertiesChain
    {
        public VkChainHeader header;

        [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceExtensionPropertiesChain *, const char *, uint32_t *, VkExtensionProperties *) __attribute__((stdcall))")]
        public IntPtr pfnNextLayer;

        [NativeTypeName("const struct VkEnumerateInstanceExtensionPropertiesChain *")]
        public VkEnumerateInstanceExtensionPropertiesChain* pNextLink;
    }
}
