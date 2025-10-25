// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkEnumerateInstanceExtensionPropertiesChain
{
    public VkChainHeader header;

    [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceExtensionPropertiesChain *, const char *, uint32_t *, VkExtensionProperties *) __attribute__((stdcall))")]
    public delegate* unmanaged<VkEnumerateInstanceExtensionPropertiesChain*, sbyte*, uint*, VkExtensionProperties*, VkResult> pfnNextLayer;

    [NativeTypeName("const struct VkEnumerateInstanceExtensionPropertiesChain *")]
    public VkEnumerateInstanceExtensionPropertiesChain* pNextLink;

    public readonly VkResult CallDown([NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkExtensionProperties* pProperties)
    {
        return pfnNextLayer(pNextLink, pLayerName, pPropertyCount, pProperties);
    }
}
