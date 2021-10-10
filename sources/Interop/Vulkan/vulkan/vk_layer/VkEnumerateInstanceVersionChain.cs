// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkEnumerateInstanceVersionChain
    {
        public VkChainHeader header;

        [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceVersionChain *, uint32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged<VkEnumerateInstanceVersionChain*, uint*, VkResult> pfnNextLayer;

        [NativeTypeName("const struct VkEnumerateInstanceVersionChain *")]
        public VkEnumerateInstanceVersionChain* pNextLink;

        public VkResult CallDown([NativeTypeName("uint32_t *")] uint* pApiVersion)
        {
            return pfnNextLayer(pNextLink, pApiVersion);
        }
    }
}
