// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkEnumerateInstanceLayerPropertiesChain
    {
        public VkChainHeader header;

        [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceLayerPropertiesChain *, uint32_t *, VkLayerProperties *) __attribute__((stdcall))")]
        public IntPtr pfnNextLayer;

        [NativeTypeName("const struct VkEnumerateInstanceLayerPropertiesChain *")]
        public VkEnumerateInstanceLayerPropertiesChain* pNextLink;
    }
}
